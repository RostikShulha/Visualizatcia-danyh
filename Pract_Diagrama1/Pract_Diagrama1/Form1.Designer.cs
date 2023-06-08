namespace Pract_Diagrama1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea11 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea12 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend11 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend12 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btCreateMasGist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMinYear = new System.Windows.Forms.TextBox();
            this.txtMasGist = new System.Windows.Forms.TextBox();
            this.dgvMasGist = new System.Windows.Forms.DataGridView();
            this.dgvMasRound = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btCreateMasRound = new System.Windows.Forms.Button();
            this.txtMinAge = new System.Windows.Forms.TextBox();
            this.txtMasRound = new System.Windows.Forms.TextBox();
            this.chartDiagrams = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btCreateGist = new System.Windows.Forms.Button();
            this.btCreateRound = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasGist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasRound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagrams)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMasGist);
            this.groupBox1.Controls.Add(this.txtMasGist);
            this.groupBox1.Controls.Add(this.txtMinYear);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btCreateMasGist);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(589, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 208);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дані для гістограми";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMinAge);
            this.groupBox2.Controls.Add(this.txtMasRound);
            this.groupBox2.Controls.Add(this.btCreateMasRound);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dgvMasRound);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(589, 255);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(601, 249);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дані для кругової діаграми";
            // 
            // btCreateMasGist
            // 
            this.btCreateMasGist.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCreateMasGist.Location = new System.Drawing.Point(328, 33);
            this.btCreateMasGist.Name = "btCreateMasGist";
            this.btCreateMasGist.Size = new System.Drawing.Size(253, 61);
            this.btCreateMasGist.TabIndex = 0;
            this.btCreateMasGist.Text = "Згенерувати пустий масив";
            this.btCreateMasGist.UseVisualStyleBackColor = true;
            this.btCreateMasGist.Click += new System.EventHandler(this.btCreateMasGist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введіть початковий рік:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введіть кількість років:";
            // 
            // txtMinYear
            // 
            this.txtMinYear.Location = new System.Drawing.Point(218, 36);
            this.txtMinYear.Name = "txtMinYear";
            this.txtMinYear.Size = new System.Drawing.Size(104, 24);
            this.txtMinYear.TabIndex = 3;
            // 
            // txtMasGist
            // 
            this.txtMasGist.Location = new System.Drawing.Point(219, 73);
            this.txtMasGist.Name = "txtMasGist";
            this.txtMasGist.Size = new System.Drawing.Size(104, 24);
            this.txtMasGist.TabIndex = 4;
            // 
            // dgvMasGist
            // 
            this.dgvMasGist.AllowUserToOrderColumns = true;
            this.dgvMasGist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasGist.Location = new System.Drawing.Point(19, 115);
            this.dgvMasGist.Name = "dgvMasGist";
            this.dgvMasGist.RowHeadersWidth = 51;
            this.dgvMasGist.RowTemplate.Height = 24;
            this.dgvMasGist.Size = new System.Drawing.Size(562, 87);
            this.dgvMasGist.TabIndex = 5;
            // 
            // dgvMasRound
            // 
            this.dgvMasRound.AllowUserToOrderColumns = true;
            this.dgvMasRound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMasRound.Location = new System.Drawing.Point(19, 156);
            this.dgvMasRound.Name = "dgvMasRound";
            this.dgvMasRound.RowHeadersWidth = 51;
            this.dgvMasRound.RowTemplate.Height = 24;
            this.dgvMasRound.Size = new System.Drawing.Size(562, 87);
            this.dgvMasRound.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Введіть кількість\r\nвікових категорій:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Введіть мінімальний\r\nвік:";
            // 
            // btCreateMasRound
            // 
            this.btCreateMasRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCreateMasRound.Location = new System.Drawing.Point(328, 34);
            this.btCreateMasRound.Name = "btCreateMasRound";
            this.btCreateMasRound.Size = new System.Drawing.Size(253, 72);
            this.btCreateMasRound.TabIndex = 5;
            this.btCreateMasRound.Text = "Згенерувати пустий масив";
            this.btCreateMasRound.UseVisualStyleBackColor = true;
            this.btCreateMasRound.Click += new System.EventHandler(this.btCreateMasRound_Click);
            // 
            // txtMinAge
            // 
            this.txtMinAge.Location = new System.Drawing.Point(205, 82);
            this.txtMinAge.Name = "txtMinAge";
            this.txtMinAge.Size = new System.Drawing.Size(104, 24);
            this.txtMinAge.TabIndex = 7;
            // 
            // txtMasRound
            // 
            this.txtMasRound.Location = new System.Drawing.Point(205, 34);
            this.txtMasRound.Name = "txtMasRound";
            this.txtMasRound.Size = new System.Drawing.Size(104, 24);
            this.txtMasRound.TabIndex = 6;
            // 
            // chartDiagrams
            // 
            this.chartDiagrams.BackColor = System.Drawing.Color.NavajoWhite;
            this.chartDiagrams.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            chartArea11.Name = "ChartArea1";
            chartArea12.Name = "ChartArea2";
            this.chartDiagrams.ChartAreas.Add(chartArea11);
            this.chartDiagrams.ChartAreas.Add(chartArea12);
            legend11.Name = "Legend1";
            legend12.Name = "Legend2";
            legend12.Position.Auto = false;
            legend12.Position.Height = 19.26229F;
            legend12.Position.Width = 29F;
            legend12.Position.X = 70F;
            legend12.Position.Y = 52F;
            legend12.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Tall;
            this.chartDiagrams.Legends.Add(legend11);
            this.chartDiagrams.Legends.Add(legend12);
            this.chartDiagrams.Location = new System.Drawing.Point(12, 12);
            this.chartDiagrams.Name = "chartDiagrams";
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Кількість учнів";
            series11.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series12.ChartArea = "ChartArea2";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series12.Legend = "Legend1";
            series12.Name = "Sector";
            this.chartDiagrams.Series.Add(series11);
            this.chartDiagrams.Series.Add(series12);
            this.chartDiagrams.Size = new System.Drawing.Size(556, 521);
            this.chartDiagrams.TabIndex = 2;
            this.chartDiagrams.Text = "chart1";
            // 
            // btCreateGist
            // 
            this.btCreateGist.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCreateGist.Location = new System.Drawing.Point(33, 543);
            this.btCreateGist.Name = "btCreateGist";
            this.btCreateGist.Size = new System.Drawing.Size(252, 45);
            this.btCreateGist.TabIndex = 3;
            this.btCreateGist.Text = "Побудувати гістограму";
            this.btCreateGist.UseVisualStyleBackColor = true;
            this.btCreateGist.Click += new System.EventHandler(this.btCreateGist_Click);
            // 
            // btCreateRound
            // 
            this.btCreateRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btCreateRound.Location = new System.Drawing.Point(325, 542);
            this.btCreateRound.Name = "btCreateRound";
            this.btCreateRound.Size = new System.Drawing.Size(315, 46);
            this.btCreateRound.TabIndex = 4;
            this.btCreateRound.Text = "Побудувати кругову діаграму";
            this.btCreateRound.UseVisualStyleBackColor = true;
            this.btCreateRound.Click += new System.EventHandler(this.btCreateRound_Click);
            // 
            // btExit
            // 
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btExit.Location = new System.Drawing.Point(794, 542);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(198, 46);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Вихід";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1213, 610);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btCreateRound);
            this.Controls.Add(this.btCreateGist);
            this.Controls.Add(this.chartDiagrams);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Діаграми";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasGist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMasRound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDiagrams)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMasGist;
        private System.Windows.Forms.TextBox txtMasGist;
        private System.Windows.Forms.TextBox txtMinYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btCreateMasGist;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMinAge;
        private System.Windows.Forms.TextBox txtMasRound;
        private System.Windows.Forms.Button btCreateMasRound;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvMasRound;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiagrams;
        private System.Windows.Forms.Button btCreateGist;
        private System.Windows.Forms.Button btCreateRound;
        private System.Windows.Forms.Button btExit;
    }
}

