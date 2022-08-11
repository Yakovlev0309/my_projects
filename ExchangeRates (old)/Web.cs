using System;
using System.IO;
using System.Net;

namespace ExchangeRates
{
    /// <summary>
    /// Класс, предоставляющий доступ к удалённому ресурсу.
    /// </summary>
    class Web
    {
        //Задание полей класса
        public HttpWebResponse Response { get; set; }
        public Stream DataStream { get; set; }
        public StreamReader StreamReader { get; set; }
        private string adress;
        //Конструктор
        public Web(Source source)
        {
            adress = GetAdress(source);
        }
        //Метод для определения адреса ресурса в соответствии с объектом перечисления
        private string GetAdress(Source source)
        {
            switch (source)
            {
                case Source.CBR:
                    return "https://www.cbr.ru/currency_base/daily/";
                case Source.FINMARKET:
                    return "http://www.finmarket.ru/currency/rates/";
                case Source.ALTA:
                    return "https://www.alta.ru/currency/";
            }
            return null;
        }
        //Метод для подключения к удалённому ресурсу по заданному адресу
        public void TryConnect()
        {
            try
            {
                //Создание объекта для выполнения запроса к универсальному ресурсу по URI
                WebRequest request = WebRequest.Create(adress);
                //Задание сетевых учётных данных по умолчанию для проверки подлинности запроса
                request.Credentials = CredentialCache.DefaultCredentials;
                //Получение ответа на интернет-запрос
                Response = (HttpWebResponse)request.GetResponse();
                //Получение потока, используемого для чтения основного текста ответа с сервера
                DataStream = Response.GetResponseStream();
                //Инициализация нового экземпляра класса StreamReader для потока DataStream
                StreamReader = new StreamReader(DataStream);
            }
            //В случае отсутствия подключения происходит выброс исключения на вызывающий уровень
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}