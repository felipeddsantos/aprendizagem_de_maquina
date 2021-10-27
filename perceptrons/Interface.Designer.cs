/*

Aprendizagem de Máquina - Funções Lógicas com Perceptron (Interface Gráfica)  
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿namespace FuncoesLogicas{

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
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.tbx8 = new System.Windows.Forms.TextBox();
            this.tbx7 = new System.Windows.Forms.TextBox();
            this.tbx3 = new System.Windows.Forms.TextBox();
            this.tbx6 = new System.Windows.Forms.TextBox();
            this.tbx5 = new System.Windows.Forms.TextBox();
            this.tbx4 = new System.Windows.Forms.TextBox();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tby4 = new System.Windows.Forms.TextBox();
            this.tby3 = new System.Windows.Forms.TextBox();
            this.tby2 = new System.Windows.Forms.TextBox();
            this.tby1 = new System.Windows.Forms.TextBox();
            this.tbb = new System.Windows.Forms.TextBox();
            this.tbw2 = new System.Windows.Forms.TextBox();
            this.tbw1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbalfa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(269, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Treinar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(269, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 41);
            this.button2.TabIndex = 1;
            this.button2.Text = "Testar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // tbx2
            // 
            this.tbx2.Location = new System.Drawing.Point(77, 112);
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(39, 20);
            this.tbx2.TabIndex = 2;
            // 
            // tbx8
            // 
            this.tbx8.Location = new System.Drawing.Point(77, 238);
            this.tbx8.Name = "tbx8";
            this.tbx8.Size = new System.Drawing.Size(39, 20);
            this.tbx8.TabIndex = 3;
            // 
            // tbx7
            // 
            this.tbx7.Location = new System.Drawing.Point(32, 238);
            this.tbx7.Name = "tbx7";
            this.tbx7.Size = new System.Drawing.Size(39, 20);
            this.tbx7.TabIndex = 4;
            // 
            // tbx3
            // 
            this.tbx3.Location = new System.Drawing.Point(32, 153);
            this.tbx3.Name = "tbx3";
            this.tbx3.Size = new System.Drawing.Size(39, 20);
            this.tbx3.TabIndex = 5;
            // 
            // tbx6
            // 
            this.tbx6.Location = new System.Drawing.Point(77, 194);
            this.tbx6.Name = "tbx6";
            this.tbx6.Size = new System.Drawing.Size(39, 20);
            this.tbx6.TabIndex = 6;
            // 
            // tbx5
            // 
            this.tbx5.Location = new System.Drawing.Point(32, 194);
            this.tbx5.Name = "tbx5";
            this.tbx5.Size = new System.Drawing.Size(39, 20);
            this.tbx5.TabIndex = 7;
            // 
            // tbx4
            // 
            this.tbx4.Location = new System.Drawing.Point(77, 153);
            this.tbx4.Name = "tbx4";
            this.tbx4.Size = new System.Drawing.Size(39, 20);
            this.tbx4.TabIndex = 8;
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(32, 112);
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(39, 20);
            this.tbx1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "X1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(81, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "X2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(126, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Y";
            // 
            // tby4
            // 
            this.tby4.Location = new System.Drawing.Point(122, 238);
            this.tby4.Name = "tby4";
            this.tby4.Size = new System.Drawing.Size(39, 20);
            this.tby4.TabIndex = 13;
            // 
            // tby3
            // 
            this.tby3.Location = new System.Drawing.Point(122, 194);
            this.tby3.Name = "tby3";
            this.tby3.Size = new System.Drawing.Size(39, 20);
            this.tby3.TabIndex = 14;
            // 
            // tby2
            // 
            this.tby2.Location = new System.Drawing.Point(122, 153);
            this.tby2.Name = "tby2";
            this.tby2.Size = new System.Drawing.Size(39, 20);
            this.tby2.TabIndex = 15;
            // 
            // tby1
            // 
            this.tby1.Location = new System.Drawing.Point(122, 112);
            this.tby1.Name = "tby1";
            this.tby1.Size = new System.Drawing.Size(39, 20);
            this.tby1.TabIndex = 16;
            // 
            // tbb
            // 
            this.tbb.Location = new System.Drawing.Point(525, 234);
            this.tbb.Name = "tbb";
            this.tbb.Size = new System.Drawing.Size(39, 20);
            this.tbb.TabIndex = 17;
            // 
            // tbw2
            // 
            this.tbw2.Location = new System.Drawing.Point(537, 180);
            this.tbw2.Name = "tbw2";
            this.tbw2.Size = new System.Drawing.Size(39, 20);
            this.tbw2.TabIndex = 18;
            // 
            // tbw1
            // 
            this.tbw1.Location = new System.Drawing.Point(537, 128);
            this.tbw1.Name = "tbw1";
            this.tbw1.Size = new System.Drawing.Size(39, 20);
            this.tbw1.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(500, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "b:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(500, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "W2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(500, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "W1:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(500, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "Parâmetros Iniciais:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(500, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 16);
            this.label8.TabIndex = 25;
            this.label8.Text = "Taxa de Aprendizagem:";
            // 
            // tbalfa
            // 
            this.tbalfa.Location = new System.Drawing.Point(658, 284);
            this.tbalfa.Name = "tbalfa";
            this.tbalfa.Size = new System.Drawing.Size(39, 20);
            this.tbalfa.TabIndex = 24;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbalfa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbw1);
            this.Controls.Add(this.tbw2);
            this.Controls.Add(this.tbb);
            this.Controls.Add(this.tby1);
            this.Controls.Add(this.tby2);
            this.Controls.Add(this.tby3);
            this.Controls.Add(this.tby4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbx1);
            this.Controls.Add(this.tbx4);
            this.Controls.Add(this.tbx5);
            this.Controls.Add(this.tbx6);
            this.Controls.Add(this.tbx3);
            this.Controls.Add(this.tbx7);
            this.Controls.Add(this.tbx8);
            this.Controls.Add(this.tbx2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Interface";
            this.Text = "Perceptron";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tbx2;
        private System.Windows.Forms.TextBox tbx8;
        private System.Windows.Forms.TextBox tbx7;
        private System.Windows.Forms.TextBox tbx3;
        private System.Windows.Forms.TextBox tbx6;
        private System.Windows.Forms.TextBox tbx5;
        private System.Windows.Forms.TextBox tbx4;
        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tby4;
        private System.Windows.Forms.TextBox tby3;
        private System.Windows.Forms.TextBox tby2;
        private System.Windows.Forms.TextBox tby1;
        private System.Windows.Forms.TextBox tbb;
        private System.Windows.Forms.TextBox tbw2;
        private System.Windows.Forms.TextBox tbw1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbalfa;
    }
}
