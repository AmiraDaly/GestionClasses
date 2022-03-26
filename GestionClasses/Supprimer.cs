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
    public partial class Supprimer : Form
    {
        public Supprimer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count == 1 ) 
            {
                int selectIndice = listView1.SelectedIndices[0];
                listView1.Items[selectIndice].Remove();
        }
            else 
            {
                MessageBox.Show("Selectionner une ligne");
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem();
            item.Text = comboBox1.Text;
            listView1.Items.Add(item);

            
            
            
           
            
        }
    }
}
