namespace Pract_Diagrama_2
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartSector = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btGenerate = new System.Windows.Forms.Button();
            this.txtColvoEl = new System.Windows.Forms.TextBox();
            this.btCreateDiag = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.dgvMass = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.chartSector)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSector
            // 
            this.chartSector.BackColor = System.Drawing.Color.Moccasin;
            chartArea4.Name = "ChartArea1";
            this.chartSector.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartSector.Legends.Add(legend4);
            this.chartSector.Location = new System.Drawing.Point(6, 21);
            this.chartSector.Name = "chartSector";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.Legend = "Legend1";
            series4.Name = "Sector";
            this.chartSector.Series.Add(series4);
            this.chartSector.Size = new System.Drawing.Size(607, 368);
            this.chartSector.TabIndex = 0;
            this.chartSector.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMass);
            this.groupBox1.Controls.Add(this.txtColvoEl);
            this.groupBox1.Controls.Add(this.btGenerate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(872, 230);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Вхідні дані";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btExit);
            this.groupBox2.Controls.Add(this.btCreateDiag);
            this.groupBox2.Controls.Add(this.chartSector);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(13, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(872, 410);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Побудова діаграми";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(17, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введіть кількість елементів:";
            // 
            // btGenerate
            // 
            this.btGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btGenerate.Location = new System.Drawing.Point(20, 141);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(186, 71);
            this.btGenerate.TabIndex = 1;
            this.btGenerate.Text = "Сгенерувати пустий одновимірний масив";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // txtColvoEl
            // 
            this.txtColvoEl.Location = new System.Drawing.Point(20, 81);
            this.txtColvoEl.Name = "txtColvoEl";
            this.txtColvoEl.Size = new System.Drawing.Size(213, 24);
            this.txtColvoEl.TabIndex = 2;
            // 
            // btCreateDiag
            // 
            this.btCreateDiag.Location = new System.Drawing.Point(648, 122);
            this.btCreateDiag.Name = "btCreateDiag";
            this.btCreateDiag.Size = new System.Drawing.Size(179, 64);
            this.btCreateDiag.TabIndex = 1;
            this.btCreateDiag.Text = "Побудувати секторну діаграму";
            this.btCreateDiag.UseVisualStyleBackColor = true;
            this.btCreateDiag.Click += new System.EventHandler(this.btCreateDiag_Click);
            // 
            // btExit
            // 
            this.btExit.Location = new System.Drawing.Point(648, 236);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(179, 64);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Вихід";
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // dgvMass
            // 
            this.dgvMass.AllowUserToOrderColumns = true;
            this.dgvMass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMass.Location = new System.Drawing.Point(261, 23);
            this.dgvMass.Name = "dgvMass";
            this.dgvMass.RowHeadersWidth = 51;
            this.dgvMass.RowTemplate.Height = 24;
            this.dgvMass.Size = new System.Drawing.Size(590, 189);
            this.dgvMass.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 680);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Секторна діаграма";
            ((System.ComponentModel.ISupportInitialize)(this.chartSector)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartSector;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMass;
        private System.Windows.Forms.TextBox txtColvoEl;
        private System.Windows.Forms.Button btGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btCreateDiag;
    }
}

