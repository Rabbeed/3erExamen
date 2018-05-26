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
    public partial class FilmActorRole : Form
    {
        public FilmActorRole()
        {
            InitializeComponent();
        }

        private void filmActorRoleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (this.characterNameTextBox.Text == "" || this.characterDescriptionTextBox.Text == "")
            {
                MessageBox.Show("Verifica los campos!");
            }
            else
            {
                this.Validate();
                this.filmActorRoleBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bd);
                MessageBox.Show("Guardado");
                this.button1.Enabled = false;
                this.filmTitleIDComboBox.Enabled = false;
                this.actorIDComboBox.Enabled = false;
                this.roleTypeComboBox.Enabled = false;
                this.characterNameTextBox.Enabled = false;
                this.characterDescriptionTextBox.Enabled = false;
                this.filmActorRoleBindingNavigatorSaveItem.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = true;
                bindingNavigatorAddNewItem.Enabled = true;
            }
           

        }

        private void FilmActorRole_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd.RoleTypes' Puede moverla o quitarla según sea necesario.
            this.roleTypesTableAdapter.Fill(this.bd.RoleTypes);
            // TODO: esta línea de código carga datos en la tabla 'bd.Actors' Puede moverla o quitarla según sea necesario.
            this.actorsTableAdapter.Fill(this.bd.Actors);
            // TODO: esta línea de código carga datos en la tabla 'bd.FilmTitles' Puede moverla o quitarla según sea necesario.
            this.filmTitlesTableAdapter.Fill(this.bd.FilmTitles);
            // TODO: esta línea de código carga datos en la tabla 'bd.FilmActorRole' Puede moverla o quitarla según sea necesario.
            this.filmActorRoleTableAdapter.Fill(this.bd.FilmActorRole);
            this.button1.Enabled = false;
            this.filmTitleIDComboBox.Enabled = false;
            this.actorIDComboBox.Enabled = false;
            this.roleTypeComboBox.Enabled = false;
            this.characterNameTextBox.Enabled = false;
            this.characterDescriptionTextBox.Enabled = false;
            this.filmActorRoleBindingNavigatorSaveItem.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.filmTitleIDComboBox.Enabled = true;
            this.actorIDComboBox.Enabled = true;
            this.roleTypeComboBox.Enabled = true;
            this.characterNameTextBox.Enabled = true;
            this.characterDescriptionTextBox.Enabled = true;
            filmActorRoleBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = false;
            bindingNavigatorAddNewItem.Enabled = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            bindingNavigatorAddNewItem.Enabled = false;
            this.filmTitleIDComboBox.Enabled = true;
            this.actorIDComboBox.Enabled = true;
            this.roleTypeComboBox.Enabled = true;
            this.characterNameTextBox.Enabled = true;
            this.characterDescriptionTextBox.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = false;
            filmActorRoleBindingNavigatorSaveItem.Enabled = true;
        }

        private void filmActorRoleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void filmActorRoleDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.button1.Enabled = true;
         
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmActorRoleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd);
            this.button1.Enabled = false;
        }
    }
}