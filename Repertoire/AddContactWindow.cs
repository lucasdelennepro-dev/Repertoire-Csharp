using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Repertoire
{
    public partial class AddContactWindow : Form
    {
        public AddContactWindow()
        {
            InitializeComponent();
            LoadGroup();
        }

        private void LoadGroup()
        {
            this.CB_Group.Items.Clear();
            this.CB_Group.Items.AddRange(Global.contactsGroup.ToArray());

            if(this.CB_Group.Items.Count > 0)
            {
                this.CB_Group.SelectedIndex = 1;
            }
        }

  

        private void BT_Add_Click(object sender, EventArgs e)
        {
            // Récupération des informations du contact
            string name = this.TB_Name.Text;
            string email = this.TB_Email.Text;
            string tel = this.TB_Tel.Text;
            string city = this.TB_City.Text;
            Group group = (Group)this.CB_Group.SelectedItem;


            if (CheckInputs(name, email, tel, city, group)) 
            {
                // Création du nouveau contact
                Contact contact = new Contact(name, email, tel, city);
                group.Contacts.Add(contact);

                this.DialogResult = DialogResult.OK;
            }
            else
            {
                // Si la création est incomplète
                MessageBox.Show("Veuillez renseigner toutes les informations", "Répertoire", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public bool CheckInputs(string name, string email, string city, string tel, Group group)
        {
            // Vérification de la conformité des saisies
            return !string.IsNullOrEmpty(name)
                && !string.IsNullOrEmpty(email)
                && !string.IsNullOrEmpty(tel)
                && !string.IsNullOrEmpty(city)
                && group != null;

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void TB_Rep_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
