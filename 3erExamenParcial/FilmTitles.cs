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
    public partial class FilmTitles : Form
    {
        public FilmTitles()
        {
            InitializeComponent();
        }

        private void filmTitlesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (this.filmTitleIDTextBox.Text == "" ||
            this.filmTitleTextBox.Text == "" ||
            this.filmStoryTextBox.Text == "" ||
            this.filmDurationTextBox.Text == "" ||
            this.filmAditionalInfoTextBox.Text == "")
            {
                MessageBox.Show("Verifica los campos!");
            }
            else
            {
                this.Validate();
                this.filmTitlesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bd);
                this.filmTitlesTableAdapter.Fill(this.bd.FilmTitles);
                this.filmTitleIDTextBox.Enabled = false;
                this.filmTitleTextBox.Enabled = false;
                this.filmStoryTextBox.Enabled = false;
                this.filmReleaseDateDateTimePicker.Enabled = false;
                this.filmDurationTextBox.Enabled = false;
                this.filmGenreIDComboBox.Enabled = false;
                this.filmCertificateIDComboBox.Enabled = false;
                this.filmAditionalInfoTextBox.Enabled = false;
                this.editar.Enabled = false;
                filmTitlesBindingNavigatorSaveItem.Enabled = false;
                bindingNavigatorAddNewItem.Enabled = true;
                bindingNavigatorDeleteItem.Enabled = false;
            }
          

        }

        private void FilmTitles_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd.FilmCertificate' Puede moverla o quitarla según sea necesario.
            this.filmCertificateTableAdapter.Fill(this.bd.FilmCertificate);
            // TODO: esta línea de código carga datos en la tabla 'bd.FilmGenres' Puede moverla o quitarla según sea necesario.
            this.filmGenresTableAdapter.Fill(this.bd.FilmGenres);
            // TODO: esta línea de código carga datos en la tabla 'bd.FilmTitlesProducer' Puede moverla o quitarla según sea necesario.
            this.filmTitlesProducerTableAdapter.Fill(this.bd.FilmTitlesProducer);
            // TODO: esta línea de código carga datos en la tabla 'bd.FilmTitles' Puede moverla o quitarla según sea necesario.
            this.filmTitlesTableAdapter.Fill(this.bd.FilmTitles);
            this.filmTitleIDTextBox.Enabled = false;
            this.filmTitleTextBox.Enabled = false;
            this.filmStoryTextBox.Enabled = false;
            this.filmReleaseDateDateTimePicker.Enabled = false;
            this.filmDurationTextBox.Enabled = false;
            this.filmGenreIDComboBox.Enabled = false;
            this.filmCertificateIDComboBox.Enabled = false;
            this.filmAditionalInfoTextBox.Enabled = false;
            this.editar.Enabled = false;
            filmTitlesBindingNavigatorSaveItem.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Actors frm = new Actors();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RoleTypes frm = new RoleTypes();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FilmGenres frm = new FilmGenres();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FilmCertificate frm = new FilmCertificate();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Producers frm = new Producers();
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FilmActorRole rs = new FilmActorRole();
            rs.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FilmTitlesProducers frm = new FilmTitlesProducers();
            frm.Show();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            filmTitlesBindingNavigatorSaveItem.Enabled = true;
            this.filmTitleIDTextBox.Enabled = true;
            this.filmTitleTextBox.Enabled = true;
            this.filmStoryTextBox.Enabled = true;
            this.filmReleaseDateDateTimePicker.Enabled = true;
            this.filmDurationTextBox.Enabled = true;
            this.filmGenreIDComboBox.Enabled = true;
            this.filmCertificateIDComboBox.Enabled = true;
            this.filmAditionalInfoTextBox.Enabled = true;
        }

        private void filmTitlesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.editar.Enabled = true;
        }

        private void editar_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            filmTitlesBindingNavigatorSaveItem.Enabled = true;
            this.filmTitleIDTextBox.Enabled = true;
            this.filmTitleTextBox.Enabled = true;
            this.filmStoryTextBox.Enabled = true;
            this.filmReleaseDateDateTimePicker.Enabled = true;
            this.filmDurationTextBox.Enabled = true;
            this.filmGenreIDComboBox.Enabled = true;
            this.filmCertificateIDComboBox.Enabled = true;
            this.filmAditionalInfoTextBox.Enabled = true;
        }
    }
}
