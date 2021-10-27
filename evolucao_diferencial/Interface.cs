/*

Aprendizagem de Máquina - Otimização com Evolução Diferencial (Programa Principal)  
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otimizacao{

    public partial class Interface : Form{
    
        public Interface(){

            InitializeComponent();
        }

        int NP = 0, d = 0, G = 0;
        double F = 0, CR = 0, L0 = 0, L1 = 0;

        List<double> xi = new List<double>();
        List<double> vi = new List<double>();
        List<double> ui = new List<double>();

        double Rastrigin(List<double> x, int j){

            double sum = 10 * d;

            for(int i = 0; i < d; i++)

               sum = sum + Math.Pow(x[2 * j + i], 2) - 10 * Math.Cos(2 * Math.PI * x[2 * j + i]);

            return sum;
        }

        private void Button1_Click(object sender, EventArgs e){

            Random rd = new Random();

            xi.Clear();

            NP = int.Parse(tbNP.Text.ToString());
            G = int.Parse(tbG.Text.ToString());
            F = double.Parse(tbF.Text.ToString());
            CR = double.Parse(tbCR.Text.ToString());
            d = int.Parse(tbd.Text.ToString());
            L0 = double.Parse(tbL0.Text.ToString());
            L1 = double.Parse(tbL1.Text.ToString());

            for(int i = 0; i < NP * d; i++)

                xi.Add((L1 - L0) * rd.NextDouble() + L0);

            MessageBox.Show("População gerada");
        }

        private void Button2_Click(object sender, EventArgs e){

            int k = 0;

            Random rd = new Random();

            int target = rd.Next(0, NP);

            if(target % d != 0)

                target -= target % d;

            while(k < G){

                int a = 0, b = 0, c = 0, n = 0;

                ui.Clear();
                vi.Clear();

                while(n == 0){

                    a = rd.Next(0, NP);
                    b = rd.Next(0, NP);
                    c = rd.Next(0, NP);

                    if(a % d != 0)

                        a -= a % d;

                    if(b % d != 0)

                        b -= b % d;

                    if(c % d != 0)

                        c -= c % d;

                    if(a != b && a != c && b != c)

                        n++;
                }

                for(int j = 0; j < d; j++){

                    double rd1 = rd.NextDouble();
                    int rd2 = rd.Next(0, d);

                    vi.Add(xi[a + j] + F * (xi[b + j] - xi[c + j]));

                    if(vi[j] > L1)

                        vi[j] = L1;

                    if(vi[j] < L0)

                        vi[j] = L0;

                    if(rd1 <= CR || j == rd2)

                        ui.Add(xi[target + j]);

                    if(rd1 > CR && j != rd2)

                        ui.Add(vi[j]); 
                }

                for(int j = 0; j < d; j++){

                    if(Rastrigin(ui, 0) < Rastrigin(xi, target / 2))

                        xi[target + j] = ui[j];
                }

                k++;
            }

            MessageBox.Show("Evolução concluída.");

            MessageBox.Show("Ponto de mínimo: x1 = " + xi[target].ToString() + ", x2 = " + xi[target + 1].ToString() + "\nValor da função: f(x1, x2) = " + Rastrigin(xi, target / 2));
        }
    }
}
