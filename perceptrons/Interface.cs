/*

Aprendizagem de Máquina - Funções Lógicas com Perceptron (Programa Principal)  
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

namespace FuncoesLogicas{

    public partial class Interface : Form{
    
        public Interface(){
        
            InitializeComponent();
        }

        double alfa, w1, w2, b;
        int i = 0, j = 1;
        
        List<double> xi = new List<double>();
        List<double> yi = new List<double>();
        List<double> yl = new List<double>();

        private void Button1_Click(object sender, EventArgs e){

            xi.Add(double.Parse(tbx1.Text));
            xi.Add(double.Parse(tbx2.Text));
            xi.Add(double.Parse(tbx3.Text));
            xi.Add(double.Parse(tbx4.Text));
            xi.Add(double.Parse(tbx5.Text));
            xi.Add(double.Parse(tbx6.Text));
            xi.Add(double.Parse(tbx7.Text));
            xi.Add(double.Parse(tbx8.Text));

            yi.Add(double.Parse(tby1.Text));
            yi.Add(double.Parse(tby2.Text));
            yi.Add(double.Parse(tby3.Text));
            yi.Add(double.Parse(tby4.Text));

            yl.Add(0);
            yl.Add(0);
            yl.Add(0);
            yl.Add(0);

            w1 = double.Parse(tbw1.Text);
            w2 = double.Parse(tbw2.Text);
            b = double.Parse(tbb.Text);
            alfa = double.Parse(tbalfa.Text);

            while(j > 0){

                i++;
                j = 0;

                for(int t = 0; t < 4; t++){

                    yl[t] = xi[2 * t] * w1 + xi[2 * t + 1] * w2 + b;

                    if(yl[t] >= 0)
                    
                        yl[t] = 1;

                    if(yl[t] < 0)
                    
                        yl[t] = -1;
                
                    if(yl[t] != yi[t]){

                        w1 = w1 + alfa * yi[t] * xi[2 * t];
                        w2 = w2 + alfa * yi[t] * xi[2 * t + 1];
                        b = b + alfa * yi[t];
                        
                        j++;
                    }
                }
            }

            tbx1.Text = tbx2.Text = tbx3.Text = tbx4.Text = tbx5.Text = tbx6.Text = tbx7.Text = tbx8.Text = 
            tby1.Text = tby1.Text = tby2.Text = tby3.Text = tby4.Text = tbw1.Text = tbw2.Text = tbb.Text = 
            tbalfa.Text = " ";

            MessageBox.Show("Perceptron treinado com sucesso!\nNúmero de ciclos de treinamento: " +
             +i+ "\nParâmetros calculados: w1 = " + w1 + " w2 = " + w2 + " b = " + b);
        }

        private void Button2_Click(object sender, EventArgs e){

            tbx1.Text = xi[0].ToString();
            tbx2.Text = xi[1].ToString();
            tbx3.Text = xi[2].ToString();
            tbx4.Text = xi[3].ToString();
            tbx5.Text = xi[4].ToString();
            tbx6.Text = xi[5].ToString();
            tbx7.Text = xi[6].ToString();
            tbx8.Text = xi[7].ToString();

            for(int t = 0; t < 4; t++){

                yl[t] = w1 * xi[2 * t] + w2 * xi[2 * t + 1] + b;

                if(yl[t] >= 0)
                
                    yl[t] = 1;
                    
                else
                
                    yl[t] = -1;
            }

            tby1.Text = yl[0].ToString();
            tby2.Text = yl[1].ToString();
            tby3.Text = yl[2].ToString();
            tby4.Text = yl[3].ToString();

            xi.Clear();
            yi.Clear();
            yl.Clear();
            
            w1 = w2 = b = i = 0;

            j = 1;
        }
    }
}
