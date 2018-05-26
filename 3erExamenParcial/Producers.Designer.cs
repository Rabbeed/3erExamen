namespace _3erExamenParcial
{
    partial class Producers
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
            System.Windows.Forms.Label producerIDLabel;
            System.Windows.Forms.Label producerNameLabel;
            System.Windows.Forms.Label contactEmailAddressLabel;
            System.Windows.Forms.Label websiteLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Producers));
            this.bd = new _3erExamenParcial.bd();
            this.producersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.producersTableAdapter = new _3erExamenParcial.bdTableAdapters.ProducersTableAdapter();
            this.tableAdapterManager = new _3erExamenParcial.bdTableAdapters.TableAdapterManager();
            this.producersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.producersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.producerIDTextBox = new System.Windows.Forms.TextBox();
            this.producerNameTextBox = new System.Windows.Forms.TextBox();
            this.contactEmailAddressTextBox = new System.Windows.Forms.TextBox();
            this.websiteTextBox = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producersDataGridView = new System.Windows.Forms.DataGridView();
            producerIDLabel = new System.Windows.Forms.Label();
            producerNameLabel = new System.Windows.Forms.Label();
            contactEmailAddressLabel = new System.Windows.Forms.Label();
            websiteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingNavigator)).BeginInit();
            this.producersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // producerIDLabel
            // 
            producerIDLabel.AutoSize = true;
            producerIDLabel.Location = new System.Drawing.Point(33, 49);
            producerIDLabel.Name = "producerIDLabel";
            producerIDLabel.Size = new System.Drawing.Size(67, 13);
            producerIDLabel.TabIndex = 4;
            producerIDLabel.Text = "Producer ID:";
            // 
            // producerNameLabel
            // 
            producerNameLabel.AutoSize = true;
            producerNameLabel.Location = new System.Drawing.Point(33, 75);
            producerNameLabel.Name = "producerNameLabel";
            producerNameLabel.Size = new System.Drawing.Size(84, 13);
            producerNameLabel.TabIndex = 6;
            producerNameLabel.Text = "Producer Name:";
            // 
            // contactEmailAddressLabel
            // 
            contactEmailAddressLabel.AutoSize = true;
            contactEmailAddressLabel.Location = new System.Drawing.Point(33, 101);
            contactEmailAddressLabel.Name = "contactEmailAddressLabel";
            contactEmailAddressLabel.Size = new System.Drawing.Size(116, 13);
            contactEmailAddressLabel.TabIndex = 8;
            contactEmailAddressLabel.Text = "Contact Email Address:";
            // 
            // websiteLabel
            // 
            websiteLabel.AutoSize = true;
            websiteLabel.Location = new System.Drawing.Point(33, 127);
            websiteLabel.Name = "websiteLabel";
            websiteLabel.Size = new System.Drawing.Size(49, 13);
            websiteLabel.TabIndex = 10;
            websiteLabel.Text = "Website:";
            // 
            // bd
            // 
            this.bd.DataSetName = "bd";
            this.bd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // producersBindingSource
            // 
            this.producersBindingSource.DataMember = "Producers";
            this.producersBindingSource.DataSource = this.bd;
            // 
            // producersTableAdapter
            // 
            this.producersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilmActorRoleTableAdapter = null;
            this.tableAdapterManager.FilmCertificateTableAdapter = null;
            this.tableAdapterManager.FilmGenresTableAdapter = null;
            this.tableAdapterManager.FilmTitlesProducerTableAdapter = null;
            this.tableAdapterManager.FilmTitlesTableAdapter = null;
            this.tableAdapterManager.ProducersTableAdapter = this.producersTableAdapter;
            this.tableAdapterManager.RoleTypesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _3erExamenParcial.bdTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // producersBindingNavigator
            // 
            this.producersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.producersBindingNavigator.BindingSource = this.producersBindingSource;
            this.producersBindingNavigator.CountItem = null;
            this.producersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.producersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.producersBindingNavigatorSaveItem});
            this.producersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.producersBindingNavigator.MoveFirstItem = null;
            this.producersBindingNavigator.MoveLastItem = null;
            this.producersBindingNavigator.MoveNextItem = null;
            this.producersBindingNavigator.MovePreviousItem = null;
            this.producersBindingNavigator.Name = "producersBindingNavigator";
            this.producersBindingNavigator.PositionItem = null;
            this.producersBindingNavigator.Size = new System.Drawing.Size(477, 25);
            this.producersBindingNavigator.TabIndex = 0;
            this.producersBindingNavigator.Text = "bindingNavigator1";
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
            // producersBindingNavigatorSaveItem
            // 
            this.producersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.producersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("producersBindingNavigatorSaveItem.Image")));
            this.producersBindingNavigatorSaveItem.Name = "producersBindingNavigatorSaveItem";
            this.producersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.producersBindingNavigatorSaveItem.Text = "Guardar datos";
            this.producersBindingNavigatorSaveItem.Click += new System.EventHandler(this.producersBindingNavigatorSaveItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(387, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // producerIDTextBox
            // 
            this.producerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.producersBindingSource, "ProducerID", true));
            this.producerIDTextBox.Location = new System.Drawing.Point(155, 46);
            this.producerIDTextBox.Name = "producerIDTextBox";
            this.producerIDTextBox.Size = new System.Drawing.Size(287, 20);
            this.producerIDTextBox.TabIndex = 5;
            // 
            // producerNameTextBox
            // 
            this.producerNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.producersBindingSource, "ProducerName", true));
            this.producerNameTextBox.Location = new System.Drawing.Point(155, 72);
            this.producerNameTextBox.Name = "producerNameTextBox";
            this.producerNameTextBox.Size = new System.Drawing.Size(287, 20);
            this.producerNameTextBox.TabIndex = 7;
            // 
            // contactEmailAddressTextBox
            // 
            this.contactEmailAddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.producersBindingSource, "ContactEmailAddress", true));
            this.contactEmailAddressTextBox.Location = new System.Drawing.Point(155, 98);
            this.contactEmailAddressTextBox.Name = "contactEmailAddressTextBox";
            this.contactEmailAddressTextBox.Size = new System.Drawing.Size(287, 20);
            this.contactEmailAddressTextBox.TabIndex = 9;
            // 
            // websiteTextBox
            // 
            this.websiteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.producersBindingSource, "Website", true));
            this.websiteTextBox.Location = new System.Drawing.Point(155, 124);
            this.websiteTextBox.Name = "websiteTextBox";
            this.websiteTextBox.Size = new System.Drawing.Size(287, 20);
            this.websiteTextBox.TabIndex = 11;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Website";
            this.dataGridViewTextBoxColumn4.HeaderText = "Website";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ContactEmailAddress";
            this.dataGridViewTextBoxColumn3.HeaderText = "ContactEmailAddress";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProducerName";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProducerName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProducerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProducerID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // producersDataGridView
            // 
            this.producersDataGridView.AllowUserToAddRows = false;
            this.producersDataGridView.AllowUserToDeleteRows = false;
            this.producersDataGridView.AutoGenerateColumns = false;
            this.producersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.producersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.producersDataGridView.DataSource = this.producersBindingSource;
            this.producersDataGridView.Location = new System.Drawing.Point(12, 180);
            this.producersDataGridView.Name = "producersDataGridView";
            this.producersDataGridView.ReadOnly = true;
            this.producersDataGridView.Size = new System.Drawing.Size(450, 220);
            this.producersDataGridView.TabIndex = 1;
            this.producersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.producersDataGridView_CellContentClick);
            // 
            // Producers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 444);
            this.Controls.Add(producerIDLabel);
            this.Controls.Add(this.producerIDTextBox);
            this.Controls.Add(producerNameLabel);
            this.Controls.Add(this.producerNameTextBox);
            this.Controls.Add(contactEmailAddressLabel);
            this.Controls.Add(this.contactEmailAddressTextBox);
            this.Controls.Add(websiteLabel);
            this.Controls.Add(this.websiteTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.producersDataGridView);
            this.Controls.Add(this.producersBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Producers";
            this.Text = "Producers";
            this.Load += new System.EventHandler(this.Producers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingNavigator)).EndInit();
            this.producersBindingNavigator.ResumeLayout(false);
            this.producersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.producersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bd bd;
        private System.Windows.Forms.BindingSource producersBindingSource;
        private bdTableAdapters.ProducersTableAdapter producersTableAdapter;
        private bdTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator producersBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton producersBindingNavigatorSaveItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox producerIDTextBox;
        private System.Windows.Forms.TextBox producerNameTextBox;
        private System.Windows.Forms.TextBox contactEmailAddressTextBox;
        private System.Windows.Forms.TextBox websiteTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView producersDataGridView;
    }
}