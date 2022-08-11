using System;

namespace Pass_nerator
{
	/// <summary>
	/// Статический класс, содержащий методы для генерации пароля.
	/// </summary>
	static class PasswordGenerator
	{
		//Метод для генерации пароля, состоящего из один буквенных символов
		public static string GetLettersOnly(int count, Language language)
		{
			char[] pass = new char[count];

			string letters;
			switch(language)
			{
				case Language.ENGLISH:
					letters = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
					break;

				default:
					letters = "АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЬьЫыЪъЭэЮюЯя";
					break;
			}

			Random Rnd = new Random();
			for (int i = 0; i < pass.Length; i++)
			{
				pass[i] = letters[Rnd.Next(letters.Length)];
			}
			string Password = "";
			foreach (char c in pass)
			{
				Password += c;
			}
			return Password;
		}
		//Метод для генерации пароля, состоящего из одних цифр
		public static string GetNumbersOnly(int count)
		{
			int[] pass = new int[count];
			Random Rnd = new Random();
			for (int i = 0; i < pass.Length; i++)
			{
				pass[i] = Rnd.Next(10);
			}
			string Password = "";
			foreach (int i in pass)
			{
				Password += i.ToString();
			}
			return Password;
		}
		//Метод для генерации пароля из цифр и букв
		public static string GetNumbersAndLetters(int count, Language language, bool lettersFirst)
		{
			string letters;
			switch (language)
			{
				case Language.ENGLISH:
					letters = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
					break;

				default:
					letters = "АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЬьЫыЪъЭэЮюЯя";
					break;
			}

			Random Rnd = new Random();
			int count_of_letters = Rnd.Next(count - count * 2 / 3, count - count / 3);
			char[] Lpass = new char[count_of_letters];
			for (int i = 0; i < Lpass.Length; i++)
			{
				Lpass[i] = letters[Rnd.Next(letters.Length)];
			}
			int[] Npass = new int[count - count_of_letters];
			for (int i = 0; i < Npass.Length; i++)
			{
				Npass[i] = Rnd.Next(10);
			}
			string Password = "";
			foreach (char c in Lpass)
			{
				Password += c;
			}
			foreach (int i in Npass)
			{
				Password += i.ToString();
			}
			if (!lettersFirst)
			{
				char[] pass = Password.ToCharArray();
				for (int k = pass.Length - 1; k >= 1; k--)
				{
					int j = Rnd.Next(k + 1);
					var tmp = pass[j];
					pass[j] = pass[k];
					pass[k] = tmp;
				}
				Password = "";
				foreach (char c in pass)
				{
					Password += c;
				}
			}
			return Password;
		}
		//Метод для генерации пароля с использованием кодового слова
		public static string GetWithKeyWord(int count, bool lettersFirst, string keyWord)
		{
			if (count > keyWord.Length)
			{
				int[] pass = new int[count - keyWord.Length];
				Random Rnd = new Random();
				for (int i = 0; i < pass.Length; i++)
				{
					pass[i] = Rnd.Next(10);
				}
				string Password = "";
				if (count - keyWord.Length == 1)
				{
					if (!lettersFirst)
					{
						int choice = Rnd.Next(2);
						if (choice == 0)
						{
							foreach (int i in pass)
							{
								Password += i.ToString();
							}
							Password += keyWord;
						}
						else if (choice == 1)
						{
							foreach (int i in pass)
							{
								Password += i.ToString();
							}
							string time = keyWord;
							time += Password;
							Password = time;
						}
					}
					else
					{
						foreach (int i in pass)
						{
							Password += i.ToString();
						}
						string time = keyWord;
						time += Password;
						Password = time;
					}
				}
				else
				{
					if (!lettersFirst)
					{
						if (count % 2 == 0 && keyWord.Length % 2 == 0 || count % 2 == 1 && keyWord.Length % 2 == 1)
						{
							string time = keyWord;
							int choice = Rnd.Next(2);
							if (choice == 0)
							{
								foreach (int i in pass)
								{
									Password += i.ToString();
								}
								time += Password.Remove(0, Password.Length / 2);
								Password = Password.Remove(Password.Length / 2) + time;
							}
							else if (choice == 1)
							{
								foreach (int i in pass)
								{
									Password += i.ToString();
								}
								time += Password.Remove(0, Password.Length / 2);
								Password = Password.Remove(0, Password.Length / 2) + time;
							}
						}
						else if (count % 2 == 1 && keyWord.Length % 2 == 0 || count % 2 == 0 && keyWord.Length % 2 == 1)
						{
							string time = keyWord;
							int choice = Rnd.Next(2);
							if (choice == 0)
							{
								for (int i = 0; i < pass.Length; i++)
								{
									if (i < pass.Length / 2)
									{
										Password += pass[i];
									}
									else
									{
										time += pass[i];
									}
								}
								Password += time;
							}
							else if (choice == 1)
							{
								for (int i = 0; i < pass.Length; i++)
								{
									if (i <= pass.Length / 2)
									{
										Password += pass[i];
									}
									else
									{
										time += pass[i];
									}
								}
								Password += time;
							}
						}
					}
					else
					{
						foreach (int i in pass)
						{
							Password += i.ToString();
						}
						string time = keyWord;
						time += Password;
						Password = time;
					}
				}
				return Password;
			}
			else if (count == keyWord.Length)
			{
				return keyWord;
			}
			else
			{
				return "";
			}
		}
	}
}
