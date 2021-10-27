/*

Aprendizagem de Máquina - Reconhecimento de Dígitos com Redes Neurais Multicamadas (Interface Gráfica)  
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
        
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bt1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbalfa = new System.Windows.Forms.TextBox();
            this.v2 = new System.Windows.Forms.TextBox();
            this.v12 = new System.Windows.Forms.TextBox();
            this.v11 = new System.Windows.Forms.TextBox();
            this.v9 = new System.Windows.Forms.TextBox();
            this.v8 = new System.Windows.Forms.TextBox();
            this.v6 = new System.Windows.Forms.TextBox();
            this.v5 = new System.Windows.Forms.TextBox();
            this.v3 = new System.Windows.Forms.TextBox();
            this.v1 = new System.Windows.Forms.TextBox();
            this.v10 = new System.Windows.Forms.TextBox();
            this.v7 = new System.Windows.Forms.TextBox();
            this.v4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbq = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(372, 388);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(106, 50);
            this.bt1.TabIndex = 0;
            this.bt1.Text = "Treinar";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.Bt1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(575, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Testar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // grafico
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico.Legends.Add(legend1);
            this.grafico.Location = new System.Drawing.Point(335, 22);
            this.grafico.Name = "grafico";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Erro";
            this.grafico.Series.Add(series1);
            this.grafico.Size = new System.Drawing.Size(433, 332);
            this.grafico.TabIndex = 2;
            this.grafico.Text = "chart1";
            // 
            // tbalfa
            // 
            this.tbalfa.Location = new System.Drawing.Point(170, 305);
            this.tbalfa.Name = "tbalfa";
            this.tbalfa.Size = new System.Drawing.Size(100, 20);
            this.tbalfa.TabIndex = 3;
            // 
            // v2
            // 
            this.v2.Location = new System.Drawing.Point(104, 92);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(50, 20);
            this.v2.TabIndex = 4;
            // 
            // v12
            // 
            this.v12.Location = new System.Drawing.Point(160, 170);
            this.v12.Name = "v12";
            this.v12.Size = new System.Drawing.Size(50, 20);
            this.v12.TabIndex = 5;
            // 
            // v11
            // 
            this.v11.Location = new System.Drawing.Point(104, 170);
            this.v11.Name = "v11";
            this.v11.Size = new System.Drawing.Size(50, 20);
            this.v11.TabIndex = 6;
            // 
            // v9
            // 
            this.v9.Location = new System.Drawing.Point(160, 144);
            this.v9.Name = "v9";
            this.v9.Size = new System.Drawing.Size(50, 20);
            this.v9.TabIndex = 7;
            // 
            // v8
            // 
            this.v8.Location = new System.Drawing.Point(104, 144);
            this.v8.Name = "v8";
            this.v8.Size = new System.Drawing.Size(50, 20);
            this.v8.TabIndex = 8;
            // 
            // v6
            // 
            this.v6.Location = new System.Drawing.Point(160, 118);
            this.v6.Name = "v6";
            this.v6.Size = new System.Drawing.Size(50, 20);
            this.v6.TabIndex = 9;
            // 
            // v5
            // 
            this.v5.Location = new System.Drawing.Point(104, 118);
            this.v5.Name = "v5";
            this.v5.Size = new System.Drawing.Size(50, 20);
            this.v5.TabIndex = 10;
            // 
            // v3
            // 
            this.v3.Location = new System.Drawing.Point(160, 92);
            this.v3.Name = "v3";
            this.v3.Size = new System.Drawing.Size(50, 20);
            this.v3.TabIndex = 11;
            // 
            // v1
            // 
            this.v1.Location = new System.Drawing.Point(48, 92);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(50, 20);
            this.v1.TabIndex = 12;
            // 
            // v10
            // 
            this.v10.Location = new System.Drawing.Point(48, 170);
            this.v10.Name = "v10";
            this.v10.Size = new System.Drawing.Size(50, 20);
            this.v10.TabIndex = 13;
            // 
            // v7
            // 
            this.v7.Location = new System.Drawing.Point(48, 144);
            this.v7.Name = "v7";
            this.v7.Size = new System.Drawing.Size(50, 20);
            this.v7.TabIndex = 14;
            // 
            // v4
            // 
            this.v4.Location = new System.Drawing.Point(48, 118);
            this.v4.Name = "v4";
            this.v4.Size = new System.Drawing.Size(50, 20);
            this.v4.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tabela Verdade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "X2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Taxa de Aprendizagem:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Neurônios Camada Escondida:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "X1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Parâmetros";
            // 
            // tbq
            // 
            this.tbq.Location = new System.Drawing.Point(214, 334);
            this.tbq.Name = "tbq";
            this.tbq.Size = new System.Drawing.Size(100, 20);
            this.tbq.TabIndex = 24;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbq);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.v4);
            this.Controls.Add(this.v7);
            this.Controls.Add(this.v10);
            this.Controls.Add(this.v1);
            this.Controls.Add(this.v3);
            this.Controls.Add(this.v5);
            this.Controls.Add(this.v6);
            this.Controls.Add(this.v8);
            this.Controls.Add(this.v9);
            this.Controls.Add(this.v11);
            this.Controls.Add(this.v12);
            this.Controls.Add(this.v2);
            this.Controls.Add(this.tbalfa);
            this.Controls.Add(this.grafico);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt1);
            this.Name = "Interface";
            this.Text = "Rede Multicamadas";
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
        private System.Windows.Forms.TextBox tbalfa;
        private System.Windows.Forms.TextBox v2;
        private System.Windows.Forms.TextBox v12;
        private System.Windows.Forms.TextBox v11;
        private System.Windows.Forms.TextBox v9;
        private System.Windows.Forms.TextBox v8;
        private System.Windows.Forms.TextBox v6;
        private System.Windows.Forms.TextBox v5;
        private System.Windows.Forms.TextBox v3;
        private System.Windows.Forms.TextBox v1;
        private System.Windows.Forms.TextBox v10;
        private System.Windows.Forms.TextBox v7;
        private System.Windows.Forms.TextBox v4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbq;
    }
}
