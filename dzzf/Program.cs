using System.Text.RegularExpressions;

namespace dzzf
{
    
    /// <summary>
    /// Структура для представления алкогольного напитка.
    /// </summary>
    struct Drink
    {
        public string Name;
        public double Alcohol;

        public Drink(string name, double alcohol)
        {
            Name = name;
            Alcohol = alcohol;
        }
    }

    /// <summary>
    /// Структура для представления алкогольного напитка.
    /// </summary>
    struct Student
    {
        public string LastName;
        public string FirstName;
        public int Id;
        public DateTime Birthday;
        public char AlcoholCategory; // a, b, c, d
        public double Volume; // Объем выпитой жидкости (в литрах)
        public Drink FavoriteDrink;

        public Student(string lastName, string firstName, int id, DateTime birthday, char alcoholCategory, double volume, Drink favoriteDrink)
        {
            LastName = lastName;
            FirstName = firstName;
            Id = id;
            Birthday = birthday;
            AlcoholCategory = alcoholCategory;
            Volume = volume;
            FavoriteDrink = favoriteDrink;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Информация о каждом типе значений. Выводится тип, максимальное значение и минимальное значение
            Console.WriteLine("Задание 1");
            Console.WriteLine("Тип данных: byte - Максимальное значение: " + byte.MaxValue + " - Минимальное значение: " + byte.MinValue);
            Console.WriteLine("Тип данных: int - Максимальное значение: " + int.MaxValue + " - Минимальное значение: " + int.MinValue);
            Console.WriteLine("Тип данных: float - Максимальное значение: " + float.MaxValue + " - Минимальное значение: " + float.MinValue);
            Console.WriteLine("Тип данных: double - Максимальное значение: " + double.MaxValue + " - Минимальное значение: " + double.MinValue);
            Console.WriteLine("Тип данных: bool - Значение true/false,максимального и минимального значения не существует");
            Console.WriteLine("Тип данных: char - Максимальное значение: " + char.MaxValue + " - Минимальное значение: " + char.MinValue);
            Console.WriteLine("Тип данных: long - Максимальное значение: " + long.MaxValue + " - Минимальное значение: " + long.MinValue);
            Console.WriteLine("Тип данных: sbyte - Максимальное значение: " + sbyte.MaxValue + " - Минимальное значение: " + sbyte.MinValue);
            Console.WriteLine("Тип данных: short - Максимальное значение: " + short.MaxValue + " - Минимальное значение: " + short.MinValue);
            Console.WriteLine("Тип данных: ushort - Максимальное значение: " + ushort.MaxValue + " - Минимальное значение: " + ushort.MinValue);
            Console.WriteLine("Тип данных: ulong - Максимальное значение: " + ulong.MaxValue + " - Минимальное значение: " + ulong.MinValue);
            Console.WriteLine("Тип данных: decimal - Максимальное значение: " + decimal.MaxValue + " - Минимальное значение: " + decimal.MinValue);

            //Принимаются данные пользователя в виде имени, города, возраста и PIN-кода. Выводятся в правильном формате
            Console.WriteLine("Задание 2");
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите ваш город");
            string city = Console.ReadLine();
            Console.WriteLine("Введите возраст");
            string age = Console.ReadLine();
            Console.WriteLine("Введите PIN-код");
            string pin = Console.ReadLine();
            Console.WriteLine($"Ваше имя: {name}, ваш город: {city}, ваш возраст: {age}, ваш PIN-код: {pin}");

            //Нужно преобразовать входную строчку: строчные буквы заменить на заглавные, а заглавные - на строчные.
            Console.WriteLine("Задание 3");
            string str;
            Console.Write("Введите строку: ");
            str = Console.ReadLine();
            str = string.Concat(str.Select(c => (char)(char.ToLower(c) ^ char.ToUpper(c) ^ c)));
            Console.WriteLine("Полученная строка " + str);
            

            //Введите строку, введите подстроку. Необходимо найти количество вхождений и вывести на экран.
            Console.WriteLine("Задание 4");
            Console.WriteLine("Введите строку:");
            string strochka = Console.ReadLine();
            Console.WriteLine("Введите подстроку:");
            string podstroka = Console.ReadLine();
            int count = new Regex(podstroka).Matches(strochka).Count;
            Console.WriteLine(count);


            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите стандартную цену бутылки (normPrice):");
            int normPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите скидку в дьюти фри (salePrice):");
            int salePrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите стоимость отпуска (holidayPrice):");
            int holidayPrice = Convert.ToInt32(Console.ReadLine());
            double discount = normPrice * (salePrice / 100.0);
            double savings = discount;
            int bottles = (int)(holidayPrice / savings);
            Console.WriteLine($"Необходимо купить бутылок: {bottles}");

            //Создать структуру студента.У студента есть Фамилия, Имя, его Идентификатор, Дата рождения, Категория алкоголизма
            //a - студент алкоголик, b - студент любитель выпить, но не алкоголик, c - студент пьет по праздникам, d - студент не пьет
            //У студента есть объем выпитой жидкости конкретного напитка.
            //Нужно создать 5 студентов с различными параметрами.
            //Посчитать общий объем выпитого, общий объем алкоголя(процент спирта) и кто сколько процентов алкоголя и жидкости от общего кол-ва выпил.
            //Напитки задать в виде структуры: наименование типа напитка и процент спирта.
            Console.WriteLine("Задание 6");
            Drink vodka = new Drink("Водка", 40.0);
            Drink beer = new Drink("Пиво", 6.0);
            Drink vino = new Drink("Вино", 12.0);
            Drink viski = new Drink("Виски", 30.0);
            Drink aperol = new Drink("Апероль", 20.0);
            Student[] students = new Student[]
            {
            new Student("Иванов", "Петя", 1, new DateTime(2003, 3, 1), 'a', 10.0, vodka),
            new Student("Сидоркин", "Кирилл", 2, new DateTime(2002, 2, 5), 'b', 4.0, beer),
            new Student("Александров", "Артём", 3, new DateTime(2006, 4, 3), 'c', 2.0, viski),
            new Student("Кузнецов", "Илья", 4, new DateTime(2006, 7, 4), 'c', 2.0, aperol),
            new Student("Пышкина", "Екатерина", 5, new DateTime(2005, 8, 9), 'd', 0.0, vino)
            };
            double totalVolume = 0.0;
            double totalAlcoholVolume = 0.0;
            foreach (var student in students)
            {
                totalVolume += student.Volume;
                double studentAlcoholVolume = student.Volume * (student.FavoriteDrink.Alcohol / 100);
                totalAlcoholVolume += studentAlcoholVolume;

                Console.WriteLine($"{student.LastName} {student.FirstName} выпил {student.Volume} литров ({studentAlcoholVolume:F2} литров алкоголя)");
            }

            Console.WriteLine($"nОбщий объем выпитого: {totalVolume:F2} литров");
            Console.WriteLine($"Общий объем алкоголя: {totalAlcoholVolume:F2} литров");

            foreach (var student in students)
            {
                double studentAlcoholVolume = student.Volume * (student.FavoriteDrink.Alcohol / 100);
                double alcoholPercentage = (studentAlcoholVolume / totalAlcoholVolume) * 100;
                double liquidPercentage = (student.Volume / totalVolume) * 100;

                Console.WriteLine($"{student.LastName} {student.FirstName}: {alcoholPercentage:F2}% от общего алкоголя, {liquidPercentage:F2}% от общего объема");
            }
        }
    }
}
