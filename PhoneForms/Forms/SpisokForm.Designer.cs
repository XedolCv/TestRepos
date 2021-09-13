namespace PhoneForms.Forms
{
    partial class SpisokForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gloginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datespisaniyaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomerTlf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spisanieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phonesDataSet = new PhoneForms.PhonesDataSet();
            this.spisanieTableAdapter = new PhoneForms.PhonesDataSetTableAdapters.SpisanieTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spisanieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.modelDataGridViewTextBoxColumn,
            this.gloginDataGridViewTextBoxColumn,
            this.gpassDataGridViewTextBoxColumn,
            this.fIODataGridViewTextBoxColumn,
            this.datespisaniyaDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.Comm,
            this.NomerTlf});
            this.dataGridView1.DataSource = this.spisanieBindingSource;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(822, 204);
            this.dataGridView1.TabIndex = 0;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // gloginDataGridViewTextBoxColumn
            // 
            this.gloginDataGridViewTextBoxColumn.DataPropertyName = "Glogin";
            this.gloginDataGridViewTextBoxColumn.HeaderText = "Glogin";
            this.gloginDataGridViewTextBoxColumn.Name = "gloginDataGridViewTextBoxColumn";
            // 
            // gpassDataGridViewTextBoxColumn
            // 
            this.gpassDataGridViewTextBoxColumn.DataPropertyName = "Gpass";
            this.gpassDataGridViewTextBoxColumn.HeaderText = "Gpass";
            this.gpassDataGridViewTextBoxColumn.Name = "gpassDataGridViewTextBoxColumn";
            // 
            // fIODataGridViewTextBoxColumn
            // 
            this.fIODataGridViewTextBoxColumn.DataPropertyName = "FIO";
            this.fIODataGridViewTextBoxColumn.HeaderText = "FIO";
            this.fIODataGridViewTextBoxColumn.Name = "fIODataGridViewTextBoxColumn";
            // 
            // datespisaniyaDataGridViewTextBoxColumn
            // 
            this.datespisaniyaDataGridViewTextBoxColumn.DataPropertyName = "Date_spisaniya";
            this.datespisaniyaDataGridViewTextBoxColumn.HeaderText = "Date_spisaniya";
            this.datespisaniyaDataGridViewTextBoxColumn.Name = "datespisaniyaDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // Comm
            // 
            this.Comm.HeaderText = "Коментарий";
            this.Comm.Name = "Comm";
            // 
            // NomerTlf
            // 
            this.NomerTlf.HeaderText = "Номер Телефона";
            this.NomerTlf.Name = "NomerTlf";
            // 
            // spisanieBindingSource
            // 
            this.spisanieBindingSource.DataMember = "Spisanie";
            this.spisanieBindingSource.DataSource = this.phonesDataSet;
            // 
            // phonesDataSet
            // 
            this.phonesDataSet.DataSetName = "PhonesDataSet";
            this.phonesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spisanieTableAdapter
            // 
            this.spisanieTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SpisokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhoneForms.Properties.Resources.Rpbjm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(846, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SpisokForm";
            this.Text = "SpisokForm";
            this.Load += new System.EventHandler(this.SpisokForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spisanieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PhonesDataSet phonesDataSet;
        private System.Windows.Forms.BindingSource spisanieBindingSource;
        private PhonesDataSetTableAdapters.SpisanieTableAdapter spisanieTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gloginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gpassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datespisaniyaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comm;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomerTlf;
        private System.Windows.Forms.Button button1;
    }
}