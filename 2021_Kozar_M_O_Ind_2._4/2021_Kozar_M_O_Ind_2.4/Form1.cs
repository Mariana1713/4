using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2021_Kozar_M_O_Ind_2._4
{
    public partial class Form1 : Form
	{
		public double[] VectorRead;
		private Vector first;
		private Vector second;
		private static string separator = @"\,";
		private static string regExpTemplate = string.Format(@"^[+-]?\d*(?:[{0}]\d*)?(?:[E][+-]?\d*)?(\s[+-]?\d*(?:[{0}]\d*)?(?:[E][+-]?\d*)?)+$", separator);
		private Regex regExp = new Regex(regExpTemplate);
		public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
		private bool UpdateData()
		{
			if (regExp.IsMatch(FirstVector.Text))
			{
				VectorRead = Array.ConvertAll(FirstVector.Text.Split(' '), double.Parse);
				this.first = new Vector(VectorRead);
			}
			else
			{
				this.PromptError();
				return false;
			}

			if (regExp.IsMatch(secondVector.Text))
			{
				VectorRead = Array.ConvertAll(secondVector.Text.Split(' '), double.Parse);
				this.second = new Vector(VectorRead);
			}
			else
			{
				this.PromptError();
				return false;
			}
			return true;
		}
		private void Add_Click(object sender, EventArgs e)
        {
			if (!UpdateData())
				return;
			Vector Res = Vector.Add(first, second);
			string r="";
			foreach (double value in Res.VectorValue())
			{
				r += value.ToString() +" ";
			}
			Result.Text = r;
        }
		private void PromptError(string ErrPrompt = "Введені некоректі дані!!!")
		{
			Result.Text = ErrPrompt;
		}

		

		private void button1_Click(object sender, EventArgs e)
		{
			if (!UpdateData())
				return;
			double scal = Vector.Scalar(first, second);
			Result.Text = scal.ToString();
		}
	}
}
