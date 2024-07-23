using StringSorter.Interfaces;
using StringSorter.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StringSorter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            sortingStratComboBox.Items.AddRange(new object[] { "BubbleSort", "MergeSort", "QuickSort" });
            sortingStratComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            string inputString = inputStringTextBox.Text.Trim();
            string outputString = string.Empty;
            ISort algorithm;

            if (string.IsNullOrEmpty(inputString))
            {
                MessageBox.Show("Please enter a string to sort.");
                return;
            }

            if (sortingStratComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a sorting strategy.");
                return;
            }

            switch (sortingStratComboBox.SelectedItem.ToString())
            {
                case "BubbleSort":
                    algorithm = new BubbleSortService();
                    outputString = algorithm.Sort(inputString);
                    break;
                case "MergeSort":
                    algorithm = new MergeSortService();
                    outputString = algorithm.Sort(inputString);
                    break;
                case "QuickSort":
                    algorithm = new QuickSortService();
                    outputString = algorithm.Sort(inputString);
                    break;
                default:
                    MessageBox.Show("Unavailable sorting strategy.");
                    return;
            }

            outputStringTextBox.Text = outputString;
        }

        private void sortingStratComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void inputStringTextBox_TextChanged(object sender, EventArgs e)
        {
            outputStringTextBox.Text = string.Empty;
        }

        private void outputStringTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void inputStringTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
            }
        }
    }
}
