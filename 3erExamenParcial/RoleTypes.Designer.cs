namespace _3erExamenParcial
{
    partial class RoleTypes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleTypes));
            System.Windows.Forms.Label roleTypeIDLabel;
            System.Windows.Forms.Label roleTypeLabel;
            this.bd = new _3erExamenParcial.bd();
            this.roleTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roleTypesTableAdapter = new _3erExamenParcial.bdTableAdapters.RoleTypesTableAdapter();
            this.tableAdapterManager = new _3erExamenParcial.bdTableAdapters.TableAdapterManager();
            this.roleTypesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.roleTypesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.roleTypesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleTypeIDTextBox = new System.Windows.Forms.TextBox();
            this.roleTypeTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            roleTypeIDLabel = new System.Windows.Forms.Label();
            roleTypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleTypesBindingNavigator)).BeginInit();
            this.roleTypesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleTypesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bd
            // 
            this.bd.DataSetName = "bd";
            this.bd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roleTypesBindingSource
            // 
            this.roleTypesBindingSource.DataMember = "RoleTypes";
            this.roleTypesBindingSource.DataSource = this.bd;
            // 
            // roleTypesTableAdapter
            // 
            this.roleTypesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilmCertificateTableAdapter = null;
            this.tableAdapterManager.FilmGenresTableAdapter = null;
            this.tableAdapterManager.FilmActorRoleTableAdapter = null;
            this.tableAdapterManager.FilmTitlesProducerTableAdapter = null;
            this.tableAdapterManager.FilmTitlesTableAdapter = null;
            this.tableAdapterManager.ProducersTableAdapter = null;
            this.tableAdapterManager.RoleTypesTableAdapter = this.roleTypesTableAdapter;
            this.tableAdapterManager.UpdateOrder = _3erExamenParcial.bdTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // roleTypesBindingNavigator
            // 
            this.roleTypesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.roleTypesBindingNavigator.BindingSource = this.roleTypesBindingSource;
            this.roleTypesBindingNavigator.CountItem = null;
            this.roleTypesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.roleTypesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.roleTypesBindingNavigatorSaveItem});
            this.roleTypesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.roleTypesBindingNavigator.MoveFirstItem = null;
            this.roleTypesBindingNavigator.MoveLastItem = null;
            this.roleTypesBindingNavigator.MoveNextItem = null;
            this.roleTypesBindingNavigator.MovePreviousItem = null;
            this.roleTypesBindingNavigator.Name = "roleTypesBindingNavigator";
            this.roleTypesBindingNavigator.PositionItem = null;
            this.roleTypesBindingNavigator.Size = new System.Drawing.Size(277, 25);
            this.roleTypesBindingNavigator.TabIndex = 0;
            this.roleTypesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Agregar nuevo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Eliminar";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // roleTypesBindingNavigatorSaveItem
            // 
            this.roleTypesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.roleTypesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("roleTypesBindingNavigatorSaveItem.Image")));
            this.roleTypesBindingNavigatorSaveItem.Name = "roleTypesBindingNavigatorSaveItem";
            this.roleTypesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.roleTypesBindingNavigatorSaveItem.Text = "Guardar datos";
            this.roleTypesBindingNavigatorSaveItem.Click += new System.EventHandler(this.roleTypesBindingNavigatorSaveItem_Click);
            // 
            // roleTypesDataGridView
            // 
            this.roleTypesDataGridView.AllowUserToAddRows = false;
            this.roleTypesDataGridView.AllowUserToDeleteRows = false;
            this.roleTypesDataGridView.AllowUserToOrderColumns = true;
            this.roleTypesDataGridView.AutoGenerateColumns = false;
            this.roleTypesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roleTypesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.roleTypesDataGridView.DataSource = this.roleTypesBindingSource;
            this.roleTypesDataGridView.Location = new System.Drawing.Point(12, 104);
            this.roleTypesDataGridView.Name = "roleTypesDataGridView";
            this.roleTypesDataGridView.Size = new System.Drawing.Size(253, 105);
            this.roleTypesDataGridView.TabIndex = 1;
            this.roleTypesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roleTypesDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "RoleTypeID";
            this.dataGridViewTextBoxColumn1.HeaderText = "RoleTypeID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "RoleType";
            this.dataGridViewTextBoxColumn2.HeaderText = "RoleType";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // roleTypeIDLabel
            // 
            roleTypeIDLabel.AutoSize = true;
            roleTypeIDLabel.Location = new System.Drawing.Point(18, 44);
            roleTypeIDLabel.Name = "roleTypeIDLabel";
            roleTypeIDLabel.Size = new System.Drawing.Size(73, 13);
            roleTypeIDLabel.TabIndex = 2;
            roleTypeIDLabel.Text = "Role Type ID:";
            // 
            // roleTypeIDTextBox
            // 
            this.roleTypeIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roleTypesBindingSource, "RoleTypeID", true));
            this.roleTypeIDTextBox.Location = new System.Drawing.Point(97, 41);
            this.roleTypeIDTextBox.Name = "roleTypeIDTextBox";
            this.roleTypeIDTextBox.Size = new System.Drawing.Size(146, 20);
            this.roleTypeIDTextBox.TabIndex = 3;
            // 
            // roleTypeLabel
            // 
            roleTypeLabel.AutoSize = true;
            roleTypeLabel.Location = new System.Drawing.Point(18, 70);
            roleTypeLabel.Name = "roleTypeLabel";
            roleTypeLabel.Size = new System.Drawing.Size(59, 13);
            roleTypeLabel.TabIndex = 4;
            roleTypeLabel.Text = "Role Type:";
            // 
            // roleTypeTextBox
            // 
            this.roleTypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roleTypesBindingSource, "RoleType", true));
            this.roleTypeTextBox.Location = new System.Drawing.Point(97, 67);
            this.roleTypeTextBox.Name = "roleTypeTextBox";
            this.roleTypeTextBox.Size = new System.Drawing.Size(146, 20);
            this.roleTypeTextBox.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RoleTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 258);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(roleTypeIDLabel);
            this.Controls.Add(this.roleTypeIDTextBox);
            this.Controls.Add(roleTypeLabel);
            this.Controls.Add(this.roleTypeTextBox);
            this.Controls.Add(this.roleTypesDataGridView);
            this.Controls.Add(this.roleTypesBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "RoleTypes";
            this.Text = "RoleTypes";
            this.Load += new System.EventHandler(this.RoleTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleTypesBindingNavigator)).EndInit();
            this.roleTypesBindingNavigator.ResumeLayout(false);
            this.roleTypesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roleTypesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bd bd;
        private System.Windows.Forms.BindingSource roleTypesBindingSource;
        private bdTableAdapters.RoleTypesTableAdapter roleTypesTableAdapter;
        private bdTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator roleTypesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton roleTypesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView roleTypesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox roleTypeIDTextBox;
        private System.Windows.Forms.TextBox roleTypeTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}