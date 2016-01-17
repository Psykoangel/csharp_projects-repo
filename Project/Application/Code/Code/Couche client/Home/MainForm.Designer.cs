namespace Code
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrementDeLaBDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterLaListeDesClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterLesRéservationsDunClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterModifierOuSupprimerLesDétailsDunClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesRéservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterLaListeDesRéservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterLesDétailsDuneRéservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterModifierOuSupprimerLesDétailsDuneRéservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimerUneRéservationetSesDétailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesÉquipementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterLesÉquipementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.détailDunÉquipementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterModifierSupprimerLeDétailDunÉquipementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesEmployésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterLaListeDesEmployésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consulterLesDétailsDunEmployéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterModifierOuSupprimerLesDétailsDunEmployéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abscencesDesEmployésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimeMain = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.gestionToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(784, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrementDeLaBDDToolStripMenuItem,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // enregistrementDeLaBDDToolStripMenuItem
            // 
            this.enregistrementDeLaBDDToolStripMenuItem.Name = "enregistrementDeLaBDDToolStripMenuItem";
            this.enregistrementDeLaBDDToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.enregistrementDeLaBDDToolStripMenuItem.Text = "*Enregistrement de la BDD*";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesClientsToolStripMenuItem,
            this.gestionDesRéservationsToolStripMenuItem,
            this.gestionDesÉquipementsToolStripMenuItem,
            this.gestionDesEmployésToolStripMenuItem});
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.gestionToolStripMenuItem.Text = "Gestions";
            // 
            // gestionDesClientsToolStripMenuItem
            // 
            this.gestionDesClientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterLaListeDesClientsToolStripMenuItem,
            this.consulterLesRéservationsDunClientToolStripMenuItem,
            this.ajouterModifierOuSupprimerLesDétailsDunClientToolStripMenuItem});
            this.gestionDesClientsToolStripMenuItem.Name = "gestionDesClientsToolStripMenuItem";
            this.gestionDesClientsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.gestionDesClientsToolStripMenuItem.Text = "Gestion des clients";
            // 
            // consulterLaListeDesClientsToolStripMenuItem
            // 
            this.consulterLaListeDesClientsToolStripMenuItem.Name = "consulterLaListeDesClientsToolStripMenuItem";
            this.consulterLaListeDesClientsToolStripMenuItem.Size = new System.Drawing.Size(351, 22);
            this.consulterLaListeDesClientsToolStripMenuItem.Text = "Consulter la liste des clients";
            this.consulterLaListeDesClientsToolStripMenuItem.Click += new System.EventHandler(this.consulterLaListeDesClientsToolStripMenuItem_Click);
            // 
            // consulterLesRéservationsDunClientToolStripMenuItem
            // 
            this.consulterLesRéservationsDunClientToolStripMenuItem.Name = "consulterLesRéservationsDunClientToolStripMenuItem";
            this.consulterLesRéservationsDunClientToolStripMenuItem.Size = new System.Drawing.Size(351, 22);
            this.consulterLesRéservationsDunClientToolStripMenuItem.Text = "Consulter les réservations d\'un client";
            this.consulterLesRéservationsDunClientToolStripMenuItem.Click += new System.EventHandler(this.consulterLesRéservationsDunClientToolStripMenuItem_Click);
            // 
            // ajouterModifierOuSupprimerLesDétailsDunClientToolStripMenuItem
            // 
            this.ajouterModifierOuSupprimerLesDétailsDunClientToolStripMenuItem.Name = "ajouterModifierOuSupprimerLesDétailsDunClientToolStripMenuItem";
            this.ajouterModifierOuSupprimerLesDétailsDunClientToolStripMenuItem.Size = new System.Drawing.Size(351, 22);
            this.ajouterModifierOuSupprimerLesDétailsDunClientToolStripMenuItem.Text = "Ajouter, modifier ou supprimer les détails d\'un client";
            this.ajouterModifierOuSupprimerLesDétailsDunClientToolStripMenuItem.Click += new System.EventHandler(this.ajouterModifierOuSupprimerLesDétailsDunClientToolStripMenuItem_Click);
            // 
            // gestionDesRéservationsToolStripMenuItem
            // 
            this.gestionDesRéservationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterLaListeDesRéservationsToolStripMenuItem,
            this.consulterLesDétailsDuneRéservationToolStripMenuItem,
            this.ajouterModifierOuSupprimerLesDétailsDuneRéservationToolStripMenuItem,
            this.imprimerUneRéservationetSesDétailsToolStripMenuItem});
            this.gestionDesRéservationsToolStripMenuItem.Name = "gestionDesRéservationsToolStripMenuItem";
            this.gestionDesRéservationsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.gestionDesRéservationsToolStripMenuItem.Text = "Gestion des réservations";
            // 
            // consulterLaListeDesRéservationsToolStripMenuItem
            // 
            this.consulterLaListeDesRéservationsToolStripMenuItem.Name = "consulterLaListeDesRéservationsToolStripMenuItem";
            this.consulterLaListeDesRéservationsToolStripMenuItem.Size = new System.Drawing.Size(386, 22);
            this.consulterLaListeDesRéservationsToolStripMenuItem.Text = "Consulter la liste des réservations";
            this.consulterLaListeDesRéservationsToolStripMenuItem.Click += new System.EventHandler(this.consulterLaListeDesRéservationsToolStripMenuItem_Click);
            // 
            // consulterLesDétailsDuneRéservationToolStripMenuItem
            // 
            this.consulterLesDétailsDuneRéservationToolStripMenuItem.Name = "consulterLesDétailsDuneRéservationToolStripMenuItem";
            this.consulterLesDétailsDuneRéservationToolStripMenuItem.Size = new System.Drawing.Size(386, 22);
            this.consulterLesDétailsDuneRéservationToolStripMenuItem.Text = "Consulter les détails d\'une réservation";
            this.consulterLesDétailsDuneRéservationToolStripMenuItem.Click += new System.EventHandler(this.consulterLesDétailsDuneRéservationToolStripMenuItem_Click);
            // 
            // ajouterModifierOuSupprimerLesDétailsDuneRéservationToolStripMenuItem
            // 
            this.ajouterModifierOuSupprimerLesDétailsDuneRéservationToolStripMenuItem.Name = "ajouterModifierOuSupprimerLesDétailsDuneRéservationToolStripMenuItem";
            this.ajouterModifierOuSupprimerLesDétailsDuneRéservationToolStripMenuItem.Size = new System.Drawing.Size(386, 22);
            this.ajouterModifierOuSupprimerLesDétailsDuneRéservationToolStripMenuItem.Text = "Ajouter, modifier ou supprimer les détails d\'une réservation";
            this.ajouterModifierOuSupprimerLesDétailsDuneRéservationToolStripMenuItem.Click += new System.EventHandler(this.ajouterModifierOuSupprimerLesDétailsDuneRéservationToolStripMenuItem_Click);
            // 
            // imprimerUneRéservationetSesDétailsToolStripMenuItem
            // 
            this.imprimerUneRéservationetSesDétailsToolStripMenuItem.Name = "imprimerUneRéservationetSesDétailsToolStripMenuItem";
            this.imprimerUneRéservationetSesDétailsToolStripMenuItem.Size = new System.Drawing.Size(386, 22);
            this.imprimerUneRéservationetSesDétailsToolStripMenuItem.Text = "Imprimer une réservation et ses détails";
            // 
            // gestionDesÉquipementsToolStripMenuItem
            // 
            this.gestionDesÉquipementsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterLesÉquipementsToolStripMenuItem,
            this.détailDunÉquipementToolStripMenuItem,
            this.ajouterModifierSupprimerLeDétailDunÉquipementToolStripMenuItem});
            this.gestionDesÉquipementsToolStripMenuItem.Name = "gestionDesÉquipementsToolStripMenuItem";
            this.gestionDesÉquipementsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.gestionDesÉquipementsToolStripMenuItem.Text = "Gestion des équipements";
            // 
            // consulterLesÉquipementsToolStripMenuItem
            // 
            this.consulterLesÉquipementsToolStripMenuItem.Name = "consulterLesÉquipementsToolStripMenuItem";
            this.consulterLesÉquipementsToolStripMenuItem.Size = new System.Drawing.Size(386, 22);
            this.consulterLesÉquipementsToolStripMenuItem.Text = "Consulter les équipements";
            this.consulterLesÉquipementsToolStripMenuItem.Click += new System.EventHandler(this.consulterLesÉquipementsToolStripMenuItem_Click);
            // 
            // détailDunÉquipementToolStripMenuItem
            // 
            this.détailDunÉquipementToolStripMenuItem.Name = "détailDunÉquipementToolStripMenuItem";
            this.détailDunÉquipementToolStripMenuItem.Size = new System.Drawing.Size(386, 22);
            this.détailDunÉquipementToolStripMenuItem.Text = "Consulter les détails d\'un équipement";
            this.détailDunÉquipementToolStripMenuItem.Click += new System.EventHandler(this.détailDunÉquipementToolStripMenuItem_Click);
            // 
            // ajouterModifierSupprimerLeDétailDunÉquipementToolStripMenuItem
            // 
            this.ajouterModifierSupprimerLeDétailDunÉquipementToolStripMenuItem.Name = "ajouterModifierSupprimerLeDétailDunÉquipementToolStripMenuItem";
            this.ajouterModifierSupprimerLeDétailDunÉquipementToolStripMenuItem.Size = new System.Drawing.Size(386, 22);
            this.ajouterModifierSupprimerLeDétailDunÉquipementToolStripMenuItem.Text = "Ajouter, modifier ou supprimer les détails d\'un équipement";
            this.ajouterModifierSupprimerLeDétailDunÉquipementToolStripMenuItem.Click += new System.EventHandler(this.ajouterModifierSupprimerLeDétailDunÉquipementToolStripMenuItem_Click);
            // 
            // gestionDesEmployésToolStripMenuItem
            // 
            this.gestionDesEmployésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consulterLaListeDesEmployésToolStripMenuItem,
            this.consulterLesDétailsDunEmployéToolStripMenuItem,
            this.ajouterModifierOuSupprimerLesDétailsDunEmployéToolStripMenuItem,
            this.abscencesDesEmployésToolStripMenuItem});
            this.gestionDesEmployésToolStripMenuItem.Name = "gestionDesEmployésToolStripMenuItem";
            this.gestionDesEmployésToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.gestionDesEmployésToolStripMenuItem.Text = "Gestion des employés";
            // 
            // consulterLaListeDesEmployésToolStripMenuItem
            // 
            this.consulterLaListeDesEmployésToolStripMenuItem.Name = "consulterLaListeDesEmployésToolStripMenuItem";
            this.consulterLaListeDesEmployésToolStripMenuItem.Size = new System.Drawing.Size(441, 22);
            this.consulterLaListeDesEmployésToolStripMenuItem.Text = "Consulter la liste des employés";
            this.consulterLaListeDesEmployésToolStripMenuItem.Click += new System.EventHandler(this.consulterLaListeDesEmployésToolStripMenuItem_Click);
            // 
            // consulterLesDétailsDunEmployéToolStripMenuItem
            // 
            this.consulterLesDétailsDunEmployéToolStripMenuItem.Name = "consulterLesDétailsDunEmployéToolStripMenuItem";
            this.consulterLesDétailsDunEmployéToolStripMenuItem.Size = new System.Drawing.Size(441, 22);
            this.consulterLesDétailsDunEmployéToolStripMenuItem.Text = "Consulter les détails d\'un employé";
            this.consulterLesDétailsDunEmployéToolStripMenuItem.Click += new System.EventHandler(this.consulterLesDétailsDunEmployéToolStripMenuItem_Click);
            // 
            // ajouterModifierOuSupprimerLesDétailsDunEmployéToolStripMenuItem
            // 
            this.ajouterModifierOuSupprimerLesDétailsDunEmployéToolStripMenuItem.Name = "ajouterModifierOuSupprimerLesDétailsDunEmployéToolStripMenuItem";
            this.ajouterModifierOuSupprimerLesDétailsDunEmployéToolStripMenuItem.Size = new System.Drawing.Size(441, 22);
            this.ajouterModifierOuSupprimerLesDétailsDunEmployéToolStripMenuItem.Text = "Ajouter, modifier ou supprimer les détails d\'un employé";
            this.ajouterModifierOuSupprimerLesDétailsDunEmployéToolStripMenuItem.Click += new System.EventHandler(this.ajouterModifierOuSupprimerLesDétailsDunEmployéToolStripMenuItem_Click);
            // 
            // abscencesDesEmployésToolStripMenuItem
            // 
            this.abscencesDesEmployésToolStripMenuItem.Name = "abscencesDesEmployésToolStripMenuItem";
            this.abscencesDesEmployésToolStripMenuItem.Size = new System.Drawing.Size(441, 22);
            this.abscencesDesEmployésToolStripMenuItem.Text = "Ajouter, modifier ou supprimer une période d\'inactivité d\'un employé";
            this.abscencesDesEmployésToolStripMenuItem.Click += new System.EventHandler(this.abscencesDesEmployésToolStripMenuItem_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fAQToolStripMenuItem,
            this.aProposToolStripMenuItem,
            this.créditsToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(24, 20);
            this.aideToolStripMenuItem.Text = "?";
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.fAQToolStripMenuItem.Text = "FAQ";
            this.fAQToolStripMenuItem.Click += new System.EventHandler(this.fAQToolStripMenuItem_Click);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aProposToolStripMenuItem.Text = "A propos";
            this.aProposToolStripMenuItem.Click += new System.EventHandler(this.aProposToolStripMenuItem_Click);
            // 
            // créditsToolStripMenuItem
            // 
            this.créditsToolStripMenuItem.Name = "créditsToolStripMenuItem";
            this.créditsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.créditsToolStripMenuItem.Text = "Crédits";
            this.créditsToolStripMenuItem.Click += new System.EventHandler(this.créditsToolStripMenuItem_Click);
            // 
            // dateTimeMain
            // 
            this.dateTimeMain.AutoSize = true;
            this.dateTimeMain.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.dateTimeMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeMain.ForeColor = System.Drawing.Color.White;
            this.dateTimeMain.Location = new System.Drawing.Point(641, 590);
            this.dateTimeMain.Name = "dateTimeMain";
            this.dateTimeMain.Size = new System.Drawing.Size(29, 16);
            this.dateTimeMain.TabIndex = 1;
            this.dateTimeMain.Text = "___";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 612);
            this.Controls.Add(this.dateTimeMain);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "| Doo-Jet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesRéservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesÉquipementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesEmployésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.Label dateTimeMain;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterLesÉquipementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem détailDunÉquipementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterModifierSupprimerLeDétailDunÉquipementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterLaListeDesEmployésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterLesDétailsDunEmployéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterModifierOuSupprimerLesDétailsDunEmployéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrementDeLaBDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterLaListeDesClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterLesRéservationsDunClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterModifierOuSupprimerLesDétailsDunClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterLaListeDesRéservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consulterLesDétailsDuneRéservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterModifierOuSupprimerLesDétailsDuneRéservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimerUneRéservationetSesDétailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abscencesDesEmployésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem créditsToolStripMenuItem;
    }
}

