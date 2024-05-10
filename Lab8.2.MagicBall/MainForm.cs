using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab8._2.MagicBall
{
	public partial class MainForm : Form
	{
		private static List<string> _answers = new List<string>
		{
			"Не подскажу",
			"Предрешено",
			"Никаких сомнений",
			"Определённо да",
			"Можешь быть уверен в этом",
			"Нет",
			"Вероятнее всего",
			"Хорошие перспективы",
			"Знаки говорят — «да»",
			"Да",
			"Пока не ясно, попробуй снова",
			"Спроси позже",
			"Лучше не рассказывать",
			"Сейчас нельзя предсказать",
			"Сконцентрируйся и спроси опять",
			"Даже не думай",
			"Мой ответ — «нет»",
			"По моим данным — «нет»",
			"Перспективы не очень хорошие",
			"Весьма сомнительно"
		};

		private static List<double> _probabilities = new List<double>
		{
			0.05,
			0.05,
			0.05,
			0.05,
			0.05,
			0.05,
			0.05,
			0.05,
			0.05,
			0.05,
			0.05,
			0.05,
			0.05,
			0.05,
			0.05,
			0.05,
			0.05,
			0.05,
			0.05,
			0.05
		};

		public MainForm()
		{
			InitializeComponent();
		}

		private void answerBtn_Click(object sender, EventArgs e)
		{
			var rnd = new Random();

			var num = rnd.NextDouble();

			for (var i = 0; i < _answers.Count; i++)
			{
				num = num - _probabilities[i];
				if (num <= 0)
				{
					answerLabel.Text = _answers[i];
					break;
				}
			}
		}
	}
}
