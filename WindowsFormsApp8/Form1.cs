using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp8
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		double p = 0.5;

		double[] pred = {0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9, 1};
		string[] answer = {
			"Вряд ли",
			"Маловероятно",
			"Перспективы не радужные",
			"Скорее нет, чем да",
			"Пока не ясно, попробуй еще раз",
			"Скорее да, чем нет",
			"Риск есть, но он невелик, дерзай!",
			"Весьма вероятно",
			"Вполне возможно",
			"Я уверен в этом!"
};

		double r;
		Random rand = new Random();
		private void lb8_2_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
            lbAnswer.Text.Trim();
            if (tbQuestion.Text != String.Empty)
            {
                r = rand.NextDouble();
                if (r < p) lbAnswer.Text = "Yes!";
                else lbAnswer.Text = "No!";
            }
            else lbAnswer.Text = "Сначала задайте вопрос.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lbAnswer2.Text.Trim();
            double tmp = 0;
            if (tbQuestion2.Text != String.Empty)
            {
                for (int i = 0; i < 12; i++)
                {
                    tmp = pred[i];
                    r = rand.NextDouble();
                    if (r < tmp)
                    {
                        lbAnswer2.Text = answer[i];
                        break;
                    }
                }
            }
            else lbAnswer2.Text = "Сначала задайте вопрос.";
        }
    }
}
