namespace mediatek86
{
    partial class FrmMediatek86
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
            this.dgvPersonnel = new System.Windows.Forms.DataGridView();
            this.gbxPersonnel = new System.Windows.Forms.GroupBox();
            this.gbxAbsences = new System.Windows.Forms.GroupBox();
            this.dgvAbsences = new System.Windows.Forms.DataGridView();
            this.btnAjoutPersonnel = new System.Windows.Forms.Button();
            this.btnModifPersonnel = new System.Windows.Forms.Button();
            this.btnSupprimerPersonnel = new System.Windows.Forms.Button();
            this.btnAjoutAbsence = new System.Windows.Forms.Button();
            this.btnModifAbsence = new System.Windows.Forms.Button();
            this.btnSupprimerAbsence = new System.Windows.Forms.Button();
            this.gbxAjoutModifPersonnel = new System.Windows.Forms.GroupBox();
            this.cbxServicePersonnel = new System.Windows.Forms.ComboBox();
            this.lblServicePersonnel = new System.Windows.Forms.Label();
            this.btnAnnulerPersonnel = new System.Windows.Forms.Button();
            this.btnEnregistrerPersonnel = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.gbxAjoutModifAbsence = new System.Windows.Forms.GroupBox();
            this.cbxMotif = new System.Windows.Forms.ComboBox();
            this.btnAnnulerAbsence = new System.Windows.Forms.Button();
            this.btnEnregistrerAbsence = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblDateDebut = new System.Windows.Forms.Label();
            this.btnGestionAbsence = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).BeginInit();
            this.gbxPersonnel.SuspendLayout();
            this.gbxAbsences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).BeginInit();
            this.gbxAjoutModifPersonnel.SuspendLayout();
            this.gbxAjoutModifAbsence.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPersonnel
            // 
            this.dgvPersonnel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonnel.Location = new System.Drawing.Point(6, 19);
            this.dgvPersonnel.Name = "dgvPersonnel";
            this.dgvPersonnel.Size = new System.Drawing.Size(329, 152);
            this.dgvPersonnel.TabIndex = 0;
            // 
            // gbxPersonnel
            // 
            this.gbxPersonnel.Controls.Add(this.dgvPersonnel);
            this.gbxPersonnel.Location = new System.Drawing.Point(12, 12);
            this.gbxPersonnel.Name = "gbxPersonnel";
            this.gbxPersonnel.Size = new System.Drawing.Size(341, 177);
            this.gbxPersonnel.TabIndex = 1;
            this.gbxPersonnel.TabStop = false;
            this.gbxPersonnel.Text = "Personnel";
            // 
            // gbxAbsences
            // 
            this.gbxAbsences.Controls.Add(this.dgvAbsences);
            this.gbxAbsences.Location = new System.Drawing.Point(371, 12);
            this.gbxAbsences.Name = "gbxAbsences";
            this.gbxAbsences.Size = new System.Drawing.Size(341, 177);
            this.gbxAbsences.TabIndex = 2;
            this.gbxAbsences.TabStop = false;
            this.gbxAbsences.Text = "Absences";
            // 
            // dgvAbsences
            // 
            this.dgvAbsences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbsences.Location = new System.Drawing.Point(6, 19);
            this.dgvAbsences.Name = "dgvAbsences";
            this.dgvAbsences.Size = new System.Drawing.Size(329, 152);
            this.dgvAbsences.TabIndex = 3;
            // 
            // btnAjoutPersonnel
            // 
            this.btnAjoutPersonnel.Location = new System.Drawing.Point(12, 195);
            this.btnAjoutPersonnel.Name = "btnAjoutPersonnel";
            this.btnAjoutPersonnel.Size = new System.Drawing.Size(112, 23);
            this.btnAjoutPersonnel.TabIndex = 3;
            this.btnAjoutPersonnel.Text = "Ajouter personnel";
            this.btnAjoutPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnModifPersonnel
            // 
            this.btnModifPersonnel.Location = new System.Drawing.Point(126, 195);
            this.btnModifPersonnel.Name = "btnModifPersonnel";
            this.btnModifPersonnel.Size = new System.Drawing.Size(112, 23);
            this.btnModifPersonnel.TabIndex = 4;
            this.btnModifPersonnel.Text = "Modifier personnel";
            this.btnModifPersonnel.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerPersonnel
            // 
            this.btnSupprimerPersonnel.Location = new System.Drawing.Point(241, 195);
            this.btnSupprimerPersonnel.Name = "btnSupprimerPersonnel";
            this.btnSupprimerPersonnel.Size = new System.Drawing.Size(112, 23);
            this.btnSupprimerPersonnel.TabIndex = 5;
            this.btnSupprimerPersonnel.Text = "Supprimer personnel";
            this.btnSupprimerPersonnel.UseVisualStyleBackColor = true;
            this.btnSupprimerPersonnel.Click += new System.EventHandler(this.btnSupprimerPersonnel_Click);
            // 
            // btnAjoutAbsence
            // 
            this.btnAjoutAbsence.Location = new System.Drawing.Point(371, 195);
            this.btnAjoutAbsence.Name = "btnAjoutAbsence";
            this.btnAjoutAbsence.Size = new System.Drawing.Size(112, 23);
            this.btnAjoutAbsence.TabIndex = 6;
            this.btnAjoutAbsence.Text = "Ajouter absence";
            this.btnAjoutAbsence.UseVisualStyleBackColor = true;
            // 
            // btnModifAbsence
            // 
            this.btnModifAbsence.Location = new System.Drawing.Point(485, 195);
            this.btnModifAbsence.Name = "btnModifAbsence";
            this.btnModifAbsence.Size = new System.Drawing.Size(112, 23);
            this.btnModifAbsence.TabIndex = 7;
            this.btnModifAbsence.Text = "Modifier absence";
            this.btnModifAbsence.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerAbsence
            // 
            this.btnSupprimerAbsence.Location = new System.Drawing.Point(600, 195);
            this.btnSupprimerAbsence.Name = "btnSupprimerAbsence";
            this.btnSupprimerAbsence.Size = new System.Drawing.Size(112, 23);
            this.btnSupprimerAbsence.TabIndex = 8;
            this.btnSupprimerAbsence.Text = "Supprimer absence";
            this.btnSupprimerAbsence.UseVisualStyleBackColor = true;
            // 
            // gbxAjoutModifPersonnel
            // 
            this.gbxAjoutModifPersonnel.Controls.Add(this.cbxServicePersonnel);
            this.gbxAjoutModifPersonnel.Controls.Add(this.lblServicePersonnel);
            this.gbxAjoutModifPersonnel.Controls.Add(this.btnAnnulerPersonnel);
            this.gbxAjoutModifPersonnel.Controls.Add(this.btnEnregistrerPersonnel);
            this.gbxAjoutModifPersonnel.Controls.Add(this.txtMail);
            this.gbxAjoutModifPersonnel.Controls.Add(this.txtTelephone);
            this.gbxAjoutModifPersonnel.Controls.Add(this.txtPrenom);
            this.gbxAjoutModifPersonnel.Controls.Add(this.txtNom);
            this.gbxAjoutModifPersonnel.Controls.Add(this.lblMail);
            this.gbxAjoutModifPersonnel.Controls.Add(this.lblTel);
            this.gbxAjoutModifPersonnel.Controls.Add(this.lblPrenom);
            this.gbxAjoutModifPersonnel.Controls.Add(this.lblNom);
            this.gbxAjoutModifPersonnel.Location = new System.Drawing.Point(12, 224);
            this.gbxAjoutModifPersonnel.Name = "gbxAjoutModifPersonnel";
            this.gbxAjoutModifPersonnel.Size = new System.Drawing.Size(341, 191);
            this.gbxAjoutModifPersonnel.TabIndex = 9;
            this.gbxAjoutModifPersonnel.TabStop = false;
            this.gbxAjoutModifPersonnel.Text = "Ajouter du personnel";
            // 
            // cbxServicePersonnel
            // 
            this.cbxServicePersonnel.FormattingEnabled = true;
            this.cbxServicePersonnel.Location = new System.Drawing.Point(70, 121);
            this.cbxServicePersonnel.Name = "cbxServicePersonnel";
            this.cbxServicePersonnel.Size = new System.Drawing.Size(256, 21);
            this.cbxServicePersonnel.TabIndex = 16;
            // 
            // lblServicePersonnel
            // 
            this.lblServicePersonnel.AutoSize = true;
            this.lblServicePersonnel.Location = new System.Drawing.Point(9, 126);
            this.lblServicePersonnel.Name = "lblServicePersonnel";
            this.lblServicePersonnel.Size = new System.Drawing.Size(43, 13);
            this.lblServicePersonnel.TabIndex = 15;
            this.lblServicePersonnel.Text = "Service";
            // 
            // btnAnnulerPersonnel
            // 
            this.btnAnnulerPersonnel.Location = new System.Drawing.Point(98, 162);
            this.btnAnnulerPersonnel.Name = "btnAnnulerPersonnel";
            this.btnAnnulerPersonnel.Size = new System.Drawing.Size(83, 23);
            this.btnAnnulerPersonnel.TabIndex = 14;
            this.btnAnnulerPersonnel.Text = "Annuler";
            this.btnAnnulerPersonnel.UseVisualStyleBackColor = true;
            this.btnAnnulerPersonnel.Click += new System.EventHandler(this.btnAnnulerPersonnel_Click);
            // 
            // btnEnregistrerPersonnel
            // 
            this.btnEnregistrerPersonnel.Location = new System.Drawing.Point(9, 162);
            this.btnEnregistrerPersonnel.Name = "btnEnregistrerPersonnel";
            this.btnEnregistrerPersonnel.Size = new System.Drawing.Size(83, 23);
            this.btnEnregistrerPersonnel.TabIndex = 10;
            this.btnEnregistrerPersonnel.Text = "Enregistrer";
            this.btnEnregistrerPersonnel.UseVisualStyleBackColor = true;
            this.btnEnregistrerPersonnel.Click += new System.EventHandler(this.btnEnregistrerPersonnel_Click);
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(70, 94);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(256, 20);
            this.txtMail.TabIndex = 13;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(70, 70);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(256, 20);
            this.txtTelephone.TabIndex = 12;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(70, 46);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(256, 20);
            this.txtPrenom.TabIndex = 11;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(70, 22);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(256, 20);
            this.txtNom.TabIndex = 10;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(9, 96);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(26, 13);
            this.lblMail.TabIndex = 3;
            this.lblMail.Text = "Mail";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(6, 73);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(58, 13);
            this.lblTel.TabIndex = 2;
            this.lblTel.Text = "Téléphone";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(6, 49);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(43, 13);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(6, 25);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // gbxAjoutModifAbsence
            // 
            this.gbxAjoutModifAbsence.Controls.Add(this.cbxMotif);
            this.gbxAjoutModifAbsence.Controls.Add(this.btnAnnulerAbsence);
            this.gbxAjoutModifAbsence.Controls.Add(this.btnEnregistrerAbsence);
            this.gbxAjoutModifAbsence.Controls.Add(this.textBox3);
            this.gbxAjoutModifAbsence.Controls.Add(this.textBox4);
            this.gbxAjoutModifAbsence.Controls.Add(this.lblMotif);
            this.gbxAjoutModifAbsence.Controls.Add(this.lblDateFin);
            this.gbxAjoutModifAbsence.Controls.Add(this.lblDateDebut);
            this.gbxAjoutModifAbsence.Location = new System.Drawing.Point(371, 224);
            this.gbxAjoutModifAbsence.Name = "gbxAjoutModifAbsence";
            this.gbxAjoutModifAbsence.Size = new System.Drawing.Size(341, 150);
            this.gbxAjoutModifAbsence.TabIndex = 10;
            this.gbxAjoutModifAbsence.TabStop = false;
            this.gbxAjoutModifAbsence.Text = "Ajouter/Modifier une absence";
            // 
            // cbxMotif
            // 
            this.cbxMotif.FormattingEnabled = true;
            this.cbxMotif.Location = new System.Drawing.Point(87, 79);
            this.cbxMotif.Name = "cbxMotif";
            this.cbxMotif.Size = new System.Drawing.Size(239, 21);
            this.cbxMotif.TabIndex = 15;
            // 
            // btnAnnulerAbsence
            // 
            this.btnAnnulerAbsence.Location = new System.Drawing.Point(98, 121);
            this.btnAnnulerAbsence.Name = "btnAnnulerAbsence";
            this.btnAnnulerAbsence.Size = new System.Drawing.Size(83, 23);
            this.btnAnnulerAbsence.TabIndex = 14;
            this.btnAnnulerAbsence.Text = "Annuler";
            this.btnAnnulerAbsence.UseVisualStyleBackColor = true;
            // 
            // btnEnregistrerAbsence
            // 
            this.btnEnregistrerAbsence.Location = new System.Drawing.Point(9, 121);
            this.btnEnregistrerAbsence.Name = "btnEnregistrerAbsence";
            this.btnEnregistrerAbsence.Size = new System.Drawing.Size(83, 23);
            this.btnEnregistrerAbsence.TabIndex = 10;
            this.btnEnregistrerAbsence.Text = "Enregistrer";
            this.btnEnregistrerAbsence.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(87, 46);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(239, 20);
            this.textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(87, 22);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(239, 20);
            this.textBox4.TabIndex = 10;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Location = new System.Drawing.Point(6, 82);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(30, 13);
            this.lblMotif.TabIndex = 3;
            this.lblMotif.Text = "Motif";
            // 
            // lblDateFin
            // 
            this.lblDateFin.AutoSize = true;
            this.lblDateFin.Location = new System.Drawing.Point(6, 49);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(59, 13);
            this.lblDateFin.TabIndex = 1;
            this.lblDateFin.Text = "Date de fin";
            // 
            // lblDateDebut
            // 
            this.lblDateDebut.AutoSize = true;
            this.lblDateDebut.Location = new System.Drawing.Point(6, 25);
            this.lblDateDebut.Name = "lblDateDebut";
            this.lblDateDebut.Size = new System.Drawing.Size(75, 13);
            this.lblDateDebut.TabIndex = 0;
            this.lblDateDebut.Text = "Date de début";
            // 
            // btnGestionAbsence
            // 
            this.btnGestionAbsence.Location = new System.Drawing.Point(371, 386);
            this.btnGestionAbsence.Name = "btnGestionAbsence";
            this.btnGestionAbsence.Size = new System.Drawing.Size(341, 23);
            this.btnGestionAbsence.TabIndex = 16;
            this.btnGestionAbsence.Text = "Gérer les absences du personnel sélectionné";
            this.btnGestionAbsence.UseVisualStyleBackColor = true;
            // 
            // FrmMediatek86
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 429);
            this.Controls.Add(this.btnGestionAbsence);
            this.Controls.Add(this.gbxAjoutModifAbsence);
            this.Controls.Add(this.gbxAjoutModifPersonnel);
            this.Controls.Add(this.btnSupprimerAbsence);
            this.Controls.Add(this.btnModifAbsence);
            this.Controls.Add(this.btnAjoutAbsence);
            this.Controls.Add(this.btnSupprimerPersonnel);
            this.Controls.Add(this.btnModifPersonnel);
            this.Controls.Add(this.btnAjoutPersonnel);
            this.Controls.Add(this.gbxAbsences);
            this.Controls.Add(this.gbxPersonnel);
            this.Name = "FrmMediatek86";
            this.Text = "MediaTek86";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonnel)).EndInit();
            this.gbxPersonnel.ResumeLayout(false);
            this.gbxAbsences.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbsences)).EndInit();
            this.gbxAjoutModifPersonnel.ResumeLayout(false);
            this.gbxAjoutModifPersonnel.PerformLayout();
            this.gbxAjoutModifAbsence.ResumeLayout(false);
            this.gbxAjoutModifAbsence.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonnel;
        private System.Windows.Forms.GroupBox gbxPersonnel;
        private System.Windows.Forms.GroupBox gbxAbsences;
        private System.Windows.Forms.DataGridView dgvAbsences;
        private System.Windows.Forms.Button btnAjoutPersonnel;
        private System.Windows.Forms.Button btnModifPersonnel;
        private System.Windows.Forms.Button btnSupprimerPersonnel;
        private System.Windows.Forms.Button btnAjoutAbsence;
        private System.Windows.Forms.Button btnModifAbsence;
        private System.Windows.Forms.Button btnSupprimerAbsence;
        private System.Windows.Forms.GroupBox gbxAjoutModifPersonnel;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Button btnAnnulerPersonnel;
        private System.Windows.Forms.Button btnEnregistrerPersonnel;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.GroupBox gbxAjoutModifAbsence;
        private System.Windows.Forms.Button btnAnnulerAbsence;
        private System.Windows.Forms.Button btnEnregistrerAbsence;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblDateDebut;
        private System.Windows.Forms.ComboBox cbxMotif;
        private System.Windows.Forms.ComboBox cbxServicePersonnel;
        private System.Windows.Forms.Label lblServicePersonnel;
        private System.Windows.Forms.Button btnGestionAbsence;
    }
}

