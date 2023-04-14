namespace FarmaVital
{
    partial class PesqFabricante
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
            this.fabricdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabrinmfanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabriRSocailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricnpjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabriIscEstDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabriIsMunicipalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabrirepreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabriendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabrinumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricomplementoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabribairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabriestadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabritel1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabritel2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabriemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmaDataSet = new FarmaVital.FarmaDataSet();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.fabricanteTableAdapter = new FarmaVital.FarmaDataSetTableAdapters.fabricanteTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricanteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaDataSet)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fabricdDataGridViewTextBoxColumn,
            this.fabrinmfanDataGridViewTextBoxColumn,
            this.fabriRSocailDataGridViewTextBoxColumn,
            this.fabricnpjDataGridViewTextBoxColumn,
            this.fabriIscEstDataGridViewTextBoxColumn,
            this.fabriIsMunicipalDataGridViewTextBoxColumn,
            this.fabrirepreDataGridViewTextBoxColumn,
            this.fabriendDataGridViewTextBoxColumn,
            this.fabrinumDataGridViewTextBoxColumn,
            this.fabricepDataGridViewTextBoxColumn,
            this.fabricomplementoDataGridViewTextBoxColumn,
            this.fabribairroDataGridViewTextBoxColumn,
            this.fabricidadeDataGridViewTextBoxColumn,
            this.fabriestadoDataGridViewTextBoxColumn,
            this.fabritel1DataGridViewTextBoxColumn,
            this.fabritel2DataGridViewTextBoxColumn,
            this.fabriemailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fabricanteBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 211);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(844, 191);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // fabricdDataGridViewTextBoxColumn
            // 
            this.fabricdDataGridViewTextBoxColumn.DataPropertyName = "fabri_cd";
            this.fabricdDataGridViewTextBoxColumn.HeaderText = "fabri_cd";
            this.fabricdDataGridViewTextBoxColumn.Name = "fabricdDataGridViewTextBoxColumn";
            this.fabricdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fabrinmfanDataGridViewTextBoxColumn
            // 
            this.fabrinmfanDataGridViewTextBoxColumn.DataPropertyName = "fabri_nmfan";
            this.fabrinmfanDataGridViewTextBoxColumn.HeaderText = "fabri_nmfan";
            this.fabrinmfanDataGridViewTextBoxColumn.Name = "fabrinmfanDataGridViewTextBoxColumn";
            // 
            // fabriRSocailDataGridViewTextBoxColumn
            // 
            this.fabriRSocailDataGridViewTextBoxColumn.DataPropertyName = "fabri_RSocail";
            this.fabriRSocailDataGridViewTextBoxColumn.HeaderText = "fabri_RSocail";
            this.fabriRSocailDataGridViewTextBoxColumn.Name = "fabriRSocailDataGridViewTextBoxColumn";
            // 
            // fabricnpjDataGridViewTextBoxColumn
            // 
            this.fabricnpjDataGridViewTextBoxColumn.DataPropertyName = "fabri_cnpj";
            this.fabricnpjDataGridViewTextBoxColumn.HeaderText = "fabri_cnpj";
            this.fabricnpjDataGridViewTextBoxColumn.Name = "fabricnpjDataGridViewTextBoxColumn";
            // 
            // fabriIscEstDataGridViewTextBoxColumn
            // 
            this.fabriIscEstDataGridViewTextBoxColumn.DataPropertyName = "fabri_IscEst";
            this.fabriIscEstDataGridViewTextBoxColumn.HeaderText = "fabri_IscEst";
            this.fabriIscEstDataGridViewTextBoxColumn.Name = "fabriIscEstDataGridViewTextBoxColumn";
            // 
            // fabriIsMunicipalDataGridViewTextBoxColumn
            // 
            this.fabriIsMunicipalDataGridViewTextBoxColumn.DataPropertyName = "fabri_IsMunicipal";
            this.fabriIsMunicipalDataGridViewTextBoxColumn.HeaderText = "fabri_IsMunicipal";
            this.fabriIsMunicipalDataGridViewTextBoxColumn.Name = "fabriIsMunicipalDataGridViewTextBoxColumn";
            // 
            // fabrirepreDataGridViewTextBoxColumn
            // 
            this.fabrirepreDataGridViewTextBoxColumn.DataPropertyName = "fabri_repre";
            this.fabrirepreDataGridViewTextBoxColumn.HeaderText = "fabri_repre";
            this.fabrirepreDataGridViewTextBoxColumn.Name = "fabrirepreDataGridViewTextBoxColumn";
            // 
            // fabriendDataGridViewTextBoxColumn
            // 
            this.fabriendDataGridViewTextBoxColumn.DataPropertyName = "fabri_end";
            this.fabriendDataGridViewTextBoxColumn.HeaderText = "fabri_end";
            this.fabriendDataGridViewTextBoxColumn.Name = "fabriendDataGridViewTextBoxColumn";
            // 
            // fabrinumDataGridViewTextBoxColumn
            // 
            this.fabrinumDataGridViewTextBoxColumn.DataPropertyName = "fabri_num";
            this.fabrinumDataGridViewTextBoxColumn.HeaderText = "fabri_num";
            this.fabrinumDataGridViewTextBoxColumn.Name = "fabrinumDataGridViewTextBoxColumn";
            // 
            // fabricepDataGridViewTextBoxColumn
            // 
            this.fabricepDataGridViewTextBoxColumn.DataPropertyName = "fabri_cep";
            this.fabricepDataGridViewTextBoxColumn.HeaderText = "fabri_cep";
            this.fabricepDataGridViewTextBoxColumn.Name = "fabricepDataGridViewTextBoxColumn";
            // 
            // fabricomplementoDataGridViewTextBoxColumn
            // 
            this.fabricomplementoDataGridViewTextBoxColumn.DataPropertyName = "fabri_complemento";
            this.fabricomplementoDataGridViewTextBoxColumn.HeaderText = "fabri_complemento";
            this.fabricomplementoDataGridViewTextBoxColumn.Name = "fabricomplementoDataGridViewTextBoxColumn";
            // 
            // fabribairroDataGridViewTextBoxColumn
            // 
            this.fabribairroDataGridViewTextBoxColumn.DataPropertyName = "fabri_bairro";
            this.fabribairroDataGridViewTextBoxColumn.HeaderText = "fabri_bairro";
            this.fabribairroDataGridViewTextBoxColumn.Name = "fabribairroDataGridViewTextBoxColumn";
            // 
            // fabricidadeDataGridViewTextBoxColumn
            // 
            this.fabricidadeDataGridViewTextBoxColumn.DataPropertyName = "fabri_cidade";
            this.fabricidadeDataGridViewTextBoxColumn.HeaderText = "fabri_cidade";
            this.fabricidadeDataGridViewTextBoxColumn.Name = "fabricidadeDataGridViewTextBoxColumn";
            // 
            // fabriestadoDataGridViewTextBoxColumn
            // 
            this.fabriestadoDataGridViewTextBoxColumn.DataPropertyName = "fabri_estado";
            this.fabriestadoDataGridViewTextBoxColumn.HeaderText = "fabri_estado";
            this.fabriestadoDataGridViewTextBoxColumn.Name = "fabriestadoDataGridViewTextBoxColumn";
            // 
            // fabritel1DataGridViewTextBoxColumn
            // 
            this.fabritel1DataGridViewTextBoxColumn.DataPropertyName = "fabri_tel1";
            this.fabritel1DataGridViewTextBoxColumn.HeaderText = "fabri_tel1";
            this.fabritel1DataGridViewTextBoxColumn.Name = "fabritel1DataGridViewTextBoxColumn";
            // 
            // fabritel2DataGridViewTextBoxColumn
            // 
            this.fabritel2DataGridViewTextBoxColumn.DataPropertyName = "fabri_tel2";
            this.fabritel2DataGridViewTextBoxColumn.HeaderText = "fabri_tel2";
            this.fabritel2DataGridViewTextBoxColumn.Name = "fabritel2DataGridViewTextBoxColumn";
            // 
            // fabriemailDataGridViewTextBoxColumn
            // 
            this.fabriemailDataGridViewTextBoxColumn.DataPropertyName = "fabri_email";
            this.fabriemailDataGridViewTextBoxColumn.HeaderText = "fabri_email";
            this.fabriemailDataGridViewTextBoxColumn.Name = "fabriemailDataGridViewTextBoxColumn";
            // 
            // fabricanteBindingSource
            // 
            this.fabricanteBindingSource.DataMember = "fabricante";
            this.fabricanteBindingSource.DataSource = this.farmaDataSet;
            // 
            // farmaDataSet
            // 
            this.farmaDataSet.DataSetName = "FarmaDataSet";
            this.farmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pesquisa  Nome Fantasia";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(90, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(603, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // fabricanteTableAdapter
            // 
            this.fabricanteTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(292, 428);
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
            this.button3.Location = new System.Drawing.Point(578, 453);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 32);
            this.button3.TabIndex = 37;
            this.button3.Text = "Deletar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button5.Location = new System.Drawing.Point(268, 453);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(99, 32);
            this.button5.TabIndex = 36;
            this.button5.Text = "Cadastrar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button7.Location = new System.Drawing.Point(423, 453);
            this.button7.Margin = new System.Windows.Forms.Padding(2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(99, 32);
            this.button7.TabIndex = 38;
            this.button7.Text = "Alterar";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 25);
            this.label1.TabIndex = 44;
            this.label1.Text = "Pesquisa de Fabricante";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Location = new System.Drawing.Point(292, 35);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(342, 1);
            this.panel6.TabIndex = 43;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(721, 156);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 32);
            this.button2.TabIndex = 45;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::FarmaVital.Properties.Resources.My_project_1__9_;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(2, 513);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 38);
            this.button1.TabIndex = 53;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // PesqFabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(905, 553);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PesqFabricante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlterFabricante";
            this.Load += new System.EventHandler(this.AlterFabricante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricanteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaDataSet)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private FarmaDataSet farmaDataSet;
        private System.Windows.Forms.BindingSource fabricanteBindingSource;
        private FarmaDataSetTableAdapters.fabricanteTableAdapter fabricanteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabrinmfanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabriRSocailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricnpjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabriIscEstDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabriIsMunicipalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabrirepreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabriendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabrinumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricomplementoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabribairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabriestadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabritel1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabritel2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabriemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}