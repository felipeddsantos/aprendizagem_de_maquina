/*

Aprendizagem de Máquina - Reconhecimento de Dígitos com Redes Neurais Multicamadas (Programa Principal)  
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

namespace ReconhecimentoDeDigitos{

    public partial class Interface : Form{

        public Interface(){

            InitializeComponent();
        }

        int j = 0, k = 0, q = 0;
        double alfa = 0;

        List<Neuronio> N = new List<Neuronio>();
        List<double> xi = new List<double>();
        List<double> yt = new List<double>();

        List<double> erro = new List<double>();

        private void Bt1_Click(object sender, EventArgs e){

            alfa = double.Parse(tbalfa.Text);
            q = int.Parse(tbq.Text) + 1;
            
            j = k = 0;

            grafico.Series["Erro"].Points.Clear();

            xi.Clear();
            yt.Clear();
            N.Clear();
            erro.Clear();

            xi.Add(double.Parse(v1.Text));
            xi.Add(double.Parse(v2.Text));
            yt.Add(double.Parse(v3.Text));
            xi.Add(double.Parse(v4.Text));
            xi.Add(double.Parse(v5.Text));
            yt.Add(double.Parse(v6.Text));
            xi.Add(double.Parse(v7.Text));
            xi.Add(double.Parse(v8.Text));
            yt.Add(double.Parse(v9.Text));
            xi.Add(double.Parse(v10.Text));
            xi.Add(double.Parse(v11.Text));
            yt.Add(double.Parse(v12.Text));

            Random rdm = new Random();

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

            while(j < 6000){

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

                        N[l].w[1] = N[l].w[1] + alfa * N[l].Deltaj(yt[i], i, l + 1, 1, 0, N) * xi[2 * i];
                        N[l].w[2] = N[l].w[2] + alfa * N[l].Deltaj(yt[i], i, l + 1, 1, 0, N) * xi[2 * i + 1];
                        N[l].w[0] = N[l].w[0] + alfa * N[l].Deltaj(yt[i], i, l + 1, 1, 0, N);
                    }

                    erro.Add(0.5 * Math.Pow(yt[i] - N[N.Count - 1].y, 2));
                }

               grafico.Series["Erro"].Points.AddXY(k, erro.Sum());

               j++;
            }

            MessageBox.Show("Rede treinada.\nErro final: " + erro.Sum() + "\nCiclos: " + k); 
        }

        private void Button2_Click(object sender, EventArgs e){

            yt.Clear();

            for(int i = 0; i < 4; i++){

                N[N.Count - 1].xi.Clear();

                for(int l = 0; l < N.Count - 1; l++){

                    N[l].y = N[l].FuncaoAtivadora(N[l].Saida(i, 1));

                    N[N.Count - 1].xi.Add(N[l].y);
                }

                N[N.Count - 1].y = N[N.Count - 1].FuncaoAtivadora(N[N.Count - 1].Saida(i, 0));

                yt.Add(N[N.Count - 1].y);
            }

            v3.Text = yt[0].ToString();
            v6.Text = yt[1].ToString();
            v9.Text = yt[2].ToString();
            v12.Text = yt[3].ToString();
        }
    }
}
