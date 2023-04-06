namespace FarmaVital
{
    partial class PesqCliente
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
            this.cliecdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliesnmDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliecpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliergDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliedtnascDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clietelefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliecelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienumcasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliebairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliecidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliecepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clieufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cliesexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmaDataSet = new FarmaVital.FarmaDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.clienteTableAdapter = new FarmaVital.FarmaDataSetTableAdapters.clienteTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaDataSet)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cliecdDataGridViewTextBoxColumn,
            this.clienmDataGridViewTextBoxColumn,
            this.cliesnmDataGridViewTextBoxColumn,
            this.cliecpfDataGridViewTextBoxColumn,
            this.cliergDataGridViewTextBoxColumn,
            this.cliedtnascDataGridViewTextBoxColumn,
            this.clieendDataGridViewTextBoxColumn,
            this.clieemailDataGridViewTextBoxColumn,
            this.clietelefoneDataGridViewTextBoxColumn,
            this.cliecelularDataGridViewTextBoxColumn,
            this.clienumcasaDataGridViewTextBoxColumn,
            this.cliebairroDataGridViewTextBoxColumn,
            this.cliecidadeDataGridViewTextBoxColumn,
            this.cliecepDataGridViewTextBoxColumn,
            this.clieufDataGridViewTextBoxColumn,
            this.cliesexoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.clienteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 207);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(744, 256);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cliecdDataGridViewTextBoxColumn
            // 
            this.cliecdDataGridViewTextBoxColumn.DataPropertyName = "clie_cd";
            this.cliecdDataGridViewTextBoxColumn.HeaderText = "clie_cd";
            this.cliecdDataGridViewTextBoxColumn.Name = "cliecdDataGridViewTextBoxColumn";
            this.cliecdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clienmDataGridViewTextBoxColumn
            // 
            this.clienmDataGridViewTextBoxColumn.DataPropertyName = "clie_nm";
            this.clienmDataGridViewTextBoxColumn.HeaderText = "clie_nm";
            this.clienmDataGridViewTextBoxColumn.Name = "clienmDataGridViewTextBoxColumn";
            // 
            // cliesnmDataGridViewTextBoxColumn
            // 
            this.cliesnmDataGridViewTextBoxColumn.DataPropertyName = "clie_snm";
            this.cliesnmDataGridViewTextBoxColumn.HeaderText = "clie_snm";
            this.cliesnmDataGridViewTextBoxColumn.Name = "cliesnmDataGridViewTextBoxColumn";
            // 
            // cliecpfDataGridViewTextBoxColumn
            // 
            this.cliecpfDataGridViewTextBoxColumn.DataPropertyName = "clie_cpf";
            this.cliecpfDataGridViewTextBoxColumn.HeaderText = "clie_cpf";
            this.cliecpfDataGridViewTextBoxColumn.Name = "cliecpfDataGridViewTextBoxColumn";
            // 
            // cliergDataGridViewTextBoxColumn
            // 
            this.cliergDataGridViewTextBoxColumn.DataPropertyName = "clie_rg";
            this.cliergDataGridViewTextBoxColumn.HeaderText = "clie_rg";
            this.cliergDataGridViewTextBoxColumn.Name = "cliergDataGridViewTextBoxColumn";
            // 
            // cliedtnascDataGridViewTextBoxColumn
            // 
            this.cliedtnascDataGridViewTextBoxColumn.DataPropertyName = "clie_dtnasc";
            this.cliedtnascDataGridViewTextBoxColumn.HeaderText = "clie_dtnasc";
            this.cliedtnascDataGridViewTextBoxColumn.Name = "cliedtnascDataGridViewTextBoxColumn";
            // 
            // clieendDataGridViewTextBoxColumn
            // 
            this.clieendDataGridViewTextBoxColumn.DataPropertyName = "clie_end";
            this.clieendDataGridViewTextBoxColumn.HeaderText = "clie_end";
            this.clieendDataGridViewTextBoxColumn.Name = "clieendDataGridViewTextBoxColumn";
            // 
            // clieemailDataGridViewTextBoxColumn
            // 
            this.clieemailDataGridViewTextBoxColumn.DataPropertyName = "clie_email";
            this.clieemailDataGridViewTextBoxColumn.HeaderText = "clie_email";
            this.clieemailDataGridViewTextBoxColumn.Name = "clieemailDataGridViewTextBoxColumn";
            // 
            // clietelefoneDataGridViewTextBoxColumn
            // 
            this.clietelefoneDataGridViewTextBoxColumn.DataPropertyName = "clie_telefone";
            this.clietelefoneDataGridViewTextBoxColumn.HeaderText = "clie_telefone";
            this.clietelefoneDataGridViewTextBoxColumn.Name = "clietelefoneDataGridViewTextBoxColumn";
            // 
            // cliecelularDataGridViewTextBoxColumn
            // 
            this.cliecelularDataGridViewTextBoxColumn.DataPropertyName = "clie_celular";
            this.cliecelularDataGridViewTextBoxColumn.HeaderText = "clie_celular";
            this.cliecelularDataGridViewTextBoxColumn.Name = "cliecelularDataGridViewTextBoxColumn";
            // 
            // clienumcasaDataGridViewTextBoxColumn
            // 
            this.clienumcasaDataGridViewTextBoxColumn.DataPropertyName = "clie_numcasa";
            this.clienumcasaDataGridViewTextBoxColumn.HeaderText = "clie_numcasa";
            this.clienumcasaDataGridViewTextBoxColumn.Name = "clienumcasaDataGridViewTextBoxColumn";
            // 
            // cliebairroDataGridViewTextBoxColumn
            // 
            this.cliebairroDataGridViewTextBoxColumn.DataPropertyName = "clie_bairro";
            this.cliebairroDataGridViewTextBoxColumn.HeaderText = "clie_bairro";
            this.cliebairroDataGridViewTextBoxColumn.Name = "cliebairroDataGridViewTextBoxColumn";
            // 
            // cliecidadeDataGridViewTextBoxColumn
            // 
            this.cliecidadeDataGridViewTextBoxColumn.DataPropertyName = "clie_cidade";
            this.cliecidadeDataGridViewTextBoxColumn.HeaderText = "clie_cidade";
            this.cliecidadeDataGridViewTextBoxColumn.Name = "cliecidadeDataGridViewTextBoxColumn";
            // 
            // cliecepDataGridViewTextBoxColumn
            // 
            this.cliecepDataGridViewTextBoxColumn.DataPropertyName = "clie_cep";
            this.cliecepDataGridViewTextBoxColumn.HeaderText = "clie_cep";
            this.cliecepDataGridViewTextBoxColumn.Name = "cliecepDataGridViewTextBoxColumn";
            // 
            // clieufDataGridViewTextBoxColumn
            // 
            this.clieufDataGridViewTextBoxColumn.DataPropertyName = "clie_uf";
            this.clieufDataGridViewTextBoxColumn.HeaderText = "clie_uf";
            this.clieufDataGridViewTextBoxColumn.Name = "clieufDataGridViewTextBoxColumn";
            // 
            // cliesexoDataGridViewTextBoxColumn
            // 
            this.cliesexoDataGridViewTextBoxColumn.DataPropertyName = "clie_sexo";
            this.cliesexoDataGridViewTextBoxColumn.HeaderText = "clie_sexo";
            this.cliesexoDataGridViewTextBoxColumn.Name = "cliesexoDataGridViewTextBoxColumn";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.farmaDataSet;
            // 
            // farmaDataSet
            // 
            this.farmaDataSet.DataSetName = "FarmaDataSet";
            this.farmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisar CPF";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 166);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(555, 20);
            this.textBox1.TabIndex = 3;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(203, 502);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 1);
            this.panel2.TabIndex = 35;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(407, 528);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 32);
            this.button3.TabIndex = 37;
            this.button3.Text = "Deletar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button7.Location = new System.Drawing.Point(232, 527);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 32);
            this.button7.TabIndex = 39;
            this.button7.Text = "Alterar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button5.Location = new System.Drawing.Point(589, 159);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 32);
            this.button5.TabIndex = 40;
            this.button5.Text = "Pesquisar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(273, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Pesquisa de Cliente";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Location = new System.Drawing.Point(203, 47);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(342, 1);
            this.panel6.TabIndex = 41;
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
            // PesqCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(867, 655);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PesqCliente";
            this.Text = "PesqCliente";
            this.Load += new System.EventHandler(this.PesqCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaDataSet)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private FarmaDataSet farmaDataSet;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private FarmaDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliecdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliesnmDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliecpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliergDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliedtnascDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clietelefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliecelularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clienumcasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliebairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliecidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliecepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clieufDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cliesexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
    }
}