/*

Aprendizagem de Máquina - Otimização com Evolução Diferencial (Interface Gráfica)  
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿namespace Otimizacao{

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
        
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbF = new System.Windows.Forms.TextBox();
            this.tbNP = new System.Windows.Forms.TextBox();
            this.tbCR = new System.Windows.Forms.TextBox();
            this.tbG = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbL1 = new System.Windows.Forms.TextBox();
            this.tbL0 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(492, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 101);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gerar População";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(492, 233);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 101);
            this.button2.TabIndex = 1;
            this.button2.Text = "Evoluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // tbF
            // 
            this.tbF.Location = new System.Drawing.Point(220, 28);
            this.tbF.Name = "tbF";
            this.tbF.Size = new System.Drawing.Size(100, 20);
            this.tbF.TabIndex = 2;
            // 
            // tbNP
            // 
            this.tbNP.Location = new System.Drawing.Point(249, 158);
            this.tbNP.Name = "tbNP";
            this.tbNP.Size = new System.Drawing.Size(100, 20);
            this.tbNP.TabIndex = 3;
            // 
            // tbCR
            // 
            this.tbCR.Location = new System.Drawing.Point(256, 89);
            this.tbCR.Name = "tbCR";
            this.tbCR.Size = new System.Drawing.Size(100, 20);
            this.tbCR.TabIndex = 4;
            // 
            // tbG
            // 
            this.tbG.Location = new System.Drawing.Point(248, 232);
            this.tbG.Name = "tbG";
            this.tbG.Size = new System.Drawing.Size(100, 20);
            this.tbG.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fator de Perturbação:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Constante de Cruzamento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Quantidade de Indivíduos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quantidade de Gerações:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(254, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dimensão da Função de Rastrigin:";
            // 
            // tbd
            // 
            this.tbd.Location = new System.Drawing.Point(310, 304);
            this.tbd.Name = "tbd";
            this.tbd.Size = new System.Drawing.Size(100, 20);
            this.tbd.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(50, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Campo de Busca:";
            // 
            // tbL1
            // 
            this.tbL1.Location = new System.Drawing.Point(297, 376);
            this.tbL1.Name = "tbL1";
            this.tbL1.Size = new System.Drawing.Size(100, 20);
            this.tbL1.TabIndex = 12;
            // 
            // tbL0
            // 
            this.tbL0.Location = new System.Drawing.Point(191, 376);
            this.tbL0.Name = "tbL0";
            this.tbL0.Size = new System.Drawing.Size(100, 20);
            this.tbL0.TabIndex = 14;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbL0);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbL1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbG);
            this.Controls.Add(this.tbCR);
            this.Controls.Add(this.tbNP);
            this.Controls.Add(this.tbF);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Interface";
            this.Text = "Otimizacao";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbF;
        private System.Windows.Forms.TextBox tbNP;
        private System.Windows.Forms.TextBox tbCR;
        private System.Windows.Forms.TextBox tbG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbL1;
        private System.Windows.Forms.TextBox tbL0;
    }
}
