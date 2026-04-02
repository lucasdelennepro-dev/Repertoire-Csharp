using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repertoire
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            Global.contactsGroup = SaveManager.Open();
            LoadGroup();
        }

        // Met à jour la liste de contact
        private void UpdateContacts()
        {
            int selectedIndex = this.CB_Groups.SelectedIndex;

            // Afficher tout les contacts
            if(selectedIndex == 0)
            {
                ShowAllContacts();
            }
            else if (selectedIndex > 0)
            {
                // Affichage des contacts selon le groupe selectionné
                Group group = (Group)this.CB_Groups.SelectedItem;
                ShowContactsOf(group);
            }

            if(LB_Contacts.Items.Count > 0)
            {
                this.LB_Contacts.SelectedIndex = 0;
            }
            else
            {
                ClearInfos();
            }
        }

        private void ShowContactsOf(Group group)
        {
            this.LB_Contacts.Items.Clear();
            this.LB_Contacts.Items.AddRange(group.Contacts.ToArray());
        }

        private void ShowAllContacts()
        {
            this.LB_Contacts.Items.Clear();
            foreach(Group group in Global.contactsGroup)
            {
                this.LB_Contacts.Items.AddRange(group.Contacts.ToArray());
            }
        }

        private void BT_AddContact_Click(object sender, EventArgs e)
        {
            // Instancier la fenêtre d'ajout de contact
            AddContactWindow acw = new AddContactWindow();
            DialogResult dr = acw.ShowDialog();

            if(dr == DialogResult.OK)
            {
                UpdateContacts();

                // Sauvegarder les données de contact

                SaveManager.Save(Global.contactsGroup);
            }

        }

        // Charge les groupe dans la CB_Groups
        private void LoadGroup()
        {
            this.CB_Groups.Items.Clear();
            this.CB_Groups.Items.Add("Tout");
            this.CB_Groups.Items.AddRange(Global.contactsGroup.ToArray());
            this.CB_Groups.SelectedIndex = 0;
            
        }

        private void LB_Contacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contact contact = (Contact)this.LB_Contacts.SelectedItem;
            

            if(contact !=null)
            {
                ShowInfosOf(contact);
            }
        }

        private void ShowInfosOf(Contact contact)
        {
            ClearInfos();
            this.LB_Group.Text = GetGroupOf(contact).Name;
            this.LB_Email.Text = contact.Email;
            this.LB_Name.Text = contact.ToString();
            this.LB_Tel.Text = contact.Tel;
            this.LB_City.Text = contact.City;
       
        }

        private void ClearInfos()
        {
            this.LB_Group.Text = "";
            this.LB_Email.Text = "";
            this.LB_Name.Text = "";
            this.LB_Tel.Text = "";
            this.LB_City.Text = "";
        }

        private Group GetGroupOf(Contact contact)
        {
            return Global.contactsGroup.Find(group => group.Contacts.Contains(contact));
        }

        private void CB_Groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateContacts();
        }

    

        private void BT_DeleteContact_Click(object sender, EventArgs e)
        {
            Contact contact = (Contact)this.LB_Contacts.SelectedItem;
            Group group = GetGroupOf(contact);

            if(group != null && contact != null)
            {
               DialogResult dr = MessageBox.Show("Etes vous sur de vouloir supprimer le contact ?", "Répertoire", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
               if (dr == DialogResult.Yes)
                {
                    group.Contacts.Remove(contact);
                    UpdateContacts();
                    SaveManager.Save(Global.contactsGroup);

                }
            }
        }
    }
}
