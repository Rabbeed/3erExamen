namespace _3erExamenParcial
{
    partial class FilmCertificate
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
            System.Windows.Forms.Label certificateIDLabel;
            System.Windows.Forms.Label certificateLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmCertificate));
            this.bd = new _3erExamenParcial.bd();
            this.filmCertificateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmCertificateTableAdapter = new _3erExamenParcial.bdTableAdapters.FilmCertificateTableAdapter();
            this.tableAdapterManager = new _3erExamenParcial.bdTableAdapters.TableAdapterManager();
            this.filmCertificateBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.filmCertificateBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.filmCertificateDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.certificateIDTextBox = new System.Windows.Forms.TextBox();
            this.certificateTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            certificateIDLabel = new System.Windows.Forms.Label();
            certificateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmCertificateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmCertificateBindingNavigator)).BeginInit();
            this.filmCertificateBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmCertificateDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // certificateIDLabel
            // 
            certificateIDLabel.AutoSize = true;
            certificateIDLabel.Location = new System.Drawing.Point(12, 41);
            certificateIDLabel.Name = "certificateIDLabel";
            certificateIDLabel.Size = new System.Drawing.Size(71, 13);
            certificateIDLabel.TabIndex = 2;
            certificateIDLabel.Text = "Certificate ID:";
            // 
            // certificateLabel
            // 
            certificateLabel.AutoSize = true;
            certificateLabel.Location = new System.Drawing.Point(12, 67);
            certificateLabel.Name = "certificateLabel";
            certificateLabel.Size = new System.Drawing.Size(57, 13);
            certificateLabel.TabIndex = 4;
            certificateLabel.Text = "Certificate:";
            // 
            // bd
            // 
            this.bd.DataSetName = "bd";
            this.bd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmCertificateBindingSource
            // 
            this.filmCertificateBindingSource.DataMember = "FilmCertificate";
            this.filmCertificateBindingSource.DataSource = this.bd;
            // 
            // filmCertificateTableAdapter
            // 
            this.filmCertificateTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilmActorRoleTableAdapter = null;
            this.tableAdapterManager.FilmCertificateTableAdapter = this.filmCertificateTableAdapter;
            this.tableAdapterManager.FilmGenresTableAdapter = null;
            this.tableAdapterManager.FilmTitlesProducerTableAdapter = null;
            this.tableAdapterManager.FilmTitlesTableAdapter = null;
            this.tableAdapterManager.ProducersTableAdapter = null;
            this.tableAdapterManager.RoleTypesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _3erExamenParcial.bdTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // filmCertificateBindingNavigator
            // 
            this.filmCertificateBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.filmCertificateBindingNavigator.BindingSource = this.filmCertificateBindingSource;
            this.filmCertificateBindingNavigator.CountItem = null;
            this.filmCertificateBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.filmCertificateBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.filmCertificateBindingNavigatorSaveItem});
            this.filmCertificateBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.filmCertificateBindingNavigator.MoveFirstItem = null;
            this.filmCertificateBindingNavigator.MoveLastItem = null;
            this.filmCertificateBindingNavigator.MoveNextItem = null;
            this.filmCertificateBindingNavigator.MovePreviousItem = null;
            this.filmCertificateBindingNavigator.Name = "filmCertificateBindingNavigator";
            this.filmCertificateBindingNavigator.PositionItem = null;
            this.filmCertificateBindingNavigator.Size = new System.Drawing.Size(270, 25);
            this.filmCertificateBindingNavigator.TabIndex = 0;
            this.filmCertificateBindingNavigator.Text = "bindingNavigator1";
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
            // filmCertificateBindingNavigatorSaveItem
            // 
            this.filmCertificateBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.filmCertificateBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("filmCertificateBindingNavigatorSaveItem.Image")));
            this.filmCertificateBindingNavigatorSaveItem.Name = "filmCertificateBindingNavigatorSaveItem";
            this.filmCertificateBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.filmCertificateBindingNavigatorSaveItem.Text = "Guardar datos";
            this.filmCertificateBindingNavigatorSaveItem.Click += new System.EventHandler(this.filmCertificateBindingNavigatorSaveItem_Click);
            // 
            // filmCertificateDataGridView
            // 
            this.filmCertificateDataGridView.AllowUserToAddRows = false;
            this.filmCertificateDataGridView.AllowUserToDeleteRows = false;
            this.filmCertificateDataGridView.AutoGenerateColumns = false;
            this.filmCertificateDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmCertificateDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.filmCertificateDataGridView.DataSource = this.filmCertificateBindingSource;
            this.filmCertificateDataGridView.Location = new System.Drawing.Point(12, 112);
            this.filmCertificateDataGridView.Name = "filmCertificateDataGridView";
            this.filmCertificateDataGridView.ReadOnly = true;
            this.filmCertificateDataGridView.Size = new System.Drawing.Size(246, 220);
            this.filmCertificateDataGridView.TabIndex = 1;
            this.filmCertificateDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filmCertificateDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CertificateID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CertificateID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Certificate";
            this.dataGridViewTextBoxColumn2.HeaderText = "Certificate";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // certificateIDTextBox
            // 
            this.certificateIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmCertificateBindingSource, "CertificateID", true));
            this.certificateIDTextBox.Location = new System.Drawing.Point(89, 38);
            this.certificateIDTextBox.Name = "certificateIDTextBox";
            this.certificateIDTextBox.Size = new System.Drawing.Size(169, 20);
            this.certificateIDTextBox.TabIndex = 3;
            // 
            // certificateTextBox
            // 
            this.certificateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmCertificateBindingSource, "Certificate", true));
            this.certificateTextBox.Location = new System.Drawing.Point(89, 64);
            this.certificateTextBox.Name = "certificateTextBox";
            this.certificateTextBox.Size = new System.Drawing.Size(169, 20);
            this.certificateTextBox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FilmCertificate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 376);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(certificateIDLabel);
            this.Controls.Add(this.certificateIDTextBox);
            this.Controls.Add(certificateLabel);
            this.Controls.Add(this.certificateTextBox);
            this.Controls.Add(this.filmCertificateDataGridView);
            this.Controls.Add(this.filmCertificateBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FilmCertificate";
            this.Text = "FilmCertificate";
            this.Load += new System.EventHandler(this.FilmCertificate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmCertificateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmCertificateBindingNavigator)).EndInit();
            this.filmCertificateBindingNavigator.ResumeLayout(false);
            this.filmCertificateBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmCertificateDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bd bd;
        private System.Windows.Forms.BindingSource filmCertificateBindingSource;
        private bdTableAdapters.FilmCertificateTableAdapter filmCertificateTableAdapter;
        private bdTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator filmCertificateBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton filmCertificateBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView filmCertificateDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox certificateIDTextBox;
        private System.Windows.Forms.TextBox certificateTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}