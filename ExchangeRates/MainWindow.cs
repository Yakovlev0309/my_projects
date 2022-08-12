using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ExchangeRates
{
    /// <summary>
    /// Класс главного окна приложения.
    /// </summary>
    public partial class MainWindow : Form
    {
        //Экземпляры перечислений
        private Currency currency;
        private Source source;
        //Конструктор формы
        public MainWindow()
        {
            currency = Currency.USD;
            FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();
        }
        //Загрузка формы
        private void MainWindow_Load(object sender, EventArgs e)
        {
            //Оператор foreach для перебора элементов перечислений
            foreach (string s in Enum.GetNames(typeof(Currency)))
            {
                rateComboBox.Items.Add(s);
            }
            rateComboBox.SelectedIndex = 0;
            foreach (string s in Enum.GetNames(typeof(Source)))
            {
                sourceComboBox.Items.Add(s);
            }
            sourceComboBox.SelectedIndex = 0;
        }
        //Нажатие на кнопку "Получить данные"
        private void startParse_Click(object sender, EventArgs e)
        {
            //Задание переменных
            bool error = false;
            Web web = null;
            //Попытка выполнения подключения к ресурсу
            try
            {
                web = new Web(source);
                web.TryConnect();
            }
            //Если пользователь не подключён к сети Интернет
            catch (Exception)
            {
                error = true;
                MessageBox.Show("Невозможно получить данные. Нет подключения к сети интернет.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Если пользователь подключён к сети Интернет
            if (!error)
            {
                //Создание объекта для парсинга (поиска) нужных данных со страницы html
                Rate rate = new Rate(web.StreamReader.ReadToEnd(), currency);
                //Вызов метода для выполнения парсинга
                rate.Parse(source);
                //Заполнение текстовых составляющих объектов типа Label полученными данными
                fullNameLabel.Text = rate.FullName;
                codeLabel.Text = rate.Count;
                nameLabel.Text = rate.Name;
                currencyLabel.Text = rate.Currency;
                countLabel.Text = rate.Count;
                //Закрытие потоков
                web.StreamReader.Close();
                web.DataStream.Close();
                web.Response.Close();
                //Вывод информации о просматриваемом объекте в панель состояния
                informationLabel.Text = $"Вы просматриваете {rate.FullName} с ресурса {source.ToString().ToLower()}.ru";
            }
        }
        //Изменение выбранного элемента в списке rateComboBox
        private void rateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currency = (Currency)Enum.GetValues(typeof(Currency)).GetValue(rateComboBox.SelectedIndex);
        }
        //Изменение выбранного элемента в списке sourceComboBox
        private void sourceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            source = (Source)Enum.GetValues(typeof(Source)).GetValue(sourceComboBox.SelectedIndex);
        }

        private void MainWindow_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message message = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref message);
        }
        //Нажатие на кнопку с нижним подчёркиванием
        private void collapseButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        //Нажатие на кнопку с красным крестом
        private void exitbutton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //Нажатие ПКМ на statusStrip
        private void statusStrip_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message message = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref message);
        }
        //Нажатие ПКМ на menuStrip
        private void menuStrip_MouseDown(object sender, MouseEventArgs e)
        {
            Capture = false;
            Message message = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref message);
        }
        //Обработчик события перерисовки формы
        private void MainWindow_Paint(object sender, PaintEventArgs e)
        {
            //Рисование контуров формы, главного меню и строки состояния
            Graphics g = CreateGraphics();
            Pen p = new Pen(Color.Black);
            g.DrawLine(p, 0, 0, Width - 1, 0);
            g.DrawLine(p, 0, 0, 0, Height - 1);
            g.DrawLine(p, Width - 1, 0, Width - 1, Height - 1);
            g.DrawLine(p, 0, Height - 1, Width - 1, Height - 1);

            g = statusStrip.CreateGraphics();
            g.DrawLine(p, 0, 0, 0, Height - 1);
            g.DrawLine(p, Width - 1, 0, Width - 1, Height - 1);

            g = menuStrip.CreateGraphics();
            g.DrawLine(p, 0, 0, Width - 1, 0);
            g.DrawLine(p, 0, 0, 0, Height - 1);
            g.DrawLine(p, Width - 1, 0, Width - 1, Height - 1);
            g.Dispose();
            p.Dispose();
        }
        //Нажатие на кнопку "Сохранить"
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Создание диалогового окна для сохранения текстового файла
            SaveFileDialog SaveDialog = new SaveFileDialog
            {
                Title = "Сохранить файл в формате .txt",
                OverwritePrompt = true,
                CheckPathExists = true,
                FileName = $"{currency} from {source}",
                Filter = "Текстовый файл|*.txt",
                ShowHelp = true
            };
            //Если пользователь нажал на "Сохранить"
            if (SaveDialog.ShowDialog() == DialogResult.OK)
            {
                //Создание потока для записи текстовых данных в файл
                StreamWriter sw = new StreamWriter(SaveDialog.FileName);
                string firstString = $"Курс рубля относительно валюты {fullNameLabel.Text} с ресурса {source.ToString().ToLower()}.ru";
                sw.Write($"{firstString}\n{new string('*', firstString.Length)}\nЦифровой код: {codeLabel.Text}\nБуквенный код: {nameLabel.Text}\nКурс: {currencyLabel.Text} руб. за количество единиц: {countLabel.Text}\nДата {DateTime.Now.ToShortDateString()}\nВремя: {DateTime.Now.ToShortTimeString()}\n{new string('*', firstString.Length)}");
                //Закрытие потока
                sw.Close();
            }
        }
        //Нажатие на кнопку "Выход"
        private void выходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
	}
}