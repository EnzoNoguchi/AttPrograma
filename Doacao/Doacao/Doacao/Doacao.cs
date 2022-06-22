using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doacao
{
    public partial class Doacao : Form

    {
        DAOPessoa pessoa;
        DAOPessoa pessoaDoacao;
        Form1 elementos;
        public string brinquedo;
        public string roupas;
        public string dinheiro;
        public string alimento;

        public Doacao()
        {
            InitializeComponent();
            pessoaDoacao = new DAOPessoa();
            pessoa = new DAOPessoa();
            brinquedo = "não";
            roupas = "não";
            dinheiro = "não";
            alimento = "não";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            
            GraphicsPath forma1 = new GraphicsPath();
            forma1.AddEllipse(0, 0, button1.Width, button1.Height);
            button1.Region = new Region(forma1);


            GraphicsPath forma2 = new GraphicsPath();
            forma2.AddEllipse(0, 0, button2.Width, button2.Height);
            button2.Region = new Region(forma2);


            GraphicsPath forma3 = new GraphicsPath();
            forma3.AddEllipse(0, 0, button3.Width, button3.Height);
            button3.Region = new Region(forma3);

            GraphicsPath forma4 = new GraphicsPath();
            forma4.AddEllipse(0, 0, button4.Width, button4.Height);
            button4.Region = new Region(forma4);

        }







        private void Doacao_Load(object sender, EventArgs e)
        {
            this.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }








        //================================================================= Botões =================================================================









        private void button3_Click(object sender, EventArgs e)
        {
            brinquedo = "sim";           

        }//Botão Brinquedos






        private void button2_Click(object sender, EventArgs e)
        {
            roupas = "sim";
        }//Botão Roupas






        private void button4_Click(object sender, EventArgs e)
        {
            dinheiro = "sim";
        }//Botão Dinheiro





        private void Alimentos(object sender, EventArgs e)
        {
            alimento = "sim";
        }//Botão Alimentos

        private void button5_Click(object sender, EventArgs e)
        {
            string nome = elementos.nome();
            string telefone = elementos.telefone();
            string endereco = elementos.endereco();
            string email = elementos.email();

            pessoa.Inserir(nome, email, telefone, endereco, brinquedo, roupas, dinheiro, alimento);
           


        }//Botao finalizar







    }//Fim da classe
}//Fim do projeto
