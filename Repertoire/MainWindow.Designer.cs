namespace Repertoire
{
    partial class MainWindow
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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.Group_Search = new System.Windows.Forms.GroupBox();
            this.TB_Search = new System.Windows.Forms.TextBox();
            this.CB_Groups = new System.Windows.Forms.ComboBox();
            this.group_ContactList = new System.Windows.Forms.GroupBox();
            this.BT_AddContact = new System.Windows.Forms.Button();
            this.LB_Contacts = new System.Windows.Forms.ListBox();
            this.panel_Right = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_Group = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_City = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LB_Tel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LB_Email = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Name = new System.Windows.Forms.Label();
            this.BT_DeleteContact = new System.Windows.Forms.Button();
            this.panelLeft.SuspendLayout();
            this.Group_Search.SuspendLayout();
            this.group_ContactList.SuspendLayout();
            this.panel_Right.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeft.Controls.Add(this.Group_Search);
            this.panelLeft.Controls.Add(this.group_ContactList);
            this.panelLeft.Location = new System.Drawing.Point(16, 15);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(266, 401);
            this.panelLeft.TabIndex = 0;
            // 
            // Group_Search
            // 
            this.Group_Search.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Group_Search.Controls.Add(this.TB_Search);
            this.Group_Search.Controls.Add(this.CB_Groups);
            this.Group_Search.Location = new System.Drawing.Point(7, 4);
            this.Group_Search.Margin = new System.Windows.Forms.Padding(4);
            this.Group_Search.Name = "Group_Search";
            this.Group_Search.Padding = new System.Windows.Forms.Padding(4);
            this.Group_Search.Size = new System.Drawing.Size(249, 92);
            this.Group_Search.TabIndex = 2;
            this.Group_Search.TabStop = false;
            this.Group_Search.Text = "Rechercher";
            // 
            // TB_Search
            // 
            this.TB_Search.Location = new System.Drawing.Point(8, 55);
            this.TB_Search.Margin = new System.Windows.Forms.Padding(4);
            this.TB_Search.Name = "TB_Search";
            this.TB_Search.Size = new System.Drawing.Size(232, 19);
            this.TB_Search.TabIndex = 0;
            // 
            // CB_Groups
            // 
            this.CB_Groups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Groups.FormattingEnabled = true;
            this.CB_Groups.Location = new System.Drawing.Point(8, 22);
            this.CB_Groups.Margin = new System.Windows.Forms.Padding(4);
            this.CB_Groups.Name = "CB_Groups";
            this.CB_Groups.Size = new System.Drawing.Size(232, 21);
            this.CB_Groups.TabIndex = 0;
            this.CB_Groups.SelectedIndexChanged += new System.EventHandler(this.CB_Groups_SelectedIndexChanged);
            // 
            // group_ContactList
            // 
            this.group_ContactList.Controls.Add(this.BT_AddContact);
            this.group_ContactList.Controls.Add(this.LB_Contacts);
            this.group_ContactList.Location = new System.Drawing.Point(7, 100);
            this.group_ContactList.Margin = new System.Windows.Forms.Padding(4);
            this.group_ContactList.Name = "group_ContactList";
            this.group_ContactList.Padding = new System.Windows.Forms.Padding(4);
            this.group_ContactList.Size = new System.Drawing.Size(249, 295);
            this.group_ContactList.TabIndex = 1;
            this.group_ContactList.TabStop = false;
            this.group_ContactList.Text = "Répertoire";
            // 
            // BT_AddContact
            // 
            this.BT_AddContact.Location = new System.Drawing.Point(48, 238);
            this.BT_AddContact.Margin = new System.Windows.Forms.Padding(4);
            this.BT_AddContact.Name = "BT_AddContact";
            this.BT_AddContact.Size = new System.Drawing.Size(148, 42);
            this.BT_AddContact.TabIndex = 2;
            this.BT_AddContact.Text = "Ajouter";
            this.BT_AddContact.UseVisualStyleBackColor = true;
            this.BT_AddContact.Click += new System.EventHandler(this.BT_AddContact_Click);
            // 
            // LB_Contacts
            // 
            this.LB_Contacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Contacts.FormattingEnabled = true;
            this.LB_Contacts.ItemHeight = 15;
            this.LB_Contacts.Location = new System.Drawing.Point(8, 22);
            this.LB_Contacts.Margin = new System.Windows.Forms.Padding(4);
            this.LB_Contacts.Name = "LB_Contacts";
            this.LB_Contacts.Size = new System.Drawing.Size(232, 199);
            this.LB_Contacts.TabIndex = 1;
            this.LB_Contacts.SelectedIndexChanged += new System.EventHandler(this.LB_Contacts_SelectedIndexChanged);
            // 
            // panel_Right
            // 
            this.panel_Right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_Right.Controls.Add(this.label2);
            this.panel_Right.Controls.Add(this.LB_Group);
            this.panel_Right.Controls.Add(this.label3);
            this.panel_Right.Controls.Add(this.LB_City);
            this.panel_Right.Controls.Add(this.label6);
            this.panel_Right.Controls.Add(this.LB_Tel);
            this.panel_Right.Controls.Add(this.label4);
            this.panel_Right.Controls.Add(this.LB_Email);
            this.panel_Right.Controls.Add(this.label1);
            this.panel_Right.Controls.Add(this.LB_Name);
            this.panel_Right.Location = new System.Drawing.Point(291, 42);
            this.panel_Right.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Right.Name = "panel_Right";
            this.panel_Right.Size = new System.Drawing.Size(305, 320);
            this.panel_Right.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, -1);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "FICHE INFO";
            // 
            // LB_Group
            // 
            this.LB_Group.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LB_Group.Location = new System.Drawing.Point(95, 245);
            this.LB_Group.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Group.Name = "LB_Group";
            this.LB_Group.Size = new System.Drawing.Size(209, 28);
            this.LB_Group.TabIndex = 10;
            this.LB_Group.Text = "Inconnu";
            this.LB_Group.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(12, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 28);
            this.label3.TabIndex = 9;
            this.label3.Text = "Status :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LB_City
            // 
            this.LB_City.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LB_City.Location = new System.Drawing.Point(95, 200);
            this.LB_City.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_City.Name = "LB_City";
            this.LB_City.Size = new System.Drawing.Size(209, 28);
            this.LB_City.TabIndex = 8;
            this.LB_City.Text = "Inconnu";
            this.LB_City.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.Location = new System.Drawing.Point(12, 200);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Lieux :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LB_Tel
            // 
            this.LB_Tel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LB_Tel.Location = new System.Drawing.Point(95, 155);
            this.LB_Tel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Tel.Name = "LB_Tel";
            this.LB_Tel.Size = new System.Drawing.Size(209, 28);
            this.LB_Tel.TabIndex = 6;
            this.LB_Tel.Text = "Inconnu";
            this.LB_Tel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "N° tél :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LB_Email
            // 
            this.LB_Email.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LB_Email.Location = new System.Drawing.Point(95, 110);
            this.LB_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Email.Name = "LB_Email";
            this.LB_Email.Size = new System.Drawing.Size(209, 28);
            this.LB_Email.TabIndex = 4;
            this.LB_Email.Text = "exemplemail@gmail.com";
            this.LB_Email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(12, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Email :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LB_Name
            // 
            this.LB_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LB_Name.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Name.Location = new System.Drawing.Point(-1, 42);
            this.LB_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_Name.Name = "LB_Name";
            this.LB_Name.Size = new System.Drawing.Size(305, 35);
            this.LB_Name.TabIndex = 2;
            this.LB_Name.Text = "Nom";
            this.LB_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BT_DeleteContact
            // 
            this.BT_DeleteContact.Font = new System.Drawing.Font("Ebrima", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_DeleteContact.Location = new System.Drawing.Point(376, 354);
            this.BT_DeleteContact.Margin = new System.Windows.Forms.Padding(4);
            this.BT_DeleteContact.Name = "BT_DeleteContact";
            this.BT_DeleteContact.Size = new System.Drawing.Size(132, 42);
            this.BT_DeleteContact.TabIndex = 13;
            this.BT_DeleteContact.Text = "Supprimer";
            this.BT_DeleteContact.UseVisualStyleBackColor = true;
            this.BT_DeleteContact.Click += new System.EventHandler(this.BT_DeleteContact_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 430);
            this.Controls.Add(this.BT_DeleteContact);
            this.Controls.Add(this.panel_Right);
            this.Controls.Add(this.panelLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlternanceRépertoire";
            this.panelLeft.ResumeLayout(false);
            this.Group_Search.ResumeLayout(false);
            this.Group_Search.PerformLayout();
            this.group_ContactList.ResumeLayout(false);
            this.panel_Right.ResumeLayout(false);
            this.panel_Right.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.GroupBox group_ContactList;
        private System.Windows.Forms.GroupBox Group_Search;
        private System.Windows.Forms.Button BT_AddContact;
        private System.Windows.Forms.ListBox LB_Contacts;
        private System.Windows.Forms.ComboBox CB_Groups;
        private System.Windows.Forms.TextBox TB_Search;
        private System.Windows.Forms.Panel panel_Right;
        private System.Windows.Forms.Label LB_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LB_Tel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LB_Email;
        private System.Windows.Forms.Label LB_City;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BT_DeleteContact;
        private System.Windows.Forms.Label LB_Group;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

