using AngleSharp.Dom;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;
using System.Collections.Generic;
using System.Text;

namespace ExchangeRates
{
    /// <summary>
    /// Класс, предназначенный для работы с данными, полученными с сервера.
    /// </summary>
    class Rate
    {
        //Задание полей класса
        public string Code { get; set; }
        public string Name { get; set; }
        public string Count { get; set; }
        public string FullName { get; set; }
        public string Currency { get; set; }
        //Задание вспомогательных переменных
        private string html;
        private Currency currency;
        //Конструктор
        public Rate(string html, Currency currency)
        {
            this.html = html;
            this.currency = currency;
        }
        //Вызов метода для парсинга в соответствии с объектом перечисления
        public void Parse(Source source)
        {
            switch (source)
            {
                case Source.CBR:
                    ParseFromCBR();
                    break;
                case Source.FINMARKET:
                    ParseFromFinmarket();
                    break;
                case Source.ALTA:
                    ParseFromAlta();
                    break;
            }
        }
        //Методы для парсинга
        private void ParseFromCBR()
        {
            //Список элементов, получаемых со страницы
            List<string> elements = new List<string>();
            //Создание экземпляра класса HtmlParser для парсинга страниц html
            HtmlParser parser = new HtmlParser();
            IHtmlDocument document = parser.ParseDocument(html);
            //Получение элемента table с полученной страницы
            IElement el = document.QuerySelector("table");
            //Применение оператора foreach для перебора элементов страницы и поиска нужных
            GetElements(ref elements, document);
            //Запись полученных данных в соответствующие переменные
            Code = elements[0];
            Name = elements[1];
            Count = elements[2];
            FullName = elements[3];
            Currency = elements[4];
        }

        private void ParseFromFinmarket()
        {
            //Попытка изменения кодировки
            byte[] startArr = Encoding.GetEncoding(1251).GetBytes(html);
            byte[] finishArr = Encoding.Convert(Encoding.UTF8, Encoding.GetEncoding(1251), startArr);
            string utfHtml = Encoding.UTF8.GetString(finishArr);
            //Список элементов, получаемых со страницы
            List<string> elements = new List<string>();
            //Создание экземпляра класса HtmlParser для парсинга страниц html
            HtmlParser parser = new HtmlParser();
            IHtmlDocument document = parser.ParseDocument(utfHtml);
            //Применение оператора foreach для перебора элементов страницы и поиска нужных
            GetElements(ref elements, document);
            //Запись полученных данных в соответствующие переменные
            Code = "нет данных";
            Name = elements[0];
            Count = elements[2];
            FullName = "нет данных";
            Currency = elements[3];
        }

        private void ParseFromAlta()
        {
            //Список элементов, получаемых со страницы
            List<string> elements = new List<string>();
            //Создание экземпляра класса HtmlParser для парсинга страниц html
            HtmlParser parser = new HtmlParser();
            IHtmlDocument document = parser.ParseDocument(html);
            //Применение оператора foreach для перебора элементов страницы и поиска нужных
            foreach (IElement el in document.QuerySelectorAll("table"))
            {
                foreach (IElement ele in el.QuerySelectorAll("tbody"))
                {
                    GetElements(ref elements, ele);
                }
            }
            //Запись полученных данных в соответствующие переменные
            Code = elements[0].Substring(0, 3);
            Name = elements[0].Substring(4);
            string[] strs = elements[1].Split(' ');
            FullName = strs[0].Trim() + " " + strs[1].Trim();
            //Применение оператора foreach для перебора строк полученного элемента
            foreach (string s in strs)
            {
                if (s.Contains(")"))
                {
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s[i] == ')')
                        {
                            break;
                        }
                        else
                        {
                            Count += s[i];
                        }
                    }
                    break;
                }
            }
            Currency = elements[2];
        }

        void GetElements(ref List<string> elements, dynamic el)
		{
            foreach (IElement element in el.QuerySelectorAll("tr"))
            {
                if (element.TextContent.Contains(currency.ToString()))
                {
                    foreach (IElement e in element.QuerySelectorAll("td"))
                    {
                        elements.Add(e.TextContent);
                    }
                }
            }
        }
    }
}