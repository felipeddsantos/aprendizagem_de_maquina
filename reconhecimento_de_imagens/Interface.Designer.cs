/*

Aprendizagem de Máquina - Reconhecimento de Imagens com Algoritmo de Hebb (Interface Gráfica)  
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿namespace ReconhecimentoDeImagens{

    partial class Interface{

        ///Variável de designer necessária
        private System.ComponentModel.IContainer components = null;

        ///Limpar os recursos que estão sendo usados
        protected override void Dispose(bool disposing){
        
            if(disposing && (components != null))
            
                components.Dispose();
            
            base.Dispose(disposing);
        }

        ///Método necessário para suporte ao Designer - não modifique o conteúdo deste método com o editor de código
        private void InitializeComponent(){
        
            this.bt1 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(12, 28);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(107, 39);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "Treinar";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.Bt1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(12, 219);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(107, 39);
            this.bt2.TabIndex = 1;
            this.bt2.Text = "Testar";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.Bt2_Click);
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(153, 28);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(182, 20);
            this.tb1.TabIndex = 2;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(153, 54);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(182, 20);
            this.tb2.TabIndex = 3;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(153, 229);
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(182, 20);
            this.tb3.TabIndex = 4;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt1);
            this.Name = "Interface";
            this.Text = "Interface";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb3;
    }
}
