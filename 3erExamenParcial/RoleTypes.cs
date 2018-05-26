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
    public partial class RoleTypes : Form
    {
        public RoleTypes()
        {
            InitializeComponent();
        }

        private void roleTypesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (this.roleTypeTextBox.Text == "" || this.roleTypeIDTextBox.Text == "") {
                MessageBox.Show("Verifica los campos");
            }
            else { 
            this.Validate();
            this.roleTypesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bd);
            this.roleTypeIDTextBox.Enabled = false;
            this.roleTypeTextBox.Enabled = false;
            MessageBox.Show("Guardado con exito :)");
            this.button1.Enabled = false;
            bindingNavigatorAddNewItem.Enabled = true;
            bindingNavigatorDeleteItem.Enabled = true;
            this.roleTypesBindingNavigatorSaveItem.Enabled = false;
            }

        }

        private void RoleTypes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bd.RoleTypes' Puede moverla o quitarla según sea necesario.
            this.roleTypesTableAdapter.Fill(this.bd.RoleTypes);
            this.roleTypeIDTextBox.Enabled = false;
            this.roleTypeTextBox.Enabled = false;
            this.button1.Enabled = false;
            this.roleTypesBindingNavigatorSaveItem.Enabled = false;
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.roleTypeIDTextBox.Enabled = true;
            this.roleTypeTextBox.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = false;
            bindingNavigatorDeleteItem.Enabled = false;
            roleTypesBindingNavigatorSaveItem.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
        }

        private void roleTypesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.roleTypeIDTextBox.Enabled = true;
            this.roleTypeTextBox.Enabled = true;
            this.button1.Enabled = true;
            this.roleTypesBindingNavigatorSaveItem.Enabled = true;
            bindingNavigatorAddNewItem.Enabled = false;
        }
    }
}
