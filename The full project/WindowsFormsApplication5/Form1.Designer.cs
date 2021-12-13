namespace WindowsFormsApplication5
{
	partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtboxplayer1 = new System.Windows.Forms.TextBox();
            this.txtboxplayer2 = new System.Windows.Forms.TextBox();
            this.lblplayer1 = new System.Windows.Forms.Label();
            this.playbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtboxplayer1
            // 
            this.txtboxplayer1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxplayer1.ForeColor = System.Drawing.Color.Silver;
            this.txtboxplayer1.Location = new System.Drawing.Point(54, 77);
            this.txtboxplayer1.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtboxplayer1.Name = "txtboxplayer1";
            this.txtboxplayer1.Size = new System.Drawing.Size(242, 27);
            this.txtboxplayer1.TabIndex = 0;
            this.txtboxplayer1.Text = "Enter a name";
            this.txtboxplayer1.Click += new System.EventHandler(this.txtboxplayer1_Click);
            this.txtboxplayer1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtboxplayer1.Enter += new System.EventHandler(this.txtboxplayer1_Enter);
            this.txtboxplayer1.Leave += new System.EventHandler(this.txtboxplayer1_Leave);
            // 
            // txtboxplayer2
            // 
            this.txtboxplayer2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtboxplayer2.ForeColor = System.Drawing.Color.Silver;
            this.txtboxplayer2.Location = new System.Drawing.Point(54, 215);
            this.txtboxplayer2.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtboxplayer2.Name = "txtboxplayer2";
            this.txtboxplayer2.Size = new System.Drawing.Size(240, 27);
            this.txtboxplayer2.TabIndex = 1;
            this.txtboxplayer2.Text = "Enter a name";
            this.txtboxplayer2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.txtboxplayer2.Enter += new System.EventHandler(this.txtboxplayer2_Enter);
            this.txtboxplayer2.Leave += new System.EventHandler(this.txtboxplayer2_Leave);
            // 
            // lblplayer1
            // 
            this.lblplayer1.AutoSize = true;
            this.lblplayer1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayer1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblplayer1.Location = new System.Drawing.Point(48, 38);
            this.lblplayer1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblplayer1.Name = "lblplayer1";
            this.lblplayer1.Size = new System.Drawing.Size(120, 28);
            this.lblplayer1.TabIndex = 2;
            this.lblplayer1.Text = "Player <X>";
            this.lblplayer1.Click += new System.EventHandler(this.label1_Click);
            // 
            // playbutton
            // 
            this.playbutton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.playbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.playbutton.FlatAppearance.BorderSize = 0;
            this.playbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playbutton.ForeColor = System.Drawing.Color.White;
            this.playbutton.Location = new System.Drawing.Point(436, 177);
            this.playbutton.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.playbutton.Name = "playbutton";
            this.playbutton.Size = new System.Drawing.Size(138, 65);
            this.playbutton.TabIndex = 0;
            this.playbutton.Text = "PLAY";
            this.playbutton.UseVisualStyleBackColor = false;
            this.playbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(51, 168);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Player <O>";
            // 
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltest.Location = new System.Drawing.Point(48, 283);
            this.lbltest.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(0, 16);
            this.lbltest.TabIndex = 4;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(624, 315);
            this.Controls.Add(this.lbltest);
            this.Controls.Add(this.playbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblplayer1);
            this.Controls.Add(this.txtboxplayer2);
            this.Controls.Add(this.txtboxplayer1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtboxplayer1;
		private System.Windows.Forms.TextBox txtboxplayer2;
		private System.Windows.Forms.Label lblplayer1;
		private System.Windows.Forms.Button playbutton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lbltest;
	}
}

