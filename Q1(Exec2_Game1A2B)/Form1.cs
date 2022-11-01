using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1_Exec2_Game1A2B_
{
	public partial class Form1 : Form
	{
		private int[] answer = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };//正確答案
		private String[] guess = new string[10];//猜的答案數字
		private int m, n;
		private Random random = new Random();

		

		public Form1()
		{
			InitializeComponent();
			AnswerLabel.Text = String.Empty;
			CountLabel.Text = String.Empty;

			for (int i = 0; i < 10; i++)
			{
				answer[i] = i;
			}
			for (int i = 0; i < 10; i++)
			{
				n = random.Next(0, 10);
				m = answer[n];
				answer[n] = answer[9 - i];
				answer[9 - i] = m;
			}
		}
		private void CheckButton_Click(object sender, EventArgs e)
		{
			string num = "";
			int a = 0, b = 0;
			if (InputTextBox.TextLength != 4)
			{
				MessageBox.Show("請輸入4個不一樣的數字");
			}
			else
			{
				for (int j = 1; j <= 4; j++)
				{
					guess[j] = InputTextBox.Text.Substring(j - 1, 1);
					num += guess[j];
				}
				if ((guess[1] == guess[2] || guess[1] == guess[3] ||guess[1] == guess[4] || guess[2] == guess[3] ||	guess[2] == guess[4] || guess[3] == guess[4]))
				{
					MessageBox.Show("不能輸入重複的數字");
				}
				else
				{
					for (int x = 1; x <= 4; x++)
					{
						for (int y = 1; y <= 4; y++)
						{
							if (guess[x] == answer[y].ToString())
							{
								if (x == y)
								{
									a++;
								}
								else if (x != y)
								{
									b++;
								}
							}
						}
					}
					ResultTextBox.Text += num + "-----" + a.ToString() + "A" + b.ToString() + "B" + "\r\n";//顯示幾A幾B
					CountLabel.Text = "猜了" + (ResultTextBox.Lines.Length - 1) + "次";//顯示猜了幾次
					InputTextBox.Focus();
					InputTextBox.SelectAll();
				}

				//如果4A0B猜對了 讓確定按鈕和看答案按鈕不能按
				if (a == 4 && b == 0)
				{
					MessageBox.Show("猜對了");
					CheckButton.Enabled = false;
					AnswerButton.Enabled = false;
				}
			}
		}

		private void AnswerButton_Click(object sender, EventArgs e)
		{
			AnswerLabel.Text = "";
			for (int i = 1; i <= 4; i++)
			{
				AnswerLabel.Text += answer[i];
			}
		}

		private void RestartButton_Click(object sender, EventArgs e)
		{
			//按下重新開始之後 清除Label上的字 並讓按鈕恢復使用
			AnswerLabel.Text = "";
			CountLabel.Text = "";
			InputTextBox.Text = "";
			ResultTextBox.Text = "";
			CheckButton.Enabled = true;
			AnswerButton.Enabled = true;
			//重新讓答案的陣列塞滿隨機數字
			for (int i = 0; i < 10; i++)
			{
				n = random.Next(0, 10 - i);
				m = answer[n];
				answer[n] = answer[9 - i];
				answer[9 - i] = m;
			}
			for (int j = 1; j <= 4; j++)
			{
				guess[j] = "";
			}
		}

	}
}
