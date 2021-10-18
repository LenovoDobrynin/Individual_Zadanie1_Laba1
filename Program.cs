using System;
using System.Collections;

namespace Table
{
    public class OOP
    {

        public struct Item
        {
            public String ItemName;
            public String ItemType;
            public int ploh;
            public int uroz;

            public Item(string ItemName, String ItemType, int ploh, int uroz)
            {
                this.ItemName = ItemName;
                this.ItemType = ItemType;
                this.ploh = ploh;
                this.uroz = uroz;

            }

            public void Print()
            {
                Console.WriteLine($"|{this.ItemName,-24}|{this.ItemType,-12}|{this.ploh,-20}|{this.uroz,-15}|");

            }
        }

        private static void Main()
        {
            ArrayList list = new();


            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Введите нужные данные:");

                Console.WriteLine("Наименование урожая:");
                string name = Console.ReadLine();

                Console.WriteLine("Тип вашего растения (З-Зерновой, Б-Бобовые)");
                string ItemType = Console.ReadLine();

                Console.WriteLine("Площадь посева (га)");
                int ploh = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Урожайность (ц/га)");
                int uroz = Int32.Parse(Console.ReadLine());
                Item value = new(name, ItemType, ploh, uroz);
                list.Add(value);
                while (true)
                {
                    Console.WriteLine("Добавить строку?\nДа - продолжить\nНет - вывести таблицу");
                    string input = Console.ReadLine();
                    if (input == "Да" || input == "Нет")
                    {
                        if (input == "Нет")
                        {
                            flag = false;
                            break;
                        }
                        break;
                    }
                    else Console.WriteLine("Ошибка ввода. Попробуйте еще раз.");
                }

            }
            Console.WriteLine(new String('-', 76));
            Console.WriteLine($"{"|Сельскохозяйственные культуры",-75}|");
            Console.WriteLine(new String('-', 76));
            Console.WriteLine($"{"|Наименование",-25}|{"Тип ",-12}|{"Площадь (га)",-20}|{"Урожайность (ц/га)",-15}|");
            Console.WriteLine(new String('-', 76));
            foreach (Item item in list)
            {
                item.Print();
                Console.WriteLine(new String('-', 76));
            }
            Console.WriteLine($"{"|Перечисляемый тип: З - зерновые, Б - бобовые",-75}|");
            Console.WriteLine(new String('-', 76));
        }

    }
}