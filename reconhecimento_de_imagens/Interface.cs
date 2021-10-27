/*

Aprendizagem de Máquina - Reconhecimento de Imagens com Algoritmo de Hebb (Programa Principal)  
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

namespace ReconhecimentoDeImagens{

    public partial class Interface : Form{
    
        public Interface(){
        
            InitializeComponent();
        }

        float[] bitsF = new float[2000];
        float[] bitsS = new float[2000];
        float[] parametros = new float[2000];
        int i = 0;
        float soma = 0;
        
        private void Bt1_Click(object sender, EventArgs e){
        
            FileStream arcF = File.OpenRead(tb1.Text);

            FileStream arcS = File.OpenRead(tb2.Text);

            while(arcF.CanRead && arcF.Position < arcF.Length){

                bitsF[i] = (int)arcF.ReadByte() - 48;

                if(bitsF[i] != 0 && bitsF[i] != 1)
                
                    continue;
                    
                if(bitsF[i] == 0)
                
                    bitsF[i] = -1;
                    
                i++;
            }

            i = 0;

            while(arcS.CanRead && arcS.Position < arcS.Length){

                bitsS[i] = (int)arcS.ReadByte() - 48;

                if(bitsS[i] != 0 && bitsS[i] != 1)
                
                    continue;

                if(bitsS[i] == 0)
                
                    bitsS[i] = -1;

                i++;
            }

            for(int j = 0; j <= 1240; j++)
            
                parametros[j] = bitsF[j] - bitsS[j];
            
            //O bias será zero, pois b = 1 - 1 (a soma das saídas)
            //O limiar foi arbitrado em t = 0

            MessageBox.Show("Neurônio treinado com sucesso");

            i = 0;

            tb1.Text = "";
            tb2.Text = "";

            arcF.Dispose();
            arcS.Dispose();
        }

        private void Bt2_Click(object sender, EventArgs e){

            FileStream arc = File.OpenRead(tb3.Text);
            
            soma = 0;
            int[] bits = new int[2000];
            int i = 0;

            while(arc.CanRead && arc.Position < arc.Length){

                bits[i] = (int)arc.ReadByte() - 48;

                if(bits[i] != 0 && bits[i] != 1)
                
                    continue;

                if(bits[i] == 0)
                
                    bits[i] = -1;

                i++;
            }

            for(int j = 0; j <= 1239; j++)

                soma = bits[j] * parametros[j] + soma;
                
            if(soma >= 0)

                MessageBox.Show("Letra F");

            if(soma < 0)

                MessageBox.Show("Letra S");

            arc.Dispose();
        }
    }
}
