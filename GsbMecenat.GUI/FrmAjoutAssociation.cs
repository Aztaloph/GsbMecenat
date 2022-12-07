using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GsbMecenat.BLL;
using GsbMecenat.BO;

namespace GsbMecenat.GUI
{
    public partial class FrmAjoutAssociation : Form
    {
        public FrmAjoutAssociation()
        {
            InitializeComponent();

            #region Remplir la liste des Pays
            cboPays.DataSource = PaysManager.GetInstance().GetLesPays();
            cboPays.DisplayMember = "Nom";
            cboPays.ValueMember = "CodeISO";
            cboPays.SelectedIndex = -1;
            #endregion

            #region Remplir la liste des Missions
            cboMission.DataSource = MissionManager.GetInstance().GetLesMissions();
            cboMission.DisplayMember = "Libelle";
            cboMission.ValueMember = "Id";
            cboMission.SelectedIndex = -1;
            #endregion
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            #region Contrôle des données saisies
            string erreurs = "";
            if (string.IsNullOrWhiteSpace(txtNom.Text) == true)
            {
                erreurs += "Le nom du produit doit être renseigné\n";
                txtNom.Focus();
            }
            if (cboPays.SelectedIndex == -1)
            {
                erreurs += "Le Pays doit être renseignée\n";
            }
            #endregion

            if (erreurs != "")
            {
                MessageBox.Show(erreurs, "Erreurs", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Enregistrement du produit dans la BDD
                string nom = txtNom.Text;
                string Responsable = txtResponsable.Text;
                string CodeISO = cboPays.SelectedValue.ToString();
                int IdMission = Convert.ToInt32(cboMission.SelectedValue.ToString());
                AssociationManager.GetInstance().AjouterAssociation(nom, Responsable, CodeISO, IdMission);
                MessageBox.Show("Association ajouté", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
