namespace Pract_ChartBox
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKrok = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkDil = new System.Windows.Forms.CheckBox();
            this.chkSqrtx = new System.Windows.Forms.CheckBox();
            this.chkSin2x = new System.Windows.Forms.CheckBox();
            this.chkCos = new System.Windows.Forms.CheckBox();
            this.chkSin = new System.Windows.Forms.CheckBox();
            this.chartGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btCalc = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.cbGraphics = new System.Windows.Forms.ComboBox();
            this.txtZnach = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKrok);
            this.groupBox1.Controls.Add(this.txtMax);
            this.groupBox1.Controls.Add(this.txtMin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(562, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Початкові дані";
            // 
            // txtKrok
            // 
            this.txtKrok.Location = new System.Drawing.Point(130, 92);
            this.txtKrok.Name = "txtKrok";
            this.txtKrok.Size = new System.Drawing.Size(134, 24);
            this.txtKrok.TabIndex = 5;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(130, 59);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(134, 24);
            this.txtMax.TabIndex = 4;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(129, 24);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(134, 24);
            this.txtMin.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Введіть крок:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Введіть Xmax:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введіть Xmin:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbGraphics);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(837, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(221, 127);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Значення графіку";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Виберіть функцію, значення\r\nякої треба показати:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkDil);
            this.groupBox3.Controls.Add(this.chkSqrtx);
            this.groupBox3.Controls.Add(this.chkSin2x);
            this.groupBox3.Controls.Add(this.chkCos);
            this.groupBox3.Controls.Add(this.chkSin);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(562, 162);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 279);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Побудова графіків";
            // 
            // chkDil
            // 
            this.chkDil.AutoSize = true;
            this.chkDil.Location = new System.Drawing.Point(7, 231);
            this.chkDil.Name = "chkDil";
            this.chkDil.Size = new System.Drawing.Size(163, 40);
            this.chkDil.TabIndex = 4;
            this.chkDil.Text = "Побудувати графік\r\n(4 + x)/( x^2)";
            this.chkDil.UseVisualStyleBackColor = true;
            // 
            // chkSqrtx
            // 
            this.chkSqrtx.AutoSize = true;
            this.chkSqrtx.Location = new System.Drawing.Point(7, 185);
            this.chkSqrtx.Name = "chkSqrtx";
            this.chkSqrtx.Size = new System.Drawing.Size(163, 40);
            this.chkSqrtx.TabIndex = 3;
            this.chkSqrtx.Text = "Побудувати графік\r\n√x";
            this.chkSqrtx.UseVisualStyleBackColor = true;
            // 
            // chkSin2x
            // 
            this.chkSin2x.AutoSize = true;
            this.chkSin2x.Location = new System.Drawing.Point(7, 122);
            this.chkSin2x.Name = "chkSin2x";
            this.chkSin2x.Size = new System.Drawing.Size(163, 40);
            this.chkSin2x.TabIndex = 2;
            this.chkSin2x.Text = "Побудувати графік\r\nsin(x) + 2*x";
            this.chkSin2x.UseVisualStyleBackColor = true;
            // 
            // chkCos
            // 
            this.chkCos.AutoSize = true;
            this.chkCos.Location = new System.Drawing.Point(7, 76);
            this.chkCos.Name = "chkCos";
            this.chkCos.Size = new System.Drawing.Size(209, 22);
            this.chkCos.TabIndex = 1;
            this.chkCos.Text = "Побудувати графік cos(x)";
            this.chkCos.UseVisualStyleBackColor = true;
            // 
            // chkSin
            // 
            this.chkSin.AutoSize = true;
            this.chkSin.Location = new System.Drawing.Point(7, 24);
            this.chkSin.Name = "chkSin";
            this.chkSin.Size = new System.Drawing.Size(203, 22);
            this.chkSin.TabIndex = 0;
            this.chkSin.Text = "Побудувати графік sin(x)";
            this.chkSin.UseVisualStyleBackColor = true;
            // 
            // chartGraph
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGraph.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGraph.Legends.Add(legend2);
            this.chartGraph.Location = new System.Drawing.Point(24, 15);
            this.chartGraph.Name = "chartGraph";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Sin(x)";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "Cos(x)";
            series8.BorderWidth = 2;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Cos(x) + 2*x";
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "√x";
            series10.BorderWidth = 2;
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "(x + 4)/(x^2)";
            this.chartGraph.Series.Add(series6);
            this.chartGraph.Series.Add(series7);
            this.chartGraph.Series.Add(series8);
            this.chartGraph.Series.Add(series9);
            this.chartGraph.Series.Add(series10);
            this.chartGraph.Size = new System.Drawing.Size(516, 616);
            this.chartGraph.TabIndex = 3;
            this.chartGraph.Text = "chart1";
            this.chartGraph.EnabledChanged += new System.EventHandler(this.Form1_Load);
            // 
            // btCalc
            // 
            this.btCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCalc.Location = new System.Drawing.Point(591, 459);
            this.btCalc.Name = "btCalc";
            this.btCalc.Size = new System.Drawing.Size(158, 46);
            this.btCalc.TabIndex = 4;
            this.btCalc.Text = "Розрахунок";
            this.btCalc.UseVisualStyleBackColor = true;
            this.btCalc.Click += new System.EventHandler(this.btCalc_Click);
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btClear.Location = new System.Drawing.Point(591, 520);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(158, 46);
            this.btClear.TabIndex = 5;
            this.btClear.Text = "Очистка графіків";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btExit.Location = new System.Drawing.Point(591, 582);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(158, 46);
            this.btExit.TabIndex = 6;
            this.btExit.Text = "Вихід";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // cbGraphics
            // 
            this.cbGraphics.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGraphics.FormattingEnabled = true;
            this.cbGraphics.Location = new System.Drawing.Point(9, 95);
            this.cbGraphics.Name = "cbGraphics";
            this.cbGraphics.Size = new System.Drawing.Size(200, 26);
            this.cbGraphics.TabIndex = 1;
            // 
            // txtZnach
            // 
            this.txtZnach.Location = new System.Drawing.Point(808, 162);
            this.txtZnach.Multiline = true;
            this.txtZnach.Name = "txtZnach";
            this.txtZnach.Size = new System.Drawing.Size(250, 466);
            this.txtZnach.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 643);
            this.Controls.Add(this.txtZnach);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btCalc);
            this.Controls.Add(this.chartGraph);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGraph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKrok;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkDil;
        private System.Windows.Forms.CheckBox chkSqrtx;
        private System.Windows.Forms.CheckBox chkSin2x;
        private System.Windows.Forms.CheckBox chkCos;
        private System.Windows.Forms.CheckBox chkSin;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGraph;
        private System.Windows.Forms.Button btCalc;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.ComboBox cbGraphics;
        private System.Windows.Forms.TextBox txtZnach;
    }
}

