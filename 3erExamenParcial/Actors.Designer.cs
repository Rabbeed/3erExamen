namespace _3erExamenParcial
{
    partial class Actors
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label actorIDLabel;
            System.Windows.Forms.Label actorFullNameLabel;
            System.Windows.Forms.Label actorNotesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Actors));
            this.bd = new _3erExamenParcial.bd();
            this.actorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actorsTableAdapter = new _3erExamenParcial.bdTableAdapters.ActorsTableAdapter();
            this.tableAdapterManager = new _3erExamenParcial.bdTableAdapters.TableAdapterManager();
            this.actorsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.actorsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.actorsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorIDTextBox = new System.Windows.Forms.TextBox();
            this.actorFullNameTextBox = new System.Windows.Forms.TextBox();
            this.actorNotesTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            actorIDLabel = new System.Windows.Forms.Label();
            actorFullNameLabel = new System.Windows.Forms.Label();
            actorNotesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingNavigator)).BeginInit();
            this.actorsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actorsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // actorIDLabel
            // 
            actorIDLabel.AutoSize = true;
            actorIDLabel.Location = new System.Drawing.Point(12, 43);
            actorIDLabel.Name = "actorIDLabel";
            actorIDLabel.Size = new System.Drawing.Size(49, 13);
            actorIDLabel.TabIndex = 2;
            actorIDLabel.Text = "Actor ID:";
            // 
            // actorFullNameLabel
            // 
            actorFullNameLabel.AutoSize = true;
            actorFullNameLabel.Location = new System.Drawing.Point(12, 69);
            actorFullNameLabel.Name = "actorFullNameLabel";
            actorFullNameLabel.Size = new System.Drawing.Size(85, 13);
            actorFullNameLabel.TabIndex = 4;
            actorFullNameLabel.Text = "Actor Full Name:";
            // 
            // actorNotesLabel
            // 
            actorNotesLabel.AutoSize = true;
            actorNotesLabel.Location = new System.Drawing.Point(12, 95);
            actorNotesLabel.Name = "actorNotesLabel";
            actorNotesLabel.Size = new System.Drawing.Size(66, 13);
            actorNotesLabel.TabIndex = 6;
            actorNotesLabel.Text = "Actor Notes:";
            // 
            // bd
            // 
            this.bd.DataSetName = "bd";
            this.bd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // actorsBindingSource
            // 
            this.actorsBindingSource.DataMember = "Actors";
            this.actorsBindingSource.DataSource = this.bd;
            // 
            // actorsTableAdapter
            // 
            this.actorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActorsTableAdapter = this.actorsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilmCertificateTableAdapter = null;
            this.tableAdapterManager.FilmGenresTableAdapter = null;
            this.tableAdapterManager.FilmActorRoleTableAdapter = null;
            this.tableAdapterManager.FilmTitlesProducerTableAdapter = null;
            this.tableAdapterManager.FilmTitlesTableAdapter = null;
            this.tableAdapterManager.ProducersTableAdapter = null;
            this.tableAdapterManager.RoleTypesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _3erExamenParcial.bdTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // actorsBindingNavigator
            // 
            this.actorsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.actorsBindingNavigator.BindingSource = this.actorsBindingSource;
            this.actorsBindingNavigator.CountItem = null;
            this.actorsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.actorsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.actorsBindingNavigatorSaveItem});
            this.actorsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.actorsBindingNavigator.MoveFirstItem = null;
            this.actorsBindingNavigator.MoveLastItem = null;
            this.actorsBindingNavigator.MoveNextItem = null;
            this.actorsBindingNavigator.MovePreviousItem = null;
            this.actorsBindingNavigator.Name = "actorsBindingNavigator";
            this.actorsBindingNavigator.PositionItem = null;
            this.actorsBindingNavigator.Size = new System.Drawing.Size(378, 25);
            this.actorsBindingNavigator.TabIndex = 0;
            this.actorsBindingNavigator.Text = "bindingNavigator1";
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
            // actorsBindingNavigatorSaveItem
            // 
            this.actorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.actorsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("actorsBindingNavigatorSaveItem.Image")));
            this.actorsBindingNavigatorSaveItem.Name = "actorsBindingNavigatorSaveItem";
            this.actorsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.actorsBindingNavigatorSaveItem.Text = "Guardar datos";
            this.actorsBindingNavigatorSaveItem.Click += new System.EventHandler(this.actorsBindingNavigatorSaveItem_Click);
            // 
            // actorsDataGridView
            // 
            this.actorsDataGridView.AllowUserToAddRows = false;
            this.actorsDataGridView.AllowUserToDeleteRows = false;
            this.actorsDataGridView.AllowUserToOrderColumns = true;
            this.actorsDataGridView.AutoGenerateColumns = false;
            this.actorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actorsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.actorsDataGridView.DataSource = this.actorsBindingSource;
            this.actorsDataGridView.EnableHeadersVisualStyles = false;
            this.actorsDataGridView.Location = new System.Drawing.Point(20, 130);
            this.actorsDataGridView.Name = "actorsDataGridView";
            this.actorsDataGridView.ReadOnly = true;
            this.actorsDataGridView.Size = new System.Drawing.Size(346, 213);
            this.actorsDataGridView.TabIndex = 1;
            this.actorsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.actorsDataGridView_CellClick);
            this.actorsDataGridView.Click += new System.EventHandler(this.actorsDataGridView_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ActorID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ActorID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ActorFullName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ActorFullName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ActorNotes";
            this.dataGridViewTextBoxColumn3.HeaderText = "ActorNotes";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // actorIDTextBox
            // 
            this.actorIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actorsBindingSource, "ActorID", true));
            this.actorIDTextBox.Location = new System.Drawing.Point(103, 40);
            this.actorIDTextBox.Name = "actorIDTextBox";
            this.actorIDTextBox.Size = new System.Drawing.Size(244, 20);
            this.actorIDTextBox.TabIndex = 3;
            // 
            // actorFullNameTextBox
            // 
            this.actorFullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actorsBindingSource, "ActorFullName", true));
            this.actorFullNameTextBox.Location = new System.Drawing.Point(103, 66);
            this.actorFullNameTextBox.Name = "actorFullNameTextBox";
            this.actorFullNameTextBox.Size = new System.Drawing.Size(244, 20);
            this.actorFullNameTextBox.TabIndex = 5;
            // 
            // actorNotesTextBox
            // 
            this.actorNotesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.actorsBindingSource, "ActorNotes", true));
            this.actorNotesTextBox.Location = new System.Drawing.Point(103, 92);
            this.actorNotesTextBox.Name = "actorNotesTextBox";
            this.actorNotesTextBox.Size = new System.Drawing.Size(244, 20);
            this.actorNotesTextBox.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(291, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Actors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 379);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(actorIDLabel);
            this.Controls.Add(this.actorIDTextBox);
            this.Controls.Add(actorFullNameLabel);
            this.Controls.Add(this.actorFullNameTextBox);
            this.Controls.Add(actorNotesLabel);
            this.Controls.Add(this.actorNotesTextBox);
            this.Controls.Add(this.actorsDataGridView);
            this.Controls.Add(this.actorsBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Actors";
            this.Text = "Actors";
            this.Load += new System.EventHandler(this.Actors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingNavigator)).EndInit();
            this.actorsBindingNavigator.ResumeLayout(false);
            this.actorsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actorsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bd bd;
        private System.Windows.Forms.BindingSource actorsBindingSource;
        private bdTableAdapters.ActorsTableAdapter actorsTableAdapter;
        private bdTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator actorsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton actorsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView actorsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.TextBox actorIDTextBox;
        private System.Windows.Forms.TextBox actorFullNameTextBox;
        private System.Windows.Forms.TextBox actorNotesTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

