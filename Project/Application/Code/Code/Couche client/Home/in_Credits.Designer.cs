namespace Code
{
    partial class Crédits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Crédits));
            this.chefProjet = new System.Windows.Forms.Label();
            this.devOne = new System.Windows.Forms.Label();
            this.devTwo = new System.Windows.Forms.Label();
            this.devThree = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.SuspendLayout();
            // 
            // chefProjet
            // 
            this.chefProjet.AutoSize = true;
            this.chefProjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chefProjet.ForeColor = System.Drawing.Color.White;
            this.chefProjet.Location = new System.Drawing.Point(12, 9);
            this.chefProjet.Name = "chefProjet";
            this.chefProjet.Size = new System.Drawing.Size(198, 20);
            this.chefProjet.TabIndex = 0;
            this.chefProjet.Text = "Hao Xiong | Chef de Projet";
            // 
            // devOne
            // 
            this.devOne.AutoSize = true;
            this.devOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devOne.ForeColor = System.Drawing.Color.White;
            this.devOne.Location = new System.Drawing.Point(47, 52);
            this.devOne.Name = "devOne";
            this.devOne.Size = new System.Drawing.Size(227, 20);
            this.devOne.TabIndex = 1;
            this.devOne.Text = "Laetitia Bonanni | Développeur";
            // 
            // devTwo
            // 
            this.devTwo.AutoSize = true;
            this.devTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devTwo.ForeColor = System.Drawing.Color.White;
            this.devTwo.Location = new System.Drawing.Point(47, 102);
            this.devTwo.Name = "devTwo";
            this.devTwo.Size = new System.Drawing.Size(226, 20);
            this.devTwo.TabIndex = 2;
            this.devTwo.Text = "Michael Scherer | Développeur";
            // 
            // devThree
            // 
            this.devThree.AutoSize = true;
            this.devThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.devThree.ForeColor = System.Drawing.Color.White;
            this.devThree.Location = new System.Drawing.Point(47, 152);
            this.devThree.Name = "devThree";
            this.devThree.Size = new System.Drawing.Size(217, 20);
            this.devThree.TabIndex = 3;
            this.devThree.Text = "Jonathan Klein | Développeur";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(301, 198);
            this.shapeContainer1.TabIndex = 4;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.BorderColor = System.Drawing.Color.White;
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 19;
            this.lineShape4.X2 = 47;
            this.lineShape4.Y1 = 171;
            this.lineShape4.Y2 = 171;
            // 
            // lineShape3
            // 
            this.lineShape3.BorderColor = System.Drawing.Color.White;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 18;
            this.lineShape3.X2 = 44;
            this.lineShape3.Y1 = 121;
            this.lineShape3.Y2 = 121;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.White;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 19;
            this.lineShape2.X2 = 46;
            this.lineShape2.Y1 = 71;
            this.lineShape2.Y2 = 71;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 18;
            this.lineShape1.X2 = 18;
            this.lineShape1.Y1 = 29;
            this.lineShape1.Y2 = 171;
            // 
            // Crédits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(301, 198);
            this.Controls.Add(this.devThree);
            this.Controls.Add(this.devTwo);
            this.Controls.Add(this.devOne);
            this.Controls.Add(this.chefProjet);
            this.Controls.Add(this.shapeContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Crédits";
            this.Text = "Crédits";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chefProjet;
        private System.Windows.Forms.Label devOne;
        private System.Windows.Forms.Label devTwo;
        private System.Windows.Forms.Label devThree;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
    }
}