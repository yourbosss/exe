using System;
using System.Drawing;
using System.Windows.Forms;

namespace Exe
{
    partial class ExeForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartDichotomy = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblIntervalStart = new System.Windows.Forms.Label();
            this.txtInterval1 = new System.Windows.Forms.TextBox();
            this.lblIntervalEnd = new System.Windows.Forms.Label();
            this.txtInterval2 = new System.Windows.Forms.TextBox();
            this.lblPrecision = new System.Windows.Forms.Label();
            this.txtAccuracy = new System.Windows.Forms.TextBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.запуститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.покоординатныйСпускToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartDichotomy)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartDichotomy
            // 
            chartArea1.Name = "ChartArea1";
            this.chartDichotomy.ChartAreas.Add(chartArea1);
            this.chartDichotomy.Location = new System.Drawing.Point(473, 50);
            this.chartDichotomy.Name = "chartDichotomy";
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Lime;
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.White;
            this.chartDichotomy.Series.Add(series1);
            this.chartDichotomy.Size = new System.Drawing.Size(689, 424);
            this.chartDichotomy.TabIndex = 0;
            this.chartDichotomy.Text = "chart1";
            this.chartDichotomy.Click += new System.EventHandler(this.chartDichotomy_Click);
            // 
            // lblIntervalStart
            // 
            this.lblIntervalStart.Location = new System.Drawing.Point(20, 190);
            this.lblIntervalStart.Name = "lblIntervalStart";
            this.lblIntervalStart.Size = new System.Drawing.Size(100, 20);
            this.lblIntervalStart.TabIndex = 2;
            this.lblIntervalStart.Text = "Начало интервала";
            this.lblIntervalStart.Click += new System.EventHandler(this.lblIntervalStart_Click);
            // 
            // txtInterval1
            // 
            this.txtInterval1.Location = new System.Drawing.Point(150, 187);
            this.txtInterval1.Multiline = true;
            this.txtInterval1.Name = "txtInterval1";
            this.txtInterval1.Size = new System.Drawing.Size(200, 31);
            this.txtInterval1.TabIndex = 3;
            // 
            // lblIntervalEnd
            // 
            this.lblIntervalEnd.Location = new System.Drawing.Point(20, 240);
            this.lblIntervalEnd.Name = "lblIntervalEnd";
            this.lblIntervalEnd.Size = new System.Drawing.Size(100, 20);
            this.lblIntervalEnd.TabIndex = 4;
            this.lblIntervalEnd.Text = "Конец интервала";
            // 
            // txtInterval2
            // 
            this.txtInterval2.Location = new System.Drawing.Point(150, 240);
            this.txtInterval2.Multiline = true;
            this.txtInterval2.Name = "txtInterval2";
            this.txtInterval2.Size = new System.Drawing.Size(200, 29);
            this.txtInterval2.TabIndex = 5;
            // 
            // lblPrecision
            // 
            this.lblPrecision.Location = new System.Drawing.Point(20, 292);
            this.lblPrecision.Name = "lblPrecision";
            this.lblPrecision.Size = new System.Drawing.Size(100, 20);
            this.lblPrecision.TabIndex = 6;
            this.lblPrecision.Text = "Нужная точность";
            this.lblPrecision.Click += new System.EventHandler(this.lblPrecision_Click);
            // 
            // txtAccuracy
            // 
            this.txtAccuracy.Location = new System.Drawing.Point(150, 289);
            this.txtAccuracy.Multiline = true;
            this.txtAccuracy.Name = "txtAccuracy";
            this.txtAccuracy.Size = new System.Drawing.Size(200, 30);
            this.txtAccuracy.TabIndex = 7;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запуститьToolStripMenuItem,
            this.очиститьToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip.TabIndex = 8;
            // 
            // запуститьToolStripMenuItem
            // 
            this.запуститьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.покоординатныйСпускToolStripMenuItem});
            this.запуститьToolStripMenuItem.Name = "запуститьToolStripMenuItem";
            this.запуститьToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.запуститьToolStripMenuItem.Text = "Запустить";
            this.запуститьToolStripMenuItem.Click += new System.EventHandler(this.запуститьToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.toolStripMenuItem1.Text = "дихотомия";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.дихотомияToolStripMenuItem1_Click);
            // 
            // покоординатныйСпускToolStripMenuItem
            // 
            this.покоординатныйСпускToolStripMenuItem.Name = "покоординатныйСпускToolStripMenuItem";
            this.покоординатныйСпускToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.покоординатныйСпускToolStripMenuItem.Text = "покоординатный спуск";
            this.покоординатныйСпускToolStripMenuItem.Click += new System.EventHandler(this.покоординатныйСпускToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // formula
            // 
            this.formula.Location = new System.Drawing.Point(150, 50);
            this.formula.Multiline = true;
            this.formula.Name = "formula";
            this.formula.Size = new System.Drawing.Size(200, 46);
            this.formula.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Введите вашу формулу: ";
            // 
            // ExeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.formula);
            this.Controls.Add(this.chartDichotomy);
            this.Controls.Add(this.lblIntervalStart);
            this.Controls.Add(this.txtInterval1);
            this.Controls.Add(this.lblIntervalEnd);
            this.Controls.Add(this.txtInterval2);
            this.Controls.Add(this.lblPrecision);
            this.Controls.Add(this.txtAccuracy);
            this.Controls.Add(this.menuStrip);
            this.Name = "ExeForm";
            this.Text = "Программа.";
            this.Load += new System.EventHandler(this.DichotomyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartDichotomy)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartDichotomy;

        private readonly double golden = (1 + Math.Sqrt(5)) / 2; // Золотое сечение
        private Label lblIntervalStart;
        private Label lblIntervalEnd;
        private Label lblPrecision;
        private TextBox txtInterval1;
        private TextBox txtInterval2;
        private TextBox txtAccuracy;
        private MenuStrip menuStrip;
        private ToolStripMenuItem запуститьToolStripMenuItem;
        private ToolStripMenuItem очиститьToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem покоординатныйСпускToolStripMenuItem;
        private TextBox formula;
        private Label label1;
    }
}

