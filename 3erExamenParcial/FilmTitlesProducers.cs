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
    public partial class FilmTitlesProducers : Form
    {
        public FilmTitlesProducers()
        {
            InitializeComponent();
        }

        private void filmTitlesProducerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
          
            this.Validate();
            this.filmTitlesProducerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd);
            filmTitlesProducerBindingNavigatorSaveItem.Enabled = false;
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = false;
        }

        private void FilmTitlesProducers_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd.Producers' Puede moverla o quitarla según sea necesario.
            this.producersTableAdapter.Fill(this.bd.Producers);
            // TODO: esta línea de código carga datos en la tabla 'bd.FilmTitles' Puede moverla o quitarla según sea necesario.
            this.filmTitlesTableAdapter.Fill(this.bd.FilmTitles);
            // TODO: esta línea de código carga datos en la tabla 'bd.FilmTitlesProducer' Puede moverla o quitarla según sea necesario.
            this.filmTitlesProducerTableAdapter.Fill(this.bd.FilmTitlesProducer);
            this.producerIDComboBox.Enabled = false;
            this.filmTitleIDComboBox.Enabled = false;
            filmTitlesProducerBindingNavigatorSaveItem.Enabled = false;
            this.button1.Enabled = false;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
           
            this.filmTitlesProducerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = false;
            this.producerIDComboBox.Enabled = true;
            this.filmTitleIDComboBox.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = false;
            filmTitlesProducerBindingNavigatorSaveItem.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = false;
            this.producerIDComboBox.Enabled = true;
            this.filmTitleIDComboBox.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = false;
            filmTitlesProducerBindingNavigatorSaveItem.Enabled = true;
        }

        private void filmTitlesProducerDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.button1.Enabled = true;
        }
    }
}
