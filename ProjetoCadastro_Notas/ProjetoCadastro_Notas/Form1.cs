using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCadastro_Notas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nome, curso, turma, turno;
            Double nota01, nota02, media;

            nome = textBox1.Text;
            curso = textBox2.Text;
            turno = textBox3.Text;
            turma = textBox4.Text;

            nota01 = Convert.ToDouble(textBox5.Text);
            nota02 = Convert.ToDouble(textBox6.Text);

            media = (nota01 + nota02) / 2;

            if(media >= 7)
            {
                label12.Text = "APROVADO";
            } else
            {
                label12.Text = "REPROVADO";

            }
            label10.Text = label10.Text + nome +
                "\n" + curso + "\n" + turno + "\n" + turma;

            label11.Text = Convert.ToString(label11.Text
                + "A MÉDIA É: " + media);
   
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
