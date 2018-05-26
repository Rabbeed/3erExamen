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
    public partial class FilmGenres : Form
    {
        public FilmGenres()
        {
            InitializeComponent();
        }

        private void filmGenresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (this.genreTextBox.Text == "" || this.genreIDTextBox.Text == "")
            {
                MessageBox.Show("Verifica los campos!");
            }
            else
            {
                this.Validate();
                this.filmGenresBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bd);
                MessageBox.Show("Guardado");
                this.genreIDTextBox.Enabled = false;
                this.genreTextBox.Enabled = false;
                this.button1.Enabled = false;
                filmGenresBindingNavigatorSaveItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = true;
                bindingNavigatorAddNewItem.Enabled = true;
            }
        }
       

        private void FilmGenres_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd.FilmGenres' Puede moverla o quitarla según sea necesario.
            this.filmGenresTableAdapter.Fill(this.bd.FilmGenres);
            this.genreIDTextBox.Enabled = false;
            this.genreTextBox.Enabled = false;
            this.button1.Enabled = false;
            filmGenresBindingNavigatorSaveItem.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.genreIDTextBox.Enabled = true;
            this.genreTextBox.Enabled = true;
            filmGenresBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = false;
            bindingNavigatorAddNewItem.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.genreIDTextBox.Enabled = true;
            this.genreTextBox.Enabled = true;
            filmGenresBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = false;
            bindingNavigatorAddNewItem.Enabled = false;
        }

        private void filmGenresDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.button1.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.Validate();
            this.filmGenresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd);
        }
    }
}
