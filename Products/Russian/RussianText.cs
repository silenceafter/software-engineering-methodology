﻿using abstract_factory.Interfaces;
using abstract_factory.Models;

namespace abstract_factory.Products.Russian
{
    public class RussianText : IText
    {
        public TextModel GetText()
        {
            return new TextModel() 
            { 
                Title = "Абстрактная фабрика. Интерфейсы на разных языках",
                HeaderContext = new Dictionary<string, string> { { "Home", "Главная" }, { "Help", "Помощь" } },
                MainContext = new Dictionary<string, string> { { "Main", "Москва\r\nМосква – столица России, крупнейший город страны и важный культурный центр. Это город контрастов, где древняя архитектура соседствует с современными небоскрёбами. Кремль и Красная площадь – главные символы Москвы, привлекающие миллионы туристов со всего мира. Помимо этого, в Москве стоит посетить Третьяковскую галерею, знаменитый Большой театр и ВДНХ. Здесь каждый найдёт что-то интересное – от истории до искусства.\r\n\r\nСанкт-Петербург\r\nСанкт-Петербург, основанный Петром Великим, славится своими дворцами, реками и каналами. Этот город часто называют \"Северной Венецией\" за его многочисленные мосты и великолепную архитектуру. Эрмитаж, один из крупнейших музеев мира, предлагает уникальные коллекции искусства. Также не пропустите Петропавловскую крепость, Исаакиевский собор и прогулку по Невскому проспекту – главной улице города.\r\n\r\nКазань\r\nКазань – это удивительное сочетание восточной и западной культур, где мусульманские мечети соседствуют с православными храмами. Город, столица Татарстана, является важным культурным и историческим центром России. Главные достопримечательности Казани включают Казанский Кремль, мечеть Кул-Шариф и улицу Баумана. Казань также известна своим гостеприимством и знаменитыми татарскими блюдами, такими как чак-чак и эчпочмак." } },
                FooterContext = new Dictionary<string, string> { { "Copyright", "Все права защищены" }, { "Contacts", "Контакты: info@mail.ru" }, { "Address", "Адрес: г. Москва, ул. Примерная, д. 123" } }
                };
        }
    }
}
