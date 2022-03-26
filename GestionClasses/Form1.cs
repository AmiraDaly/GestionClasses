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
    public partial class GestionClasses : Form
    {
        public GestionClasses()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ajouter Ajout = new Ajouter();
            Ajout.Show();
        }

        private void supprimerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supprimer Suprim = new Supprimer();
            Suprim.Show();
        }

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modifier Modif = new Modifier();
            Modif.Show();
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
