using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pass_nerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public RadioButton OnlyLetters, OnlyNumbers, Together, OnlyLettersRus, TogetherRus, KeyWord;
        public Button GetPassword;
        public Label Title, Pass, LCount;
        public TextBox Password, TCount, TKeyWord;
        public CheckBox LettersFirst;

        private void Form1_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            ShowIcon = false;
            Text = "";
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Size = new Size(650, 400);
            BackgroundImage = Properties.Resources.cool;
            BackgroundImageLayout = ImageLayout.Stretch;

            Title = new Label
            {
                Text = "Pass-nerator",
                Location = new Point(215, 10),
                AutoSize = true,
                Font = new Font("Times New Roman", 30, FontStyle.Italic),
                ForeColor = Color.Red,
                BackColor = Color.Transparent
            };
            Controls.Add(Title);

            GetPassword = new Button
            {
                Location = new Point(268, 133),
                Size = new Size(100, 60),
                Text = "Создать пароль",
                BackColor = Color.LightGreen,
                Font = new Font("Consolas", 14),
                Cursor = Cursors.Hand
            };
            Controls.Add(GetPassword);
            GetPassword.Click += new EventHandler(GetPassword_click);

            OnlyLetters = new RadioButton
            {
                Location = new Point(20, 70),
                Text = "Только буквы (англ)",
                AutoSize = true,
                BackColor = Color.Transparent,
                ForeColor = Color.LightGreen,
                Font = new Font("Consolas", 10, FontStyle.Bold)
            };
            Controls.Add(OnlyLetters);
            OnlyLetters.Click += new EventHandler(OnlyLetters_Click);

            OnlyNumbers = new RadioButton
            {
                Location = new Point(20, 100),
                Text = "Только цифры",
                AutoSize = true,
                BackColor = Color.Transparent,
                ForeColor = Color.LightGreen,
                Font = new Font("Consolas", 10, FontStyle.Bold)
            };
            Controls.Add(OnlyNumbers);
            OnlyNumbers.Click += new EventHandler(OnlyNumbers_Click);

            Together = new RadioButton
            {
                Location = new Point(20, 130),
                Text = "Цифры и буквы (англ)",
                AutoSize = true,
                BackColor = Color.Transparent,
                ForeColor = Color.LightGreen,
                Font = new Font("Consolas", 10, FontStyle.Bold),
                Checked = true
            };
            Controls.Add(Together);
            Together.Click += new EventHandler(Together_Click);

            OnlyLettersRus = new RadioButton
            {
                Location = new Point(450, 70),
                Text = "Только буквы (рус)",
                AutoSize = true,
                BackColor = Color.Transparent,
                ForeColor = Color.LightGreen,
                Font = new Font("Consolas", 10, FontStyle.Bold)
            };
            Controls.Add(OnlyLettersRus);
            OnlyLettersRus.Click += new EventHandler(OnlyLettersRus_Click);

            TogetherRus = new RadioButton
            {
                Location = new Point(450, 100),
                Text = "Цифры и буквы (рус)",
                AutoSize = true,
                BackColor = Color.Transparent,
                ForeColor = Color.LightGreen,
                Font = new Font("Consolas", 10, FontStyle.Bold)
            };
            Controls.Add(TogetherRus);
            TogetherRus.Click += new EventHandler(TogetherRus_Click);

            KeyWord = new RadioButton
            {
                Location = new Point(450, 130),
                Text = "Кодовое слово",
                AutoSize = true,
                BackColor = Color.Transparent,
                ForeColor = Color.LightGreen,
                Font = new Font("Consolas", 10, FontStyle.Bold)
            };
            Controls.Add(KeyWord);
            KeyWord.Click += new EventHandler(KeyWord_Click);

            Pass = new Label
            {
                Location = new Point(135, 300),
                Text = "Пароль:",
                AutoSize = true,
                Font = new Font("Consolas", 16, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.LightGreen,
            };
            Controls.Add(Pass);

            LCount = new Label
            {
                Location = new Point(110, 230),
                Text = "Кол-во\nсимволов:",
                AutoSize = true,
                Font = new Font("Consolas", 16, FontStyle.Bold),
                BackColor = Color.Transparent,
                ForeColor = Color.LightGreen,
            };
            Controls.Add(LCount);

            Password = new TextBox
            {
                Location = new Point(235, 300),
                Text = "",
                Size = new Size(170, 50),
                ReadOnly = true,
                MaxLength = 16,
                Font = new Font("Consolas", 14, FontStyle.Bold),
                TextAlign = HorizontalAlignment.Center
            };
            Controls.Add(Password);

            TCount = new TextBox
            {
                Location = new Point(235, 260),
                Text = "",
                Size = new Size(40, 50),
                Font = new Font("Consolas", 14, FontStyle.Bold),
                MaxLength = 2,
                TextAlign = HorizontalAlignment.Center,
                ForeColor = Color.Red
            };
            Controls.Add(TCount);
            TCount.Click += new EventHandler(TCount_Click);

            LettersFirst = new CheckBox
            {
                Location = new Point(450, 225),
                Text = "Цифры в конце",
                AutoSize = true,
                BackColor = Color.Transparent,
                ForeColor = Color.LightGreen,
                Font = new Font("Consolas", 12, FontStyle.Bold),
                Cursor = Cursors.Hand
            };
            Controls.Add(LettersFirst);

            TKeyWord = new TextBox
            {
                Location = new Point(445, 160),
                Text = "",
                Size = new Size(170, 50),
                MaxLength = 16,
                Font = new Font("Consolas", 14, FontStyle.Bold),
                TextAlign = HorizontalAlignment.Center,
                Visible = false,
                AllowDrop = true
            };
            Controls.Add(TKeyWord);
        }

        private void TCount_Click(object sender, EventArgs e)
        {
            TCount.Clear();
        }

        private void TogetherRus_Click(object sender, EventArgs e)
        {
            TKeyWord.Visible = false;
        }

        private void OnlyLettersRus_Click(object sender, EventArgs e)
        {
            TKeyWord.Visible = false;
        }

        private void Together_Click(object sender, EventArgs e)
        {
            TKeyWord.Visible = false;
        }

        private void OnlyNumbers_Click(object sender, EventArgs e)
        {
            TKeyWord.Visible = false;
        }

        private void OnlyLetters_Click(object sender, EventArgs e)
        {
            TKeyWord.Visible = false;
        }

        private void KeyWord_Click(object sender, EventArgs e)
        {
            TKeyWord.Visible = true;
        }

        private void GetPassword_click(object sender, EventArgs e)
        {
            if (TCount.Text != "")
            {
                if (Convert.ToInt32(TCount.Text) < 17 && Convert.ToInt32(TCount.Text) > 0)
                {
                    if (OnlyLetters.Checked == true)
                    {
                        Password.Text = Only_Letters(Convert.ToInt32(TCount.Text));
                    }
                    else if (OnlyNumbers.Checked == true)
                    {
                        Password.Text = Only_Numbers(Convert.ToInt32(TCount.Text));
                    }
                    else if (Together.Checked == true)
                    {
                        Password.Text = TogetheR(Convert.ToInt32(TCount.Text), LettersFirst);
                    }
                    else if (OnlyLettersRus.Checked == true)
                    {
                        Password.Text = Only_Letters_Rus(Convert.ToInt32(TCount.Text));
                    }
                    else if (TogetherRus.Checked == true)
                    {
                        Password.Text = TogetheR_Rus(Convert.ToInt32(TCount.Text), LettersFirst);
                    }
                    else if (KeyWord.Checked == true)
                    {
                        Password.Text = Key_Word(Convert.ToInt32(TCount.Text), LettersFirst, TKeyWord);
                    }
                }
            }
        }
        static string Only_Letters(int count)
        {
            char[] pass = new char[count];
            string letters = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
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
        static string Only_Numbers(int count)
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
        static string TogetheR(int count, CheckBox LettersFirst)
        {
            string letters = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
            Random Rnd = new Random();
            int count_of_letters = Rnd.Next(count - count * 2/3, count - count / 3);
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
            if (LettersFirst.Checked == false)
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
        static string Only_Letters_Rus(int count)
        {
            char[] pass = new char[count];
            string letters = "АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЬьЫыЪъЭэЮюЯя";
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
        static string TogetheR_Rus(int count, CheckBox LettersFirst)
        {
            string letters = "АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЬьЫыЪъЭэЮюЯя";
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
            if (LettersFirst.Checked == false)
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
        static string Key_Word(int count, CheckBox LettersFirst, TextBox TKeyWord)
        {
                if (count > TKeyWord.Text.Length)
                {
                    int[] pass = new int[count - TKeyWord.Text.Length];
                    Random Rnd = new Random();
                    for (int i = 0; i < pass.Length; i++)
                    {
                        pass[i] = Rnd.Next(10);
                    }
                    string Password = "";
                    if (count - TKeyWord.Text.Length == 1)
                    {
                        if (LettersFirst.Checked == false)
                        {
                            int choice = Rnd.Next(2);
                            if (choice == 0)
                            {
                                foreach (int i in pass)
                                {
                                    Password += i.ToString();
                                }
                                Password += TKeyWord.Text;
                            }
                            else if (choice == 1)
                            {
                                foreach (int i in pass)
                                {
                                    Password += i.ToString();
                                }
                                string time = TKeyWord.Text;
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
                            string time = TKeyWord.Text;
                            time += Password;
                            Password = time;
                        }
                    }
                    else
                    {
                        if (LettersFirst.Checked == false)
                        {
                            if (count % 2 == 0 && TKeyWord.Text.Length % 2 == 0 || count % 2 == 1 && TKeyWord.Text.Length % 2 == 1)
                            {
                                string time = TKeyWord.Text;
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
                            else if (count % 2 == 1 && TKeyWord.Text.Length % 2 == 0 || count % 2 == 0 && TKeyWord.Text.Length % 2 == 1)
                            {
                                string time = TKeyWord.Text;
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
                            string time = TKeyWord.Text;
                            time += Password;
                            Password = time;
                        }
                    }
                    return Password;
                }
                else if (count == TKeyWord.Text.Length)
                {
                    return TKeyWord.Text;
                }
                else
                {
                    return "";
                }
        }
    }
}