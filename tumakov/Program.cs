namespace tumakov
{ //Виды банковского счёта
    enum BankAccountType
    {
        Текущий,
        Сберегательный
    }
    //информация о банковском счёте
    struct BankAccount
    {

        /// <summary>
        /// Тип счёта
        /// </summary> 
        public int Number;
        /// <summary>
        /// Тип счёта
        /// </summary>
        public string Type;
        /// <summary>
        /// Баланс
        /// </summary>
        public double Balance;
    }
    //Включает вузы
    enum VUZ
    {
        КГУ,
        КАИ,
        КХТИ
    }
    struct Worker
    {
        /// <summary>
        /// Имя работника
        /// </summary>
        public string Name;
        /// <summary>
        /// ВУЗ, в котором работает
        /// </summary>
        public VUZ Vuz;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создать перечислимый тип данных отображающий виды банковского счета .Создать переменную типа перечисления,
            //присвоить ей значение и вывести
            Console.WriteLine("Задание 3.1");
            BankAccountType mytype = BankAccountType.Сберегательный;
            Console.WriteLine("Тип банковского счёта" + mytype);

            //Создать структуру данных, которая хранит информацию о банковском
            //счете – его номер, тип и баланс. Создать переменную такого типа, заполнить структуру
            //значениями и напечатать.
            Console.WriteLine("Задание 3.2");
            BankAccount mybank = new BankAccount();
            mybank.Number = 164759305;
            mybank.Type = "текущий";
            mybank.Balance = 999999999;
            Console.WriteLine($"Номер счёта:{mybank.Number}, тип счёта:{mybank.Type}, баланс счёта:{mybank.Balance}");

            //Создать перечислимый тип ВУЗ{КГУ, КАИ, КХТИ}. Создать
            //структуру работник с двумя полями: имя, ВУЗ.Заполнить структуру данными и
            //распечатать.
            Console.WriteLine("Домашнее задание 3.1");
            Worker worker = new Worker();
            worker.Name = "Анна";
            worker.Vuz = VUZ.КГУ;
            Console.WriteLine($"Имя работника:{worker.Name}, ВУЗ:{worker.Vuz}");
        }
    }
}
