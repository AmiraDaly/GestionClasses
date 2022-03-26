using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GestionClasses
{
    public partial class Ajouter : Form
    {
        public Ajouter()
        {
            InitializeComponent();
        }

        private void Ajouter_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            //    (String.IsNullOrEmpty(txtNom.Text)|| String.IsNullOrEmpty(txtNumInscription.Text))
            //return ;
             if (txtNumInscription.Text == "" || txtNom.Text =="" || txtPrenom.Text =="" || txtClasse.Text =="" )
             {
                 MessageBox.Show("Attention !! champs vide");
                 clearData();
                     return;
             }
            ListViewItem item = new ListViewItem(txtNumInscription.Text);
            item.SubItems.Add(txtNumInscription.Text);
            item.SubItems.Add(txtNom.Text);
            item.SubItems.Add(txtPrenom.Text);
            item.SubItems.Add(txtClasse.Text);
            listView.Items.Add(item);
            txtNumInscription.Focus();
            clearData();


        }
        private void clearData(){
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtClasse.Text = "";
            txtNumInscription.Text = "";
        }
        private void btn_retour_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionClasses form = new GestionClasses();
            form.Show();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
