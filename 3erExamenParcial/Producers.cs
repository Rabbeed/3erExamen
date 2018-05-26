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
    public partial class Producers : Form
    {
        public Producers()
        {
            InitializeComponent();
        }

        private void producersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (this.producerIDTextBox.Text == "" ||
                this.producerNameTextBox.Text == "" ||
                this.contactEmailAddressTextBox.Text == "" ||
                this.websiteTextBox.Text == "")
            {
                MessageBox.Show("Verifica los campos!");
            }
            else
            {
                this.Validate();
                this.producersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bd);
                this.producerIDTextBox.Enabled = false;
                this.producerNameTextBox.Enabled = false;
                this.contactEmailAddressTextBox.Enabled = false;
                this.websiteTextBox.Enabled = false;
                this.button1.Enabled = false;
                this.producersBindingNavigatorSaveItem.Enabled = false;
                bindingNavigatorAddNewItem.Enabled = true;
                bindingNavigatorDeleteItem.Enabled = true;
                MessageBox.Show("Guardado");
            }


        }

        private void Producers_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd.Producers' Puede moverla o quitarla según sea necesario.
            this.producersTableAdapter.Fill(this.bd.Producers);
            this.producerIDTextBox.Enabled = false;
            this.producerNameTextBox.Enabled = false;
            this.contactEmailAddressTextBox.Enabled = false;
            this.websiteTextBox.Enabled = false;
            this.button1.Enabled = false;
            this.producersBindingNavigatorSaveItem.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.producerIDTextBox.Enabled = true;
            this.producerNameTextBox.Enabled = true;
            this.contactEmailAddressTextBox.Enabled = true;
            this.websiteTextBox.Enabled = true;
            this.button1.Enabled = true;
            this.producersBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = false;
            bindingNavigatorAddNewItem.Enabled = false;

        }

        private void producersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.producerIDTextBox.Enabled = true;
            this.producerNameTextBox.Enabled = true;
            this.contactEmailAddressTextBox.Enabled = true;
            this.websiteTextBox.Enabled = true;
            this.button1.Enabled = true;
            this.producersBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = false;
            bindingNavigatorAddNewItem.Enabled = false;
        }
    }
}
