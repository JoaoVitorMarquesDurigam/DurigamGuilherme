﻿using System;
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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[15];
            int i;
            Random num = new Random();

            for(i = 0; i < 15; i++)
            {
                vetor[i] = num.Next(1, 100);
                if( i % 2 == 0)
                {
                    txtpar.Text = vetor[i].ToString() + "";
                }
            }
        }
    }
}
