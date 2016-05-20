using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using UtilisateursBO; // Référence la couche BO
using UtilisateursBLL; // Référence la couche BLL

namespace UtilisateursGUI
{
    public partial class AffichageInfos : Form
    {
        #region Gestion du formulaire
        #region Initialisation du formulaire
        public AffichageInfos()
        {
            InitializeComponent();

            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            UtilisateursBLL.GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Eleve"]);

            // Initialisation de la valeur du total des médicaments sur l'années
            medicTotAnScoValue.Text = GestionMedicament.GetNbMedicamentsAnnees().ToString() + " médicaments";

            //initialisation du nombre de visites max en fonction de la periode
            NbtotVstP.Text = GestionVisite.GetNbVstMaxP( dateTimeDeb.Value.ToString(),dateTimeFin.Value.ToString()) .ToString() + " visites ";

            //initialisation du nombre de visites max en fonction de la periode
            nbVstEP.Text = GestionVisite.GetNbVstMoy(dateTimeDeb.Value.ToString(), dateTimeFin.Value.ToString()).ToString();
        }
        #endregion

        #region Bouton fermer
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #endregion

        private void todayBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Today is: " + DateTime.Now.Year);
        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            // Récupération de chaîne de connexion à la BD à l'ouverture du formulaire
            UtilisateursBLL.GestionEleve.SetchaineConnexion(ConfigurationManager.ConnectionStrings["Eleve"]);

            // Initialisation de la valeur du total des médicaments sur l'années
            medicTotAnScoValue.Text = GestionMedicament.GetNbMedicamentsAnnees().ToString() + " médicaments";

            //initialisation du nombre de visites max en fonction de la periode
            NbtotVstP.Text = GestionVisite.GetNbVstMaxP(dateTimeDeb.Value.ToString(), dateTimeFin.Value.ToString()).ToString() + " visites ";

            //initialisation du nombre de visites max en fonction de la periode
            nbVstEP.Text = GestionVisite.GetNbVstMoy(dateTimeDeb.Value.ToString(), dateTimeFin.Value.ToString()).ToString();
        }

    }
}
