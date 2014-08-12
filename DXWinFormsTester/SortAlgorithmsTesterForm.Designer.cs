namespace DXWinFormsTester
{
    partial class SortAlgorithmsTesterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortAlgorithmsTesterForm));
            this.chartSortTime = new DevExpress.XtraCharts.ChartControl();
            this.buttonSortData = new System.Windows.Forms.Button();
            this.labelDataToSort = new DevExpress.XtraEditors.LabelControl();
            this.memoDataToSort = new DevExpress.XtraEditors.MemoEdit();
            this.labelResults = new DevExpress.XtraEditors.LabelControl();
            this.memoResults = new DevExpress.XtraEditors.MemoEdit();
            this.labelChart = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.chartSortTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDataToSort.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoResults.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chartSortTime
            // 
            this.chartSortTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartSortTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.chartSortTime.Location = new System.Drawing.Point(472, 34);
            this.chartSortTime.Name = "chartSortTime";
            this.chartSortTime.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartSortTime.Size = new System.Drawing.Size(502, 446);
            this.chartSortTime.TabIndex = 0;
            // 
            // buttonSortData
            // 
            this.buttonSortData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSortData.Location = new System.Drawing.Point(12, 492);
            this.buttonSortData.Name = "buttonSortData";
            this.buttonSortData.Size = new System.Drawing.Size(962, 46);
            this.buttonSortData.TabIndex = 1;
            this.buttonSortData.Text = "Sort Data";
            this.buttonSortData.UseVisualStyleBackColor = true;
            this.buttonSortData.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelDataToSort
            // 
            this.labelDataToSort.Location = new System.Drawing.Point(12, 12);
            this.labelDataToSort.Name = "labelDataToSort";
            this.labelDataToSort.Size = new System.Drawing.Size(72, 16);
            this.labelDataToSort.TabIndex = 2;
            this.labelDataToSort.Text = "Data to sort:";
            // 
            // memoDataToSort
            // 
            this.memoDataToSort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.memoDataToSort.EditValue = resources.GetString("memoDataToSort.EditValue");
            this.memoDataToSort.Location = new System.Drawing.Point(12, 34);
            this.memoDataToSort.Name = "memoDataToSort";
            this.memoDataToSort.Size = new System.Drawing.Size(454, 304);
            this.memoDataToSort.TabIndex = 4;
            this.memoDataToSort.UseOptimizedRendering = true;
            // 
            // labelResults
            // 
            this.labelResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelResults.Location = new System.Drawing.Point(12, 344);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(46, 16);
            this.labelResults.TabIndex = 5;
            this.labelResults.Text = "Results:";
            // 
            // memoResults
            // 
            this.memoResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.memoResults.Location = new System.Drawing.Point(12, 366);
            this.memoResults.Name = "memoResults";
            this.memoResults.Size = new System.Drawing.Size(454, 114);
            this.memoResults.TabIndex = 6;
            this.memoResults.UseOptimizedRendering = true;
            // 
            // labelChart
            // 
            this.labelChart.Location = new System.Drawing.Point(472, 12);
            this.labelChart.Name = "labelChart";
            this.labelChart.Size = new System.Drawing.Size(79, 16);
            this.labelChart.TabIndex = 7;
            this.labelChart.Text = "Results chart:";
            // 
            // SortAlgorithmsTesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 550);
            this.Controls.Add(this.labelChart);
            this.Controls.Add(this.memoResults);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.memoDataToSort);
            this.Controls.Add(this.labelDataToSort);
            this.Controls.Add(this.buttonSortData);
            this.Controls.Add(this.chartSortTime);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SortAlgorithmsTesterForm";
            this.Text = "Sort Algorithms Tester Form";
            ((System.ComponentModel.ISupportInitialize)(this.chartSortTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoDataToSort.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoResults.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartSortTime;
        private System.Windows.Forms.Button buttonSortData;
        private DevExpress.XtraEditors.LabelControl labelDataToSort;
        private DevExpress.XtraEditors.MemoEdit memoDataToSort;
        private DevExpress.XtraEditors.LabelControl labelResults;
        private DevExpress.XtraEditors.MemoEdit memoResults;
        private DevExpress.XtraEditors.LabelControl labelChart;

    }
}

