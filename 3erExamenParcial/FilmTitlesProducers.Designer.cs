namespace _3erExamenParcial
{
    partial class FilmTitlesProducers
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
            System.Windows.Forms.Label filmTitleIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmTitlesProducers));
            this.bd = new _3erExamenParcial.bd();
            this.filmTitlesProducerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTitlesProducerTableAdapter = new _3erExamenParcial.bdTableAdapters.FilmTitlesProducerTableAdapter();
            this.tableAdapterManager = new _3erExamenParcial.bdTableAdapters.TableAdapterManager();
            this.filmTitlesProducerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.filmTitlesProducerBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.filmTitlesProducerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producerIDComboBox = new System.Windows.Forms.ComboBox();
            this.producersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.producersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmTitleIDComboBox = new System.Windows.Forms.ComboBox();
            this.filmTitlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.filmTitlesTableAdapter = new _3erExamenParcial.bdTableAdapters.FilmTitlesTableAdapter();
            this.producersTableAdapter = new _3erExamenParcial.bdTableAdapters.ProducersTableAdapter();
            this.producersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.filmTitlesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            producerIDLabel = new System.Windows.Forms.Label();
            filmTitleIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmTitlesProducerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmTitlesProducerBindingNavigator)).BeginInit();
            this.filmTitlesProducerBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmTitlesProducerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmTitlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmTitlesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // producerIDLabel
            // 
            producerIDLabel.AutoSize = true;
            producerIDLabel.Location = new System.Drawing.Point(31, 33);
            producerIDLabel.Name = "producerIDLabel";
            producerIDLabel.Size = new System.Drawing.Size(67, 13);
            producerIDLabel.TabIndex = 5;
            producerIDLabel.Text = "Producer ID:";
            // 
            // filmTitleIDLabel
            // 
            filmTitleIDLabel.AutoSize = true;
            filmTitleIDLabel.Location = new System.Drawing.Point(31, 60);
            filmTitleIDLabel.Name = "filmTitleIDLabel";
            filmTitleIDLabel.Size = new System.Drawing.Size(65, 13);
            filmTitleIDLabel.TabIndex = 7;
            filmTitleIDLabel.Text = "Film Title ID:";
            // 
            // bd
            // 
            this.bd.DataSetName = "bd";
            this.bd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmTitlesProducerBindingSource
            // 
            this.filmTitlesProducerBindingSource.DataMember = "FilmTitlesProducer";
            this.filmTitlesProducerBindingSource.DataSource = this.bd;
            // 
            // filmTitlesProducerTableAdapter
            // 
            this.filmTitlesProducerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilmActorRoleTableAdapter = null;
            this.tableAdapterManager.FilmCertificateTableAdapter = null;
            this.tableAdapterManager.FilmGenresTableAdapter = null;
            this.tableAdapterManager.FilmTitlesProducerTableAdapter = this.filmTitlesProducerTableAdapter;
            this.tableAdapterManager.FilmTitlesTableAdapter = null;
            this.tableAdapterManager.ProducersTableAdapter = null;
            this.tableAdapterManager.RoleTypesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _3erExamenParcial.bdTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // filmTitlesProducerBindingNavigator
            // 
            this.filmTitlesProducerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.filmTitlesProducerBindingNavigator.BindingSource = this.filmTitlesProducerBindingSource;
            this.filmTitlesProducerBindingNavigator.CountItem = null;
            this.filmTitlesProducerBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.filmTitlesProducerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.filmTitlesProducerBindingNavigatorSaveItem});
            this.filmTitlesProducerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.filmTitlesProducerBindingNavigator.MoveFirstItem = null;
            this.filmTitlesProducerBindingNavigator.MoveLastItem = null;
            this.filmTitlesProducerBindingNavigator.MoveNextItem = null;
            this.filmTitlesProducerBindingNavigator.MovePreviousItem = null;
            this.filmTitlesProducerBindingNavigator.Name = "filmTitlesProducerBindingNavigator";
            this.filmTitlesProducerBindingNavigator.PositionItem = null;
            this.filmTitlesProducerBindingNavigator.Size = new System.Drawing.Size(275, 25);
            this.filmTitlesProducerBindingNavigator.TabIndex = 0;
            this.filmTitlesProducerBindingNavigator.Text = "bindingNavigator1";
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
            // filmTitlesProducerBindingNavigatorSaveItem
            // 
            this.filmTitlesProducerBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.filmTitlesProducerBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("filmTitlesProducerBindingNavigatorSaveItem.Image")));
            this.filmTitlesProducerBindingNavigatorSaveItem.Name = "filmTitlesProducerBindingNavigatorSaveItem";
            this.filmTitlesProducerBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.filmTitlesProducerBindingNavigatorSaveItem.Text = "Guardar datos";
            this.filmTitlesProducerBindingNavigatorSaveItem.Click += new System.EventHandler(this.filmTitlesProducerBindingNavigatorSaveItem_Click);
            // 
            // filmTitlesProducerDataGridView
            // 
            this.filmTitlesProducerDataGridView.AllowUserToAddRows = false;
            this.filmTitlesProducerDataGridView.AllowUserToDeleteRows = false;
            this.filmTitlesProducerDataGridView.AutoGenerateColumns = false;
            this.filmTitlesProducerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmTitlesProducerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.filmTitlesProducerDataGridView.DataSource = this.filmTitlesProducerBindingSource;
            this.filmTitlesProducerDataGridView.Location = new System.Drawing.Point(15, 88);
            this.filmTitlesProducerDataGridView.Name = "filmTitlesProducerDataGridView";
            this.filmTitlesProducerDataGridView.ReadOnly = true;
            this.filmTitlesProducerDataGridView.Size = new System.Drawing.Size(243, 220);
            this.filmTitlesProducerDataGridView.TabIndex = 5;
            this.filmTitlesProducerDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filmTitlesProducerDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProducerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProducerID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FilmTitleID";
            this.dataGridViewTextBoxColumn2.HeaderText = "FilmTitleID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // producerIDComboBox
            // 
            this.producerIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmTitlesProducerBindingSource, "ProducerID", true));
            this.producerIDComboBox.DataSource = this.producersBindingSource2;
            this.producerIDComboBox.DisplayMember = "ProducerID";
            this.producerIDComboBox.FormattingEnabled = true;
            this.producerIDComboBox.Location = new System.Drawing.Point(104, 30);
            this.producerIDComboBox.Name = "producerIDComboBox";
            this.producerIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.producerIDComboBox.TabIndex = 6;
            this.producerIDComboBox.ValueMember = "ProducerID";
            // 
            // producersBindingSource1
            // 
            this.producersBindingSource1.DataMember = "Producers";
            this.producersBindingSource1.DataSource = this.bd;
            // 
            // producersBindingSource
            // 
            this.producersBindingSource.DataMember = "Producers";
            this.producersBindingSource.DataSource = this.bd;
            // 
            // filmTitleIDComboBox
            // 
            this.filmTitleIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmTitlesProducerBindingSource, "FilmTitleID", true));
            this.filmTitleIDComboBox.DataSource = this.filmTitlesBindingSource1;
            this.filmTitleIDComboBox.DisplayMember = "FilmTitleID";
            this.filmTitleIDComboBox.FormattingEnabled = true;
            this.filmTitleIDComboBox.Location = new System.Drawing.Point(104, 57);
            this.filmTitleIDComboBox.Name = "filmTitleIDComboBox";
            this.filmTitleIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.filmTitleIDComboBox.TabIndex = 8;
            this.filmTitleIDComboBox.ValueMember = "FilmTitleID";
            // 
            // filmTitlesBindingSource
            // 
            this.filmTitlesBindingSource.DataMember = "FilmTitles";
            this.filmTitlesBindingSource.DataSource = this.bd;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // filmTitlesTableAdapter
            // 
            this.filmTitlesTableAdapter.ClearBeforeFill = true;
            // 
            // producersTableAdapter
            // 
            this.producersTableAdapter.ClearBeforeFill = true;
            // 
            // producersBindingSource2
            // 
            this.producersBindingSource2.DataMember = "Producers";
            this.producersBindingSource2.DataSource = this.bd;
            // 
            // filmTitlesBindingSource1
            // 
            this.filmTitlesBindingSource1.DataMember = "FilmTitles";
            this.filmTitlesBindingSource1.DataSource = this.bd;
            // 
            // FilmTitlesProducers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 346);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(producerIDLabel);
            this.Controls.Add(this.producerIDComboBox);
            this.Controls.Add(filmTitleIDLabel);
            this.Controls.Add(this.filmTitleIDComboBox);
            this.Controls.Add(this.filmTitlesProducerDataGridView);
            this.Controls.Add(this.filmTitlesProducerBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FilmTitlesProducers";
            this.Text = "FilmTitlesProducers";
            this.Load += new System.EventHandler(this.FilmTitlesProducers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmTitlesProducerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmTitlesProducerBindingNavigator)).EndInit();
            this.filmTitlesProducerBindingNavigator.ResumeLayout(false);
            this.filmTitlesProducerBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmTitlesProducerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmTitlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.producersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmTitlesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bd bd;
        private System.Windows.Forms.BindingSource filmTitlesProducerBindingSource;
        private bdTableAdapters.FilmTitlesProducerTableAdapter filmTitlesProducerTableAdapter;
        private bdTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator filmTitlesProducerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton filmTitlesProducerBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView filmTitlesProducerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ComboBox producerIDComboBox;
        private System.Windows.Forms.ComboBox filmTitleIDComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource filmTitlesBindingSource;
        private bdTableAdapters.FilmTitlesTableAdapter filmTitlesTableAdapter;
        private System.Windows.Forms.BindingSource producersBindingSource;
        private bdTableAdapters.ProducersTableAdapter producersTableAdapter;
        private System.Windows.Forms.BindingSource producersBindingSource1;
        private System.Windows.Forms.BindingSource producersBindingSource2;
        private System.Windows.Forms.BindingSource filmTitlesBindingSource1;
    }
}