namespace _3erExamenParcial
{
    partial class FilmGenres
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
            System.Windows.Forms.Label genreIDLabel;
            System.Windows.Forms.Label genreLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmGenres));
            this.bd = new _3erExamenParcial.bd();
            this.filmGenresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmGenresTableAdapter = new _3erExamenParcial.bdTableAdapters.FilmGenresTableAdapter();
            this.tableAdapterManager = new _3erExamenParcial.bdTableAdapters.TableAdapterManager();
            this.filmGenresBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.filmGenresBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.filmGenresDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.genreIDTextBox = new System.Windows.Forms.TextBox();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            genreIDLabel = new System.Windows.Forms.Label();
            genreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmGenresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmGenresBindingNavigator)).BeginInit();
            this.filmGenresBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmGenresDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // genreIDLabel
            // 
            genreIDLabel.AutoSize = true;
            genreIDLabel.Location = new System.Drawing.Point(12, 44);
            genreIDLabel.Name = "genreIDLabel";
            genreIDLabel.Size = new System.Drawing.Size(53, 13);
            genreIDLabel.TabIndex = 4;
            genreIDLabel.Text = "Genre ID:";
            // 
            // genreLabel
            // 
            genreLabel.AutoSize = true;
            genreLabel.Location = new System.Drawing.Point(12, 70);
            genreLabel.Name = "genreLabel";
            genreLabel.Size = new System.Drawing.Size(39, 13);
            genreLabel.TabIndex = 6;
            genreLabel.Text = "Genre:";
            // 
            // bd
            // 
            this.bd.DataSetName = "bd";
            this.bd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmGenresBindingSource
            // 
            this.filmGenresBindingSource.DataMember = "FilmGenres";
            this.filmGenresBindingSource.DataSource = this.bd;
            // 
            // filmGenresTableAdapter
            // 
            this.filmGenresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActorsTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilmActorRoleTableAdapter = null;
            this.tableAdapterManager.FilmCertificateTableAdapter = null;
            this.tableAdapterManager.FilmGenresTableAdapter = this.filmGenresTableAdapter;
            this.tableAdapterManager.FilmTitlesProducerTableAdapter = null;
            this.tableAdapterManager.FilmTitlesTableAdapter = null;
            this.tableAdapterManager.ProducersTableAdapter = null;
            this.tableAdapterManager.RoleTypesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _3erExamenParcial.bdTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // filmGenresBindingNavigator
            // 
            this.filmGenresBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.filmGenresBindingNavigator.BindingSource = this.filmGenresBindingSource;
            this.filmGenresBindingNavigator.CountItem = null;
            this.filmGenresBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.filmGenresBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.filmGenresBindingNavigatorSaveItem});
            this.filmGenresBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.filmGenresBindingNavigator.MoveFirstItem = null;
            this.filmGenresBindingNavigator.MoveLastItem = null;
            this.filmGenresBindingNavigator.MoveNextItem = null;
            this.filmGenresBindingNavigator.MovePreviousItem = null;
            this.filmGenresBindingNavigator.Name = "filmGenresBindingNavigator";
            this.filmGenresBindingNavigator.PositionItem = null;
            this.filmGenresBindingNavigator.Size = new System.Drawing.Size(270, 25);
            this.filmGenresBindingNavigator.TabIndex = 0;
            this.filmGenresBindingNavigator.Text = "bindingNavigator1";
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
            // filmGenresBindingNavigatorSaveItem
            // 
            this.filmGenresBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.filmGenresBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("filmGenresBindingNavigatorSaveItem.Image")));
            this.filmGenresBindingNavigatorSaveItem.Name = "filmGenresBindingNavigatorSaveItem";
            this.filmGenresBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.filmGenresBindingNavigatorSaveItem.Text = "Guardar datos";
            this.filmGenresBindingNavigatorSaveItem.Click += new System.EventHandler(this.filmGenresBindingNavigatorSaveItem_Click);
            // 
            // filmGenresDataGridView
            // 
            this.filmGenresDataGridView.AllowUserToAddRows = false;
            this.filmGenresDataGridView.AllowUserToDeleteRows = false;
            this.filmGenresDataGridView.AutoGenerateColumns = false;
            this.filmGenresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmGenresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.filmGenresDataGridView.DataSource = this.filmGenresBindingSource;
            this.filmGenresDataGridView.Location = new System.Drawing.Point(12, 104);
            this.filmGenresDataGridView.Name = "filmGenresDataGridView";
            this.filmGenresDataGridView.ReadOnly = true;
            this.filmGenresDataGridView.Size = new System.Drawing.Size(245, 187);
            this.filmGenresDataGridView.TabIndex = 1;
            this.filmGenresDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filmGenresDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "GenreID";
            this.dataGridViewTextBoxColumn1.HeaderText = "GenreID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Genre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Genre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(182, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // genreIDTextBox
            // 
            this.genreIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmGenresBindingSource, "GenreID", true));
            this.genreIDTextBox.Location = new System.Drawing.Point(71, 41);
            this.genreIDTextBox.Name = "genreIDTextBox";
            this.genreIDTextBox.Size = new System.Drawing.Size(168, 20);
            this.genreIDTextBox.TabIndex = 5;
            // 
            // genreTextBox
            // 
            this.genreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmGenresBindingSource, "Genre", true));
            this.genreTextBox.Location = new System.Drawing.Point(71, 67);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(168, 20);
            this.genreTextBox.TabIndex = 7;
            // 
            // FilmGenres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 327);
            this.Controls.Add(genreIDLabel);
            this.Controls.Add(this.genreIDTextBox);
            this.Controls.Add(genreLabel);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filmGenresDataGridView);
            this.Controls.Add(this.filmGenresBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FilmGenres";
            this.Text = "FilmGenres";
            this.Load += new System.EventHandler(this.FilmGenres_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmGenresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmGenresBindingNavigator)).EndInit();
            this.filmGenresBindingNavigator.ResumeLayout(false);
            this.filmGenresBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmGenresDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bd bd;
        private System.Windows.Forms.BindingSource filmGenresBindingSource;
        private bdTableAdapters.FilmGenresTableAdapter filmGenresTableAdapter;
        private bdTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator filmGenresBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton filmGenresBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView filmGenresDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox genreIDTextBox;
        private System.Windows.Forms.TextBox genreTextBox;
    }
}