using SorterUtility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsTester
{
    public partial class formSortAlgorithmTester : Form
    {
        public formSortAlgorithmTester()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxResult.Clear();

            string[] tokens = textBoxIntsToSort.Text.Split(',');
            int[] arr;
            try
            {
                arr = Array.ConvertAll<string, int>(tokens, int.Parse);
                var sorter = new Sorter();
                var results = sorter.GetSortResults(arr);
                if (results.Count > 0)
                    textBoxResult.Text = "Sort results: \r\n\r\n";
                
                foreach (var item in results)
                {
                    textBoxResult.Text += item.Name + ": " + item.SortTimeInMs + " ms\r\n";
                }
            }
            catch (Exception)
            {
                textBoxResult.Text = "Array is in invalid form.\r\nPlease use format: <number><,>\r\nFor example: 3,2,1";
            }

        }
    }
}
