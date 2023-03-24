namespace FarmaVital
{
    partial class AlterFabricante
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.farmaDataSet = new FarmaVital.FarmaDataSet();
            this.fabricanteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fabricanteTableAdapter = new FarmaVital.FarmaDataSetTableAdapters.fabricanteTableAdapter();
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
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricanteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
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
            this.dataGridView1.Location = new System.Drawing.Point(39, 226);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(728, 171);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pesquisa por Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Pesquisa por Nome Fantasia";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(440, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 175);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Pesquisar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(144, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(144, 175);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(232, 20);
            this.textBox2.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(558, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Alterar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(558, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Alterar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // farmaDataSet
            // 
            this.farmaDataSet.DataSetName = "FarmaDataSet";
            this.farmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fabricanteBindingSource
            // 
            this.fabricanteBindingSource.DataMember = "fabricante";
            this.fabricanteBindingSource.DataSource = this.farmaDataSet;
            // 
            // fabricanteTableAdapter
            // 
            this.fabricanteTableAdapter.ClearBeforeFill = true;
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
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(674, 98);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Deletar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(674, 172);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Deletar";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // AlterFabricante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AlterFabricante";
            this.Text = "AlterFabricante";
            this.Load += new System.EventHandler(this.AlterFabricante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fabricanteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}