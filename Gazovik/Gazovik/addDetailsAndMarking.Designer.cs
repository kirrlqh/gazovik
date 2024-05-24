namespace Gazovik
{
    partial class addDetailsAndMarking
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
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.деталиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.gazovikDataSet = new Gazovik.gazovikDataSet();
            this.cmbManufacturer = new System.Windows.Forms.ComboBox();
            this.производителиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.деталиBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.cmbEquipment = new System.Windows.Forms.ComboBox();
            this.оборудованиеBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.деталиBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.txtMarking = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtYears = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.dGWdetails = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.маркировкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.наименованиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПроизводителяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПоставщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.годвыпускаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDОборудованияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.деталиBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.gazovikDataSet1 = new Gazovik.gazovikDataSet1();
            this.деталиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.деталиTableAdapter = new Gazovik.gazovikDataSetTableAdapters.ДеталиTableAdapter();
            this.производителиTableAdapter = new Gazovik.gazovikDataSetTableAdapters.ПроизводителиTableAdapter();
            this.оборудованиеTableAdapter = new Gazovik.gazovikDataSetTableAdapters.ОборудованиеTableAdapter();
            this.деталиTableAdapter1 = new Gazovik.gazovikDataSet1TableAdapters.ДеталиTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.деталиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gazovikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.производителиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGWdetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gazovikDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbType
            // 
            this.cmbType.DataSource = this.деталиBindingSource1;
            this.cmbType.DisplayMember = "Тип";
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(195, 229);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(160, 24);
            this.cmbType.TabIndex = 1;
            this.cmbType.ValueMember = "Тип";
            // 
            // деталиBindingSource1
            // 
            this.деталиBindingSource1.DataMember = "Детали";
            this.деталиBindingSource1.DataSource = this.gazovikDataSet;
            // 
            // gazovikDataSet
            // 
            this.gazovikDataSet.DataSetName = "gazovikDataSet";
            this.gazovikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbManufacturer
            // 
            this.cmbManufacturer.DataSource = this.производителиBindingSource;
            this.cmbManufacturer.DisplayMember = "ID";
            this.cmbManufacturer.FormattingEnabled = true;
            this.cmbManufacturer.Location = new System.Drawing.Point(195, 277);
            this.cmbManufacturer.Margin = new System.Windows.Forms.Padding(4);
            this.cmbManufacturer.Name = "cmbManufacturer";
            this.cmbManufacturer.Size = new System.Drawing.Size(160, 24);
            this.cmbManufacturer.TabIndex = 3;
            this.cmbManufacturer.ValueMember = "ID";
            // 
            // производителиBindingSource
            // 
            this.производителиBindingSource.DataMember = "Производители";
            this.производителиBindingSource.DataSource = this.gazovikDataSet;
            // 
            // деталиBindingSource2
            // 
            this.деталиBindingSource2.DataMember = "Детали";
            this.деталиBindingSource2.DataSource = this.gazovikDataSet;
            // 
            // cmbEquipment
            // 
            this.cmbEquipment.DataSource = this.оборудованиеBindingSource;
            this.cmbEquipment.DisplayMember = "ID";
            this.cmbEquipment.FormattingEnabled = true;
            this.cmbEquipment.Location = new System.Drawing.Point(195, 329);
            this.cmbEquipment.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEquipment.Name = "cmbEquipment";
            this.cmbEquipment.Size = new System.Drawing.Size(160, 24);
            this.cmbEquipment.TabIndex = 4;
            this.cmbEquipment.ValueMember = "ID";
            // 
            // оборудованиеBindingSource
            // 
            this.оборудованиеBindingSource.DataMember = "Оборудование";
            this.оборудованиеBindingSource.DataSource = this.gazovikDataSet;
            // 
            // деталиBindingSource3
            // 
            this.деталиBindingSource3.DataMember = "Детали";
            this.деталиBindingSource3.DataSource = this.gazovikDataSet;
            // 
            // txtMarking
            // 
            this.txtMarking.Location = new System.Drawing.Point(43, 229);
            this.txtMarking.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarking.Name = "txtMarking";
            this.txtMarking.Size = new System.Drawing.Size(132, 22);
            this.txtMarking.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(43, 279);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 6;
            // 
            // txtYears
            // 
            this.txtYears.Location = new System.Drawing.Point(43, 329);
            this.txtYears.Margin = new System.Windows.Forms.Padding(4);
            this.txtYears.Name = "txtYears";
            this.txtYears.Size = new System.Drawing.Size(132, 22);
            this.txtYears.TabIndex = 7;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(43, 380);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(169, 28);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "внести данные";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "маркировка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 259);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "наименование";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 307);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "год выпуска";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(192, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "тип";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(192, 259);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "производитель";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 307);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "оборудование";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(806, 194);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 28);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "обновка";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.Refresh_Click_1);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(698, 194);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(100, 28);
            this.btnDel.TabIndex = 11;
            this.btnDel.Text = "удалить";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AllowDrop = true;
            this.btnEdit.Location = new System.Drawing.Point(557, 194);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(134, 28);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "редактировать";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // dGWdetails
            // 
            this.dGWdetails.AllowDrop = true;
            this.dGWdetails.AutoGenerateColumns = false;
            this.dGWdetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGWdetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.маркировкаDataGridViewTextBoxColumn,
            this.наименованиеDataGridViewTextBoxColumn,
            this.типDataGridViewTextBoxColumn,
            this.iDПроизводителяDataGridViewTextBoxColumn,
            this.iDПоставщикаDataGridViewTextBoxColumn,
            this.годвыпускаDataGridViewTextBoxColumn,
            this.iDОборудованияDataGridViewTextBoxColumn});
            this.dGWdetails.DataSource = this.деталиBindingSource4;
            this.dGWdetails.Location = new System.Drawing.Point(48, 27);
            this.dGWdetails.Name = "dGWdetails";
            this.dGWdetails.RowHeadersWidth = 51;
            this.dGWdetails.RowTemplate.Height = 24;
            this.dGWdetails.Size = new System.Drawing.Size(934, 150);
            this.dGWdetails.TabIndex = 13;
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
            // годвыпускаDataGridViewTextBoxColumn
            // 
            this.годвыпускаDataGridViewTextBoxColumn.DataPropertyName = "Год_выпуска";
            this.годвыпускаDataGridViewTextBoxColumn.HeaderText = "Год_выпуска";
            this.годвыпускаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.годвыпускаDataGridViewTextBoxColumn.Name = "годвыпускаDataGridViewTextBoxColumn";
            this.годвыпускаDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDОборудованияDataGridViewTextBoxColumn
            // 
            this.iDОборудованияDataGridViewTextBoxColumn.DataPropertyName = "ID_Оборудования";
            this.iDОборудованияDataGridViewTextBoxColumn.HeaderText = "ID_Оборудования";
            this.iDОборудованияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDОборудованияDataGridViewTextBoxColumn.Name = "iDОборудованияDataGridViewTextBoxColumn";
            this.iDОборудованияDataGridViewTextBoxColumn.Width = 125;
            // 
            // деталиBindingSource4
            // 
            this.деталиBindingSource4.DataMember = "Детали";
            this.деталиBindingSource4.DataSource = this.gazovikDataSet1;
            // 
            // gazovikDataSet1
            // 
            this.gazovikDataSet1.DataSetName = "gazovikDataSet1";
            this.gazovikDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // деталиBindingSource
            // 
            this.деталиBindingSource.DataMember = "Детали";
            this.деталиBindingSource.DataSource = this.gazovikDataSet;
            // 
            // деталиTableAdapter
            // 
            this.деталиTableAdapter.ClearBeforeFill = true;
            // 
            // производителиTableAdapter
            // 
            this.производителиTableAdapter.ClearBeforeFill = true;
            // 
            // оборудованиеTableAdapter
            // 
            this.оборудованиеTableAdapter.ClearBeforeFill = true;
            // 
            // деталиTableAdapter1
            // 
            this.деталиTableAdapter1.ClearBeforeFill = true;
            // 
            // addDetailsAndMarking
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 494);
            this.Controls.Add(this.dGWdetails);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtYears);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMarking);
            this.Controls.Add(this.cmbEquipment);
            this.Controls.Add(this.cmbManufacturer);
            this.Controls.Add(this.cmbType);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "addDetailsAndMarking";
            this.Text = "AddDetForm";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.деталиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gazovikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.производителиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.оборудованиеBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGWdetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gazovikDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.деталиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.ComboBox cmbManufacturer;
        private System.Windows.Forms.ComboBox cmbEquipment;
        private System.Windows.Forms.TextBox txtMarking;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtYears;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dGWdetails;
        private gazovikDataSet gazovikDataSet;
        private System.Windows.Forms.BindingSource деталиBindingSource;
        private gazovikDataSetTableAdapters.ДеталиTableAdapter деталиTableAdapter;
        private System.Windows.Forms.BindingSource деталиBindingSource1;
        private System.Windows.Forms.BindingSource деталиBindingSource2;
        private System.Windows.Forms.BindingSource деталиBindingSource3;
        private System.Windows.Forms.BindingSource производителиBindingSource;
        private gazovikDataSetTableAdapters.ПроизводителиTableAdapter производителиTableAdapter;
        private System.Windows.Forms.BindingSource оборудованиеBindingSource;
        private gazovikDataSetTableAdapters.ОборудованиеTableAdapter оборудованиеTableAdapter;
        private gazovikDataSet1 gazovikDataSet1;
        private System.Windows.Forms.BindingSource деталиBindingSource4;
        private gazovikDataSet1TableAdapters.ДеталиTableAdapter деталиTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn маркировкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn наименованиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПроизводителяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПоставщикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn годвыпускаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDОборудованияDataGridViewTextBoxColumn;
    }
}