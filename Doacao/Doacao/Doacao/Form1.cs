using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doacao
{
    public partial class Form1 : Form
    {
        DAOPessoa pessoa;
        public Form1()
        {
            InitializeComponent();
            pessoa = new DAOPessoa();//Abrindo conexao com bd

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }//Textbox Nome


        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Maskedtxt TELEFONE


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//TXT Email

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//TXT Endereco


        public string nome()
        {
            return textBox1.Text;
        }

        public string email()
        {
            return textBox2.Text;
        }

        public string telefone()
        {
            return maskedTextBox2.Text;
        }

        public string endereco()
        {
            return textBox3.Text;
        }






        /////////////////////////////BOTÃO
        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string email = textBox2.Text;
            string telefone = maskedTextBox2.Text;
            string endereco = textBox3.Text;
       


            this.Visible = false;
            Doacao OutroForm = new Doacao();
            OutroForm.ShowDialog();
            
        }//Botão concluir

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }//Fim da classe
}//Fim do projeto
