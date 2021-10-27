/*

Aprendizagem de Máquina - Regressão Não Linear com Redes Neurais Multicamadas (Programa Principal)  
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

namespace RegressaoNaoLinear{

    public partial class Interface : Form{

        public Interface(){

            InitializeComponent();
        }

        int j = 0, k = 0, q = 0;
        double alfa = 0;

        List<Neuronio> N = new List<Neuronio>();
        List<double> xi = new List<double>();
        List<double> yt = new List<double>();

        private void Button2_Click(object sender, EventArgs e){

            yt.Clear();

            for(int i = 0; i < xi.Count; i++){

                N[N.Count - 1].xi.Clear();

                for (int l = 0; l < N.Count - 1; l++){

                    N[l].y = N[l].FuncaoAtivadora(N[l].Saida(i, 1));

                    N[N.Count - 1].xi.Add(N[l].y);
                }

                N[N.Count - 1].y = N[N.Count - 1].FuncaoAtivadora(N[N.Count - 1].Saida(i, 0));

                yt.Add(N[N.Count - 1].y);
            }

            for(int i = 0; i < yt.Count(); i++)

                grafico.Series["Calculado"].Points.AddXY(xi[i], yt[i]);
        }

        List<double> erro = new List<double>();

        private void Bt1_Click(object sender, EventArgs e){

            alfa = double.Parse(tbalfa.Text);
            q = int.Parse(tbq.Text) + 1;

            j = k = 0;

            grafico.Series["Calculado"].Points.Clear();
            grafico.Series["Esperado"].Points.Clear();
            
            xi.Clear();
            yt.Clear();
            N.Clear();
            erro.Clear();

            xi.Add(-1.0);
            xi.Add(-0.9);
            xi.Add(-0.8);
            xi.Add(-0.7);
            xi.Add(-0.6);
            xi.Add(-0.5);
            xi.Add(-0.4);
            xi.Add(-0.3);
            xi.Add(-0.2);
            xi.Add(-0.1);
            xi.Add(0);

            yt.Add(-0.9602);
            yt.Add(-0.5770);
            yt.Add(-0.0729);
            yt.Add(0.3771);
            yt.Add(0.6405);
            yt.Add(0.6600);
            yt.Add(0.4609);
            yt.Add(0.1336);
            yt.Add(-0.2013);
            yt.Add(-0.4344);
            yt.Add(-0.500);

            Random rdm = new Random();

            for(int i = 0; i < xi.Count(); i++)

                grafico.Series["Esperado"].Points.AddXY(xi[i], yt[i]);

            for(int i = 0; i < q; i++){

                N.Add(new Neuronio());

                if(i < q - 1 ){
                    
                    for(int j = 0; j < xi.Count; j++)

                        N[i].xi.Add(xi[j]);

                    N[i].InicializarPesos(rdm, 1, q);
                }

                if(i == q - 1 )

                    N[i].InicializarPesos(rdm, 0, q);
            }

            while(j <= 50000){

                k++;

                erro.Clear();

                for(int i = 0; i < yt.Count; i++){

                    N[N.Count - 1].xi.Clear();

                    for(int l = 0; l < N.Count - 1; l++){

                        N[l].y = N[l].FuncaoAtivadora(N[l].Saida(i, 1));

                        N[N.Count - 1].xi.Add(N[l].y);
                    }

                    N[N.Count - 1].y = N[N.Count - 1].FuncaoAtivadora(N[N.Count - 1].Saida(i, 0));

                    for(int l = 1; l < N.Count; l++)

                        N[N.Count - 1].w[l] = N[N.Count - 1].w[l] + alfa * N[N.Count - 1].Deltak(yt[i], i, 0) * N[N.Count - 1].xi[l - 1];

                    N[N.Count - 1].w[0] = N[N.Count - 1].w[0] + alfa * N[N.Count - 1].Deltak(yt[i], i, 0);

                    for(int l = 0; l < N.Count - 1; l++){

                        N[l].w[1] = N[l].w[1] + alfa * N[l].Deltaj(yt[i], i, l + 1, 1, 0, N) * xi[i];
                        N[l].w[0] = N[l].w[0] + alfa * N[l].Deltaj(yt[i], i, l + 1, 1, 0, N);
                    }

                    erro.Add(0.5 * Math.Pow(yt[i] - N[N.Count - 1].y, 2));
                }

               j++;
            }

            MessageBox.Show("Rede treinada.\nErro final: " + erro.Sum() + "\nCiclos: " + (k - 1)); 
        }
    }
}
