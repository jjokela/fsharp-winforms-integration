using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SorterUtility;
using DevExpress.XtraCharts;
using System.Collections;

namespace DXWinFormsTester
{
    public partial class SortAlgorithmsTesterForm : DevExpress.XtraEditors.XtraForm
    {
        public SortAlgorithmsTesterForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            memoResults.Text = "";

            string[] tokens = memoDataToSort.Text.Split(',');
            int[] arr;
            try
            {
                arr = Array.ConvertAll<string, int>(tokens, int.Parse);
                var sorter = new Sorter();
                var results = sorter.GetSortResults(arr);

                foreach (var item in results)
                {
                    memoResults.Text += item.Name + ": " + item.SortTimeInMs + " ms\r\n";
                }

                // Bind the chart to the list. 
                chartSortTime.DataSource = results;

                if (chartSortTime.Series.Count == 0)
                    CreateSeries();
            }
            catch (Exception)
            {
                memoResults.Text = "Array is in invalid form.\r\nPlease use format: <number><,>\r\nFor example: 3,2,1";
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
            
        }

        private void CreateSeries()
        {
            // Create a series, and add it to the chart. 
            Series series1 = new Series("Sort time (ms)", ViewType.Bar);
            chartSortTime.Series.Add(series1);

            // Adjust the series data members. 
            series1.ArgumentDataMember = "Name";
            series1.ValueDataMembers.AddRange(new string[] { "SortTimeInMs" });
        }
    }
}
