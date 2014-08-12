namespace WinFormsTester
{
    partial class formSortAlgorithmTester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSortAlgorithmTester));
            this.buttonSortData = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.textBoxIntsToSort = new System.Windows.Forms.TextBox();
            this.labelIntsToSort = new System.Windows.Forms.Label();
            this.labelResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSortData
            // 
            this.buttonSortData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSortData.Location = new System.Drawing.Point(12, 670);
            this.buttonSortData.Name = "buttonSortData";
            this.buttonSortData.Size = new System.Drawing.Size(770, 46);
            this.buttonSortData.TabIndex = 0;
            this.buttonSortData.Text = "Sort Data";
            this.buttonSortData.UseVisualStyleBackColor = true;
            this.buttonSortData.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxResult.Location = new System.Drawing.Point(15, 504);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(767, 160);
            this.textBoxResult.TabIndex = 1;
            // 
            // textBoxIntsToSort
            // 
            this.textBoxIntsToSort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIntsToSort.Location = new System.Drawing.Point(12, 29);
            this.textBoxIntsToSort.Multiline = true;
            this.textBoxIntsToSort.Name = "textBoxIntsToSort";
            this.textBoxIntsToSort.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxIntsToSort.Size = new System.Drawing.Size(770, 452);
            this.textBoxIntsToSort.TabIndex = 2;
            this.textBoxIntsToSort.Text = resources.GetString("textBoxIntsToSort.Text");
            // 
            // labelIntsToSort
            // 
            this.labelIntsToSort.AutoSize = true;
            this.labelIntsToSort.Location = new System.Drawing.Point(12, 9);
            this.labelIntsToSort.Name = "labelIntsToSort";
            this.labelIntsToSort.Size = new System.Drawing.Size(86, 17);
            this.labelIntsToSort.TabIndex = 3;
            this.labelIntsToSort.Text = "Data to sort:";
            // 
            // labelResults
            // 
            this.labelResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelResults.AutoSize = true;
            this.labelResults.Location = new System.Drawing.Point(12, 484);
            this.labelResults.Name = "labelResults";
            this.labelResults.Size = new System.Drawing.Size(59, 17);
            this.labelResults.TabIndex = 4;
            this.labelResults.Text = "Results:";
            // 
            // formSortAlgorithmTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 728);
            this.Controls.Add(this.labelResults);
            this.Controls.Add(this.labelIntsToSort);
            this.Controls.Add(this.textBoxIntsToSort);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonSortData);
            this.Name = "formSortAlgorithmTester";
            this.Text = "Sort Algorithms Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSortData;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.TextBox textBoxIntsToSort;
        private System.Windows.Forms.Label labelIntsToSort;
        private System.Windows.Forms.Label labelResults;
    }
}

