using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
	public partial class tic_tac_toe : Form
	{
		public tic_tac_toe()
		{
			InitializeComponent();
		}
		private void tic_tac_toe_Load(object sender, EventArgs e)
		{
			lblplayer1.Text=Informations.nameofplayerx+"  < X >";
			lblplayer2.Text = Informations.nameofplayero+"  < O >";

			for(int i = 0; i < this.Controls.Count; i++)
            {
				if(this.Controls[i] is Button)
                {
					this.Controls[i].BackColor = Color.DarkTurquoise;
				}
            }

			if (roleofplayer == 0)
			{
				lblplayer1.ForeColor = Color.Lime;
			}
			else
				lblplayer2.ForeColor = Color.Lime;
			
		}
		
		static Random random = new Random();
		int roleofplayer = random.Next(0, 2);
		string[] players = {Informations.nameofplayerx,Informations.nameofplayero};

		//**************************************************************************
		public void Play(object mybutton)
		{
			Button button = (Button)mybutton;
			if (button.Text == "")
			{
				if (roleofplayer == 0)
				{
					lblplayer1.ForeColor = Color.Black;
					lblplayer2.ForeColor = Color.Lime;
					button.ForeColor = Color.Red;
					button.Text = "X";
					roleofplayer = 1;
					Informations.draw++;
				}
				else
				{
					lblplayer2.ForeColor = Color.Black;
					lblplayer1.ForeColor = Color.Lime;
					button.ForeColor = Color.White;
					button.Text = "O";
					roleofplayer = 0;
					Informations.draw++;
				}
			}
		}
		
		public void Winner(string S)
		{
			Visible();
			lblplayer1.Visible = false;
			lblplayer2.Visible = false;
			lblwinner.Text = (S=="X"? Informations.nameofplayerx.ToUpper()+" WON" : Informations.nameofplayero.ToUpper() + " WON");
			lblwinner.Visible = true;
			playagainbutton.Visible = true;
			newplayersbutton.Visible = true;

		}
		public void Visible()
        {
			for (int i = 0; i < this.Controls.Count; i++)
			{
				if (this.Controls[i] is Button)
				{
					this.Controls[i].Visible = false;
				}
			}
			label1.Visible = false;
			label2.Visible = false;
			label3.Visible = false;
			label4.Visible = false;
		}
		public void Draw()
		{
			lblwinner.Text = "DRAW";
			lblwinner.Visible = true;
			Visible();
			lblplayer1.Visible = false;
			lblplayer2.Visible = false;
			playagainbutton.Visible = true;
			newplayersbutton.Visible = true;

		}
		public void Test(string S)
		{
			if (button1.Text == S && button2.Text == S && button3.Text == S)
			{
				Winner(S);
			}
			else if (button4.Text == S && button5.Text == S && button6.Text == S)
			{
				Winner(S);
			}
			else if (button7.Text == S && button8.Text == S && button9.Text == S)
			{
				Winner(S);
			}
			else if (button1.Text == S && button4.Text == S && button7.Text == S)
			{
				Winner(S);
			}
			else if (button2.Text == S && button5.Text == S && button8.Text == S)
			{
				Winner(S);
			}
			else if (button3.Text == S && button6.Text == S && button9.Text == S)
			{
				Winner(S);
			}
			else if (button1.Text == S && button5.Text == S && button9.Text == S)
			{
				Winner(S);
			}
			else if (button3.Text == S && button5.Text == S && button7.Text == S)
			{
				Winner(S);
			}
			else if (Informations.draw == 9)
				Draw();	
			
		}
		//**************************************************************************
		private void button1_Click(object sender, EventArgs e)
		{
			Play(button1);
			Test(button1.Text);
		}
		private void button2_Click(object sender, EventArgs e)
		{
			Play(button2);
			Test(button2.Text);
		}
		private void button3_Click(object sender, EventArgs e)
		{
			Play(button3);
			Test(button3.Text);
		}
		private void button4_Click(object sender, EventArgs e)
		{
			Play(button4);
			Test(button4.Text);
		}
		private void button5_Click(object sender, EventArgs e)
		{
			Play(button5);
			Test(button5.Text);

		}
		private void button6_Click(object sender, EventArgs e)
		{
			Play(button6);
			Test(button6.Text);
		}
		private void button7_Click(object sender, EventArgs e)
		{
			Play(button7);
			Test(button7.Text);

		}
		private void button8_Click(object sender, EventArgs e)
		{
			Play(button8);
			Test(button8.Text);
		}
		private void button9_Click(object sender, EventArgs e)
		{
			Play(button9);
			Test(button9.Text);
		}

		private void tic_tac_toe_TextChanged(object sender, EventArgs e)
		{
			
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void playagainbutton_Click(object sender, EventArgs e)
		{
			Informations.draw = 0;
            tic_tac_toe tictactoe = new tic_tac_toe();
            this.Hide();
			tictactoe.ShowDialog();
            this.Close();

        }

		private void newplayersbutton_Click(object sender, EventArgs e)
		{
			Informations.draw = 0;
			Login login = new Login();
			this.Hide();
			login.ShowDialog();
			this.Close();
		}

		
	}
}
