using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaVital
{
    public partial class FrmMenuadm : Form
    {

        private Button btnAtual;
        private Form formAtual;

        public FrmMenuadm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void Funcionarios_Click(object sender, EventArgs e)
        {
          

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirForm(new FrmFabricante(), sender);

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            AbrirForm(new FrmFuncionarios(), sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirForm(new PesqCliente(), sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AbrirForm(new PesqMedicamentos(), sender);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            //AbrirForm(new FrmFabricante(), sender);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AbrirForm(Form formSel, Object btnSender)
        {
            if (formAtual != null)
            {
                formAtual.Close();
            }
            AtivarBtn(btnSender);
            formAtual = formSel;
            formSel.TopLevel = false; //nivel de controle
            formSel.FormBorderStyle = FormBorderStyle.None;//caixa de controle desativada
            formSel.Dock = DockStyle.Fill; // Posicionamento
            this.panelContainer.Controls.Add(formSel); //adicionar o form ao painel
            this.panelContainer.Tag = formSel;
            formSel.BringToFront();//Traz o controle para frente na ordem Z
            formSel.Show();// Chama o Form
            label1.Text = formSel.Text;

        }

        private void Resetar()
        {
            label1.Text = "HOME";
            btnHome.Visible = false;
        }


        private void AtivarBtn(Object btnSender)
        {
            if (btnSender != null)
            {
                if (btnAtual != (Button)btnSender)
                {
                    btnHome.Visible = true;
                    btnAtual = (Button)btnSender;
                 
                }
            }
        }

        private void DesativarBtn()
        {
           
        }


        private void FrmMenuadm_Load(object sender, EventArgs e)
        {

        }

        private void panelMENU_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
