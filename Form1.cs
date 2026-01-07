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

namespace PROVA_SEGUNDA_ETAPA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int[,] m = new int[5, 5];
            int cont = 0;

            //Atribuindo os valores da matriz e somando as colunas 0 e 4
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (i == 0 || i== 3)
                    {
                        lblmatriz1.Text += " 0 ";
                    }
                    else if  (j > 0 && j < 4)
                    {
                        lblmatriz1.Text += " 1 ";
                    }

                    else
                    {
                        lblmatriz1.Text += " 0 ";
                    }


                }
                lblmatriz1.Text += "\n";
            }



    }

        private void btn2_Click(object sender, EventArgs e)
        {
            int[,] m = new int[5, 5];
            int cont = 111;
            int soma = 0;
            //Atribuindo os valores da matriz e somando as colunas 0 e 4
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    m[i, j] = cont;
                    cont += 11;
                    if (j == 0 || j == m.GetLength(1) - 1)
                    {
                        
                    }
                }
            }
            //Mostrando os valores da matriz e em seguida a soma
            for (int i = 0; i < m.GetLength(0); i++)
            {

                for (int j = 0; j < m.GetLength(1); j++)
                {
                    lblmatriz2.Text += m[i, j] + " ";

                }
                lblmatriz2.Text += "\n";
            }
            soma += (122 + 177 + 232 + 287 + 342 + 144 + 199 + 254 + 309 + 364);
            //soma += (111 + 166 + 221 + 276 + 331 + 155 + 210 + 265 + 320 + 375);
            // soma += (122 + 111 + 133 + 144 + 155 + 331 + 342 + 353 + 364 + 375);

            lblresultado.Text = "A soma é: " + soma;

        }
    }
}

