namespace FarmaVital
{
    partial class PesqFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesqFuncionarios));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.funcdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funnomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funsobrenmeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funrgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fundtNascDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funnumcasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funtelefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funbairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funuserDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funsenhaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.farmaDataSet = new FarmaVital.FarmaDataSet();
            this.funcionariosTableAdapter = new FarmaVital.FarmaDataSetTableAdapters.funcionariosTableAdapter();
            this.button5 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button7 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaDataSet)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(171, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pesquisa CPF";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(174, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(585, 20);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.funcdDataGridViewTextBoxColumn,
            this.funnomeDataGridViewTextBoxColumn,
            this.funsobrenmeDataGridViewTextBoxColumn,
            this.funcpfDataGridViewTextBoxColumn,
            this.funrgDataGridViewTextBoxColumn,
            this.fundtNascDataGridViewTextBoxColumn,
            this.funendDataGridViewTextBoxColumn,
            this.funnumcasaDataGridViewTextBoxColumn,
            this.funtelefoneDataGridViewTextBoxColumn,
            this.funcelularDataGridViewTextBoxColumn,
            this.funemailDataGridViewTextBoxColumn,
            this.funbairroDataGridViewTextBoxColumn,
            this.funcidadeDataGridViewTextBoxColumn,
            this.funufDataGridViewTextBoxColumn,
            this.funcepDataGridViewTextBoxColumn,
            this.funcargoDataGridViewTextBoxColumn,
            this.funuserDataGridViewTextBoxColumn,
            this.funsenhaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.funcionariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(136, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(742, 164);
            this.dataGridView1.TabIndex = 3;
            // 
            // funcdDataGridViewTextBoxColumn
            // 
            this.funcdDataGridViewTextBoxColumn.DataPropertyName = "Fun_cd";
            this.funcdDataGridViewTextBoxColumn.HeaderText = "Fun_cd";
            this.funcdDataGridViewTextBoxColumn.Name = "funcdDataGridViewTextBoxColumn";
            this.funcdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // funnomeDataGridViewTextBoxColumn
            // 
            this.funnomeDataGridViewTextBoxColumn.DataPropertyName = "Fun_nome";
            this.funnomeDataGridViewTextBoxColumn.HeaderText = "Fun_nome";
            this.funnomeDataGridViewTextBoxColumn.Name = "funnomeDataGridViewTextBoxColumn";
            // 
            // funsobrenmeDataGridViewTextBoxColumn
            // 
            this.funsobrenmeDataGridViewTextBoxColumn.DataPropertyName = "Fun_sobrenme";
            this.funsobrenmeDataGridViewTextBoxColumn.HeaderText = "Fun_sobrenme";
            this.funsobrenmeDataGridViewTextBoxColumn.Name = "funsobrenmeDataGridViewTextBoxColumn";
            // 
            // funcpfDataGridViewTextBoxColumn
            // 
            this.funcpfDataGridViewTextBoxColumn.DataPropertyName = "Fun_cpf";
            this.funcpfDataGridViewTextBoxColumn.HeaderText = "Fun_cpf";
            this.funcpfDataGridViewTextBoxColumn.Name = "funcpfDataGridViewTextBoxColumn";
            // 
            // funrgDataGridViewTextBoxColumn
            // 
            this.funrgDataGridViewTextBoxColumn.DataPropertyName = "Fun_rg";
            this.funrgDataGridViewTextBoxColumn.HeaderText = "Fun_rg";
            this.funrgDataGridViewTextBoxColumn.Name = "funrgDataGridViewTextBoxColumn";
            // 
            // fundtNascDataGridViewTextBoxColumn
            // 
            this.fundtNascDataGridViewTextBoxColumn.DataPropertyName = "Fun_dtNasc";
            this.fundtNascDataGridViewTextBoxColumn.HeaderText = "Fun_dtNasc";
            this.fundtNascDataGridViewTextBoxColumn.Name = "fundtNascDataGridViewTextBoxColumn";
            // 
            // funendDataGridViewTextBoxColumn
            // 
            this.funendDataGridViewTextBoxColumn.DataPropertyName = "Fun_end";
            this.funendDataGridViewTextBoxColumn.HeaderText = "Fun_end";
            this.funendDataGridViewTextBoxColumn.Name = "funendDataGridViewTextBoxColumn";
            // 
            // funnumcasaDataGridViewTextBoxColumn
            // 
            this.funnumcasaDataGridViewTextBoxColumn.DataPropertyName = "Fun_numcasa";
            this.funnumcasaDataGridViewTextBoxColumn.HeaderText = "Fun_numcasa";
            this.funnumcasaDataGridViewTextBoxColumn.Name = "funnumcasaDataGridViewTextBoxColumn";
            // 
            // funtelefoneDataGridViewTextBoxColumn
            // 
            this.funtelefoneDataGridViewTextBoxColumn.DataPropertyName = "Fun_telefone";
            this.funtelefoneDataGridViewTextBoxColumn.HeaderText = "Fun_telefone";
            this.funtelefoneDataGridViewTextBoxColumn.Name = "funtelefoneDataGridViewTextBoxColumn";
            // 
            // funcelularDataGridViewTextBoxColumn
            // 
            this.funcelularDataGridViewTextBoxColumn.DataPropertyName = "Fun_celular";
            this.funcelularDataGridViewTextBoxColumn.HeaderText = "Fun_celular";
            this.funcelularDataGridViewTextBoxColumn.Name = "funcelularDataGridViewTextBoxColumn";
            // 
            // funemailDataGridViewTextBoxColumn
            // 
            this.funemailDataGridViewTextBoxColumn.DataPropertyName = "Fun_email";
            this.funemailDataGridViewTextBoxColumn.HeaderText = "Fun_email";
            this.funemailDataGridViewTextBoxColumn.Name = "funemailDataGridViewTextBoxColumn";
            // 
            // funbairroDataGridViewTextBoxColumn
            // 
            this.funbairroDataGridViewTextBoxColumn.DataPropertyName = "Fun_bairro";
            this.funbairroDataGridViewTextBoxColumn.HeaderText = "Fun_bairro";
            this.funbairroDataGridViewTextBoxColumn.Name = "funbairroDataGridViewTextBoxColumn";
            // 
            // funcidadeDataGridViewTextBoxColumn
            // 
            this.funcidadeDataGridViewTextBoxColumn.DataPropertyName = "Fun_cidade";
            this.funcidadeDataGridViewTextBoxColumn.HeaderText = "Fun_cidade";
            this.funcidadeDataGridViewTextBoxColumn.Name = "funcidadeDataGridViewTextBoxColumn";
            // 
            // funufDataGridViewTextBoxColumn
            // 
            this.funufDataGridViewTextBoxColumn.DataPropertyName = "Fun_uf";
            this.funufDataGridViewTextBoxColumn.HeaderText = "Fun_uf";
            this.funufDataGridViewTextBoxColumn.Name = "funufDataGridViewTextBoxColumn";
            // 
            // funcepDataGridViewTextBoxColumn
            // 
            this.funcepDataGridViewTextBoxColumn.DataPropertyName = "Fun_cep";
            this.funcepDataGridViewTextBoxColumn.HeaderText = "Fun_cep";
            this.funcepDataGridViewTextBoxColumn.Name = "funcepDataGridViewTextBoxColumn";
            // 
            // funcargoDataGridViewTextBoxColumn
            // 
            this.funcargoDataGridViewTextBoxColumn.DataPropertyName = "Fun_cargo";
            this.funcargoDataGridViewTextBoxColumn.HeaderText = "Fun_cargo";
            this.funcargoDataGridViewTextBoxColumn.Name = "funcargoDataGridViewTextBoxColumn";
            // 
            // funuserDataGridViewTextBoxColumn
            // 
            this.funuserDataGridViewTextBoxColumn.DataPropertyName = "Fun_user";
            this.funuserDataGridViewTextBoxColumn.HeaderText = "Fun_user";
            this.funuserDataGridViewTextBoxColumn.Name = "funuserDataGridViewTextBoxColumn";
            // 
            // funsenhaDataGridViewTextBoxColumn
            // 
            this.funsenhaDataGridViewTextBoxColumn.DataPropertyName = "Fun_senha";
            this.funsenhaDataGridViewTextBoxColumn.HeaderText = "Fun_senha";
            this.funsenhaDataGridViewTextBoxColumn.Name = "funsenhaDataGridViewTextBoxColumn";
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "funcionarios";
            this.funcionariosBindingSource.DataSource = this.farmaDataSet;
            // 
            // farmaDataSet
            // 
            this.farmaDataSet.DataSetName = "FarmaDataSet";
            this.farmaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button5.Location = new System.Drawing.Point(787, 126);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(107, 32);
            this.button5.TabIndex = 41;
            this.button5.Text = "Pesquisar";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Pesquisa de funcionarios";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel6.Controls.Add(this.panel1);
            this.panel6.Location = new System.Drawing.Point(312, 33);
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
            this.button7.Location = new System.Drawing.Point(443, 395);
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
            this.panel2.Location = new System.Drawing.Point(312, 370);
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
            this.button3.Location = new System.Drawing.Point(598, 395);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 32);
            this.button3.TabIndex = 49;
            this.button3.Text = "Deletar";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(288, 395);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 32);
            this.button1.TabIndex = 48;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(0, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(49, 44);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // PesqFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(946, 447);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "PesqFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PesqFuncionarios";
            this.Load += new System.EventHandler(this.PesqFuncionarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.farmaDataSet)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FarmaDataSet farmaDataSet;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private FarmaDataSetTableAdapters.funcionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funnomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funsobrenmeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funrgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fundtNascDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funendDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funnumcasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funtelefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcelularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funbairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funufDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funuserDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funsenhaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}