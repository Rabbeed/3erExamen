namespace _3erExamenParcial
{
    partial class FilmActorRole
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
            System.Windows.Forms.Label filmTitleIDLabel;
            System.Windows.Forms.Label actorIDLabel;
            System.Windows.Forms.Label roleTypeLabel;
            System.Windows.Forms.Label characterNameLabel;
            System.Windows.Forms.Label characterDescriptionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FilmActorRole));
            this.bd = new _3erExamenParcial.bd();
            this.filmActorRoleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.filmActorRoleTableAdapter = new _3erExamenParcial.bdTableAdapters.FilmActorRoleTableAdapter();
            this.tableAdapterManager = new _3erExamenParcial.bdTableAdapters.TableAdapterManager();
            this.actorsTableAdapter = new _3erExamenParcial.bdTableAdapters.ActorsTableAdapter();
            this.filmTitlesTableAdapter = new _3erExamenParcial.bdTableAdapters.FilmTitlesTableAdapter();
            this.roleTypesTableAdapter = new _3erExamenParcial.bdTableAdapters.RoleTypesTableAdapter();
            this.filmActorRoleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.filmActorRoleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.filmActorRoleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.filmTitleIDComboBox = new System.Windows.Forms.ComboBox();
            this.filmTitlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.actorIDComboBox = new System.Windows.Forms.ComboBox();
            this.actorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roleTypeComboBox = new System.Windows.Forms.ComboBox();
            this.roleTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.characterNameTextBox = new System.Windows.Forms.TextBox();
            this.characterDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filmTitlesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.filmTitleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filmAditionalInfoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.actorsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.actorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorFullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.roleTypesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.roleTypeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            filmTitleIDLabel = new System.Windows.Forms.Label();
            actorIDLabel = new System.Windows.Forms.Label();
            roleTypeLabel = new System.Windows.Forms.Label();
            characterNameLabel = new System.Windows.Forms.Label();
            characterDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmActorRoleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmActorRoleBindingNavigator)).BeginInit();
            this.filmActorRoleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmActorRoleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmTitlesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleTypesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmTitlesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleTypesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // filmTitleIDLabel
            // 
            filmTitleIDLabel.AutoSize = true;
            filmTitleIDLabel.Location = new System.Drawing.Point(32, 25);
            filmTitleIDLabel.Name = "filmTitleIDLabel";
            filmTitleIDLabel.Size = new System.Drawing.Size(65, 13);
            filmTitleIDLabel.TabIndex = 4;
            filmTitleIDLabel.Text = "Film Title ID:";
            // 
            // actorIDLabel
            // 
            actorIDLabel.AutoSize = true;
            actorIDLabel.Location = new System.Drawing.Point(32, 52);
            actorIDLabel.Name = "actorIDLabel";
            actorIDLabel.Size = new System.Drawing.Size(49, 13);
            actorIDLabel.TabIndex = 6;
            actorIDLabel.Text = "Actor ID:";
            // 
            // roleTypeLabel
            // 
            roleTypeLabel.AutoSize = true;
            roleTypeLabel.Location = new System.Drawing.Point(32, 79);
            roleTypeLabel.Name = "roleTypeLabel";
            roleTypeLabel.Size = new System.Drawing.Size(59, 13);
            roleTypeLabel.TabIndex = 8;
            roleTypeLabel.Text = "Role Type:";
            // 
            // characterNameLabel
            // 
            characterNameLabel.AutoSize = true;
            characterNameLabel.Location = new System.Drawing.Point(32, 106);
            characterNameLabel.Name = "characterNameLabel";
            characterNameLabel.Size = new System.Drawing.Size(87, 13);
            characterNameLabel.TabIndex = 10;
            characterNameLabel.Text = "Character Name:";
            // 
            // characterDescriptionLabel
            // 
            characterDescriptionLabel.AutoSize = true;
            characterDescriptionLabel.Location = new System.Drawing.Point(32, 132);
            characterDescriptionLabel.Name = "characterDescriptionLabel";
            characterDescriptionLabel.Size = new System.Drawing.Size(112, 13);
            characterDescriptionLabel.TabIndex = 12;
            characterDescriptionLabel.Text = "Character Description:";
            // 
            // bd
            // 
            this.bd.DataSetName = "bd";
            this.bd.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmActorRoleBindingSource
            // 
            this.filmActorRoleBindingSource.DataMember = "FilmActorRole";
            this.filmActorRoleBindingSource.DataSource = this.bd;
            // 
            // filmActorRoleTableAdapter
            // 
            this.filmActorRoleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ActorsTableAdapter = this.actorsTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FilmActorRoleTableAdapter = this.filmActorRoleTableAdapter;
            this.tableAdapterManager.FilmCertificateTableAdapter = null;
            this.tableAdapterManager.FilmGenresTableAdapter = null;
            this.tableAdapterManager.FilmTitlesProducerTableAdapter = null;
            this.tableAdapterManager.FilmTitlesTableAdapter = this.filmTitlesTableAdapter;
            this.tableAdapterManager.ProducersTableAdapter = null;
            this.tableAdapterManager.RoleTypesTableAdapter = this.roleTypesTableAdapter;
            this.tableAdapterManager.UpdateOrder = _3erExamenParcial.bdTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // actorsTableAdapter
            // 
            this.actorsTableAdapter.ClearBeforeFill = true;
            // 
            // filmTitlesTableAdapter
            // 
            this.filmTitlesTableAdapter.ClearBeforeFill = true;
            // 
            // roleTypesTableAdapter
            // 
            this.roleTypesTableAdapter.ClearBeforeFill = true;
            // 
            // filmActorRoleBindingNavigator
            // 
            this.filmActorRoleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.filmActorRoleBindingNavigator.BindingSource = this.filmActorRoleBindingSource;
            this.filmActorRoleBindingNavigator.CountItem = null;
            this.filmActorRoleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.filmActorRoleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.filmActorRoleBindingNavigatorSaveItem});
            this.filmActorRoleBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.filmActorRoleBindingNavigator.MoveFirstItem = null;
            this.filmActorRoleBindingNavigator.MoveLastItem = null;
            this.filmActorRoleBindingNavigator.MoveNextItem = null;
            this.filmActorRoleBindingNavigator.MovePreviousItem = null;
            this.filmActorRoleBindingNavigator.Name = "filmActorRoleBindingNavigator";
            this.filmActorRoleBindingNavigator.PositionItem = null;
            this.filmActorRoleBindingNavigator.Size = new System.Drawing.Size(860, 25);
            this.filmActorRoleBindingNavigator.TabIndex = 0;
            this.filmActorRoleBindingNavigator.Text = "bindingNavigator1";
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
            // filmActorRoleBindingNavigatorSaveItem
            // 
            this.filmActorRoleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.filmActorRoleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("filmActorRoleBindingNavigatorSaveItem.Image")));
            this.filmActorRoleBindingNavigatorSaveItem.Name = "filmActorRoleBindingNavigatorSaveItem";
            this.filmActorRoleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.filmActorRoleBindingNavigatorSaveItem.Text = "Guardar datos";
            this.filmActorRoleBindingNavigatorSaveItem.Click += new System.EventHandler(this.filmActorRoleBindingNavigatorSaveItem_Click);
            // 
            // filmActorRoleDataGridView
            // 
            this.filmActorRoleDataGridView.AllowUserToAddRows = false;
            this.filmActorRoleDataGridView.AllowUserToDeleteRows = false;
            this.filmActorRoleDataGridView.AutoGenerateColumns = false;
            this.filmActorRoleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmActorRoleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.filmActorRoleDataGridView.DataSource = this.filmActorRoleBindingSource;
            this.filmActorRoleDataGridView.Location = new System.Drawing.Point(12, 155);
            this.filmActorRoleDataGridView.Name = "filmActorRoleDataGridView";
            this.filmActorRoleDataGridView.ReadOnly = true;
            this.filmActorRoleDataGridView.Size = new System.Drawing.Size(485, 224);
            this.filmActorRoleDataGridView.TabIndex = 1;
            this.filmActorRoleDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filmActorRoleDataGridView_CellClick);
            this.filmActorRoleDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.filmActorRoleDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FilmTitleID";
            this.dataGridViewTextBoxColumn1.HeaderText = "FilmTitleID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ActorID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ActorID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "RoleType";
            this.dataGridViewTextBoxColumn3.HeaderText = "RoleType";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "CharacterName";
            this.dataGridViewTextBoxColumn4.HeaderText = "CharacterName";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CharacterDescription";
            this.dataGridViewTextBoxColumn5.HeaderText = "CharacterDescription";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(773, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // filmTitleIDComboBox
            // 
            this.filmTitleIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmActorRoleBindingSource, "FilmTitleID", true));
            this.filmTitleIDComboBox.DataSource = this.filmTitlesBindingSource;
            this.filmTitleIDComboBox.DisplayMember = "FilmTitleID";
            this.filmTitleIDComboBox.FormattingEnabled = true;
            this.filmTitleIDComboBox.Location = new System.Drawing.Point(150, 22);
            this.filmTitleIDComboBox.Name = "filmTitleIDComboBox";
            this.filmTitleIDComboBox.Size = new System.Drawing.Size(323, 21);
            this.filmTitleIDComboBox.TabIndex = 5;
            this.filmTitleIDComboBox.ValueMember = "FilmTitleID";
            // 
            // filmTitlesBindingSource
            // 
            this.filmTitlesBindingSource.DataMember = "FilmTitles";
            this.filmTitlesBindingSource.DataSource = this.bd;
            // 
            // actorIDComboBox
            // 
            this.actorIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmActorRoleBindingSource, "ActorID", true));
            this.actorIDComboBox.DataSource = this.actorsBindingSource;
            this.actorIDComboBox.DisplayMember = "ActorID";
            this.actorIDComboBox.FormattingEnabled = true;
            this.actorIDComboBox.Location = new System.Drawing.Point(150, 49);
            this.actorIDComboBox.Name = "actorIDComboBox";
            this.actorIDComboBox.Size = new System.Drawing.Size(323, 21);
            this.actorIDComboBox.TabIndex = 7;
            this.actorIDComboBox.ValueMember = "ActorID";
            // 
            // actorsBindingSource
            // 
            this.actorsBindingSource.DataMember = "Actors";
            this.actorsBindingSource.DataSource = this.bd;
            // 
            // roleTypeComboBox
            // 
            this.roleTypeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmActorRoleBindingSource, "RoleType", true));
            this.roleTypeComboBox.DataSource = this.roleTypesBindingSource;
            this.roleTypeComboBox.DisplayMember = "RoleTypeID";
            this.roleTypeComboBox.FormattingEnabled = true;
            this.roleTypeComboBox.Location = new System.Drawing.Point(150, 76);
            this.roleTypeComboBox.Name = "roleTypeComboBox";
            this.roleTypeComboBox.Size = new System.Drawing.Size(323, 21);
            this.roleTypeComboBox.TabIndex = 9;
            this.roleTypeComboBox.ValueMember = "RoleTypeID";
            // 
            // roleTypesBindingSource
            // 
            this.roleTypesBindingSource.DataMember = "RoleTypes";
            this.roleTypesBindingSource.DataSource = this.bd;
            // 
            // characterNameTextBox
            // 
            this.characterNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmActorRoleBindingSource, "CharacterName", true));
            this.characterNameTextBox.Location = new System.Drawing.Point(150, 103);
            this.characterNameTextBox.Name = "characterNameTextBox";
            this.characterNameTextBox.Size = new System.Drawing.Size(323, 20);
            this.characterNameTextBox.TabIndex = 11;
            // 
            // characterDescriptionTextBox
            // 
            this.characterDescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmActorRoleBindingSource, "CharacterDescription", true));
            this.characterDescriptionTextBox.Location = new System.Drawing.Point(150, 129);
            this.characterDescriptionTextBox.Name = "characterDescriptionTextBox";
            this.characterDescriptionTextBox.Size = new System.Drawing.Size(323, 20);
            this.characterDescriptionTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Titles";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.filmTitleIDDataGridViewTextBoxColumn,
            this.filmTitleDataGridViewTextBoxColumn,
            this.filmAditionalInfoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.filmTitlesBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(511, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(337, 121);
            this.dataGridView1.TabIndex = 15;
            // 
            // filmTitlesBindingSource1
            // 
            this.filmTitlesBindingSource1.DataMember = "FilmTitles";
            this.filmTitlesBindingSource1.DataSource = this.bd;
            // 
            // filmTitleIDDataGridViewTextBoxColumn
            // 
            this.filmTitleIDDataGridViewTextBoxColumn.DataPropertyName = "FilmTitleID";
            this.filmTitleIDDataGridViewTextBoxColumn.HeaderText = "FilmTitleID";
            this.filmTitleIDDataGridViewTextBoxColumn.Name = "filmTitleIDDataGridViewTextBoxColumn";
            this.filmTitleIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmTitleDataGridViewTextBoxColumn
            // 
            this.filmTitleDataGridViewTextBoxColumn.DataPropertyName = "FilmTitle";
            this.filmTitleDataGridViewTextBoxColumn.HeaderText = "FilmTitle";
            this.filmTitleDataGridViewTextBoxColumn.Name = "filmTitleDataGridViewTextBoxColumn";
            this.filmTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // filmAditionalInfoDataGridViewTextBoxColumn
            // 
            this.filmAditionalInfoDataGridViewTextBoxColumn.DataPropertyName = "FilmAditionalInfo";
            this.filmAditionalInfoDataGridViewTextBoxColumn.HeaderText = "FilmAditionalInfo";
            this.filmAditionalInfoDataGridViewTextBoxColumn.Name = "filmAditionalInfoDataGridViewTextBoxColumn";
            this.filmAditionalInfoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actorIDDataGridViewTextBoxColumn,
            this.actorFullNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.actorsBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(511, 174);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(337, 104);
            this.dataGridView2.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(508, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Actors";
            // 
            // actorsBindingSource1
            // 
            this.actorsBindingSource1.DataMember = "Actors";
            this.actorsBindingSource1.DataSource = this.bd;
            // 
            // actorIDDataGridViewTextBoxColumn
            // 
            this.actorIDDataGridViewTextBoxColumn.DataPropertyName = "ActorID";
            this.actorIDDataGridViewTextBoxColumn.HeaderText = "ActorID";
            this.actorIDDataGridViewTextBoxColumn.Name = "actorIDDataGridViewTextBoxColumn";
            this.actorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // actorFullNameDataGridViewTextBoxColumn
            // 
            this.actorFullNameDataGridViewTextBoxColumn.DataPropertyName = "ActorFullName";
            this.actorFullNameDataGridViewTextBoxColumn.HeaderText = "ActorFullName";
            this.actorFullNameDataGridViewTextBoxColumn.Name = "actorFullNameDataGridViewTextBoxColumn";
            this.actorFullNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roleTypeIDDataGridViewTextBoxColumn,
            this.roleTypeDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.roleTypesBindingSource1;
            this.dataGridView3.Location = new System.Drawing.Point(511, 304);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(337, 75);
            this.dataGridView3.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Roles";
            // 
            // roleTypesBindingSource1
            // 
            this.roleTypesBindingSource1.DataMember = "RoleTypes";
            this.roleTypesBindingSource1.DataSource = this.bd;
            // 
            // roleTypeIDDataGridViewTextBoxColumn
            // 
            this.roleTypeIDDataGridViewTextBoxColumn.DataPropertyName = "RoleTypeID";
            this.roleTypeIDDataGridViewTextBoxColumn.HeaderText = "RoleTypeID";
            this.roleTypeIDDataGridViewTextBoxColumn.Name = "roleTypeIDDataGridViewTextBoxColumn";
            this.roleTypeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleTypeDataGridViewTextBoxColumn
            // 
            this.roleTypeDataGridViewTextBoxColumn.DataPropertyName = "RoleType";
            this.roleTypeDataGridViewTextBoxColumn.HeaderText = "RoleType";
            this.roleTypeDataGridViewTextBoxColumn.Name = "roleTypeDataGridViewTextBoxColumn";
            this.roleTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FilmActorRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 414);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(filmTitleIDLabel);
            this.Controls.Add(this.filmTitleIDComboBox);
            this.Controls.Add(actorIDLabel);
            this.Controls.Add(this.actorIDComboBox);
            this.Controls.Add(roleTypeLabel);
            this.Controls.Add(this.roleTypeComboBox);
            this.Controls.Add(characterNameLabel);
            this.Controls.Add(this.characterNameTextBox);
            this.Controls.Add(characterDescriptionLabel);
            this.Controls.Add(this.characterDescriptionTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filmActorRoleDataGridView);
            this.Controls.Add(this.filmActorRoleBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FilmActorRole";
            this.Text = "FilmActorRole";
            this.Load += new System.EventHandler(this.FilmActorRole_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmActorRoleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmActorRoleBindingNavigator)).EndInit();
            this.filmActorRoleBindingNavigator.ResumeLayout(false);
            this.filmActorRoleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmActorRoleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmTitlesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleTypesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmTitlesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleTypesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private bd bd;
        private System.Windows.Forms.BindingSource filmActorRoleBindingSource;
        private bdTableAdapters.FilmActorRoleTableAdapter filmActorRoleTableAdapter;
        private bdTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator filmActorRoleBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton filmActorRoleBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView filmActorRoleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox filmTitleIDComboBox;
        private System.Windows.Forms.ComboBox actorIDComboBox;
        private System.Windows.Forms.ComboBox roleTypeComboBox;
        private System.Windows.Forms.TextBox characterNameTextBox;
        private System.Windows.Forms.TextBox characterDescriptionTextBox;
        private bdTableAdapters.FilmTitlesTableAdapter filmTitlesTableAdapter;
        private System.Windows.Forms.BindingSource filmTitlesBindingSource;
        private bdTableAdapters.ActorsTableAdapter actorsTableAdapter;
        private System.Windows.Forms.BindingSource actorsBindingSource;
        private bdTableAdapters.RoleTypesTableAdapter roleTypesTableAdapter;
        private System.Windows.Forms.BindingSource roleTypesBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmTitleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn filmAditionalInfoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource filmTitlesBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorFullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource actorsBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleTypeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource roleTypesBindingSource1;
        private System.Windows.Forms.Label label3;
    }
}