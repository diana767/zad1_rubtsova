using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YP_rubtsova_zad1
{
    class Cat
    {
        private string name; // скрытое поле
        public string Name // свойство, реализуем инкапсуляцию!
        {
            // получение значения - просто возврат name
            get
            {
                return name;
            }
            // установка значения - используем проверку
            set
            {
                bool OnlyLetters = true;
                // ключ. слово value - это то, что хотят свойству присвоить
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        OnlyLetters = false;
                    }
                }

                if (OnlyLetters)
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine($"{value} - неправильное имя!!!");
                }
            }
        }

        private double ves;

        public double Ves
        {
            get
            {
                return ves;
            }
            set
            {
                if (value > 0) // Проверяем устанавливаемое значение
                {
                    ves = value; // Устанавливаем вес, если он корректный
                    Meow();
                }
                else
                {
                    Console.WriteLine("вы ввели вес неправильнно!! Поэтому мы заменили его на 0"); // Сообщение об ошибке
                }
            }
        }

        public void Meow()
        {
            Console.WriteLine($"{name}: МЯЯЯЯУ!!!!\n Вес котика {ves} ");//выводим имя и вес нашего котика
        }

    }

}
