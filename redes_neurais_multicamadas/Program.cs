/*

Aprendizagem de Máquina - Reconhecimento de Dígitos com Redes Neurais Multicamadas (Classe Principal)  
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReconhecimentoDeDigitos{

    static class Program{
        
        [STAThread]
        static void Main(){
        
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Interface());
        }
    }
}