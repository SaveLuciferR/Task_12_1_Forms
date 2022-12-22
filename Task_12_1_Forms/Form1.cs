using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_12_1_Forms
{
	public partial class Form1 : Form
	{
		Array doubleArray;
		Array doubleArray2;
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "";
			textBox2.Text = "";
			textBox3.Text = "";
			textBox4.Text = "";
			textBox5.Text = "";
			textBox6.Text = "";
			textBox7.Text = "";
			textBox8.Text = "";
			textBox9.Text = "";
		}

		private void button2_Click(object sender, EventArgs e)
		{
			try
			{
				int n = Convert.ToInt32(textBox1.Text);
				int m = Convert.ToInt32(textBox2.Text);

				if (n < 1 || m < 1)
				{
					throw new Exception("\r\nКол-во элементов массива не может быть меньше одного\r\n");
				}

				doubleArray = new Array(n, m);
				doubleArray.SetArrayElement(textBox3);
				textBox9.Text += "\r\nМассив успешно записан\r\n";
				doubleArray.GetArrayElement(textBox9);
			}
			catch (FormatException)
			{
				textBox9.Text += "\r\nНеверный формат\r\n";
			}
			catch (IndexOutOfRangeException)
			{
				textBox9.Text += "\r\nПроизошел выход за границы массива\r\n";
			}
			catch (Exception ex)
			{
				textBox9.Text += ex.Message;
			}

		}

		private void button3_Click(object sender, EventArgs e)
		{
			try
			{
				int n = Convert.ToInt32(textBox6.Text);
				int m = Convert.ToInt32(textBox7.Text);

				if (n < 1 || m < 1)
				{
					throw new Exception("\r\nКол-во элементов массива не может быть меньше одного\r\n");
				}

				doubleArray2 = new Array(n, m);
				doubleArray2.SetArrayElement(textBox8);
				textBox9.Text += "\r\nМассив успешно записан\r\n";
				doubleArray2.GetArrayElement(textBox9);
			}
			catch (FormatException)
			{
				textBox9.Text += "Неверный формат";
			}
			catch (IndexOutOfRangeException)
			{
				textBox9.Text += "Произошел выход за границы массива";
			}
			catch (Exception ex)
			{
				textBox9.Text += ex.Message;
			}
		}

		private void button4_Click(object sender, EventArgs e)
		{
			try
			{
				if (doubleArray == null)
				{
					throw new Exception("\r\nвведите первый массив\r\n");
				}

				int scalar = Convert.ToInt32(textBox4.Text);
				doubleArray.scalarArray = scalar;
				textBox9.Text += "\r\nУмножение на скаляр: " + scalar + "\r\n";
				doubleArray.GetArrayElement(textBox9);
			}
			catch (FormatException)
			{
				textBox9.Text += "\r\nНеверный формат\r\n";
			}
			catch (Exception ex)
			{
				textBox9.Text += ex.Message;
			}
		}

		private void button5_Click(object sender, EventArgs e)
		{
			try
			{
				if (doubleArray == null)
				{
					throw new Exception("\r\nВведите первый массив\r\n");
				}

				doubleArray--;
				textBox9.Text += "\r\nВычитание\r\n";
				doubleArray.GetArrayElement(textBox9);
			}
			catch (FormatException)
			{
				textBox9.Text += "\r\nНеверный формат ввода\r\n";
			}
			catch (Exception ex)
			{
				textBox9.Text += ex.Message;
			}
		}

		private void button6_Click(object sender, EventArgs e)
		{
			try
			{
				if (doubleArray == null)
				{
					throw new Exception("\r\nВведите первый массив\r\n");
				}

				doubleArray++;
				textBox9.Text += "\r\nПрибавление\r\n";
				doubleArray.GetArrayElement(textBox9);
			}
			catch (FormatException)
			{
				textBox9.Text += "\r\nНеверный формат ввода\r\n";
			}
			catch (Exception ex)
			{
				textBox9.Text += ex.Message;
			}
		}

		private void button7_Click(object sender, EventArgs e)
		{
			try
			{
				if (doubleArray == null)
				{
					throw new Exception("\r\nвведите первый массив\r\n");
				}

				string[] str = textBox5.Text.Split(' ');
				if (str.Length != 2)
				{
					throw new Exception("\r\nВ поиске по индексу должно быть всего два числа (целых)\r\n");
				}

				textBox9.Text += "\r\nЧисло по индексу: " + doubleArray[Convert.ToInt32(str[0]), Convert.ToInt32(str[1])] + "\r\n";
			}
			catch (FormatException)
			{
				textBox9.Text += "Некорректынй формат";
			}
			catch (Exception ex)
			{
				textBox9.Text += ex.Message;
			}
		}

		private void button8_Click(object sender, EventArgs e)
		{
			try
			{
				if (doubleArray == null)
				{
					throw new Exception("\r\nвведите первый массив\r\n");
				}

				Array arrRes = (double[,])doubleArray;
				textBox9.Text += "\r\nМассив успешно конвертирован в двумерный\r\n";
			}
			catch (Exception ex)
			{
				textBox9.Text += ex.Message;
			}
		}

		private void button12_Click(object sender, EventArgs e)
		{
			try
			{
				if (doubleArray == null)
				{
					throw new Exception("\r\nВведите первый массив\r\n");
				}

				textBox9.Text += "\r\nКол-во элементов в первом массиве: " + doubleArray.countArray + "\r\n";
			}
			catch (Exception ex)
			{
				textBox9.Text += ex.Message;
			}
		}

		private void button9_Click(object sender, EventArgs e)
		{
			try
			{
				if (doubleArray == null)
				{
					throw new Exception("\r\nВведите первый массив\r\n");
				}

				if (doubleArray)
				{
					textBox9.Text += "\r\nМассив упорядочен по возрастанию\r\n";
				}
				else
				{
					textBox9.Text += "\r\nМассив не упорядочен по возрастанию\r\n";
				}
			}
			catch (Exception ex)
			{
				textBox9.Text += ex.Message;
			}
		}

		private void button10_Click(object sender, EventArgs e)
		{
			try
			{
				if (doubleArray == null)
				{
					throw new Exception("\r\nВведите первый массив\r\n");
				}

				doubleArray.SortArrayElement();
				textBox9.Text += "\r\nМассив был упорядочен по убыванию\r\n";
				doubleArray.GetArrayElement(textBox9);
			}
			catch (Exception ex)
			{
				textBox9.Text += ex.Message;
			}
		}

		private void button11_Click(object sender, EventArgs e)
		{
			try
			{
				if (doubleArray == null)
				{
					throw new Exception("\r\nВведите первый массив\r\n");
				}
				
				if (doubleArray2 == null)
				{
					throw new Exception("\r\nВведите второй массив\r\n");
				}
				Array arrayRes = doubleArray * doubleArray2;
				textBox9.Text += "\r\nРезультат умножения двух массивов\r\n";
				arrayRes.GetArrayElement(textBox9);
			}
			catch (Exception ex)
			{
				textBox9.Text += ex.Message;
			}
		}
	}

	class Array
	{
		private double[][] doubleArray;
		private int n, m;

		public int countArray
		{
			get
			{
				return n * m;
			}
		}
		public int scalarArray
		{
			set
			{
				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < m; j++)
					{
						doubleArray[i][j] += value;
					}
				}
			}
		}

		public double this[int i, int j]
		{
			get
			{
				return doubleArray[i][j];
			}
			set
			{
				doubleArray[i][j] = value;
			}
		}

		public Array(int n, int m)
		{
			this.n = n;
			this.m = m;
			doubleArray = new double[n][];
			for (int i = 0; i < n; i++)
			{
				doubleArray[i] = new double[m];
			}
		}

		public void SetArrayElement(TextBox textBox)
		{
			string[] str = textBox.Text.Split(' ');
			int index = 0;

			if (str.Length != n * m)
			{
				throw new Exception("\r\nКол-во вводимых элементов в массив отличается от кол-ва элементов массива\r\n");
			}

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					doubleArray[i][j] = Convert.ToDouble(str[index]);
					index++;
				}
			}
		}

		public void GetArrayElement(TextBox textBox)
		{
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					textBox.Text += (doubleArray[i][j] + "\t");
				}
				textBox.Text += "\r\n";
			}
			textBox.Text += "\r\n";
		}

		public void SortArrayElement()
		{
			for (int i = 0; i < n; i++)
			{
				for (int k = 0; k < m; k++)
				{
					for (int j = 0; j < m - 1; j++)
					{
						if (doubleArray[i][j] < doubleArray[i][j + 1])
						{
							double temp = doubleArray[i][j];
							doubleArray[i][j] = doubleArray[i][j + 1];
							doubleArray[i][j + 1] = temp;
						}
					}
				}
			}
		}

		private bool checkSortArray()
		{
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m - 1; j++)
				{
					if (doubleArray[i][j] > doubleArray[i][j + 1])
					{
						return false;
					}
				}
			}

			return true;
		}

		public static Array operator ++(Array array)
		{
			for (int i = 0; i < array.n; i++)
			{
				for (int j = 0; j < array.m; j++)
				{
					array.doubleArray[i][j]++;
				}
			}

			return array;
		}

		public static Array operator --(Array array)
		{
			for (int i = 0; i < array.n; i++)
			{
				for (int j = 0; j < array.m; j++)
				{
					array.doubleArray[i][j]--;
				}
			}

			return array;
		}

		public static bool operator true(Array array)
		{
			return array.checkSortArray();
		}
		public static bool operator false(Array array)
		{
			return !array.checkSortArray();
		}

		public static Array operator *(Array array1, Array array2)
		{
			if (array1.m == array2.n)
			{
				int n = array1.n;
				int m = array2.m;
				Array arrRes = new Array(n, m);

				for (int i = 0; i < n; i++)
				{
					for (int j = 0; j < m; j++)
					{
						for (int k = 0; k < array1.m; k++)
						{
							arrRes.doubleArray[i][j] += (array1[i, k] * array2[k, j]);
						}
					}
				}
				return arrRes;
			}
			else
			{
				throw new Exception("Два массива не подходят для перемножения");
			}
		}

		public static implicit operator double[,](Array array)
		{
			double[,] temp = new double[array.n, array.m];

			for (int i = 0; i < array.n; i++)
			{
				for (int j = 0; j < array.m; j++)
				{
					temp[i, j] = array.doubleArray[i][j];
				}
			}

			return temp;
		}

		public static implicit operator Array(double[,] array)
		{
			var n = array.GetLength(0);
			var m = array.GetLength(1);
			var temp = new Array(n, m);

			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < m; j++)
				{
					temp[i, j] = array[i, j];
				}
			}

			return temp;
		}
	}
}
