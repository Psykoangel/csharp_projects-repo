namespace WindowsFormsApplication1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this.TxtBox03 = new System.Windows.Forms.TextBox();
            this.btn_Submit03 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtBox03
            // 
            this.TxtBox03.Location = new System.Drawing.Point(59, 57);
            this.TxtBox03.Name = "TxtBox03";
            this.TxtBox03.Size = new System.Drawing.Size(170, 20);
            this.TxtBox03.TabIndex = 0;
            // 
            // btn_Submit03
            // 
            this.btn_Submit03.Location = new System.Drawing.Point(89, 114);
            this.btn_Submit03.Name = "btn_Submit03";
            this.btn_Submit03.Size = new System.Drawing.Size(108, 56);
            this.btn_Submit03.TabIndex = 1;
            this.btn_Submit03.Text = "How HOW HOW";
            this.btn_Submit03.UseVisualStyleBackColor = true;
            this.btn_Submit03.Click += new System.EventHandler(this.btn_Submit03_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btn_Submit03);
            this.Controls.Add(this.TxtBox03);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBox03;
        private System.Windows.Forms.Button btn_Submit03;
    }
}