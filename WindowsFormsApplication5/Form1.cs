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
	public partial class Login : Form
	{
		/*blic string nameofplayerx;
		public string nameofplayero;*/
		public Login()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			playbutton.Focus();

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
				
		}

		private void textBox2_TextChanged(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void txtboxplayer1_Click(object sender, EventArgs e)
		{

		}

		private void txtboxplayer1_Enter(object sender, EventArgs e)
		{
			if (txtboxplayer1.ForeColor == Color.Silver)
			{
				txtboxplayer1.Text = "";
				txtboxplayer1.ForeColor = Color.Black;

			}
		}
		private void txtboxplayer1_Leave(object sender, EventArgs e)
		{
			txtboxplayer1.Text = txtboxplayer1.Text.Trim();
			if (txtboxplayer1.Text == "")
			{
				txtboxplayer1.ForeColor = Color.Silver;
				txtboxplayer1.Text = "Enter a name";

			}
		}

		private void txtboxplayer2_Enter(object sender, EventArgs e)
		{
			string nameofplayerX, nameofplayerO;
			nameofplayerX = txtboxplayer1.Text;
			nameofplayerO = txtboxplayer2.Text;
			if (txtboxplayer2.ForeColor == Color.Silver)
			{
				txtboxplayer2.Text = "";
				txtboxplayer2.ForeColor = Color.Black;

			}
		}

		private void txtboxplayer2_Leave(object sender, EventArgs e)
		{
			txtboxplayer2.Text = txtboxplayer2.Text.Trim();
			if (txtboxplayer2.Text == "")
			{
				txtboxplayer2.ForeColor = Color.Silver;
				txtboxplayer2.Text = "Enter a name";
			}
		}

		private void startbutton_Click(object sender, EventArgs e)
		{
			if (txtboxplayer2.Text == "Enter a name" || txtboxplayer1.Text == "Enter a name")
			{
				lbltest.ForeColor = Color.Red;
				lbltest.Text = " invalid player !";

			}
			else if (txtboxplayer1.Text == txtboxplayer2.Text)
			{
				lbltest.ForeColor = Color.Red;
				lbltest.Text = "Enter differnet names";
			}
			else
			{
				tic_tac_toe tictactoe = new tic_tac_toe();
				Informations game = new Informations(txtboxplayer1.Text, txtboxplayer2.Text);
				this.Hide();
				tictactoe.ShowDialog();
				this.Close();
			}
		}

			
	}
}
