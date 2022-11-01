using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2_Exec_DiceGame_
{
	public partial class Form1 : Form
	{
		public Dice dice; 
		public Form1()
		{
			InitializeComponent();
			ResultLabel.Text=String.Empty;
			ScoreLabel.Text=String.Empty;
			dice = new Dice();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			dice.Check(dice.Roll());
			ResultLabel.Text=dice.Result();
			ScoreLabel.Text=dice.Score();
		}

		public class Dice
		{
			private int[] x = new int[4];
			private string score ;

			public int[] Roll()
			{
				Random random = new Random();

				for (int i = 0; i < x.Length; i++)
				{
					x[i] = random.Next(1, 7);
					Array.Sort(x);
				}
				return x;
			}
			public string Result()
			{
				return $"{x[0]},{x[1]},{x[2]},{x[3]}";
			}
			public string Score()
			{
				return score;
			}
			public void Check(int[] set)
			{
				//2顆骰子一樣的情況
				if (x[0] == x[1] && x[1] != x[2])//4455 //4456
				{
					score = $"分數是{x[2] + x[3]}";
				}
				else if (x[1] == x[2] && x[0] != x[3])//4556
				{
					score = $"分數是{x[0] + x[3]}";
				}
				else if (x[2] == x[3] && x[0] != x[1])//4566
				{
					score = $"分數是{x[0] + x[1]}";
				}
				//3顆骰子一樣的情況
				else if (x[0] == x[1] && x[1] == x[2] && x[2] != x[3])//5556
				{
					score = $"分數是{x[2] + x[3]}";
				}
				else if (x[1] == x[2] && x[2] == x[3] && x[1] != x[0])//4555
				{
					score = $"分數是{x[0] + x[1]}";
				}
				//4顆骰子一樣的情況
				else if (x[0] == x[1] && x[1] == x[2] && x[2] == x[3])//5555
				{
					score = $"分數是{x[2] + x[3]}";
				}
				//全部骰子都不同 重來
				else
				{
					score = "四顆骰子不一樣，重骰!";
				}
			}
		}
	}
}
