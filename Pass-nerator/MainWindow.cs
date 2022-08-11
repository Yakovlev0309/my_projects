using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Pass_nerator
{
	/// <summary>
	/// Класс главного окна приложения.
	/// </summary>
	public partial class MainWindow : Form
	{
		//Вспомогательные поля
		private GenerationMethod generationMethod;
		private Language language;
		private string fileName;
		//Конструктор формы
		public MainWindow()
		{
			InitializeComponent();

			//Задание начальных значений
			FormBorderStyle = FormBorderStyle.None;
			lettersOnlyRadioButton.Checked = true;
			generationMethod = GenerationMethod.LETTERS_ONLY;
			englishRadioButton.Checked = true;
			language = Language.ENGLISH;
			numbersInTheEndCheckBox.Checked = false;
			fileName = "keywords.txt";
		}
		//Нажатие на кнопку "Получить пароль"
		private void getPasswordButton_Click(object sender, EventArgs e)
		{
			int count;
			if (int.TryParse(countOfSymbolsTextBox.Text, out count))
			{
				switch (generationMethod)
				{
					case GenerationMethod.LETTERS_ONLY:
						passwordTextBox.Text = PasswordGenerator.GetLettersOnly(count, language);
						break;
					case GenerationMethod.NUMBERS_ONLY:
						passwordTextBox.Text = PasswordGenerator.GetNumbersOnly(count);
						break;
					case GenerationMethod.LETTERS_AND_NUMBERS:
						passwordTextBox.Text = PasswordGenerator.GetNumbersAndLetters(count, language, numbersInTheEndCheckBox.Checked);
						break;
					default:
						passwordTextBox.Text = PasswordGenerator.GetWithKeyWord(count, numbersInTheEndCheckBox.Checked, keyWordTextBox.Text);
						break;
				}
			}
		}
		//События выбора языка пароля и режима его генерации
		private void lettersOnlyRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			generationMethod = GenerationMethod.LETTERS_ONLY;
		}

		private void numbersOnlyRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			generationMethod = GenerationMethod.NUMBERS_ONLY;
		}

		private void lettersAndNumbersRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			generationMethod = GenerationMethod.LETTERS_AND_NUMBERS;
		}

		private void keyWordRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			generationMethod = GenerationMethod.WITH_KEY_WORD;
		}

		private void englishRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			language = Language.ENGLISH;
		}

		private void russianRadioButton_CheckedChanged(object sender, EventArgs e)
		{
			language = Language.RUSSIAN;
		}

		private void countOfSymbolsTextBox_Click(object sender, EventArgs e)
		{
			countOfSymbolsTextBox.Clear();
		}
		//Нажатие на свободное место формы
		private void MainWindow_MouseDown(object sender, MouseEventArgs e)
		{
			Capture = false;
			Message message = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
			WndProc(ref message);
		}
		//Нажатие на свободное место меню
		private void menuStrip_MouseDown(object sender, MouseEventArgs e)
		{
			Capture = false;
			Message message = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
			WndProc(ref message);
		}

		private void exitButton_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		private void collapseButton_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}
		//Нажатие на кнопку "Сохранить"
		private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (passwordTextBox.Text != "")
			{
				//Создание диалогового окна для сохранения текстового файла
				SaveFileDialog SaveDialog = new SaveFileDialog
				{
					Title = "Сохранить файл в формате .txt",
					OverwritePrompt = true,
					CheckPathExists = true,
					FileName = "My new password",
					Filter = "Текстовый файл|*.txt",
					ShowHelp = true
				};
				//Если пользователь нажал на "Сохранить"
				if (SaveDialog.ShowDialog() == DialogResult.OK)
				{
					//Создание потока для записи текстовых данных в файл
					StreamWriter sw = new StreamWriter(SaveDialog.FileName);
					sw.Write("Your password is: " + passwordTextBox.Text);
					sw.Close();
				}
			}
			else
			{
				MessageBox.Show("Вы не сгенерировали пароль.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		//Скопировать полученный пароль в буфер обмена
		private void copyButton_Click(object sender, EventArgs e)
		{
			if (passwordTextBox.Text != "")
			{
				Clipboard.SetText(passwordTextBox.Text);
				MessageBox.Show("Пароль скопирован в буфер обмена.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Вы не сгенерировали пароль.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}
		//Подобрать кодовое слово
		private void getRandomKeyWord_Click(object sender, EventArgs e)
		{
			if (countOfKeyWords.Text == "")
			{
				countOfKeyWords.Text = "1";
			}
			//Если файл существует
			if (File.Exists(fileName))
			{
				List<string> keywords = new List<string>();

				using (StreamReader sr = new StreamReader(fileName))
				{
					while (!sr.EndOfStream)
					{
						keywords.Add(sr.ReadLine()); //Добавление строки из файла в массив
					}
				}

				int count;
				int.TryParse(countOfKeyWords.Text, out count);
				keyWordTextBox.Clear();
				Random rnd = new Random();

				//Цикл для добавления кодовых слов в элемент keyWordTextBox
				for (int i = 0; i < count; i++)
				{
					keyWordTextBox.Text += keywords[rnd.Next(keywords.Count)];
				}
			}
			else
			{
				MessageBox.Show("Не найден файл с кодовыми словами.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		//Подключить кодовые слова
		private void подключитьКодовыеСловаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//Создание диалогового окна для сохранения текстового файла
			OpenFileDialog OpenDialog = new OpenFileDialog
			{
				Title = "Открыть файл в формата .txt",
				CheckPathExists = true,
				Filter = "Текстовый файл|*.txt",
				ShowHelp = true
			};
			//Если пользователь нажал на "Сохранить"
			if (OpenDialog.ShowDialog() == DialogResult.OK)
			{
				fileName = OpenDialog.FileName;

				List<string> keywords = new List<string>();

				using (StreamReader sr = new StreamReader(fileName))
				{
					while (!sr.EndOfStream)
					{
						keywords.Add(sr.ReadLine());
					}
				}
				Random rnd = new Random();
				keyWordTextBox.Text = keywords[rnd.Next(keywords.Count)];
			}
		}
		//Нажатие на элемент для ввода количества символов в пароле
		private void countOfSymbolsTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
			{
				return;
			}
			e.Handled = true; //Запрет на ввод других символов
		}
		//Нажатие на элемент для ввода количества кодовых слов
		private void countOfKeyWords_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back)
			{
				return;
			}
			e.Handled = true; //Запрет на ввод других символов
		}
	}
}
