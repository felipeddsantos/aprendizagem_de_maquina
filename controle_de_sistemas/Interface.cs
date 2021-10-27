/*

Aprendizagem de Máquina - Controle de Sistemas com Adaline (Programa Principal)  
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

namespace ControleDeSistemas{

    public partial class Interface : Form{

        public Interface(){

            InitializeComponent();
        }

        int i = 0, j = 0;

        double alfa = 0.0025, b, min = 0.000001, y = 0.0;

        List<double> xi = new List<double>();
        List<double> yt = new List<double>();
        List<double> w = new List<double>();
        List<double> erro = new List<double>();
        List<double> errosum = new List<double>();

        private void Button1_Click(object sender, EventArgs e){

            xi.Clear();
            yt.Clear();
            w.Clear();
            errosum.Clear();

            Random rand = new Random();

            b = rand.NextDouble();

            w.Add(rand.NextDouble());
            w.Add(rand.NextDouble());
            w.Add(rand.NextDouble());
            w.Add(rand.NextDouble());

            MessageBox.Show("Pesos iniciais:\nw1 = " + w[0] + "\nw2 = " + w[1] + "\nw3 = " + w[2] + "\nw4 = " + w[3] + "\nb = " + b);

            xi.Add(0.4329);
            xi.Add(-1.3719);
            xi.Add(0.7022);
            xi.Add(-0.8535);
            xi.Add(0.3024);
            xi.Add(0.2286);
            xi.Add(0.8630);
            xi.Add(2.7909);
            xi.Add(0.1349);
            xi.Add(-0.6445);
            xi.Add(1.0530);
            xi.Add(0.5687);
            xi.Add(0.3374);
            xi.Add(-1.7163);
            xi.Add(0.3670);
            xi.Add(-0.6283);
            xi.Add(1.1434);
            xi.Add(-0.0485);
            xi.Add(0.6637);
            xi.Add(1.2606);
            xi.Add(1.3749);
            xi.Add(-0.5071);
            xi.Add(0.4464);
            xi.Add(1.3009);
            xi.Add(0.7221);
            xi.Add(-0.7587);
            xi.Add(0.7681);
            xi.Add(-0.5592);
            xi.Add(0.4403);
            xi.Add(-0.8072);
            xi.Add(0.5154);
            xi.Add(-0.3129);
            xi.Add(-0.5231);
            xi.Add(0.3548);
            xi.Add(0.2538);
            xi.Add(1.5776);
            xi.Add(0.3255);
            xi.Add(-2.0000);
            xi.Add(0.7112);
            xi.Add(-1.1209);
            xi.Add(0.5824);
            xi.Add(1.3915);
            xi.Add(-0.2291);
            xi.Add(4.1735);
            xi.Add(0.1340);
            xi.Add(0.6081);
            xi.Add(0.4450);
            xi.Add(3.2230);
            xi.Add(0.1480);
            xi.Add(-0.2988);
            xi.Add(0.4778);
            xi.Add(0.8649);
            xi.Add(0.7359);
            xi.Add(0.1869);
            xi.Add(-0.0872);
            xi.Add(2.3584);
            xi.Add(0.7115);
            xi.Add(-1.1469);
            xi.Add(0.3394);
            xi.Add(0.9573);
            xi.Add(0.8251);
            xi.Add(-1.2840);
            xi.Add(0.8452);
            xi.Add(1.2382);
            xi.Add(0.1569);
            xi.Add(0.3712);
            xi.Add(0.8825);
            xi.Add(1.7633);
            xi.Add(0.0033);
            xi.Add(0.6835);
            xi.Add(0.5389);
            xi.Add(2.8249);
            xi.Add(0.4243);
            xi.Add(0.8313);
            xi.Add(0.2634);
            xi.Add(3.5855);
            xi.Add(1.0490);
            xi.Add(0.1326);
            xi.Add(0.9138);
            xi.Add(1.9792);
            xi.Add(1.4276);
            xi.Add(0.5331);
            xi.Add(-0.0145);
            xi.Add(3.7286);
            xi.Add(0.5971);
            xi.Add(1.4865);
            xi.Add(0.2904);
            xi.Add(4.6069);
            xi.Add(0.8475);
            xi.Add(2.1479);
            xi.Add(0.3179);
            xi.Add(5.8235);
            xi.Add(1.3967);
            xi.Add(-0.4171);
            xi.Add(0.6443);
            xi.Add(1.3927);
            xi.Add(0.0044);
            xi.Add(1.5378);
            xi.Add(0.6099);
            xi.Add(4.7755);
            xi.Add(0.2201);
            xi.Add(-0.5668);
            xi.Add(0.0515);
            xi.Add(0.7829);
            xi.Add(0.6300);
            xi.Add(-1.2480);
            xi.Add(0.8591);
            xi.Add(0.8093);
            xi.Add(-0.2479);
            xi.Add(0.8960);
            xi.Add(0.0547);
            xi.Add(1.7381);
            xi.Add(-0.3088);
            xi.Add(-0.0929);
            xi.Add(0.8659);
            xi.Add(1.5483);
            xi.Add(-0.5180);
            xi.Add(1.4974);
            xi.Add(0.5453);
            xi.Add(2.3993);
            xi.Add(0.6833);
            xi.Add(0.8266);
            xi.Add(0.0829);
            xi.Add(2.8864);
            xi.Add(0.4353);
            xi.Add(-1.4066);
            xi.Add(0.4207);
            xi.Add(-0.4879);
            xi.Add(-0.1069);
            xi.Add(-3.2329);
            xi.Add(0.1856);
            xi.Add(-2.4572);
            xi.Add(0.4662);
            xi.Add(0.6261);
            xi.Add(0.7304);
            xi.Add(3.4370);
            xi.Add(0.8298);
            xi.Add(-1.4089);
            xi.Add(0.3119);
            xi.Add(1.3235);

            yt.Add(1.0000);
            yt.Add(-1.0000);
            yt.Add(-1.0000);
            yt.Add(-1.0000);
            yt.Add(1.0000);
            yt.Add(1.0000);
            yt.Add(1.0000);
            yt.Add(1.0000);
            yt.Add(-1.0000);
            yt.Add(1.0000);
            yt.Add(-1.0000);
            yt.Add(-1.0000);
            yt.Add(1.0000);
            yt.Add(1.0000);
            yt.Add(-1.0000);
            yt.Add(-1.0000);
            yt.Add(1.0000);
            yt.Add(-1.0000);
            yt.Add(-1.0000);
            yt.Add(1.0000);
            yt.Add(1.0000);
            yt.Add(-1.0000);
            yt.Add(-1.0000);
            yt.Add(1.0000);
            yt.Add(-1.0000);
            yt.Add(1.0000);
            yt.Add(-1.0000);
            yt.Add(1.0000);
            yt.Add(-1.0000);
            yt.Add(1.0000);
            yt.Add(1.0000);
            yt.Add(1.0000);
            yt.Add(-1.0000);
            yt.Add(-1.0000);
            yt.Add(-1.0000);

            i = 0;
            j = 0;

            grafico.Series["Erro"].Points.Clear();

            while(j == 0){
                
                i++;

                erro.Clear();

                for(int t = 0; t < 35; t++){

                    y = xi[4 * t] * w[0] + xi[4 * t + 1] * w[1] + xi[4 * t + 2] * w[2] + xi[4 * t + 3] * w[3] + b;

                    erro.Add(0.5 * Math.Pow(yt[t] - y, 2));

                    for(int u = 0; u < 4; u++)

                        w[u] = w[u] + alfa * (yt[t] - y) * xi[4 * t + u]; 

                    b = b + alfa * (yt[t] - y);
                }

                errosum.Add(erro.Sum());

                grafico.Series["Erro"].Points.AddXY(i, erro.Sum());

                if(i > 1){

                    if((errosum[i - 2] - errosum[i - 1]) <= min)

                        j++;
                }
            }

            MessageBox.Show("Rede neural treinada\nPesos finais:\nw1 = " + w[0] + "\nw2 = " + w[1] + "\nw3 = " + w[2] + "\nw4 = " + w[3] + "\nb = " + b + "\nNúmero de ciclos: " + i);
        }

        private void Bt2_Click(object sender, EventArgs e){

            double yf = w[0] * double.Parse(v1.Text) + w[1] * double.Parse(v2.Text) + w[2] * double.Parse(v3.Text) + w[3] * double.Parse(v4.Text) + b;

            if(yf < 0)

                yf = -1.0000;

            if(yf >= 0)

                yf = 1.0000;

            v5.Text = yf.ToString();

            if(yf == 1.0000)

                MessageBox.Show("Válvula A selecionada");

            if(yf == -1.0000)

                MessageBox.Show("Válvula B selecionada");
        }
    }
}
