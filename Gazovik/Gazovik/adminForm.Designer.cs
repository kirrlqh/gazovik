namespace Gazovik
{
    partial class adminForm
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
            this.dGWdetailsAdm = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маркировкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПроизводителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПоставщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDОборудованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.деталиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gazovikDataSet = new Gazovik.gazovikDataSet();
            this.dGWoborudAdm = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.описаниеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датавводавэксплуатациюDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оборудованиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьСотрудникаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.деталиTableAdapter = new Gazovik.gazovikDataSetTableAdapters.ДеталиTableAdapter();
            this.оборудованиеTableAdapter = new Gazovik.gazovikDataSetTableAdapters.ОборудованиеTableAdapter();
            this.dGWproizvodAdm = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.производителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.производителиTableAdapter = new Gazovik.gazovikDataSetTableAdapters.ПроизводителиTableAdapter();
            this.dGWpostavAdm = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.контактноелицоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикиTableAdapter = new Gazovik.gazovikDataSetTableAdapters.ПоставщикиTableAdapter();
            this.btnEditDetails = new System.Windows.Forms.Button();
            this.btnEditOborud = new System.Windows.Forms.Button();
            this.btnEditPostav = new System.Windows.Forms.Button();
            this.btnEditProizvod = new System.Windows.Forms.Button();
            this.btnDelOborud = new System.Windows.Forms.Button();
            this.btnDelDetails = new System.Windows.Forms.Button();
            this.btnDelPostav = new System.Windows.Forms.Button();
            this.btnDelProizvod = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGWdetailsAdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gazovikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGWoborudAdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGWproizvodAdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.производителиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGWpostavAdm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dGWdetailsAdm
            // 
            this.dGWdetailsAdm.AutoGenerateColumns = false;
            this.dGWdetailsAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWdetailsAdm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.маркировкаDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.типDataGridViewTextBoxColumn,
            this.iDПроизводителяDataGridViewTextBoxColumn,
            this.iDПоставщикаDataGridViewTextBoxColumn,
            this.iDОборудованияDataGridViewTextBoxColumn});
            this.dGWdetailsAdm.DataSource = this.деталиBindingSource;
            this.dGWdetailsAdm.Location = new System.Drawing.Point(32, 31);
            this.dGWdetailsAdm.Margin = new System.Windows.Forms.Padding(4);
            this.dGWdetailsAdm.Name = "dGWdetailsAdm";
            this.dGWdetailsAdm.RowHeadersWidth = 51;
            this.dGWdetailsAdm.Size = new System.Drawing.Size(1032, 185);
            this.dGWdetailsAdm.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // маркировкаDataGridViewTextBoxColumn
            // 
            this.маркировкаDataGridViewTextBoxColumn.DataPropertyName = "Маркировка";
            this.маркировкаDataGridViewTextBoxColumn.HeaderText = "Маркировка";
            this.маркировкаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.маркировкаDataGridViewTextBoxColumn.Name = "маркировкаDataGridViewTextBoxColumn";
            this.маркировкаDataGridViewTextBoxColumn.Width = 125;
            // 
            // наименованиеDataGridViewTextBoxColumn
            // 
            this.наименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.наименованиеDataGridViewTextBoxColumn.Name = "наименованиеDataGridViewTextBoxColumn";
            this.наименованиеDataGridViewTextBoxColumn.Width = 125;
            // 
            // типDataGridViewTextBoxColumn
            // 
            this.типDataGridViewTextBoxColumn.DataPropertyName = "Тип";
            this.типDataGridViewTextBoxColumn.HeaderText = "Тип";
            this.типDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.типDataGridViewTextBoxColumn.Name = "типDataGridViewTextBoxColumn";
            this.типDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDПроизводителяDataGridViewTextBoxColumn
            // 
            this.iDПроизводителяDataGridViewTextBoxColumn.DataPropertyName = "ID_Производителя";
            this.iDПроизводителяDataGridViewTextBoxColumn.HeaderText = "ID_Производителя";
            this.iDПроизводителяDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDПроизводителяDataGridViewTextBoxColumn.Name = "iDПроизводителяDataGridViewTextBoxColumn";
            this.iDПроизводителяDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDПоставщикаDataGridViewTextBoxColumn
            // 
            this.iDПоставщикаDataGridViewTextBoxColumn.DataPropertyName = "ID_Поставщика";
            this.iDПоставщикаDataGridViewTextBoxColumn.HeaderText = "ID_Поставщика";
            this.iDПоставщикаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDПоставщикаDataGridViewTextBoxColumn.Name = "iDПоставщикаDataGridViewTextBoxColumn";
            this.iDПоставщикаDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDОборудованияDataGridViewTextBoxColumn
            // 
            this.iDОборудованияDataGridViewTextBoxColumn.DataPropertyName = "ID_Оборудования";
            this.iDОборудованияDataGridViewTextBoxColumn.HeaderText = "ID_Оборудования";
            this.iDОборудованияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDОборудованияDataGridViewTextBoxColumn.Name = "iDОборудованияDataGridViewTextBoxColumn";
            this.iDОборудованияDataGridViewTextBoxColumn.Width = 125;
            // 
            // деталиBindingSource
            // 
            this.деталиBindingSource.DataMember = "Детали";
            this.деталиBindingSource.DataSource = this.gazovikDataSet;
            // 
            // gazovikDataSet
            // 
            this.gazovikDataSet.DataSetName = "gazovikDataSet";
            this.gazovikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dGWoborudAdm
            // 
            this.dGWoborudAdm.AutoGenerateColumns = false;
            this.dGWoborudAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWoborudAdm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.наименованиеDataGridViewTextBoxColumn1,
            this.описаниеDataGridViewTextBoxColumn,
            this.датавводавэксплуатациюDataGridViewTextBoxColumn});
            this.dGWoborudAdm.DataSource = this.оборудованиеBindingSource;
            this.dGWoborudAdm.Location = new System.Drawing.Point(32, 224);
            this.dGWoborudAdm.Margin = new System.Windows.Forms.Padding(4);
            this.dGWoborudAdm.Name = "dGWoborudAdm";
            this.dGWoborudAdm.RowHeadersWidth = 51;
            this.dGWoborudAdm.Size = new System.Drawing.Size(762, 185);
            this.dGWoborudAdm.TabIndex = 1;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            this.iDDataGridViewTextBoxColumn1.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn1.Width = 125;
            // 
            // наименованиеDataGridViewTextBoxColumn1
            // 
            this.наименованиеDataGridViewTextBoxColumn1.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.наименованиеDataGridViewTextBoxColumn1.Name = "наименованиеDataGridViewTextBoxColumn1";
            this.наименованиеDataGridViewTextBoxColumn1.Width = 125;
            // 
            // описаниеDataGridViewTextBoxColumn
            // 
            this.описаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание";
            this.описаниеDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.описаниеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.описаниеDataGridViewTextBoxColumn.Name = "описаниеDataGridViewTextBoxColumn";
            this.описаниеDataGridViewTextBoxColumn.Width = 125;
            // 
            // датавводавэксплуатациюDataGridViewTextBoxColumn
            // 
            this.датавводавэксплуатациюDataGridViewTextBoxColumn.DataPropertyName = "Дата_ввода_в_эксплуатацию";
            this.датавводавэксплуатациюDataGridViewTextBoxColumn.HeaderText = "Дата_ввода_в_эксплуатацию";
            this.датавводавэксплуатациюDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датавводавэксплуатациюDataGridViewTextBoxColumn.Name = "датавводавэксплуатациюDataGridViewTextBoxColumn";
            this.датавводавэксплуатациюDataGridViewTextBoxColumn.Width = 125;
            // 
            // оборудованиеBindingSource
            // 
            this.оборудованиеBindingSource.DataMember = "Оборудование";
            this.оборудованиеBindingSource.DataSource = this.gazovikDataSet;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьСотрудникаToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1388, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьСотрудникаToolStripMenuItem1
            // 
            this.добавитьСотрудникаToolStripMenuItem1.Name = "добавитьСотрудникаToolStripMenuItem1";
            this.добавитьСотрудникаToolStripMenuItem1.Size = new System.Drawing.Size(173, 24);
            this.добавитьСотрудникаToolStripMenuItem1.Text = "Добавить сотрудника";
            this.добавитьСотрудникаToolStripMenuItem1.Click += new System.EventHandler(this.добавитьСотрудникаToolStripMenuItem1_Click);
            // 
            // деталиTableAdapter
            // 
            this.деталиTableAdapter.ClearBeforeFill = true;
            // 
            // оборудованиеTableAdapter
            // 
            this.оборудованиеTableAdapter.ClearBeforeFill = true;
            // 
            // dGWproizvodAdm
            // 
            this.dGWproizvodAdm.AutoGenerateColumns = false;
            this.dGWproizvodAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWproizvodAdm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn2,
            this.наименованиеDataGridViewTextBoxColumn2});
            this.dGWproizvodAdm.DataSource = this.производителиBindingSource;
            this.dGWproizvodAdm.Location = new System.Drawing.Point(32, 572);
            this.dGWproizvodAdm.Name = "dGWproizvodAdm";
            this.dGWproizvodAdm.RowHeadersWidth = 51;
            this.dGWproizvodAdm.RowTemplate.Height = 24;
            this.dGWproizvodAdm.Size = new System.Drawing.Size(458, 150);
            this.dGWproizvodAdm.TabIndex = 3;
            // 
            // iDDataGridViewTextBoxColumn2
            // 
            this.iDDataGridViewTextBoxColumn2.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn2.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn2.Name = "iDDataGridViewTextBoxColumn2";
            this.iDDataGridViewTextBoxColumn2.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn2.Width = 125;
            // 
            // наименованиеDataGridViewTextBoxColumn2
            // 
            this.наименованиеDataGridViewTextBoxColumn2.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn2.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.наименованиеDataGridViewTextBoxColumn2.Name = "наименованиеDataGridViewTextBoxColumn2";
            this.наименованиеDataGridViewTextBoxColumn2.Width = 125;
            // 
            // производителиBindingSource
            // 
            this.производителиBindingSource.DataMember = "Производители";
            this.производителиBindingSource.DataSource = this.gazovikDataSet;
            // 
            // производителиTableAdapter
            // 
            this.производителиTableAdapter.ClearBeforeFill = true;
            // 
            // dGWpostavAdm
            // 
            this.dGWpostavAdm.AutoGenerateColumns = false;
            this.dGWpostavAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWpostavAdm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn3,
            this.наименованиеDataGridViewTextBoxColumn3,
            this.контактноелицоDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dGWpostavAdm.DataSource = this.поставщикиBindingSource;
            this.dGWpostavAdm.Location = new System.Drawing.Point(32, 416);
            this.dGWpostavAdm.Name = "dGWpostavAdm";
            this.dGWpostavAdm.RowHeadersWidth = 51;
            this.dGWpostavAdm.RowTemplate.Height = 24;
            this.dGWpostavAdm.Size = new System.Drawing.Size(839, 150);
            this.dGWpostavAdm.TabIndex = 4;
            // 
            // iDDataGridViewTextBoxColumn3
            // 
            this.iDDataGridViewTextBoxColumn3.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn3.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn3.Name = "iDDataGridViewTextBoxColumn3";
            this.iDDataGridViewTextBoxColumn3.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn3.Width = 125;
            // 
            // наименованиеDataGridViewTextBoxColumn3
            // 
            this.наименованиеDataGridViewTextBoxColumn3.DataPropertyName = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn3.HeaderText = "Наименование";
            this.наименованиеDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.наименованиеDataGridViewTextBoxColumn3.Name = "наименованиеDataGridViewTextBoxColumn3";
            this.наименованиеDataGridViewTextBoxColumn3.Width = 125;
            // 
            // контактноелицоDataGridViewTextBoxColumn
            // 
            this.контактноелицоDataGridViewTextBoxColumn.DataPropertyName = "Контактное_лицо";
            this.контактноелицоDataGridViewTextBoxColumn.HeaderText = "Контактное_лицо";
            this.контактноелицоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.контактноелицоDataGridViewTextBoxColumn.Name = "контактноелицоDataGridViewTextBoxColumn";
            this.контактноелицоDataGridViewTextBoxColumn.Width = 125;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.Width = 125;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 125;
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.gazovikDataSet;
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // btnEditDetails
            // 
            this.btnEditDetails.Location = new System.Drawing.Point(1086, 96);
            this.btnEditDetails.Name = "btnEditDetails";
            this.btnEditDetails.Size = new System.Drawing.Size(81, 23);
            this.btnEditDetails.TabIndex = 5;
            this.btnEditDetails.Text = "изменить";
            this.btnEditDetails.UseVisualStyleBackColor = true;
            this.btnEditDetails.Click += new System.EventHandler(this.btnEditDetails_Click);
            // 
            // btnEditOborud
            // 
            this.btnEditOborud.Location = new System.Drawing.Point(818, 293);
            this.btnEditOborud.Name = "btnEditOborud";
            this.btnEditOborud.Size = new System.Drawing.Size(81, 23);
            this.btnEditOborud.TabIndex = 6;
            this.btnEditOborud.Text = "изменить";
            this.btnEditOborud.UseVisualStyleBackColor = true;
            this.btnEditOborud.Click += new System.EventHandler(this.btnEditOborud_Click);
            // 
            // btnEditPostav
            // 
            this.btnEditPostav.Location = new System.Drawing.Point(893, 465);
            this.btnEditPostav.Name = "btnEditPostav";
            this.btnEditPostav.Size = new System.Drawing.Size(81, 23);
            this.btnEditPostav.TabIndex = 7;
            this.btnEditPostav.Text = "изменить";
            this.btnEditPostav.UseVisualStyleBackColor = true;
            this.btnEditPostav.Click += new System.EventHandler(this.btnEditPostav_Click);
            // 
            // btnEditProizvod
            // 
            this.btnEditProizvod.Location = new System.Drawing.Point(514, 617);
            this.btnEditProizvod.Name = "btnEditProizvod";
            this.btnEditProizvod.Size = new System.Drawing.Size(81, 23);
            this.btnEditProizvod.TabIndex = 7;
            this.btnEditProizvod.Text = "изменить";
            this.btnEditProizvod.UseVisualStyleBackColor = true;
            this.btnEditProizvod.Click += new System.EventHandler(this.btnEditProizvod_Click);
            // 
            // btnDelOborud
            // 
            this.btnDelOborud.Location = new System.Drawing.Point(818, 322);
            this.btnDelOborud.Name = "btnDelOborud";
            this.btnDelOborud.Size = new System.Drawing.Size(81, 23);
            this.btnDelOborud.TabIndex = 8;
            this.btnDelOborud.Text = "удалить";
            this.btnDelOborud.UseVisualStyleBackColor = true;
            this.btnDelOborud.Click += new System.EventHandler(this.btnDelOborud_Click);
            // 
            // btnDelDetails
            // 
            this.btnDelDetails.Location = new System.Drawing.Point(1086, 125);
            this.btnDelDetails.Name = "btnDelDetails";
            this.btnDelDetails.Size = new System.Drawing.Size(81, 23);
            this.btnDelDetails.TabIndex = 8;
            this.btnDelDetails.Text = "удалить";
            this.btnDelDetails.UseVisualStyleBackColor = true;
            this.btnDelDetails.Click += new System.EventHandler(this.btnDelDetails_Click);
            // 
            // btnDelPostav
            // 
            this.btnDelPostav.Location = new System.Drawing.Point(893, 494);
            this.btnDelPostav.Name = "btnDelPostav";
            this.btnDelPostav.Size = new System.Drawing.Size(81, 23);
            this.btnDelPostav.TabIndex = 8;
            this.btnDelPostav.Text = "удалить";
            this.btnDelPostav.UseVisualStyleBackColor = true;
            this.btnDelPostav.Click += new System.EventHandler(this.btnDelPostav_Click);
            // 
            // btnDelProizvod
            // 
            this.btnDelProizvod.Location = new System.Drawing.Point(514, 646);
            this.btnDelProizvod.Name = "btnDelProizvod";
            this.btnDelProizvod.Size = new System.Drawing.Size(81, 23);
            this.btnDelProizvod.TabIndex = 8;
            this.btnDelProizvod.Text = "удалить";
            this.btnDelProizvod.UseVisualStyleBackColor = true;
            this.btnDelProizvod.Click += new System.EventHandler(this.btnDelProizvod_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1288, 47);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 23);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "обновить";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // adminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1388, 744);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelDetails);
            this.Controls.Add(this.btnDelProizvod);
            this.Controls.Add(this.btnDelPostav);
            this.Controls.Add(this.btnDelOborud);
            this.Controls.Add(this.btnEditProizvod);
            this.Controls.Add(this.btnEditPostav);
            this.Controls.Add(this.btnEditOborud);
            this.Controls.Add(this.btnEditDetails);
            this.Controls.Add(this.dGWpostavAdm);
            this.Controls.Add(this.dGWproizvodAdm);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dGWoborudAdm);
            this.Controls.Add(this.dGWdetailsAdm);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "adminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGWdetailsAdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gazovikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGWoborudAdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGWproizvodAdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.производителиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGWpostavAdm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGWdetailsAdm;
        private System.Windows.Forms.DataGridView dGWoborudAdm;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьСотрудникаToolStripMenuItem1;
        private gazovikDataSet gazovikDataSet;
        private System.Windows.Forms.BindingSource деталиBindingSource;
        private gazovikDataSetTableAdapters.ДеталиTableAdapter деталиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркировкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПроизводителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПоставщикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDОборудованияDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource оборудованиеBindingSource;
        private gazovikDataSetTableAdapters.ОборудованиеTableAdapter оборудованиеTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn описаниеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датавводавэксплуатациюDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dGWproizvodAdm;
        private System.Windows.Forms.BindingSource производителиBindingSource;
        private gazovikDataSetTableAdapters.ПроизводителиTableAdapter производителиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView dGWpostavAdm;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private gazovikDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn контактноелицоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnEditDetails;
        private System.Windows.Forms.Button btnEditOborud;
        private System.Windows.Forms.Button btnEditPostav;
        private System.Windows.Forms.Button btnEditProizvod;
        private System.Windows.Forms.Button btnDelOborud;
        private System.Windows.Forms.Button btnDelDetails;
        private System.Windows.Forms.Button btnDelPostav;
        private System.Windows.Forms.Button btnDelProizvod;
        private System.Windows.Forms.Button btnRefresh;
    }
}