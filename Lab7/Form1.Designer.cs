namespace Lab7
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.aBoundLabel = new System.Windows.Forms.Label();
            this.bBoundLabel = new System.Windows.Forms.Label();
            this.nLabel = new System.Windows.Forms.Label();
            this.aBoundValue = new System.Windows.Forms.TextBox();
            this.bBoundValue = new System.Windows.Forms.TextBox();
            this.nValue = new System.Windows.Forms.TextBox();
            this.findRootsButton = new System.Windows.Forms.Button();
            this.roots = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildGraphButton = new System.Windows.Forms.Button();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize) (this.roots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.graph)).BeginInit();
            this.SuspendLayout();
            // 
            // aBoundLabel
            // 
            this.aBoundLabel.AutoSize = true;
            this.aBoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.aBoundLabel.Location = new System.Drawing.Point(31, 465);
            this.aBoundLabel.Name = "aBoundLabel";
            this.aBoundLabel.Size = new System.Drawing.Size(33, 18);
            this.aBoundLabel.TabIndex = 2;
            this.aBoundLabel.Text = "a = ";
            // 
            // bBoundLabel
            // 
            this.bBoundLabel.AutoSize = true;
            this.bBoundLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.bBoundLabel.Location = new System.Drawing.Point(295, 466);
            this.bBoundLabel.Name = "bBoundLabel";
            this.bBoundLabel.Size = new System.Drawing.Size(33, 18);
            this.bBoundLabel.TabIndex = 4;
            this.bBoundLabel.Text = "b = ";
            // 
            // nLabel
            // 
            this.nLabel.AutoSize = true;
            this.nLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.nLabel.Location = new System.Drawing.Point(540, 465);
            this.nLabel.Name = "nLabel";
            this.nLabel.Size = new System.Drawing.Size(33, 18);
            this.nLabel.TabIndex = 5;
            this.nLabel.Text = "n = ";
            // 
            // aBoundValue
            // 
            this.aBoundValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.aBoundValue.Location = new System.Drawing.Point(70, 463);
            this.aBoundValue.Name = "aBoundValue";
            this.aBoundValue.Size = new System.Drawing.Size(123, 24);
            this.aBoundValue.TabIndex = 6;
            this.aBoundValue.TextChanged += new System.EventHandler(this.aBoundValue_TextChanged);
            // 
            // bBoundValue
            // 
            this.bBoundValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.bBoundValue.Location = new System.Drawing.Point(334, 463);
            this.bBoundValue.Name = "bBoundValue";
            this.bBoundValue.Size = new System.Drawing.Size(123, 24);
            this.bBoundValue.TabIndex = 7;
            this.bBoundValue.TextChanged += new System.EventHandler(this.bBoundValue_TextChanged);
            // 
            // nValue
            // 
            this.nValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.nValue.Location = new System.Drawing.Point(595, 462);
            this.nValue.Name = "nValue";
            this.nValue.Size = new System.Drawing.Size(123, 24);
            this.nValue.TabIndex = 8;
            this.nValue.TextChanged += new System.EventHandler(this.nValue_TextChanged);
            // 
            // findRootsButton
            // 
            this.findRootsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.findRootsButton.Location = new System.Drawing.Point(682, 19);
            this.findRootsButton.Name = "findRootsButton";
            this.findRootsButton.Size = new System.Drawing.Size(203, 34);
            this.findRootsButton.TabIndex = 9;
            this.findRootsButton.Text = "Вычислить интеграл";
            this.findRootsButton.UseVisualStyleBackColor = true;
            this.findRootsButton.Click += new System.EventHandler(this.findRootsButton_Click);
            // 
            // roots
            // 
            this.roots.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.roots.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.roots.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roots.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.Column1, this.Column2, this.Column3, this.Column4});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.roots.DefaultCellStyle = dataGridViewCellStyle1;
            this.roots.Location = new System.Drawing.Point(543, 59);
            this.roots.Name = "roots";
            this.roots.Size = new System.Drawing.Size(446, 296);
            this.roots.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Точное решение (ответ)";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Результат решения методом прямоугольников";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Результат решения методом трапеций";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Результат решения методом симпсона";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // buildGraphButton
            // 
            this.buildGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buildGraphButton.Location = new System.Drawing.Point(709, 382);
            this.buildGraphButton.Name = "buildGraphButton";
            this.buildGraphButton.Size = new System.Drawing.Size(155, 34);
            this.buildGraphButton.TabIndex = 11;
            this.buildGraphButton.Text = "Построить график";
            this.buildGraphButton.UseVisualStyleBackColor = true;
            this.buildGraphButton.Click += new System.EventHandler(this.buildGraphButton_Click);
            // 
            // graph
            // 
            chartArea1.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea1);
            this.graph.Location = new System.Drawing.Point(0, 19);
            this.graph.Name = "graph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            this.graph.Series.Add(series1);
            this.graph.Size = new System.Drawing.Size(523, 336);
            this.graph.TabIndex = 12;
            this.graph.Text = "graph";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 502);
            this.Controls.Add(this.graph);
            this.Controls.Add(this.buildGraphButton);
            this.Controls.Add(this.roots);
            this.Controls.Add(this.findRootsButton);
            this.Controls.Add(this.nValue);
            this.Controls.Add(this.bBoundValue);
            this.Controls.Add(this.aBoundValue);
            this.Controls.Add(this.nLabel);
            this.Controls.Add(this.bBoundLabel);
            this.Controls.Add(this.aBoundLabel);
            this.Name = "Form1";
            this.Text = "Численные методы";
            ((System.ComponentModel.ISupportInitialize) (this.roots)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label aBoundLabel;
        private System.Windows.Forms.Label bBoundLabel;
        private System.Windows.Forms.Label nLabel;
        private System.Windows.Forms.TextBox aBoundValue;
        private System.Windows.Forms.TextBox bBoundValue;
        private System.Windows.Forms.TextBox nValue;
        private System.Windows.Forms.Button findRootsButton;
        private System.Windows.Forms.DataGridView roots;
        private System.Windows.Forms.Button buildGraphButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

