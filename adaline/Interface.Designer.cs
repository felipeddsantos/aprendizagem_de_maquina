/*

Aprendizagem de Máquina - Funções Lógicas com Adaline (Interface Gráfica)  
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
        
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.v1 = new System.Windows.Forms.TextBox();
            this.v2 = new System.Windows.Forms.TextBox();
            this.v3 = new System.Windows.Forms.TextBox();
            this.v4 = new System.Windows.Forms.TextBox();
            this.v17 = new System.Windows.Forms.TextBox();
            this.v5 = new System.Windows.Forms.TextBox();
            this.v6 = new System.Windows.Forms.TextBox();
            this.v7 = new System.Windows.Forms.TextBox();
            this.v8 = new System.Windows.Forms.TextBox();
            this.v18 = new System.Windows.Forms.TextBox();
            this.v9 = new System.Windows.Forms.TextBox();
            this.v10 = new System.Windows.Forms.TextBox();
            this.v11 = new System.Windows.Forms.TextBox();
            this.v12 = new System.Windows.Forms.TextBox();
            this.v19 = new System.Windows.Forms.TextBox();
            this.v13 = new System.Windows.Forms.TextBox();
            this.v14 = new System.Windows.Forms.TextBox();
            this.v15 = new System.Windows.Forms.TextBox();
            this.v16 = new System.Windows.Forms.TextBox();
            this.v20 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.TextBox();
            this.m = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.grafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(331, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Treinar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // v1
            // 
            this.v1.Location = new System.Drawing.Point(62, 65);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(25, 20);
            this.v1.TabIndex = 1;
            // 
            // v2
            // 
            this.v2.Location = new System.Drawing.Point(93, 65);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(25, 20);
            this.v2.TabIndex = 2;
            // 
            // v3
            // 
            this.v3.Location = new System.Drawing.Point(124, 65);
            this.v3.Name = "v3";
            this.v3.Size = new System.Drawing.Size(25, 20);
            this.v3.TabIndex = 3;
            // 
            // v4
            // 
            this.v4.Location = new System.Drawing.Point(155, 65);
            this.v4.Name = "v4";
            this.v4.Size = new System.Drawing.Size(25, 20);
            this.v4.TabIndex = 4;
            // 
            // v17
            // 
            this.v17.Location = new System.Drawing.Point(186, 65);
            this.v17.Name = "v17";
            this.v17.Size = new System.Drawing.Size(25, 20);
            this.v17.TabIndex = 5;
            // 
            // v5
            // 
            this.v5.Location = new System.Drawing.Point(62, 102);
            this.v5.Name = "v5";
            this.v5.Size = new System.Drawing.Size(25, 20);
            this.v5.TabIndex = 6;
            // 
            // v6
            // 
            this.v6.Location = new System.Drawing.Point(93, 102);
            this.v6.Name = "v6";
            this.v6.Size = new System.Drawing.Size(25, 20);
            this.v6.TabIndex = 7;
            // 
            // v7
            // 
            this.v7.Location = new System.Drawing.Point(124, 102);
            this.v7.Name = "v7";
            this.v7.Size = new System.Drawing.Size(25, 20);
            this.v7.TabIndex = 8;
            // 
            // v8
            // 
            this.v8.Location = new System.Drawing.Point(155, 102);
            this.v8.Name = "v8";
            this.v8.Size = new System.Drawing.Size(25, 20);
            this.v8.TabIndex = 9;
            // 
            // v18
            // 
            this.v18.Location = new System.Drawing.Point(186, 102);
            this.v18.Name = "v18";
            this.v18.Size = new System.Drawing.Size(25, 20);
            this.v18.TabIndex = 10;
            // 
            // v9
            // 
            this.v9.Location = new System.Drawing.Point(62, 138);
            this.v9.Name = "v9";
            this.v9.Size = new System.Drawing.Size(25, 20);
            this.v9.TabIndex = 11;
            // 
            // v10
            // 
            this.v10.Location = new System.Drawing.Point(93, 138);
            this.v10.Name = "v10";
            this.v10.Size = new System.Drawing.Size(25, 20);
            this.v10.TabIndex = 12;
            // 
            // v11
            // 
            this.v11.Location = new System.Drawing.Point(124, 138);
            this.v11.Name = "v11";
            this.v11.Size = new System.Drawing.Size(25, 20);
            this.v11.TabIndex = 13;
            // 
            // v12
            // 
            this.v12.Location = new System.Drawing.Point(155, 138);
            this.v12.Name = "v12";
            this.v12.Size = new System.Drawing.Size(25, 20);
            this.v12.TabIndex = 14;
            // 
            // v19
            // 
            this.v19.Location = new System.Drawing.Point(186, 138);
            this.v19.Name = "v19";
            this.v19.Size = new System.Drawing.Size(25, 20);
            this.v19.TabIndex = 15;
            // 
            // v13
            // 
            this.v13.Location = new System.Drawing.Point(62, 173);
            this.v13.Name = "v13";
            this.v13.Size = new System.Drawing.Size(25, 20);
            this.v13.TabIndex = 16;
            // 
            // v14
            // 
            this.v14.Location = new System.Drawing.Point(93, 173);
            this.v14.Name = "v14";
            this.v14.Size = new System.Drawing.Size(25, 20);
            this.v14.TabIndex = 17;
            // 
            // v15
            // 
            this.v15.Location = new System.Drawing.Point(124, 173);
            this.v15.Name = "v15";
            this.v15.Size = new System.Drawing.Size(25, 20);
            this.v15.TabIndex = 18;
            // 
            // v16
            // 
            this.v16.Location = new System.Drawing.Point(155, 173);
            this.v16.Name = "v16";
            this.v16.Size = new System.Drawing.Size(25, 20);
            this.v16.TabIndex = 19;
            // 
            // v20
            // 
            this.v20.Location = new System.Drawing.Point(186, 173);
            this.v20.Name = "v20";
            this.v20.Size = new System.Drawing.Size(25, 20);
            this.v20.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Vetor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Vetor 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Vetor 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "X1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Vetor 4";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "X4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "S";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(124, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "X3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "X2";
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(550, 71);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(44, 20);
            this.a.TabIndex = 30;
            // 
            // m
            // 
            this.m.Location = new System.Drawing.Point(524, 109);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(44, 20);
            this.m.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(395, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 16);
            this.label10.TabIndex = 32;
            this.label10.Text = "Tolerância de Erro:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(395, 72);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "Taxa de Aprendizagem:";
            // 
            // grafico
            // 
            chartArea1.Name = "ChartArea1";
            this.grafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.grafico.Legends.Add(legend1);
            this.grafico.Location = new System.Drawing.Point(666, 49);
            this.grafico.Name = "grafico";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Erro";
            this.grafico.Series.Add(series1);
            this.grafico.Size = new System.Drawing.Size(300, 300);
            this.grafico.TabIndex = 34;
            this.grafico.Text = "chart1";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1019, 450);
            this.Controls.Add(this.grafico);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.m);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.v20);
            this.Controls.Add(this.v16);
            this.Controls.Add(this.v15);
            this.Controls.Add(this.v14);
            this.Controls.Add(this.v13);
            this.Controls.Add(this.v19);
            this.Controls.Add(this.v12);
            this.Controls.Add(this.v11);
            this.Controls.Add(this.v10);
            this.Controls.Add(this.v9);
            this.Controls.Add(this.v18);
            this.Controls.Add(this.v8);
            this.Controls.Add(this.v7);
            this.Controls.Add(this.v6);
            this.Controls.Add(this.v5);
            this.Controls.Add(this.v17);
            this.Controls.Add(this.v4);
            this.Controls.Add(this.v3);
            this.Controls.Add(this.v2);
            this.Controls.Add(this.v1);
            this.Controls.Add(this.button1);
            this.Name = "Interface";
            this.Text = "Interface";
            ((System.ComponentModel.ISupportInitialize)(this.grafico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox v1;
        private System.Windows.Forms.TextBox v2;
        private System.Windows.Forms.TextBox v3;
        private System.Windows.Forms.TextBox v4;
        private System.Windows.Forms.TextBox v17;
        private System.Windows.Forms.TextBox v5;
        private System.Windows.Forms.TextBox v6;
        private System.Windows.Forms.TextBox v7;
        private System.Windows.Forms.TextBox v8;
        private System.Windows.Forms.TextBox v18;
        private System.Windows.Forms.TextBox v9;
        private System.Windows.Forms.TextBox v10;
        private System.Windows.Forms.TextBox v11;
        private System.Windows.Forms.TextBox v12;
        private System.Windows.Forms.TextBox v19;
        private System.Windows.Forms.TextBox v13;
        private System.Windows.Forms.TextBox v14;
        private System.Windows.Forms.TextBox v15;
        private System.Windows.Forms.TextBox v16;
        private System.Windows.Forms.TextBox v20;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox m;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataVisualization.Charting.Chart grafico;
    }
}
