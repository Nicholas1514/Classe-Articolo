using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classe_Articolo
{
	public partial class Form1 : Form
	{
		public Articolo[] art;
		int conta;
		public Form1()
		{
			InitializeComponent();
			art = new Articolo[100];
			conta = 0;
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{

			
		
			
				art[conta] = new Articolo(int.Parse(textBox1.Text), textBox2.Text, double.Parse(textBox3.Text), checkBox1.Checked);
				conta++;
			
			MessageBox.Show("Alimento inserito nella lista");
			textBox1.Text = string.Empty;
			textBox2.Text = string.Empty;
			textBox3.Text = string.Empty; 
			
		}

		private void button2_Click(object sender, EventArgs e)
		{
			  art[conta - 1].Sconta();
				listView1.Items.Add(art[conta - 1].ToString());
				
		}
	}
}
