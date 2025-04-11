using mediatek86.controller;
using System.Windows.Forms;
using mediatek86.model;
using System;

namespace mediatek86.view
{
    /// <summary>
    /// Première fenêtre de l'application permettant à l'utilisateur responsable de se connecter à l'application.
    /// </summary>
    public partial class FrmConnexion : Form
    {
        /// <summary>
        /// Contrôleur de la fenêtre
        /// </summary>
        private FrmConnexionController controller;

        /// <summary>
        /// Méthode initialisant les composants de FrmConnexion.
        /// </summary>
        public FrmConnexion()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initialisations : 
        /// Création du controleur
        /// </summary>
        private void Init()
        {
            controller = new FrmConnexionController();
        }

        /// <summary>
        /// Demande au controleur de controler l'authentification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnection_Click(object sender, System.EventArgs e)
        {
            String login = txtLogin.Text;
            String pwd = txtPassword.Text;
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
            else
            {
                Responsable responsable = new Responsable(login, pwd);
                if (controller.ControleConnexion(responsable))
                {
                    FrmMediatek86 frm = new FrmMediatek86();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Authentification incorrecte ou vous n'êtes pas admin", "Alerte");
                }
            }
        }
    }
}
