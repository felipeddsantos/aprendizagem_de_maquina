/*

Aprendizagem de Máquina - Reconhecimento de Dígitos com Perceptron (Programa Principal)  
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
using System.IO;

namespace ReconhecimentoDeDigitos{

    public partial class Interface : Form{
    
        public Interface(){

            InitializeComponent();
        }

        List<int> xi = new List<int>();
        List<double> yi = new List<double>();
        List<double> wi = new List<double>();
        List<double> b = new List<double>();
        List<int> t = new List<int>();
        List<Bitmap> bits = new List<Bitmap>();
        
        int k = 0, inc = 1, a = 0, counter = 0, n = 0, ind = 0;
        double alfa, sum = 0;
        
        Bitmap result;
        
        private void Bt_Click(object sender, EventArgs e){

            xi.Clear();
            yi.Clear();
            wi.Clear();
            b.Clear();
            t.Clear();
            bits.Clear();
            
            sum = k = a = counter = 0;
            inc = 1;

            fbd.Description = "Selecione uma pasta contendo as entradas";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.ShowDialog();

            DirectoryInfo treinamento = new DirectoryInfo(fbd.SelectedPath);

            alfa = double.Parse(tbalfa.Text);

            if(rb10.Checked){

                for(int i = 0; i < 100; i++){

                    if(i % 11 == 0)

                        t.Add(1);

                    else

                        t.Add(-1);
                }

                n = 10;
            }

            else{

                for(int i = 0; i < 40; i++){

                    if(i == 7 || i == 10 || i == 14 || i == 15 || i == 17 || i == 21 || i == 23 || i == 25 || i == 26
                        || i == 29 || i == 30 || i == 31 || i == 32 || i == 36 || i == 39)

                        t.Add(1);

                    else

                        t.Add(-1);
                }

                n = 4;
            }

            for(int i = 0; i < 10; i++){

                yi.Add(0);

                b.Add(double.Parse(tbb.Text));
            }

            for(int i = 0; i < 690000; i++)

                wi.Add(double.Parse(tbwi.Text));

            foreach(FileInfo file in treinamento.GetFiles())

                bits.Add(new Bitmap(file.FullName));

            for(int i = 0; i < 10; i++){

                for(int j = 0; j < bits[i].Width; j++){

                    for(int k = 0; k < bits[i].Height; k++){

                        Color pixelColor = bits[i].GetPixel(j, k);

                        if(pixelColor.B == 0 && pixelColor.R == 0 && pixelColor.G == 0)

                            xi.Add(1);

                        else

                            xi.Add(-1);
                    }
                }
            }

            while(inc > 0){

                inc = 0;
                a = 0;

                for(int m = 0; m < 10; m++){

                    k = 0;

                    for(int j = 0; j < n; j++){

                        for(int i = 0; i < 69000; i++)

                            sum = xi[i + 69000 * m] * wi[j + 10 * i] + sum;

                        yi[k] = sum + b[k];

                        if(yi[k] >= 0)
                        
                            yi[k] = 1;

                        if(yi[k] < 0)
                        
                            yi[k] = -1;

                        sum = 0;

                        if(yi[k] != t[a]){

                            for(int l = 0; l < 69000; l++){

                                wi[j + 10 * l] = wi[j + 10 * l] + alfa * t[a] * xi[l + 69000 * m];
                                b[k] = b[k] + alfa * t[a];
                            }

                            counter++;
                            inc++;
                        }

                        k++;
                        a++;
                    }
                }
            }

            MessageBox.Show("Rede neural treinada.\nNúmero de ciclos: " + counter + ".");
        }

        private void Bt2_Click(object sender, EventArgs e){

            sum = k = 0;
            xi.Clear();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            ofd.Title = "Selecione uma imagem para teste";
            ofd.InitialDirectory = "C:\\";

            result = new Bitmap(ofd.FileName);

            for(int i = 0; i < result.Width; i++){

                for(int j = 0; j < result.Height; j++){

                    Color pixelColor = result.GetPixel(i, j);

                    if(pixelColor.B == 0 && pixelColor.R == 0 && pixelColor.G == 0)

                        xi.Add(1);

                    else

                        xi.Add(-1);
                }
            }

            for(int j = 0; j < 10; j++){

                for(int i = 0; i < 69000; i++)

                    sum = xi[i] * wi[j + 10 * i] + sum;

                yi[k] = sum + b[k];

                if(yi[k] >= 0)

                    yi[k] = 1;

                if(yi[k] < 0)

                    yi[k] = -1;

                k++;

                sum = 0;
            }

            if(n == 10){

                if(yi[0] == 1 && yi[1] == -1 && yi[2] == -1 && yi[3] == -1 && yi[4] == -1 && yi[5] == -1 && yi[6] == -1
                && yi[7] == -1 && yi[8] == -1 && yi[9] == -1)

                    MessageBox.Show("Número 0.\n{" +yi[0]+ "," + yi[1] + "," + yi[2] + "," + yi[3] + "," + yi[4] + ","
                        + yi[5] + "," + yi[6] + "," + yi[7] + "," + yi[8] + "," + yi[9] + "}");

                else if(yi[0] == -1 && yi[1] == 1 && yi[2] == -1 && yi[3] == -1 && yi[4] == -1 && yi[5] == -1 && yi[6] == -1
                    && yi[7] == -1 && yi[8] == -1 && yi[9] == -1)

                    MessageBox.Show("Número 1.\n{" + yi[0] + "," + yi[1] + "," + yi[2] + "," + yi[3] + "," + yi[4] + ","
                        + yi[5] + "," + yi[6] + "," + yi[7] + "," + yi[8] + "," + yi[9] + "}");

                else if(yi[0] == -1 && yi[1] == -1 && yi[2] == 1 && yi[3] == -1 && yi[4] == -1 && yi[5] == -1 && yi[6] == -1
                    && yi[7] == -1 && yi[8] == -1 && yi[9] == -1)

                    MessageBox.Show("Número 2.\n{" + yi[0] + "," + yi[1] + "," + yi[2] + "," + yi[3] + "," + yi[4] + ","
                        + yi[5] + "," + yi[6] + "," + yi[7] + "," + yi[8] + "," + yi[9] + "}");

                else if(yi[0] == -1 && yi[1] == -1 && yi[2] == -1 && yi[3] == 1 && yi[4] == -1 && yi[5] == -1 && yi[6] == -1
                    && yi[7] == -1 && yi[8] == -1 && yi[9] == -1)

                    MessageBox.Show("Número 3.\n{" + yi[0] + "," + yi[1] + "," + yi[2] + "," + yi[3] + "," + yi[4] + ","
                        + yi[5] + "," + yi[6] + "," + yi[7] + "," + yi[8] + "," + yi[9] + "}");

                else if(yi[0] == -1 && yi[1] == -1 && yi[2] == -1 && yi[3] == -1 && yi[4] == 1 && yi[5] == -1 && yi[6] == -1
                    && yi[7] == -1 && yi[8] == -1 && yi[9] == -1)

                    MessageBox.Show("Número 4.\n{" + yi[0] + "," + yi[1] + "," + yi[2] + "," + yi[3] + "," + yi[4] + ","
                        + yi[5] + "," + yi[6] + "," + yi[7] + "," + yi[8] + "," + yi[9] + "}");

                else if(yi[0] == -1 && yi[1] == -1 && yi[2] == -1 && yi[3] == -1 && yi[4] == -1 && yi[5] == 1 && yi[6] == -1
                    && yi[7] == -1 && yi[8] == -1 && yi[9] == -1)

                    MessageBox.Show("Número 5.\n{" + yi[0] + "," + yi[1] + "," + yi[2] + "," + yi[3] + "," + yi[4] + ","
                        + yi[5] + "," + yi[6] + "," + yi[7] + "," + yi[8] + "," + yi[9] + "}");

                else if(yi[0] == -1 && yi[1] == -1 && yi[2] == -1 && yi[3] == -1 && yi[4] == -1 && yi[5] == -1 && yi[6] == 1
                    && yi[7] == -1 && yi[8] == -1 && yi[9] == -1)

                    MessageBox.Show("Número 6.\n{" + yi[0] + "," + yi[1] + "," + yi[2] + "," + yi[3] + "," + yi[4] + ","
                        + yi[5] + "," + yi[6] + "," + yi[7] + "," + yi[8] + "," + yi[9] + "}");

                else if(yi[0] == -1 && yi[1] == -1 && yi[2] == -1 && yi[3] == -1 && yi[4] == -1 && yi[5] == -1 && yi[6] == -1
                    && yi[7] == 1 && yi[8] == -1 && yi[9] == -1)

                    MessageBox.Show("Número 7.\n{" + yi[0] + "," + yi[1] + "," + yi[2] + "," + yi[3] + "," + yi[4] + ","
                        + yi[5] + "," + yi[6] + "," + yi[7] + "," + yi[8] + "," + yi[9] + "}");

                else if(yi[0] == -1 && yi[1] == -1 && yi[2] == -1 && yi[3] == -1 && yi[4] == -1 && yi[5] == -1 && yi[6] == -1
                    && yi[7] == -1 && yi[8] == 1 && yi[9] == -1)

                    MessageBox.Show("Número 8.\n{" + yi[0] + "," + yi[1] + "," + yi[2] + "," + yi[3] + "," + yi[4] + ","
                        + yi[5] + "," + yi[6] + "," + yi[7] + "," + yi[8] + "," + yi[9] + "}");

                else if(yi[0] == -1 && yi[1] == -1 && yi[2] == -1 && yi[3] == -1 && yi[4] == -1 && yi[5] == -1 && yi[6] == -1
                    && yi[7] == -1 && yi[8] == -1 && yi[9] == 1)

                    MessageBox.Show("Número 9.\n{" + yi[0] + "," + yi[1] + "," + yi[2] + "," + yi[3] + "," + yi[4] + ","
                        + yi[5] + "," + yi[6] + "," + yi[7] + "," + yi[8] + "," + yi[9] + "}");

                else
                
                    MessageBox.Show("Número irreconhecível.\n{" + yi[0] + "," + yi[1] + "," + yi[2] + "," + yi[3] + "," + yi[4] + ","
                        + yi[5] + "," + yi[6] + "," + yi[7] + "," + yi[8] + "," + yi[9] + "}");
            }

            else{

                if(yi[0] == -1 && yi[1] == -1 && yi[2] == -1 && yi[3] == -1)

                    MessageBox.Show("Número 0.\n{" + yi[0] + "," + yi[1] + "," + yi[2] + "," + yi[3] + "}");

                else if(yi[0] == -1 && yi[1] == -1 && yi[2] == -1 && yi[3] == 1)

                    MessageBox.Show("Número 1.\n{" + yi[0] + "," + yi[1] + "," + yi[2] + "," + yi[3] + "}");

                else if(yi[0] == -1 && yi[1] == -1 && yi[2] == 1 && yi[3] == -1)

                    MessageBox.Show("Número 2.\n{" + yi[0] + "," + yi[1] + "," + yi[2] + "," + yi[3] + "}");

                else if(yi[0] == -1 && yi[1] == -1 && yi[2] == 1 && yi[3] == 1)

                    MessageBox.Show("Número 3.\n{" + yi[0] + "," + yi[1] + "," + yi[2] + "," + yi[3] + "}");

                else if(yi[0] == -1 && yi[1] == 1 && yi[2] == -1 && yi[3] == -1)

                    MessageBox.Show("Número 4.\n{" + yi[0] + "," + yi[1] + "," + yi[2] + "," + yi[3] + "}");

                else if(yi[0] == -1 && yi[1] == 1 && yi[2] == -1 && yi[3] == 1)

                    MessageBox.Show("Número 5.\n{" + yi[0] + "," + yi[1] + "," + yi[2] + "," + yi[3] + "}");

                else if(yi[0] == -1 && yi[1] == 1 && yi[2] == 1 && yi[3] == -1)

                    MessageBox.Show("Número 6.\n{" + yi[0] + "," + yi[1] + "," + yi[2] + "," + yi[3] + "}");

                else if(yi[0] == -1 && yi[1] == 1 && yi[2] == 1 && yi[3] == 1)

                    MessageBox.Show("Número 7.\n{" + yi[0] + "," + yi[1] + "," + yi[2] + "," + yi[3] + "}");

                else if(yi[0] == 1 && yi[1] == -1 && yi[2] == -1 && yi[3] == -1)

                    MessageBox.Show("Número 8.\n{" + yi[0] + "," + yi[1] + "," + yi[2] + "," + yi[3] + "}");

                else if(yi[0] == 1 && yi[1] == -1 && yi[2] == -1 && yi[3] == 1)

                    MessageBox.Show("Número 9.\n{" + yi[0] + "," + yi[1] + "," + yi[2] + "," + yi[3] + "}");

                else

                    MessageBox.Show("Número irreconhecível.\n{" + yi[0] + "," + yi[1] + "," + yi[2] + "," + yi[3] + "}");
            }
        }

        private void Btruido_Click(object sender, EventArgs e){

            xi.Clear();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            ofd.Title = "Selecione uma imagem para adicionar ruído";
            ofd.InitialDirectory = "C:\\";

            result = new Bitmap(ofd.FileName);
            double p = double.Parse(tbporcentagem.Text);

            for(int i = 0; i < 229; i++){

                for(int j = 0; j < 299; j++){

                Random randl = new Random();
                int l = randl.Next(0, 100);

                if(l <= p * 100){

                        if(result.GetPixel(i, j).G == 255 && result.GetPixel(i, j).R == 255 && result.GetPixel(i, j).B == 255)

                            result.SetPixel(i, j, Color.Black);
                    }
            	}
            }

            result.Save("teste " + ind + ".bmp");

            MessageBox.Show("Ruído adicionado");

            ind++;
        }
    }
 }
