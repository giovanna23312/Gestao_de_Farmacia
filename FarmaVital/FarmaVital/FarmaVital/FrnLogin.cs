using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace FarmaVital
{
    public partial class FrnLogin : Form
    {
        public FrnLogin()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection();


       // private void button1_Click(object sender, EventArgs e)
      //  {
            //if ((textBox1.Text == "admi") && (textBox2.Text == "123"))
            //{
            //    this.Visible = false;
            //    FrmMenuadm menu = new FrmMenuadm();
            //    menu.ShowDialog();
            //}

            //if ((textBox1.Text == "farma") && (textBox2.Text == "123"))
            //{
            //    this.Visible = false;
            //    Farma menu = new Farma();
            //    menu.ShowDialog();
            //}

            private void button1_Click(object sender, EventArgs e)
            {
                if (textBox1.Text.Length == 0 && textBox2.Text.Length == 0)
                {
                    MessageBox.Show("Entre com os dados");
                }
                else
                {
                    funcionariosBindingSource.Filter = "Fun_user='" + textBox1.Text + "'";

                    if (textBox1.Text.ToUpper() != textBox4.Text.ToUpper())
                    {
                        MessageBox.Show("USUARIO ERRADO");
                        return;
                    }
                    if (textBox2.Text.ToUpper() != textBox3.Text.ToUpper())
                    {
                        MessageBox.Show("SENHA ERRADA");
                        return;
                    }
                    if (comboBox1.Text.ToUpper() != comboBox2.Text.ToUpper())
                    {
                        MessageBox.Show("CARGO ERRADO");
                        return;
                    }
                    if ((comboBox1.Text == "adm"))
                      {
                         this.Visible = false;
                         FrmMenuadm menu = new FrmMenuadm();
                         menu.ShowDialog();
                       }
                   if ((comboBox1.Text == "ceutico"))
                       {
                    this.Visible = false;
                    Farma menu = new Farma();
                    menu.ShowDialog();
                      }


            }

            }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrnLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'farmaDataSet.funcionarios'. Você pode movê-la ou removê-la conforme necessário.
            this.funcionariosTableAdapter.Fill(this.farmaDataSet.funcionarios);

        }
    }
}
