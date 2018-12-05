using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
	public partial class Search_in_matrix : Form
	{
		private string[,] data;

		public Search_in_matrix()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

			{
				// add data to the matrix
				data = new string[,]{// 1   2   3   4
									 {"a","b","c","d"},//1
									 {"e","f","g","h"},//2
									 {"i","j","k","l"},//3
									 {"m","o","p","q"},
									 {"r","s","t","u"},
									 {"v","w","x","y"},
									 {"z","1","2","3"} //7
                                };

				// display matrix data into richTextbox
				for (int i = 0; i < data.GetLength(0); i++)
				{
					for (int j = 0; j < data.GetLength(1); j++)
					{
						richTextBox1.Text += data[i, j] + " - ";
					}

					richTextBox1.Text += "\n";
				}

			}

			
			

			


		}

		private void button3_Click(object sender, EventArgs e)
		{
			richTextBox2.Text = "";
			// data.GetLength(0) = length of the first D (7)
			for (int i = 0; i < data.GetLength(0); i++)
			{
				// data.GetLength(1) = length of the second D (4)
				for (int j = 0; j < data.GetLength(1); j++)
				{
					if (textBox1.Text.Equals(data[i, j]))
					{
						richTextBox2.Text += "POSITION[" + i + " , " + j + "]";
					}
				}
			}
		}
	}
}


