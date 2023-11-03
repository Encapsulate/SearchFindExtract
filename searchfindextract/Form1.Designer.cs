namespace searchfindextract
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.extractBtn = new System.Windows.Forms.Button();
            this.extensionTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.moveChkBox = new System.Windows.Forms.CheckBox();
            this.copyChkBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.outputPathTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputPathTxtBox = new System.Windows.Forms.TextBox();
            this.alreadyExistTxtBox = new System.Windows.Forms.RichTextBox();
            this.foundTxtBox = new System.Windows.Forms.RichTextBox();
            this.openDirBtn = new System.Windows.Forms.Button();
            this.openOutDirBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalChkTimer = new System.Windows.Forms.Timer(this.components);
            this.alreadyExistsLbl = new System.Windows.Forms.Label();
            this.extractedLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.completedLbl = new System.Windows.Forms.Label();
            this.progressLbl = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.totalFoundLbl = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.idsFoundLbl = new System.Windows.Forms.Label();
            this.itemsFoundLbl = new System.Windows.Forms.Label();
            this.TitlesFoundLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.avIDTxtBox = new System.Windows.Forms.RichTextBox();
            this.avItemTxtBox = new System.Windows.Forms.RichTextBox();
            this.titleTxtBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dirTxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.extension = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // extractBtn
            // 
            this.extractBtn.Location = new System.Drawing.Point(6, 123);
            this.extractBtn.Name = "extractBtn";
            this.extractBtn.Size = new System.Drawing.Size(489, 23);
            this.extractBtn.TabIndex = 0;
            this.extractBtn.Text = "Extract";
            this.extractBtn.UseVisualStyleBackColor = true;
            this.extractBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // extensionTxtBox
            // 
            this.extensionTxtBox.Location = new System.Drawing.Point(414, 47);
            this.extensionTxtBox.MaxLength = 20;
            this.extensionTxtBox.Name = "extensionTxtBox";
            this.extensionTxtBox.Size = new System.Drawing.Size(80, 22);
            this.extensionTxtBox.TabIndex = 1;
            this.extensionTxtBox.Text = ".gpd";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Extension";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.moveChkBox);
            this.groupBox1.Controls.Add(this.copyChkBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.outputPathTxtBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.extractBtn);
            this.groupBox1.Controls.Add(this.inputPathTxtBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.extensionTxtBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 152);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extract By Extension";
            // 
            // moveChkBox
            // 
            this.moveChkBox.AutoSize = true;
            this.moveChkBox.Location = new System.Drawing.Point(414, 102);
            this.moveChkBox.Name = "moveChkBox";
            this.moveChkBox.Size = new System.Drawing.Size(63, 20);
            this.moveChkBox.TabIndex = 8;
            this.moveChkBox.Text = "Move";
            this.moveChkBox.UseVisualStyleBackColor = true;
            this.moveChkBox.CheckedChanged += new System.EventHandler(this.moveChkBox_CheckedChanged);
            // 
            // copyChkBox
            // 
            this.copyChkBox.AutoSize = true;
            this.copyChkBox.Checked = true;
            this.copyChkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.copyChkBox.Location = new System.Drawing.Point(414, 76);
            this.copyChkBox.Name = "copyChkBox";
            this.copyChkBox.Size = new System.Drawing.Size(61, 20);
            this.copyChkBox.TabIndex = 7;
            this.copyChkBox.Text = "Copy";
            this.copyChkBox.UseVisualStyleBackColor = true;
            this.copyChkBox.CheckedChanged += new System.EventHandler(this.copyChkBox_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Output Dir:";
            // 
            // outputPathTxtBox
            // 
            this.outputPathTxtBox.Location = new System.Drawing.Point(6, 95);
            this.outputPathTxtBox.Name = "outputPathTxtBox";
            this.outputPathTxtBox.Size = new System.Drawing.Size(400, 22);
            this.outputPathTxtBox.TabIndex = 5;
            this.outputPathTxtBox.Text = "C:\\Users\\userName\\Desktop\\gpd\\output\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input Dir:";
            // 
            // inputPathTxtBox
            // 
            this.inputPathTxtBox.Location = new System.Drawing.Point(5, 47);
            this.inputPathTxtBox.Name = "inputPathTxtBox";
            this.inputPathTxtBox.Size = new System.Drawing.Size(400, 22);
            this.inputPathTxtBox.TabIndex = 3;
            this.inputPathTxtBox.Text = "C:\\Users\\userName\\Desktop\\gpd\\titles";
            // 
            // alreadyExistTxtBox
            // 
            this.alreadyExistTxtBox.BackColor = System.Drawing.Color.Black;
            this.alreadyExistTxtBox.ForeColor = System.Drawing.Color.Red;
            this.alreadyExistTxtBox.Location = new System.Drawing.Point(11, 193);
            this.alreadyExistTxtBox.Name = "alreadyExistTxtBox";
            this.alreadyExistTxtBox.ReadOnly = true;
            this.alreadyExistTxtBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.alreadyExistTxtBox.Size = new System.Drawing.Size(237, 167);
            this.alreadyExistTxtBox.TabIndex = 4;
            this.alreadyExistTxtBox.Text = "";
            // 
            // foundTxtBox
            // 
            this.foundTxtBox.BackColor = System.Drawing.Color.Black;
            this.foundTxtBox.ForeColor = System.Drawing.Color.Lime;
            this.foundTxtBox.Location = new System.Drawing.Point(262, 193);
            this.foundTxtBox.Name = "foundTxtBox";
            this.foundTxtBox.ReadOnly = true;
            this.foundTxtBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.foundTxtBox.Size = new System.Drawing.Size(245, 167);
            this.foundTxtBox.TabIndex = 5;
            this.foundTxtBox.Text = "";
            // 
            // openDirBtn
            // 
            this.openDirBtn.Location = new System.Drawing.Point(12, 158);
            this.openDirBtn.Name = "openDirBtn";
            this.openDirBtn.Size = new System.Drawing.Size(236, 29);
            this.openDirBtn.TabIndex = 9;
            this.openDirBtn.Text = "Open input directory";
            this.openDirBtn.UseVisualStyleBackColor = true;
            this.openDirBtn.Click += new System.EventHandler(this.openDirBtn_Click);
            // 
            // openOutDirBtn
            // 
            this.openOutDirBtn.Location = new System.Drawing.Point(262, 158);
            this.openOutDirBtn.Name = "openOutDirBtn";
            this.openOutDirBtn.Size = new System.Drawing.Size(239, 29);
            this.openOutDirBtn.TabIndex = 10;
            this.openOutDirBtn.Text = "Open output directory";
            this.openOutDirBtn.UseVisualStyleBackColor = true;
            this.openOutDirBtn.Click += new System.EventHandler(this.openOutDirBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Already Exists:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Extracted from directory:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // totalChkTimer
            // 
            this.totalChkTimer.Tick += new System.EventHandler(this.totalChkTimer_Tick);
            // 
            // alreadyExistsLbl
            // 
            this.alreadyExistsLbl.AutoSize = true;
            this.alreadyExistsLbl.Location = new System.Drawing.Point(176, 363);
            this.alreadyExistsLbl.Name = "alreadyExistsLbl";
            this.alreadyExistsLbl.Size = new System.Drawing.Size(14, 16);
            this.alreadyExistsLbl.TabIndex = 12;
            this.alreadyExistsLbl.Text = "0";
            // 
            // extractedLbl
            // 
            this.extractedLbl.AutoSize = true;
            this.extractedLbl.Location = new System.Drawing.Point(443, 363);
            this.extractedLbl.Name = "extractedLbl";
            this.extractedLbl.Size = new System.Drawing.Size(14, 16);
            this.extractedLbl.TabIndex = 13;
            this.extractedLbl.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Total Found:";
            // 
            // completedLbl
            // 
            this.completedLbl.AutoSize = true;
            this.completedLbl.BackColor = System.Drawing.Color.Black;
            this.completedLbl.ForeColor = System.Drawing.Color.Lime;
            this.completedLbl.Location = new System.Drawing.Point(396, 385);
            this.completedLbl.Name = "completedLbl";
            this.completedLbl.Size = new System.Drawing.Size(16, 16);
            this.completedLbl.TabIndex = 15;
            this.completedLbl.Text = "...";
            // 
            // progressLbl
            // 
            this.progressLbl.AutoSize = true;
            this.progressLbl.Location = new System.Drawing.Point(218, 385);
            this.progressLbl.Name = "progressLbl";
            this.progressLbl.Size = new System.Drawing.Size(14, 16);
            this.progressLbl.TabIndex = 16;
            this.progressLbl.Text = "0";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(683, 436);
            this.tabControl1.TabIndex = 15;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.totalFoundLbl);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.progressLbl);
            this.tabPage1.Controls.Add(this.alreadyExistTxtBox);
            this.tabPage1.Controls.Add(this.completedLbl);
            this.tabPage1.Controls.Add(this.foundTxtBox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.openDirBtn);
            this.tabPage1.Controls.Add(this.extractedLbl);
            this.tabPage1.Controls.Add(this.openOutDirBtn);
            this.tabPage1.Controls.Add(this.alreadyExistsLbl);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(675, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "[MAIN] Get Files By Extension";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // totalFoundLbl
            // 
            this.totalFoundLbl.AutoSize = true;
            this.totalFoundLbl.Location = new System.Drawing.Point(238, 385);
            this.totalFoundLbl.Name = "totalFoundLbl";
            this.totalFoundLbl.Size = new System.Drawing.Size(14, 16);
            this.totalFoundLbl.TabIndex = 17;
            this.totalFoundLbl.Text = "0";
            this.totalFoundLbl.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.idsFoundLbl);
            this.tabPage2.Controls.Add(this.itemsFoundLbl);
            this.tabPage2.Controls.Add(this.TitlesFoundLbl);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.avIDTxtBox);
            this.tabPage2.Controls.Add(this.avItemTxtBox);
            this.tabPage2.Controls.Add(this.titleTxtBox);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(675, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "dir folder names + file.* to .txt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // idsFoundLbl
            // 
            this.idsFoundLbl.AutoSize = true;
            this.idsFoundLbl.Location = new System.Drawing.Point(547, 387);
            this.idsFoundLbl.Name = "idsFoundLbl";
            this.idsFoundLbl.Size = new System.Drawing.Size(14, 16);
            this.idsFoundLbl.TabIndex = 26;
            this.idsFoundLbl.Text = "0";
            // 
            // itemsFoundLbl
            // 
            this.itemsFoundLbl.AutoSize = true;
            this.itemsFoundLbl.Location = new System.Drawing.Point(321, 387);
            this.itemsFoundLbl.Name = "itemsFoundLbl";
            this.itemsFoundLbl.Size = new System.Drawing.Size(14, 16);
            this.itemsFoundLbl.TabIndex = 25;
            this.itemsFoundLbl.Text = "0";
            // 
            // TitlesFoundLbl
            // 
            this.TitlesFoundLbl.AutoSize = true;
            this.TitlesFoundLbl.Location = new System.Drawing.Point(89, 387);
            this.TitlesFoundLbl.Name = "TitlesFoundLbl";
            this.TitlesFoundLbl.Size = new System.Drawing.Size(14, 16);
            this.TitlesFoundLbl.TabIndex = 24;
            this.TitlesFoundLbl.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(547, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(305, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "Folder";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Title";
            // 
            // avIDTxtBox
            // 
            this.avIDTxtBox.BackColor = System.Drawing.Color.Black;
            this.avIDTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.avIDTxtBox.ForeColor = System.Drawing.Color.Lime;
            this.avIDTxtBox.Location = new System.Drawing.Point(443, 136);
            this.avIDTxtBox.Name = "avIDTxtBox";
            this.avIDTxtBox.ReadOnly = true;
            this.avIDTxtBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.avIDTxtBox.Size = new System.Drawing.Size(226, 248);
            this.avIDTxtBox.TabIndex = 21;
            this.avIDTxtBox.Text = "";
            // 
            // avItemTxtBox
            // 
            this.avItemTxtBox.BackColor = System.Drawing.Color.Black;
            this.avItemTxtBox.ForeColor = System.Drawing.Color.Lime;
            this.avItemTxtBox.Location = new System.Drawing.Point(214, 136);
            this.avItemTxtBox.Name = "avItemTxtBox";
            this.avItemTxtBox.ReadOnly = true;
            this.avItemTxtBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.avItemTxtBox.Size = new System.Drawing.Size(223, 248);
            this.avItemTxtBox.TabIndex = 20;
            this.avItemTxtBox.Text = "";
            // 
            // titleTxtBox
            // 
            this.titleTxtBox.BackColor = System.Drawing.Color.Black;
            this.titleTxtBox.ForeColor = System.Drawing.Color.Lime;
            this.titleTxtBox.Location = new System.Drawing.Point(3, 136);
            this.titleTxtBox.Name = "titleTxtBox";
            this.titleTxtBox.ReadOnly = true;
            this.titleTxtBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.titleTxtBox.Size = new System.Drawing.Size(205, 248);
            this.titleTxtBox.TabIndex = 17;
            this.titleTxtBox.Text = "";
            this.titleTxtBox.VScroll += new System.EventHandler(this.titleTxtBox_VScroll_1);
            this.titleTxtBox.TextChanged += new System.EventHandler(this.titleTxtBox_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dirTxtBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.extension);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 102);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extract By Extension";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(327, 16);
            this.label8.TabIndex = 4;
            this.label8.Text = "Input Dir [GET ALL FOLDER NAMES + *.ext to .txt doc]:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(651, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get all folder name Location + Folder Name + extension";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dirTxtBox
            // 
            this.dirTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F);
            this.dirTxtBox.Location = new System.Drawing.Point(5, 47);
            this.dirTxtBox.Name = "dirTxtBox";
            this.dirTxtBox.Size = new System.Drawing.Size(566, 21);
            this.dirTxtBox.TabIndex = 3;
            this.dirTxtBox.Text = "E:\\All Xbox 360 Avatar Items\\Avatar_Items_orig";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(583, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 16);
            this.label9.TabIndex = 2;
            this.label9.Text = "Extension";
            // 
            // extension
            // 
            this.extension.Location = new System.Drawing.Point(577, 47);
            this.extension.MaxLength = 20;
            this.extension.Name = "extension";
            this.extension.Size = new System.Drawing.Size(80, 22);
            this.extension.TabIndex = 1;
            this.extension.Text = ".bin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 450);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Search Find Extract - By BaSs_HaXoR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button extractBtn;
        private System.Windows.Forms.TextBox extensionTxtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputPathTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox outputPathTxtBox;
        private System.Windows.Forms.CheckBox moveChkBox;
        private System.Windows.Forms.CheckBox copyChkBox;
        private System.Windows.Forms.RichTextBox alreadyExistTxtBox;
        private System.Windows.Forms.RichTextBox foundTxtBox;
        private System.Windows.Forms.Button openDirBtn;
        private System.Windows.Forms.Button openOutDirBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer totalChkTimer;
        private System.Windows.Forms.Label alreadyExistsLbl;
        private System.Windows.Forms.Label extractedLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label completedLbl;
        private System.Windows.Forms.Label progressLbl;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox dirTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox extension;
        private System.Windows.Forms.Label totalFoundLbl;
        private System.Windows.Forms.RichTextBox titleTxtBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox avIDTxtBox;
        private System.Windows.Forms.RichTextBox avItemTxtBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label idsFoundLbl;
        private System.Windows.Forms.Label itemsFoundLbl;
        private System.Windows.Forms.Label TitlesFoundLbl;
    }
}

