using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExerciciosNiviaV2
{
    public partial class Exer2: Form
    {
        public Exer2()
        {
            InitializeComponent();
        }

        int[] vetor = new int[30];
        int i;
        
        private void btncalcular_Click(object sender, EventArgs e)
        {
            int qtd;
            int media;
            qtd = 0;
            media = 0;

            for (i = 0; i < 30; i++)
            {
                media = media + vetor[i];
                qtd = qtd + 1;
            }
            media = media / qtd;
            txtmedia.Text = Convert.ToString(media);
        }

        private void btnadicionar_Click(object sender, EventArgs e)
        {
            string notas;
            int notasint;

           

            if (i < 30)
            {
                 notas = txtnota.Text;
                 notasint = Convert.ToInt32(notas);
                 vetor[i] = notasint;
                txtnota.Clear();
                txtnota.Focus();
                i++;
            }
            else
            {
                txtvetorqtd.Text = "numero de notas exede 30";
            }
        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnota.Clear();
            txtvetorqtd.Clear();
            txtmedia.Clear();

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 exerprim = new Form1();
            exerprim.Show();
        }
    }
}
