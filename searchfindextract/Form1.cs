using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using static searchfindextract.Form1;

namespace searchfindextract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int alreadyExists = 0;
        int newCompleted = 0;
        int progress = 0;
        bool copyToFolder = true;
        private void createDir(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(path));
            }
            else
            {
                MessageBox.Show("Error!\nDirectory Already Exists!");
            }
        }
        int totalFounded = 0;
        private void deleteDir(string path)
        {
            if (File.Exists(path))
                File.Delete(path);
        }
        private string[] getFilesByExtension(string inputPath, string extension)
        {
            string[] files;
            if (Directory.Exists(inputPath))
            {
                var extensions = new List<string> { extension };
                files = Directory.GetFiles(inputPath, "*.*", SearchOption.AllDirectories)
                                    .Where(f => extensions.IndexOf(Path.GetExtension(f)) >= 0).ToArray();
                totalFounded = files.Length;
            }
            else
            {
                MessageBox.Show("Input Directory does NOT EXIST!\nPlease check your input path again and retry!");
                files = System.IO.Directory.GetFiles(inputPath, "*" + extension, SearchOption.AllDirectories);
            }
            return files;
        }
        public string StripAfterLastNumber(string s)
        {
            string ss;
            if (s.Contains("\\"))
            {
                ss = s.Substring(s.LastIndexOf("\\") + 1);
                return ss;
            }
            else if (s.Contains("/"))
            {
                ss = s.Substring(s.LastIndexOf("/") + 1);
                return ss;
            }
            else
            {
                return s;
            }
        }

        private void existsAlready()
        {
            if (this.alreadyExistsLbl.InvokeRequired)
            {
                this.alreadyExistsLbl.BeginInvoke((MethodInvoker)delegate () { this.alreadyExistsLbl.Text = alreadyExists.ToString(); ; });
            }
            else
            {
                this.alreadyExistsLbl.Text = alreadyExists.ToString(); ;
            }
        }
        private void doesntexistsAlready()
        {
            if (this.extractedLbl.InvokeRequired)
            {
                this.extractedLbl.BeginInvoke((MethodInvoker)delegate () { this.extractedLbl.Text = newCompleted.ToString(); ; });
            }
            else
            {
                this.extractedLbl.Text = newCompleted.ToString(); ;
            }
        }
        private void clearTxtBoxes()
        {
            if (this.alreadyExistTxtBox.InvokeRequired)
            {
                this.alreadyExistTxtBox.BeginInvoke((MethodInvoker)delegate () { this.alreadyExistTxtBox.Clear(); });
            }
            else
            {
                this.alreadyExistTxtBox.Clear();
            }
            if (this.foundTxtBox.InvokeRequired)
            {
                this.foundTxtBox.BeginInvoke((MethodInvoker)delegate () { this.foundTxtBox.Clear(); });
            }
            else
            {
                this.foundTxtBox.Clear();
            }
        }

        private void addToExistsTextBox(string value)
        {
            if (this.alreadyExistTxtBox.InvokeRequired)
            {
                this.alreadyExistTxtBox.BeginInvoke((MethodInvoker)delegate () { this.alreadyExistTxtBox.Text += value; });
            }
            else
            {
                this.alreadyExistTxtBox.Text += value;
            }
        }
        private void addToNewTextBox(string value)
        {
            if (this.foundTxtBox.InvokeRequired)
            {
                this.foundTxtBox.BeginInvoke((MethodInvoker)delegate () { this.foundTxtBox.Text += value; });
            }
            else
            {
                this.foundTxtBox.Text += value;
            }
        }
        private void totalFoundLblUpdate(string value)
        {
            if (this.totalFoundLbl.InvokeRequired)
            {
                this.totalFoundLbl.BeginInvoke((MethodInvoker)delegate () { this.totalFoundLbl.Text = value; });
            }
            else
            {
                this.totalFoundLbl.Text = value;
            }
        }
        private void completedLblUpdate(string value)
        {
            if (this.completedLbl.InvokeRequired)
            {
                this.completedLbl.BeginInvoke((MethodInvoker)delegate () { completedLbl.Visible = true; this.completedLbl.Text += value; });
            }
            else
            {
                this.completedLbl.Text += value;
            }
        }
        private void completedLblClear()
        {
            if (this.completedLbl.InvokeRequired)
            {
                this.completedLbl.BeginInvoke((MethodInvoker)delegate () { completedLbl.Text = ""; });
            }
            else
            {
                this.completedLbl.Text = "";
            }
        }

        private void moveOrCopyFiles(string[] files, bool copy, string destinationFolder)
        {
            string dir;
            string currentFile;
            clearTxtBoxes();
            totalChkTimer.Interval = 100;
            alreadyExists = 0;
            newCompleted = 0;
            totalChkTimer.Enabled = true;
            totalChkTimer.Start();
            completedLblClear();
            completedLblUpdate("...");

            if (files != null)
            {
                if (!Directory.Exists(destinationFolder))
                {
                    createDir(destinationFolder);
                    MessageBox.Show("Folder Not Found!\nCreating directory!\n[" + destinationFolder + "]");
                }
                if (copy == true)
                {
                    for (int i = 0; i < files.Length; i++)
                    {
                        currentFile = files[i];
                        dir = destinationFolder.Remove(destinationFolder.LastIndexOf('\\'));
                        if (!File.Exists(dir + "\\" + Path.GetFileName(currentFile)))
                        {
                            File.Copy(files[i], dir + "\\" + Path.GetFileName(currentFile));
                            addToNewTextBox(StripAfterLastNumber(files[i]) + "\n");
                            newCompleted++;
                            Thread.Sleep(1);
                        }
                        else
                        {
                            addToExistsTextBox(StripAfterLastNumber(files[i]) + "\n");
                            alreadyExists++;
                            Thread.Sleep(1);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i <= files.Length; i++)
                    {
                        currentFile = files[i];
                        dir = destinationFolder.Remove(destinationFolder.LastIndexOf('\\'));
                        if (!File.Exists(dir + "\\" + Path.GetFileName(currentFile)))
                        {
                            File.Move(files[i], dir + "\\" + Path.GetFileName(currentFile));
                            addToNewTextBox(StripAfterLastNumber(files[i]) + "\n");
                            newCompleted++;
                        }
                        else
                        {
                            addToExistsTextBox(StripAfterLastNumber(files[i]) + "\n");
                            alreadyExists++;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("ERROR!\nNO FILES FOUND!");
            }
            completedLblUpdate("Completed");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            completedLbl.Visible = false;
            Thread thread = new Thread(() => moveOrCopyFiles(getFilesByExtension(inputPathTxtBox.Text, extensionTxtBox.Text), copyToFolder, outputPathTxtBox.Text));
            thread.Start();
        }

        private void copyChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (copyChkBox.Checked)
            {
                copyToFolder = true;
                moveChkBox.Checked = false;
            }
        }

        private void moveChkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (moveChkBox.Checked)
            {
                copyToFolder = false;
                copyChkBox.Checked = false;
            }
        }

        private void openDirBtn_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", inputPathTxtBox.Text);
        }

        private void openOutDirBtn_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(outputPathTxtBox.Text))
            {
                Process.Start("explorer.exe", outputPathTxtBox.Text);
            }
            else
            {
                MessageBox.Show("Error!\nFolder does not exist!");
            }
        }

        private void totalChkTimer_Tick(object sender, EventArgs e)
        {
            totalChkTimer.Interval = 100;
            doesntexistsAlready();
            existsAlready();
            progress = alreadyExists + newCompleted;
            progressLbl.Text = progress.ToString() + "/" + totalFounded;
            if (progressLbl.Text == totalFounded.ToString())
            {
                totalChkTimer.Enabled = false;
                totalChkTimer.Stop();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            totalChkTimer.Start();
            totalChkTimer.Enabled = true;
        }
        
        List<string> avatarGameTitle = new List<string>();
        List<string> gameFolderNamesandLOC = new List<string>();
        List<string> itemFolders = new List<string>();
        List<string> binNamens = new List<string>();
        string[] gameItemFolderName;
        string[] gameItemBinTxt;
        List<string> gamefolderNameandLoc = new List<string>();
        
        List<string> getFolderNames(string directoryInput, int directoryDepth)
        {
            int filesFound = 0;
            foreach (string file in Directory.EnumerateFiles(directoryInput, "*" + extension.Text, SearchOption.AllDirectories))
            {
                gamefolderNameandLoc.Add(file);
                filesFound++;
            }
            for (int i = 0; i < gamefolderNameandLoc.Count; i++)
            {
                string gameBin= StripAfterLastNumber(gamefolderNameandLoc[i]);
            }
            return gamefolderNameandLoc;// folderName;
        }//BaSs_HaXoRWazHere
        #region variablesNDeclarations
        string[] thisismyoutput = { };
        int listchk1 = 0;
        int listchk2 = 0;
        List<string> bins = new List<string>();
        List<string> binsfile = new List<string>();
        #endregion
        static string GetLastParts(string text, string separator, int count)
        {
            string[] parts = text.Split(new string[] { separator }, StringSplitOptions.None);
            return string.Join(separator, parts.Skip(parts.Count() - count).Take(count).ToArray());
        }
        private void getCompeted(string binnies)
        {
            string splitgot = GetLastParts(binnies, "\\", 3);
            string[] items = splitgot.Split(new char[] { '\\' },
                     StringSplitOptions.RemoveEmptyEntries);
            //MessageBox.Show(string.Join("\\", items));
            
            //-------------- TITLE --------------------------------------------------------------------------------------------------
            string AvatargameTitle = string.Join("\\", items.Take(1));//this is GAME NAME TITLE
            //MessageBox.Show("GAME TITLE: " + AvatargameTitle);

            //-------------- ITEM NAME -----------------------------------------------------------------------------------------------
            string secondPart = string.Join("\\", items.Take(2)); //Skip .... this is ITEM NAME
            string AvataritemNames = GetLastParts(secondPart, "\\", 1);
            //MessageBox.Show("AvatarItem: " + AvataritemNames); //AVATAR ITEM NAME

            //-------------- BIN-ID --------------------------------------------------------------------------------------------------
            string binIDs = string.Join("\\", items.Skip(2));//.ToArray(); //this is .bin ID's everythingSplitAfterNthOccurence
            //MessageBox.Show("BINID: " + binIDs);

            //-------------- PARSED --------------------------------------------------------------------------------------------------
            avatarGameTitle.Add(AvatargameTitle); https://stackoverflow.com/users
            itemFolders.Add(AvataritemNames);
            binNamens.Add(binIDs);
        }
        string username = Environment.UserName;
        string outputs;
        private void saveToTxtDoc()
        {
            string myOutPutFile = dirTxtBox.Text + "\\avatarGameIDs.txt";    
          //  string path = "C:\\Users\\" + username + "\\Desktop\\" + "avatarGAME-IDs.txt";
            if (File.Exists(myOutPutFile))
            {
                MessageBox.Show("FILE EXISTS! CLEARING!");
                System.IO.File.WriteAllText(myOutPutFile, string.Empty);
            }
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            for (int x = 0; x < binNamens.Count && x < avatarGameTitle.Count; x++)// && x < itemFolders.Count; x++)
            {
                outputs = avatarGameTitle[x] + "|" + binNamens[x];
                saveToFile(myOutPutFile);
            }
            if(binNamens.Count > 0)
            {
                Process.Start("explorer.exe", dirTxtBox.Text);
            }
            else
            {
                MessageBox.Show("NOTHING FOUND!");
            }
        }
        private void saveToFile(string path)
        {
            bool done = false;
            while (!done)
            {
                done = true;
                try
                {
                    FileStream fileStream = null;
                    fileStream = File.Open(path, File.Exists(path) ? FileMode.Append : FileMode.OpenOrCreate);
                    using (StreamWriter fs = new StreamWriter(fileStream))
                    {
                        fs.WriteLine(outputs);
                    };
                    fileStream.Close();
                }
                catch (IOException)
                {
                    done = false;
                }

            }
        }

        string[] getItimias(List<string> Gamefolders)
        {
            //MessageBox.Show("GC: " + GC.GetTotalMemory(false));
            //MessageBox.Show("GC2: " + GC.GetTotalMemory(true));
            foreach (string folder in Gamefolders)
            {
                bins.AddRange(gamefolderNameandLoc);
            }
            if (bins.Count > listchk1)
            {
                foreach (var binnies in gamefolderNameandLoc)
                {
                    getCompeted(binnies);
                }
            }
            if (binsfile.Count > 0)
            {

            }
            return thisismyoutput;
        }
        private void sendinfoToTxtBox()
        {
            string totalTitle = "TOTAL TITLE: " + avatarGameTitle.Count.ToString();
            string totalItems = "\nTOTAL ITEMS: " + itemFolders.Count.ToString();
            string totalBins = "\nTOTAL BINS: " + binNamens.Count.ToString();
            string msg = totalTitle + totalItems + totalBins;
           // MessageBox.Show(msg);
            int titleCounter = 0;
            int itemCounter = 0;
            int binCounter = 0;
            List<string> uniqueTitles = avatarGameTitle.Distinct().ToList();
            List<string> uniqueItems = itemFolders.Distinct().ToList();
            List<string> uniquebins = binNamens.Distinct().ToList();

            titleCounter = uniqueTitles.Count();
            //MessageBox.Show("TITLE: " + titleCounter.ToString());
            itemCounter = uniqueItems.Count();
            //MessageBox.Show("items: " + itemCounter.ToString());
            binCounter = uniquebins.Count();
            //MessageBox.Show("bins: " + binCounter.ToString());
            //https://www.educative.io/answers/how-to-remove-duplicates-from-a-linked-list-in-c-sharp#:~:text=In%20order%20to%20remove%20duplicates,Linq%20before%20using%20this%20function.

            titleTxtBox.Lines = avatarGameTitle.ToArray();
            avItemTxtBox.Lines = itemFolders.ToArray();
            avIDTxtBox.Lines = binNamens.ToArray();
            TitlesFoundLbl.Text = titleCounter.ToString();
            itemsFoundLbl.Text = itemCounter.ToString();
            idsFoundLbl.Text = binCounter.ToString();
        }
        private void clearAll()
        {
            titleTxtBox.Clear();
            avIDTxtBox.Clear();
            avItemTxtBox.Clear();
            avatarGameTitle.Clear();
            itemFolders.Clear();
            binNamens.Clear();
            gamefolderNameandLoc.Clear();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            clearAll();
            getFolderNames(dirTxtBox.Text, 0);//getGameFolderName
            getItimias(gamefolderNameandLoc);
            saveToTxtDoc();
            sendinfoToTxtBox();

        }

        /*
                [DllImport("user32.dll", CharSet = CharSet.Auto)]
                private static extern int SendMessage(IntPtr hWnd, int wMsg, IntPtr wParam, ref Point lParam);
                private const int EM_SETSCROLLPOS = 0x4DE;
                private Point p;*/

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
        }
        //https://stackoverflow.com/questions/24065972/c-sharp-get-file-paths-of-just-files-with-no-extensions
        //https://stackoverflow.com/questions/5259961/change-file-extension-using-c-sharp
        //https://stackoverflow.com/questions/16034792/how-to-split-a-string-on-the-nth-occurrence
        //https://stackoverflow.com/questions/4841401/convert-string-array-to-string
        //https://stackoverflow.com/questions/12199600/how-do-i-get-the-last-part-of-this-filepath
        private void titleTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll_1(object sender, ScrollEventArgs e)
        {/*
            p.Y = e.NewValue;

            SendMessage(titleTxtBox.Handle, EM_SETSCROLLPOS, IntPtr.Zero, ref p);
            SendMessage(avItemTxtBox.Handle, EM_SETSCROLLPOS, IntPtr.Zero, ref p);
            SendMessage(avIDTxtBox.Handle, EM_SETSCROLLPOS, IntPtr.Zero, ref p);*/
        }

        private void synchronizedScrollRichTextBox1_vScroll(Message message)
        {
        }

        private void titleTxtBox_VScroll(object sender, EventArgs e)
        {
        }
        private void vScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void titleTxtBox_VScroll_1(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}