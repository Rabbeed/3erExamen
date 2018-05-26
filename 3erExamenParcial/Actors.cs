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
    public partial class Actors : Form
    {
        public Actors()
        {
            InitializeComponent();
        }

        private void actorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (this.actorFullNameTextBox.Text == "" || this.actorIDTextBox.Text == "" || this.actorNotesTextBox.Text == "") {
                MessageBox.Show("Verifica los campos");
            }
            else
            {
                this.Validate();
                this.actorsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bd);
                this.actorFullNameTextBox.Enabled = false;
                this.actorIDTextBox.Enabled = false;
                this.actorNotesTextBox.Enabled = false;
                MessageBox.Show("Guardado con exito :)");
                this.button1.Enabled = false;
                bindingNavigatorAddNewItem.Enabled = true;
                bindingNavigatorDeleteItem.Enabled = true;
                actorsBindingNavigatorSaveItem.Enabled = false;
            }


        }

        private void Actors_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd.Actors' Puede moverla o quitarla según sea necesario.
            this.actorsTableAdapter.Fill(this.bd.Actors);
            this.actorFullNameTextBox.Enabled = false;
            this.actorIDTextBox.Enabled = false;
            this.actorNotesTextBox.Enabled = false;
            this.button1.Enabled = false;
            actorsBindingNavigatorSaveItem.Enabled = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.actorFullNameTextBox.Enabled = true;
            this.actorIDTextBox.Enabled = true;
            this.actorNotesTextBox.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            actorsBindingNavigatorSaveItem.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.Validate();
            this.actorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.actorFullNameTextBox.Enabled = true;
            this.actorIDTextBox.Enabled = true;
            this.actorNotesTextBox.Enabled = true;
            actorsBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = false;
        }

        private void actorsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void actorsDataGridView_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
