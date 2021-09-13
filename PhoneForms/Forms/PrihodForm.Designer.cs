namespace PhoneForms.Forms
{
    partial class PrihodForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.phonesDataSet1 = new PhoneForms.PhonesDataSet();
            this.comingTableAdapter1 = new PhoneForms.PhonesDataSetTableAdapters.ComingTableAdapter();
            this.view_ComingTableAdapter1 = new PhoneForms.PhonesDataSetTableAdapters.View_ComingTableAdapter();
            this.comingBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comingBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataprihodaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shopDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fIOOperatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolvoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comingBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.phonesDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comingBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comingBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comingBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(118, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 117);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(118, 117);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Дата прихода";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Магазин продавец";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Оператор";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Кол-во";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Цена";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Сделать запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // phonesDataSet1
            // 
            this.phonesDataSet1.DataSetName = "PhonesDataSet";
            this.phonesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comingTableAdapter1
            // 
            this.comingTableAdapter1.ClearBeforeFill = true;
            // 
            // view_ComingTableAdapter1
            // 
            this.view_ComingTableAdapter1.ClearBeforeFill = true;
            // 
            // comingBindingSource2
            // 
            this.comingBindingSource2.DataMember = "Coming";
            this.comingBindingSource2.DataSource = this.phonesDataSet1;
            // 
            // comingBindingSource
            // 
            this.comingBindingSource.DataMember = "Coming";
            this.comingBindingSource.DataSource = this.phonesDataSet1;
            // 
            // comingBindingSource1
            // 
            this.comingBindingSource1.DataMember = "Coming";
            this.comingBindingSource1.DataSource = this.phonesDataSet1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Iphone8",
            "Iphone7",
            "Redmi Note 9",
            "Galaxy A50",
            "Dexp AW12"});
            this.comboBox1.Location = new System.Drawing.Point(118, 145);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(103, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Модель телефона";
            // 
            // comingBindingSource3
            // 
            this.comingBindingSource3.DataMember = "Coming";
            this.comingBindingSource3.DataSource = this.phonesDataSet1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idopDataGridViewTextBoxColumn,
            this.dataprihodaDataGridViewTextBoxColumn,
            this.shopDataGridViewTextBoxColumn,
            this.fIOOperatorDataGridViewTextBoxColumn,
            this.phoneModelDataGridViewTextBoxColumn,
            this.kolvoDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.comingBindingSource4;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(222, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(723, 179);
            this.dataGridView1.TabIndex = 17;
            // 
            // idopDataGridViewTextBoxColumn
            // 
            this.idopDataGridViewTextBoxColumn.DataPropertyName = "Id_op";
            this.idopDataGridViewTextBoxColumn.HeaderText = "Id_op";
            this.idopDataGridViewTextBoxColumn.Name = "idopDataGridViewTextBoxColumn";
            this.idopDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataprihodaDataGridViewTextBoxColumn
            // 
            this.dataprihodaDataGridViewTextBoxColumn.DataPropertyName = "Data_prihoda";
            this.dataprihodaDataGridViewTextBoxColumn.HeaderText = "Data_prihoda";
            this.dataprihodaDataGridViewTextBoxColumn.Name = "dataprihodaDataGridViewTextBoxColumn";
            // 
            // shopDataGridViewTextBoxColumn
            // 
            this.shopDataGridViewTextBoxColumn.DataPropertyName = "Shop";
            this.shopDataGridViewTextBoxColumn.HeaderText = "Shop";
            this.shopDataGridViewTextBoxColumn.Name = "shopDataGridViewTextBoxColumn";
            // 
            // fIOOperatorDataGridViewTextBoxColumn
            // 
            this.fIOOperatorDataGridViewTextBoxColumn.DataPropertyName = "FIO operator";
            this.fIOOperatorDataGridViewTextBoxColumn.HeaderText = "FIO operator";
            this.fIOOperatorDataGridViewTextBoxColumn.Name = "fIOOperatorDataGridViewTextBoxColumn";
            // 
            // phoneModelDataGridViewTextBoxColumn
            // 
            this.phoneModelDataGridViewTextBoxColumn.DataPropertyName = "Phone_Model";
            this.phoneModelDataGridViewTextBoxColumn.HeaderText = "Phone_Model";
            this.phoneModelDataGridViewTextBoxColumn.Name = "phoneModelDataGridViewTextBoxColumn";
            // 
            // kolvoDataGridViewTextBoxColumn
            // 
            this.kolvoDataGridViewTextBoxColumn.DataPropertyName = "Kol-vo";
            this.kolvoDataGridViewTextBoxColumn.HeaderText = "Kol-vo";
            this.kolvoDataGridViewTextBoxColumn.Name = "kolvoDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // comingBindingSource4
            // 
            this.comingBindingSource4.DataMember = "Coming";
            this.comingBindingSource4.DataSource = this.phonesDataSet1;
            // 
            // PrihodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhoneForms.Properties.Resources.Rpbjm;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 237);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "PrihodForm";
            this.Text = "PrihodForm";
            this.Load += new System.EventHandler(this.PrihodForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phonesDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comingBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comingBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comingBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private PhonesDataSet phonesDataSet1;
        private PhonesDataSetTableAdapters.ComingTableAdapter comingTableAdapter1;
        private PhonesDataSetTableAdapters.View_ComingTableAdapter view_ComingTableAdapter1;
        private System.Windows.Forms.BindingSource comingBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneModel;
        private System.Windows.Forms.BindingSource comingBindingSource2;
        private System.Windows.Forms.BindingSource comingBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;

        #endregion

        private System.Windows.Forms.BindingSource comingBindingSource3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataprihodaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shopDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fIOOperatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolvoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource comingBindingSource4;
    }
}