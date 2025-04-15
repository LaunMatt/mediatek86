using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using mediatek86.controller;
using mediatek86.model;

namespace mediatek86
{
    /// <summary>
    /// Fenêtre de l'application où se déroulent les actions de l'utilisateur.
    /// </summary>
    public partial class FrmMediatek86 : Form
    {
        /// <summary>
        /// Booléen pour savoir si une modification est demandée au niveau du personnel
        /// </summary>
        private Boolean enCoursDeModifPersonnel = false;
        /// <summary>
        /// Booléen pour savoir si une modification est demandée au niveau des absences
        /// </summary>
        private Boolean enCoursDeModifAbsence = false;
        /// <summary>
        /// Objet pour gérer la liste du personnel
        /// </summary>
        private BindingSource bdgPersonnel = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des services
        /// </summary>
        private BindingSource bdgServices = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des absences
        /// </summary>
        private BindingSource bdgAbsences = new BindingSource();
        /// <summary>
        /// Objet pour gérer la liste des motifs
        /// </summary>
        private BindingSource bdgMotifs = new BindingSource();
        /// <summary>
        /// Controleur de la fenêtre
        /// </summary>
        private FrmMediatek86Controller controller;

        /// <summary>
        /// Construction des composants graphiques et appel des autres initialisations
        /// </summary>
        public FrmMediatek86()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations :
        /// Création du controleur et remplissage des listes
        /// </summary>
        private void Init()
        {
            controller = new FrmMediatek86Controller();
            RemplirListePersonnel();
            RemplirListeServices();
            RemplirListeMotifs();
            EnCoursDeModifPersonnel(false);
            gbxAjoutModifAbsence.Enabled = false;
        }

        /// <summary>
        /// Affiche le personnel
        /// </summary>
        private void RemplirListePersonnel()
        {
            List<Personnel> lePersonnel = controller.GetLePersonnel();
            bdgPersonnel.DataSource = lePersonnel;
            dgvPersonnel.DataSource = bdgPersonnel;
            dgvPersonnel.Columns["idpersonnel"].Visible = false;
            dgvPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// Affiche les services
        /// </summary>
        private void RemplirListeServices()
        {
            List<Service> lesServices = controller.GetLesServices();
            bdgServices.DataSource = lesServices;
            cbxServicePersonnel.DataSource = bdgServices;
        }
        
        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerPersonnel_Click(object sender, EventArgs e)
        {
            if (!txtNom.Text.Equals("") && !txtPrenom.Text.Equals("") && !txtTelephone.Text.Equals("") && !txtMail.Text.Equals("") && cbxServicePersonnel.SelectedIndex != -1)
            {
                Service service = (Service)bdgServices.List[bdgServices.Position];
                if (enCoursDeModifPersonnel)
                {
                    Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                    personnel.Nom = txtNom.Text;
                    personnel.Prenom = txtPrenom.Text;
                    personnel.Tel = txtTelephone.Text;
                    personnel.Mail = txtMail.Text;
                    personnel.Service = service;
                    controller.UpdatePersonnel(personnel);
                }
                else
                {
                    Personnel personnel = new Personnel(0, txtNom.Text, txtPrenom.Text, txtTelephone.Text, txtMail.Text, service);
                    controller.AddPersonnel(personnel);
                }
                RemplirListePersonnel();
                EnCoursDeModifPersonnel(false);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout du personnel
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursDeModifPersonnel(Boolean modif)
        {
            enCoursDeModifPersonnel = modif;
            gbxPersonnel.Enabled = !modif;
            if (modif)
            {
                gbxAjoutModifPersonnel.Text = "Modifier du personnel";
            }
            else
            {
                gbxAjoutModifPersonnel.Text = "Ajouter du personnel";
                txtNom.Text = "";
                txtPrenom.Text = "";
                txtTelephone.Text = "";
                txtMail.Text = "";
            }
        }

        /// <summary>
        /// Annule la demande d'ajout ou de modification du personnel
        /// Vide les zones de saisie du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerPersonnel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursDeModifPersonnel(false);
            }
        }

        /// <summary>
        /// Demande de suppression du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    controller.DelPersonnel(personnel);
                    RemplirListePersonnel();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        ///  Demande de modification du personnel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifPersonnel_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                EnCoursDeModifPersonnel(true);
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                txtNom.Text = personnel.Nom;
                txtPrenom.Text = personnel.Prenom;
                txtTelephone.Text = personnel.Tel;
                txtMail.Text = personnel.Mail;
                cbxServicePersonnel.SelectedIndex = cbxServicePersonnel.FindStringExact(personnel.Service.Nom);
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Affiche les absences du personnel
        /// </summary>
        private void RemplirListeAbsences(int idpersonnelselect)
        {
            List<Absence> lesAbsences = controller.GetLesAbsences(idpersonnelselect);
            bdgAbsences.DataSource = lesAbsences;
            dgvAbsences.DataSource = bdgAbsences;
            dgvAbsences.Columns["idpersonnel"].Visible = false;
            dgvAbsences.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Affiche les MTOFS
        /// </summary>
        private void RemplirListeMotifs()
        {
            List<Motif> lesMotifs = controller.GetLesMotifs();
            bdgMotifs.DataSource = lesMotifs;
            cbxMotif.DataSource = bdgMotifs;
        }

        /// <summary>
        /// Demande d'affichage des absences
        /// </summary>
        private void btnGestionAbsence_Click(object sender, EventArgs e)
        {
            if (dgvPersonnel.SelectedRows.Count > 0)
            {
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                RemplirListeAbsences(personnel.Idpersonnel);
                gbxAjoutModifAbsence.Enabled = true;
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        /// <summary>
        /// Demande d'enregistrement de l'ajout ou de la modification d'une absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerAbsence_Click(object sender, EventArgs e)
        {
            if (!dtpDateDebut.Text.Equals("") && !dtpDateFin.Text.Equals("") && cbxMotif.SelectedIndex != -1)
            {
                Motif motif = (Motif)bdgMotifs.List[bdgMotifs.Position];
                if (enCoursDeModifAbsence)
                {
                    Personnel personnelselect = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                    Absence absence = (Absence)bdgAbsences.List[bdgAbsences.Position];
                    absence.Datedebut = DateTime.Parse(dtpDateDebut.Text);
                    absence.Datefin = DateTime.Parse(dtpDateFin.Text);
                    absence.Motif = motif;
                    int dateResult = DateTime.Compare(absence.Datedebut, absence.Datefin);
                    if (dateResult <= 0)
                    {
                        if (AbsenceChevauche(absence.Datedebut, absence.Datefin, personnelselect.Idpersonnel, absence) == false)
                        {
                            controller.UpdateAbsence(absence);
                        }
                        else
                        {
                            MessageBox.Show("La nouvelle absence ne peut pas chevaucher une absence déjà existante.", "Information");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La date de début doit être antérieure à la date de fin.", "Information");
                    }
                }
                else
                {
                    Personnel personnelselect = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                    Absence absence = new Absence(personnelselect.Idpersonnel, DateTime.Parse(dtpDateDebut.Text), DateTime.Parse(dtpDateFin.Text), motif);
                    int dateResult = DateTime.Compare(absence.Datedebut, absence.Datefin);
                    if (dateResult <= 0)
                    {
                        if (AbsenceChevauche(absence.Datedebut, absence.Datefin, personnelselect.Idpersonnel, absence) == false)
                        {
                            controller.AddAbsence(absence);
                        }
                        else
                        {
                            MessageBox.Show("La nouvelle absence ne peut pas chevaucher une absence déjà existante.", "Information");
                        }
                    }
                    else
                    {
                        MessageBox.Show("La date de début doit être antérieure à la date de fin.", "Information");
                    }
                }
                Personnel personnel = (Personnel)bdgPersonnel.List[bdgPersonnel.Position];
                RemplirListeAbsences(personnel.Idpersonnel);
                EnCoursDeModifAbsence(false);
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        /// <summary>
        /// Modification d'affichage suivant si on est en cours de modif ou d'ajout de l'absence
        /// </summary>
        /// <param name="modif"></param>
        private void EnCoursDeModifAbsence(Boolean modif)
        {
            enCoursDeModifAbsence = modif;
            gbxAbsences.Enabled = !modif;
            if (modif)
            {
                gbxAjoutModifAbsence.Text = "Modifier une absence";
            }
            else
            {
                gbxAjoutModifAbsence.Text = "Ajouter une absence";
                dtpDateDebut.Text = "";
                dtpDateFin.Text = "";
            }
        }

        /// <summary>
        /// Annule la demande d'ajout ou de modification de l'absence
        /// Vide les zones de saisie de l'absence
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerAbsence_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                EnCoursDeModifAbsence(false);
            }
        }

        /// <summary>
        /// Vérifie s'il y a une superposition d'absences pour le personnel sélectionné
        /// </summary>
        private bool AbsenceChevauche(DateTime dateDebut, DateTime dateFin, int idPersonnel, Absence absenceEnCours = null)
        {
            List<Absence> absencesExistantes = controller.GetLesAbsences(idPersonnel);

            foreach (Absence absence in absencesExistantes)
            {
                if (absenceEnCours != null && absence == absenceEnCours)
                {
                    continue;
                }
                if (!(dateFin < absence.Datedebut || dateDebut > absence.Datefin))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
