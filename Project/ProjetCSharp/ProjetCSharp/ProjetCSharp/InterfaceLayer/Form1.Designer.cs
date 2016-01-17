namespace ProjetCSharp
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fADToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.gpConnexion = new System.Windows.Forms.GroupBox();
            this.btSubmit = new System.Windows.Forms.Button();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btAddList = new System.Windows.Forms.Button();
            this.gpMessage = new System.Windows.Forms.GroupBox();
            this.lbMessage = new System.Windows.Forms.Label();
            this.gpLists = new System.Windows.Forms.GroupBox();
            this.btDeleteList = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvList = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.gpConnexion.SuspendLayout();
            this.gpMessage.SuspendLayout();
            this.gpLists.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpUsToolStripMenuItem,
            this.fADToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpUsToolStripMenuItem
            // 
            this.helpUsToolStripMenuItem.Name = "helpUsToolStripMenuItem";
            this.helpUsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.helpUsToolStripMenuItem.Text = "Help us";
            // 
            // fADToolStripMenuItem
            // 
            this.fADToolStripMenuItem.Name = "fADToolStripMenuItem";
            this.fADToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.fADToolStripMenuItem.Text = "FAQ";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password :";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(106, 28);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(192, 20);
            this.tbLogin.TabIndex = 3;
            this.tbLogin.TextChanged += new System.EventHandler(this.tbLogin_TextChanged);
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(106, 54);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(192, 20);
            this.tbPass.TabIndex = 4;
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            // 
            // gpConnexion
            // 
            this.gpConnexion.Controls.Add(this.btSubmit);
            this.gpConnexion.Controls.Add(this.tbPass);
            this.gpConnexion.Controls.Add(this.tbLogin);
            this.gpConnexion.Controls.Add(this.label2);
            this.gpConnexion.Controls.Add(this.label1);
            this.gpConnexion.Location = new System.Drawing.Point(12, 32);
            this.gpConnexion.Name = "gpConnexion";
            this.gpConnexion.Size = new System.Drawing.Size(611, 112);
            this.gpConnexion.TabIndex = 5;
            this.gpConnexion.TabStop = false;
            this.gpConnexion.Text = "Connexion";
            // 
            // btSubmit
            // 
            this.btSubmit.Enabled = false;
            this.btSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubmit.Location = new System.Drawing.Point(503, 76);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(102, 30);
            this.btSubmit.TabIndex = 5;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(18, 24);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(110, 13);
            this.lbInfo.TabIndex = 6;
            this.lbInfo.Text = "Welcome, member";
            this.lbInfo.Visible = false;
            this.lbInfo.Click += new System.EventHandler(this.lbInfo_Click);
            // 
            // btAddList
            // 
            this.btAddList.Location = new System.Drawing.Point(504, 19);
            this.btAddList.Name = "btAddList";
            this.btAddList.Size = new System.Drawing.Size(106, 25);
            this.btAddList.TabIndex = 7;
            this.btAddList.Text = "Add List";
            this.btAddList.UseVisualStyleBackColor = true;
            this.btAddList.Visible = false;
            this.btAddList.Click += new System.EventHandler(this.btAddList_Click);
            // 
            // gpMessage
            // 
            this.gpMessage.Controls.Add(this.lbMessage);
            this.gpMessage.Location = new System.Drawing.Point(12, 169);
            this.gpMessage.Name = "gpMessage";
            this.gpMessage.Size = new System.Drawing.Size(611, 153);
            this.gpMessage.TabIndex = 6;
            this.gpMessage.TabStop = false;
            this.gpMessage.Text = "Message";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Location = new System.Drawing.Point(13, 27);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(327, 13);
            this.lbMessage.TabIndex = 0;
            this.lbMessage.Text = "Please enter your login and password to access the lists application.";
            // 
            // gpLists
            // 
            this.gpLists.Controls.Add(this.btDeleteList);
            this.gpLists.Controls.Add(this.comboBox1);
            this.gpLists.Controls.Add(this.label4);
            this.gpLists.Controls.Add(this.lbAuthor);
            this.gpLists.Controls.Add(this.label3);
            this.gpLists.Controls.Add(this.btAddList);
            this.gpLists.Controls.Add(this.lvList);
            this.gpLists.Location = new System.Drawing.Point(11, 40);
            this.gpLists.Name = "gpLists";
            this.gpLists.Size = new System.Drawing.Size(616, 282);
            this.gpLists.TabIndex = 7;
            this.gpLists.TabStop = false;
            this.gpLists.Text = "My Lists";
            this.gpLists.Visible = false;
            // 
            // btDeleteList
            // 
            this.btDeleteList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btDeleteList.Location = new System.Drawing.Point(504, 50);
            this.btDeleteList.Name = "btDeleteList";
            this.btDeleteList.Size = new System.Drawing.Size(106, 28);
            this.btDeleteList.TabIndex = 12;
            this.btDeleteList.Text = "Delete List";
            this.btDeleteList.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(504, 188);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(504, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 26);
            this.label4.TabIndex = 10;
            this.label4.Text = "Assign the\r\nselected List to :";
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Location = new System.Drawing.Point(513, 127);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(22, 13);
            this.lbAuthor.TabIndex = 9;
            this.lbAuthor.Text = "Me";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(504, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Author :";
            // 
            // lvList
            // 
            this.lvList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvList.Location = new System.Drawing.Point(1, 19);
            this.lvList.MultiSelect = false;
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(497, 246);
            this.lvList.TabIndex = 0;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.List;
            this.lvList.DoubleClick += new System.EventHandler(this.lvList_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 336);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.gpLists);
            this.Controls.Add(this.gpConnexion);
            this.Controls.Add(this.gpMessage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Project C# - List App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gpConnexion.ResumeLayout(false);
            this.gpConnexion.PerformLayout();
            this.gpMessage.ResumeLayout(false);
            this.gpMessage.PerformLayout();
            this.gpLists.ResumeLayout(false);
            this.gpLists.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.GroupBox gpConnexion;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.GroupBox gpMessage;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.ToolStripMenuItem fADToolStripMenuItem;
        private System.Windows.Forms.GroupBox gpLists;
        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btAddList;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btDeleteList;
    }
}

