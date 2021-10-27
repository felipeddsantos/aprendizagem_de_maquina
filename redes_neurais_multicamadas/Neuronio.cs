/*

Aprendizagem de Máquina - Reconhecimento de Dígitos com Redes Neurais Multicamadas (Classe Neurônio)  
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReconhecimentoDeDigitos{

    class Neuronio{

        public List<double> w = new List<double>();
        public List<double> xi = new List<double>();
        public double y = 0;

        public void InicializarPesos(Random rdm, int j, int q){

            if(j == 0){

                for(int i = 0; i < q; i++)

                    w.Add(rdm.NextDouble());
            }

            else{

                for(int i = 0; i < xi.Count; i++)

                    w.Add(rdm.NextDouble());
            }
        }

        public double Saida(int i, int j){

            double sum = w[0];

            if(j == 0){

                for(int k = 1; k <= xi.Count; k++)

                    sum = sum + w[k] * xi[k-1];
            }

            else

                sum = sum + xi[2 * i] * w[1] + xi[2 * i + 1] * w[2];

            return sum;
        }

        public double FuncaoAtivadora(double x){

            return Math.Tanh(x);
        }

        public double DFuncaoAtivadora(double x){

            return 1 / Math.Pow(Math.Cosh(x),2);
        }

        public double Deltak(double yt, int i, int j){

            return (yt - y) * DFunçãoAtivadora(Saida(i, j));
        }

        public double Deltaj(double yt, int i, int j, int k, int l, List<Neuronio> N){

            return N[N.Count - 1].Deltak(yt, i, l) * N[N.Count - 1].w[j] * DFunçãoAtivadora(Saida(i, k));
        }
    }
}
