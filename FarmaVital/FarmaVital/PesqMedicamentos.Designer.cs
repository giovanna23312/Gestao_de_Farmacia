namespace FarmaVital
{
    partial class PesqMedicamentos
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
            this.medcodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mednmMedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medNMedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meddescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medcategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medmarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medDtFabriDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medDtValiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medqtdeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medPreçUnidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medPreçVenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medLucroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medicamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmaDataSet = new FarmaVital.FarmaDataSet();
            this.medicamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicamentoTableAdapter = new FarmaVital.FarmaDataSetTableAdapters.medicamentoTableAdapter();
            this.medicamentosTableAdapter = new FarmaVital.FarmaDataSetTableAdapters.medicamentosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.medcodDataGridViewTextBoxColumn,
            this.mednmMedDataGridViewTextBoxColumn,
            this.medNMedDataGridViewTextBoxColumn,
            this.meddescDataGridViewTextBoxColumn,
            this.medcategoriaDataGridViewTextBoxColumn,
            this.medmarcaDataGridViewTextBoxColumn,
            this.medDtFabriDataGridViewTextBoxColumn,
            this.medDtValiDataGridViewTextBoxColumn,
            this.medqtdeDataGridViewTextBoxColumn,
            this.medPreçUnidDataGridViewTextBoxColumn,
            this.medPreçVenDataGridViewTextBoxColumn,
            this.medLucroDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.medicamentosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 199);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(840, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // medcodDataGridViewTextBoxColumn
            // 
            this.medcodDataGridViewTextBoxColumn.DataPropertyName = "Med_cod";
            this.medcodDataGridViewTextBoxColumn.HeaderText = "Med_cod";
            this.medcodDataGridViewTextBoxColumn.Name = "medcodDataGridViewTextBoxColumn";
            this.medcodDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mednmMedDataGridViewTextBoxColumn
            // 
            this.mednmMedDataGridViewTextBoxColumn.DataPropertyName = "Med_nmMed";
            this.mednmMedDataGridViewTextBoxColumn.HeaderText = "Med_nmMed";
            this.mednmMedDataGridViewTextBoxColumn.Name = "mednmMedDataGridViewTextBoxColumn";
            // 
            // medNMedDataGridViewTextBoxColumn
            // 
            this.medNMedDataGridViewTextBoxColumn.DataPropertyName = "Med_NMed";
            this.medNMedDataGridViewTextBoxColumn.HeaderText = "Med_NMed";
            this.medNMedDataGridViewTextBoxColumn.Name = "medNMedDataGridViewTextBoxColumn";
            // 
            // meddescDataGridViewTextBoxColumn
            // 
            this.meddescDataGridViewTextBoxColumn.DataPropertyName = "Med_desc";
            this.meddescDataGridViewTextBoxColumn.HeaderText = "Med_desc";
            this.meddescDataGridViewTextBoxColumn.Name = "meddescDataGridViewTextBoxColumn";
            // 
            // medcategoriaDataGridViewTextBoxColumn
            // 
            this.medcategoriaDataGridViewTextBoxColumn.DataPropertyName = "Med_categoria";
            this.medcategoriaDataGridViewTextBoxColumn.HeaderText = "Med_categoria";
            this.medcategoriaDataGridViewTextBoxColumn.Name = "medcategoriaDataGridViewTextBoxColumn";
            // 
            // medmarcaDataGridViewTextBoxColumn
            // 
            this.medmarcaDataGridViewTextBoxColumn.DataPropertyName = "Med_marca";
            this.medmarcaDataGridViewTextBoxColumn.HeaderText = "Med_marca";
            this.medmarcaDataGridViewTextBoxColumn.Name = "medmarcaDataGridViewTextBoxColumn";
            // 
            // medDtFabriDataGridViewTextBoxColumn
            // 
            this.medDtFabriDataGridViewTextBoxColumn.DataPropertyName = "Med_DtFabri";
            this.medDtFabriDataGridViewTextBoxColumn.HeaderText = "Med_DtFabri";
            this.medDtFabriDataGridViewTextBoxColumn.Name = "medDtFabriDataGridViewTextBoxColumn";
            // 
            // medDtValiDataGridViewTextBoxColumn
            // 
            this.medDtValiDataGridViewTextBoxColumn.DataPropertyName = "Med_DtVali";
            this.medDtValiDataGridViewTextBoxColumn.HeaderText = "Med_DtVali";
            this.medDtValiDataGridViewTextBoxColumn.Name = "medDtValiDataGridViewTextBoxColumn";
            // 
            // medqtdeDataGridViewTextBoxColumn
            // 
            this.medqtdeDataGridViewTextBoxColumn.DataPropertyName = "Med_qtde";
            this.medqtdeDataGridViewTextBoxColumn.HeaderText = "Med_qtde";
            this.medqtdeDataGridViewTextBoxColumn.Name = "medqtdeDataGridViewTextBoxColumn";
            // 
            // medPreçUnidDataGridViewTextBoxColumn
            // 
            this.medPreçUnidDataGridViewTextBoxColumn.DataPropertyName = "Med_PreçUnid";
            this.medPreçUnidDataGridViewTextBoxColumn.HeaderText = "Med_PreçUnid";
            this.medPreçUnidDataGridViewTextBoxColumn.Name = "medPreçUnidDataGridViewTextBoxColumn";
            // 
            // medPreçVenDataGridViewTextBoxColumn
            // 
            this.medPreçVenDataGridViewTextBoxColumn.DataPropertyName = "Med_PreçVen";
            this.medPreçVenDataGridViewTextBoxColumn.HeaderText = "Med_PreçVen";
            this.medPreçVenDataGridViewTextBoxColumn.Name = "medPreçVenDataGridViewTextBoxColumn";
            // 
            // medLucroDataGridViewTextBoxColumn
            // 
            this.medLucroDataGridViewTextBoxColumn.DataPropertyName = "med_Lucro";
            this.medLucroDataGridViewTextBoxColumn.HeaderText = "med_Lucro";
            this.medLucroDataGridViewTextBoxColumn.Name = "medLucroDataGridViewTextBoxColumn";
            // 
            // medicamentosBindingSource
            // 
            this.medicamentosBindingSource.DataMember = "medicamentos";
            this.medicamentosBindingSource.DataSource = this.farmaDataSet;
            // 
            // farmaDataSet
            // 
            this.farmaDataSet.DataSetName = "FarmaDataSet";
            this.farmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicamentoBindingSource
            // 
            this.medicamentoBindingSource.DataMember = "medicamento";
            this.medicamentoBindingSource.DataSource = this.farmaDataSet;
            // 
            // medicamentoTableAdapter
            // 
            this.medicamentoTableAdapter.ClearBeforeFill = true;
            // 
            // medicamentosTableAdapter
            // 
            this.medicamentosTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar Medicamento";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(72, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(621, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Pesquisa de Medicamento";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Location = new System.Drawing.Point(285, 32);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(342, 1);
            this.panel6.TabIndex = 45;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 1);
            this.panel1.TabIndex = 10;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button7.Location = new System.Drawing.Point(417, 470);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 32);
            this.button7.TabIndex = 50;
            this.button7.Text = "Alterar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(286, 447);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 1);
            this.panel2.TabIndex = 47;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(541, 470);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 32);
            this.button3.TabIndex = 49;
            this.button3.Text = "Deletar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(709, 139);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 32);
            this.button1.TabIndex = 51;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button5.Location = new System.Drawing.Point(286, 470);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 32);
            this.button5.TabIndex = 48;
            this.button5.Text = "Cadastrar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::FarmaVital.Properties.Resources.My_project_1__9_;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(2, 513);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 38);
            this.button2.TabIndex = 52;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // PesqMedicamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(905, 553);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PesqMedicamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesqMedicamentos ADM";
            this.Load += new System.EventHandler(this.PesqMedicamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FarmaDataSet farmaDataSet;
        private System.Windows.Forms.BindingSource medicamentoBindingSource;
        private FarmaDataSetTableAdapters.medicamentoTableAdapter medicamentoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn medcodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mednmMedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medNMedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meddescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medcategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medmarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medDtFabriDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medDtValiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medqtdeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medPreçUnidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medPreçVenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn medLucroDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource medicamentosBindingSource;
        private FarmaDataSetTableAdapters.medicamentosTableAdapter medicamentosTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
    }
}