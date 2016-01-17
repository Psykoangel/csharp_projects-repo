namespace ProjetCSharp.InterfaceLayer.List
{
    partial class ListManager
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
            this.gpList = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btDeleteElement = new System.Windows.Forms.Button();
            this.btValidAssignement = new System.Windows.Forms.Button();
            this.cbUserNames = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbOrder = new System.Windows.Forms.TextBox();
            this.btAddElement = new System.Windows.Forms.Button();
            this.gpList.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpList
            // 
            this.gpList.Controls.Add(this.btAddElement);
            this.gpList.Controls.Add(this.tbOrder);
            this.gpList.Controls.Add(this.label4);
            this.gpList.Controls.Add(this.tbContent);
            this.gpList.Controls.Add(this.label3);
            this.gpList.Controls.Add(this.label2);
            this.gpList.Controls.Add(this.listView1);
            this.gpList.Controls.Add(this.btDeleteElement);
            this.gpList.Controls.Add(this.btValidAssignement);
            this.gpList.Controls.Add(this.cbUserNames);
            this.gpList.Controls.Add(this.label1);
            this.gpList.Location = new System.Drawing.Point(3, 12);
            this.gpList.Name = "gpList";
            this.gpList.Size = new System.Drawing.Size(474, 464);
            this.gpList.TabIndex = 0;
            this.gpList.TabStop = false;
            this.gpList.Text = "List Elements";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(9, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(305, 434);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // btDeleteElement
            // 
            this.btDeleteElement.Location = new System.Drawing.Point(326, 409);
            this.btDeleteElement.Name = "btDeleteElement";
            this.btDeleteElement.Size = new System.Drawing.Size(143, 44);
            this.btDeleteElement.TabIndex = 5;
            this.btDeleteElement.Text = "Delete Selected Element";
            this.btDeleteElement.UseVisualStyleBackColor = true;
            this.btDeleteElement.Click += new System.EventHandler(this.btDeleteElement_Click);
            // 
            // btValidAssignement
            // 
            this.btValidAssignement.Location = new System.Drawing.Point(377, 167);
            this.btValidAssignement.Name = "btValidAssignement";
            this.btValidAssignement.Size = new System.Drawing.Size(92, 29);
            this.btValidAssignement.TabIndex = 4;
            this.btValidAssignement.Text = "Affirm";
            this.btValidAssignement.UseVisualStyleBackColor = true;
            // 
            // cbUserNames
            // 
            this.cbUserNames.FormattingEnabled = true;
            this.cbUserNames.Location = new System.Drawing.Point(320, 140);
            this.cbUserNames.Name = "cbUserNames";
            this.cbUserNames.Size = new System.Drawing.Size(149, 21);
            this.cbUserNames.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Assign the\r\nselected element to :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(320, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Add a new element :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Content";
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(366, 239);
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(103, 20);
            this.tbContent.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Order";
            // 
            // tbOrder
            // 
            this.tbOrder.Location = new System.Drawing.Point(366, 265);
            this.tbOrder.Name = "tbOrder";
            this.tbOrder.Size = new System.Drawing.Size(103, 20);
            this.tbOrder.TabIndex = 11;
            // 
            // btAddElement
            // 
            this.btAddElement.Location = new System.Drawing.Point(377, 292);
            this.btAddElement.Name = "btAddElement";
            this.btAddElement.Size = new System.Drawing.Size(91, 26);
            this.btAddElement.TabIndex = 12;
            this.btAddElement.Text = "Add";
            this.btAddElement.UseVisualStyleBackColor = true;
            // 
            // ListManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 480);
            this.Controls.Add(this.gpList);
            this.Name = "ListManager";
            this.Text = "ListManager";
            this.gpList.ResumeLayout(false);
            this.gpList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpList;
        private System.Windows.Forms.ComboBox cbUserNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btValidAssignement;
        private System.Windows.Forms.Button btDeleteElement;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btAddElement;
        private System.Windows.Forms.TextBox tbOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}