/*

Aprendizagem de Máquina - Funções Lógicas com Adaline (Programa Principal)  
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

        int i = 0, j = 0;

        double alfa, b, min;

        List<double> xi = new List<double>();
        List<double> yt = new List<double>();
        List<double> w = new List<double>();
        List<double> erro = new List<double>();
        List<double> ciclo = new List<double>();
        List<double> y = new List<double>();

        private void Button1_Click(object sender, EventArgs e){

            xi.Clear();
            yt.Clear();
            y.Clear();
            w.Clear();

            xi.Add(double.Parse(v1.Text));
            xi.Add(double.Parse(v2.Text));
            xi.Add(double.Parse(v3.Text));
            xi.Add(double.Parse(v4.Text));
            xi.Add(double.Parse(v5.Text));
            xi.Add(double.Parse(v6.Text));
            xi.Add(double.Parse(v7.Text));
            xi.Add(double.Parse(v8.Text));
            xi.Add(double.Parse(v9.Text));
            xi.Add(double.Parse(v10.Text));
            xi.Add(double.Parse(v11.Text));
            xi.Add(double.Parse(v12.Text));
            xi.Add(double.Parse(v13.Text));
            xi.Add(double.Parse(v14.Text));
            xi.Add(double.Parse(v15.Text));
            xi.Add(double.Parse(v16.Text));

            yt.Add(double.Parse(v17.Text));
            yt.Add(double.Parse(v18.Text));
            yt.Add(double.Parse(v19.Text));
            yt.Add(double.Parse(v20.Text));

            y.Add(0);
            y.Add(0);
            y.Add(0);
            y.Add(0);

            w.Add(0);
            w.Add(0);
            w.Add(0);
            w.Add(0);

            ciclo.Clear();

            b = 0;

            alfa = double.Parse(a.Text);
            min = double.Parse(m.Text);

            i = 0;
            j = 0;

            grafico.Series["Erro"].Points.Clear();

            while(j == 0){
                
                i++;

                erro.Clear();

                for(int t = 0; t < 4; t++){

                    y[t] = xi[4 * t] * w[0] + xi[4 * t + 1] * w[1] + xi[4 * t + 2] * w[2] + xi[4 * t + 3] * w[3] + b;

                    erro.Add(0.5 * Math.Pow(yt[t] - y[t], 2));

                    for(int u = 0; u < 4; u++)

                        w[u] = w[u] + alfa * (yt[t] - y[t]) * xi[4 * t + u]; 

                    b = b + alfa * (yt[t] - y[t]);
                }

                grafico.Series["Erro"].Points.AddXY(i, erro.Sum());

                ciclo.Add(i);

                if(erro.Sum() <= min)

                    j++;
            }
            
            MessageBox.Show("Rede neural treinada.\nNúmero de ciclos: " + ciclo.Max() + "\nErro total: " + erro.Sum());
        }
    }
}
