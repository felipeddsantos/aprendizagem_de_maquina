/*

Aprendizagem de Máquina - Reconhecimento de Dígitos com Perceptron (Interface Gráfica)  
Felipe Daniel Dias dos Santos - 11711ECP004
Graduação em Engenharia de Computação - Faculdade de Engenharia Elétrica - Universidade Federal de Uberlândia

*/

﻿namespace ReconhecimentoDeDigitos{

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
        
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbb = new System.Windows.Forms.TextBox();
            this.tbwi = new System.Windows.Forms.TextBox();
            this.tbalfa = new System.Windows.Forms.TextBox();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbporcentagem = new System.Windows.Forms.TextBox();
            this.btruido = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 326);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rb10);
            this.tabPage1.Controls.Add(this.rb4);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbb);
            this.tabPage1.Controls.Add(this.tbwi);
            this.tabPage1.Controls.Add(this.tbalfa);
            this.tabPage1.Controls.Add(this.bt2);
            this.tabPage1.Controls.Add(this.bt);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 300);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Treinamento";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btruido);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbporcentagem);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 300);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ruído";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb10.Location = new System.Drawing.Point(65, 96);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(105, 20);
            this.rb10.TabIndex = 43;
            this.rb10.TabStop = true;
            this.rb10.Text = "10 Neurônios";
            this.rb10.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            this.rb4.AutoSize = true;
            this.rb4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb4.Location = new System.Drawing.Point(65, 150);
            this.rb4.Name = "rb4";
            this.rb4.Size = new System.Drawing.Size(98, 20);
            this.rb4.TabIndex = 42;
            this.rb4.TabStop = true;
            this.rb4.Text = "4 Neurônios";
            this.rb4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(471, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Parâmetros:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(471, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Pesos Iniciais:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(471, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Bias:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(471, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Taxa de Aprendizado:";
            // 
            // tbb
            // 
            this.tbb.Location = new System.Drawing.Point(515, 204);
            this.tbb.Name = "tbb";
            this.tbb.Size = new System.Drawing.Size(100, 20);
            this.tbb.TabIndex = 37;
            // 
            // tbwi
            // 
            this.tbwi.Location = new System.Drawing.Point(571, 146);
            this.tbwi.Name = "tbwi";
            this.tbwi.Size = new System.Drawing.Size(100, 20);
            this.tbwi.TabIndex = 36;
            // 
            // tbalfa
            // 
            this.tbalfa.Location = new System.Drawing.Point(618, 92);
            this.tbalfa.Name = "tbalfa";
            this.tbalfa.Size = new System.Drawing.Size(100, 20);
            this.tbalfa.TabIndex = 35;
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(208, 184);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(116, 59);
            this.bt2.TabIndex = 34;
            this.bt2.Text = "Testar";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.Bt2_Click);
            // 
            // bt
            // 
            this.bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt.Location = new System.Drawing.Point(208, 44);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(116, 59);
            this.bt.TabIndex = 33;
            this.bt.Text = "Treinar";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.Bt_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "Proporção:";
            // 
            // tbporcentagem
            // 
            this.tbporcentagem.Location = new System.Drawing.Point(428, 144);
            this.tbporcentagem.Name = "tbporcentagem";
            this.tbporcentagem.Size = new System.Drawing.Size(100, 20);
            this.tbporcentagem.TabIndex = 39;
            // 
            // btruido
            // 
            this.btruido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btruido.Location = new System.Drawing.Point(121, 123);
            this.btruido.Name = "btruido";
            this.btruido.Size = new System.Drawing.Size(116, 59);
            this.btruido.TabIndex = 41;
            this.btruido.Text = "Adicionar Ruído";
            this.btruido.UseVisualStyleBackColor = true;
            this.btruido.Click += new System.EventHandler(this.Btruido_Click);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Interface";
            this.Text = "Reconhecimento de Dígitos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RadioButton rb10;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbb;
        private System.Windows.Forms.TextBox tbwi;
        private System.Windows.Forms.TextBox tbalfa;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btruido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbporcentagem;
    }
}
