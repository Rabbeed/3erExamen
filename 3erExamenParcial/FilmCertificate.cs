using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3erExamenParcial
{
    public partial class FilmCertificate : Form
    {
        public FilmCertificate()
        {
            InitializeComponent();
        }

        private void filmCertificateBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (this.certificateTextBox.Text == "" || this.certificateIDTextBox.Text == "")
            {
                MessageBox.Show("Verfica los campos!");
            }
            else
            {
                this.Validate();
                this.filmCertificateBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bd);
                this.certificateIDTextBox.Enabled = false;
                this.certificateTextBox.Enabled = false;
                this.button1.Enabled = false;
                filmCertificateBindingNavigatorSaveItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = true;
                MessageBox.Show("Guardado");
                bindingNavigatorAddNewItem.Enabled = true;
            }


        }

        private void FilmCertificate_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd.FilmCertificate' Puede moverla o quitarla según sea necesario.
            this.filmCertificateTableAdapter.Fill(this.bd.FilmCertificate);
      
            this.certificateIDTextBox.Enabled = false;
            this.certificateTextBox.Enabled = false;
            this.button1.Enabled = false;
            filmCertificateBindingNavigatorSaveItem.Enabled = false;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = false;
            this.certificateIDTextBox.Enabled = true;
            this.certificateTextBox.Enabled = true;
            filmCertificateBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = false;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.Validate();
            this.filmCertificateBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd);
        }

        private void filmCertificateDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = false;
            this.certificateIDTextBox.Enabled = true;
            this.certificateTextBox.Enabled = true;
            filmCertificateBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = false;
        }
    }
}
