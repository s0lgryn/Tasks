using System;

namespace F1
{
    class Employee
    {
        private string Birthdate { get; set; }   //Дата рождения
        private string Fullname { get; set; }    //ФИО
        private string Department { get; set; }  //Отдел
        private string Position { get; set; }    // Должность
        private int Salary { get; set; }         //Зарплата
        private int Expirience { get; set; }     //Стаж
        private string Status { get; set; }      //Состояние

        private readonly string[] StatusStorage = new string[5] //Массив доступных для изменения статусов
        { 
          "Работает",
          "В отпуске", 
          "В командировке",
          "На больничном",
          "Уволен" 
        }; 
       
        //Конструктор
        public Employee(string fullname, string department, int salary, int expirience, string pos, string birthdate)
        {
            this.Fullname = fullname;
            this.Department = department;
            this.Salary = salary;
            this.Expirience = expirience;
            this.Position = pos;
            this.Birthdate = birthdate;
            this.Status = StatusStorage[0];
        }
        public Employee()
        {
            this.Fullname = "0";
            this.Department = "0";
            this.Salary = 0;
            this.Expirience = 0;
            this.Position = "0";
            this.Birthdate = "0";
        }
        //Напечатать ФИО
        public void PrintName()
        {
            Console.WriteLine(Fullname);
        }
        //Напечатать полную информацию
        public void PrintInfo()
        {
            Console.WriteLine($"ФИО: {Fullname}\nДата рождения: {Birthdate}\nДолножсть: {Position}\nОтдел: {Department}\nЗарплата: {Salary}\nСтаж: {Expirience}\nСтатус: {Status}");
        }
        //Поменять должность
        public void SetNewPos()
        {
            Console.Write($"Введите должность для {Fullname}\nТекущая: {Position}\nНовая: ");
            this.Position = Console.ReadLine();
        }
        //Поменять отдел
        public void SetNewDep()
        {
            Console.Write($"Введите новый отдел для {Fullname}\nТекущий: {Department}\nНовый: "); ;
            this.Department = Console.ReadLine();
        }
        //Поменять стаж
        public void SetNewExp()
        {
            Console.Write($"Введите новый стаж для {Fullname}\nТекущий: {Expirience}\nНовый: ");
            this.Expirience = int.Parse(Console.ReadLine());
        }
        //Поменять зарплату
        public void SetNewSalary()
        {
            Console.Write($"Введите новую зарплату для {Fullname}\nТекущая: {Salary}\nНовая: ");
            this.Salary = int.Parse(Console.ReadLine());
        }
        //Поменять статус
        public void SetNewStatus()
        {
            Console.WriteLine("Доступные статусы:");
            Console.WriteLine($"1 {StatusStorage[0]}\n2 {StatusStorage[1]}\n3 {StatusStorage[2]}\n4 {StatusStorage[3]}\n5 {StatusStorage[4]}");
            Console.Write($"Выберите новый статус для {Fullname}\nТекущий: {Status}\nНовый: ");
            this.Status = StatusStorage[int.Parse(Console.ReadLine()) - 1];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Объявляем массив экземпляров класса и инициализируем его
            var Employers = new[] {
                new Employee("Михаил Евгеньевич Артеменко","IT",50000,5,"Специалист","14.11.2002"),
                new Employee("Александр Владимирович Семиренко","IT",90000,7,"Старший Специалист","14.05.1972"),
                new Employee("Николай Артемович Васнецов","IT",40000,5,"Младший Специалист","24.07.1992"),
                new Employee("Сергей Артурович Михайлюк","IT",1500000,5,"Lead","09.01.1982"),
                new Employee(),
            };
            //Бесконечный цикл для работы меню
            for (; ; )
            {
                Console.Clear();     //Очищает консоль после отработки функции
                int input;
                Console.WriteLine("Выберите функцию");
                Console.WriteLine("1 Получить информацию");
                Console.WriteLine("2 Изменить должность");
                Console.WriteLine("3 Измеить отдел");
                Console.WriteLine("4 Изменить стаж");
                Console.WriteLine("5 Изменить зарплату");
                Console.WriteLine("6 Изменить статус");
                Console.WriteLine("0 Выход");
                //Двух уровневое меню реализованное c помощью вложенных switch
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        int c1input;
                        Console.WriteLine("Выберите количество \n1 Все \n2 Один \n3 Несколько");
                        c1input = Convert.ToInt32(Console.ReadLine());
                        switch (c1input)
                        {
                            case 1:
                                for (int i = 0; i < Employers.Length; i++)
                                {
                                    Employers[i].PrintInfo();
                                    Console.WriteLine("___________________________");
                                }
                                Console.ReadKey();  //Костыль который не позволяет моментально очистить вывод
                                break;
                            case 2:
                                int c12input;
                                //Вывод имен сотрудников для выбора
                                for (int i = 0; i < Employers.Length; i++)
                                {
                                    Console.Write(i + 1 + " ");
                                    Employers[i].PrintName();
                                }
                                Console.WriteLine("Выберите сотрудника");
                                c12input = Convert.ToInt32(Console.ReadLine());
                                Employers[c12input - 1].PrintInfo();
                                Console.WriteLine("___________________________");
                                Console.ReadKey();  //Костыль который не позволяет моментально очистить вывод
                                break;
                            case 3:
                                int c13input;
                                Console.WriteLine("Выберите сотрудника");
                                Console.WriteLine("0 для возврата в предыдущее меню\n-------");
                                //Вывод имен сотрудников для выбора
                                for (int i = 0; i < Employers.Length; i++) 
                                {
                                    Console.Write(i + 1 + " ");
                                    Employers[i].PrintName();
                                }
                                Console.WriteLine("___________________________");
                                bool flag = true;
                                while (flag) //пока не введен 0, можно вводить индексы сотрудников
                                {
                                    c13input = Convert.ToInt32(Console.ReadLine());
                                    if (c13input != 0)
                                    {
                                        Employers[c13input - 1].PrintInfo();
                                        Console.WriteLine("___________________________");
                                    }
                                    else
                                        flag = false;
                                }
                                break;
                        }
                        break;
                    case 2:
                        int c2input;
                        Console.WriteLine("Выберите количество \n1 Все \n2 Один \n3 Несколько");
                        c2input = Convert.ToInt32(Console.ReadLine());
                        switch (c2input)
                        {
                            case 1:
                                //Вывод имен сотрудников для выбора
                                for (int i = 0; i < Employers.Length; i++)
                                {
                                    Employers[i].SetNewPos();
                                    Console.WriteLine("\n___________________________");
                                }
                                break;
                            case 2:
                                int c22input;
                                //Вывод имен сотрудников для выбора
                                for (int i = 0; i < Employers.Length; i++)
                                {
                                    Console.Write(i + 1 + " ");
                                    Employers[i].PrintName();
                                }
                                Console.WriteLine("Выберите сотрудника");
                                c22input = Convert.ToInt32(Console.ReadLine());
                                Employers[c22input - 1].SetNewPos();
                                Console.WriteLine("___________________________");
                                break;
                            case 3:
                                int c23input;

                                Console.WriteLine("Выберите сотрудника");
                                Console.WriteLine("0 для возврата в предыдущее меню\n-------");
                                //Вывод имен сотрудников для выбора
                                for (int i = 0; i < Employers.Length; i++)
                                {
                                    Console.Write(i + 1 + " ");
                                    Employers[i].PrintName();
                                }
                                bool flag = true;
                                while (flag) //пока не введен 0, можно вводить индексы сотрудников
                                {

                                    c23input = Convert.ToInt32(Console.ReadLine());
                                    if (c23input != 0)
                                    {
                                        Employers[c23input - 1].SetNewPos();
                                        Console.WriteLine("___________________________");
                                    }
                                    else
                                        flag = false;
                                }
                                break;
                        }
                        break;
                    case 3:
                        int c3input;
                        Console.WriteLine("Выберите количество \n1 Все \n2 Один \n3 Несколько");
                        c3input = Convert.ToInt32(Console.ReadLine());
                        switch (c3input)
                        {
                            case 1:
                                for (int i = 0; i < Employers.Length; i++)
                                {
                                    Employers[i].SetNewDep();
                                    Console.WriteLine("\n___________________________");
                                }
                                break;
                            case 2:
                                int c32input;
                                for (int i = 0; i < Employers.Length; i++)
                                {
                                    Console.Write(i + 1 + " ");
                                    Employers[i].PrintName();
                                }
                                Console.Write("Выберите сотрудника: ");
                                c32input = Convert.ToInt32(Console.ReadLine());
                                Employers[c32input - 1].SetNewDep();
                                Console.WriteLine("___________________________");
                                break;
                            case 3:
                                int c33input;

                                Console.WriteLine("Выберите сотрудника");
                                Console.WriteLine("0 для возврата в предыдущее меню\n-------");
                                for (int i = 0; i < Employers.Length; i++) //выводит ФИО сотрудника
                                {
                                    Console.Write(i + 1 + " ");
                                    Employers[i].PrintName();
                                }
                                bool flag = true;
                                while (flag) //пока не введен 0, можно вводить индексы сотрудников
                                {

                                    c33input = Convert.ToInt32(Console.ReadLine());
                                    if (c33input != 0)
                                    {
                                        Employers[c33input - 1].SetNewDep();
                                        Console.WriteLine("___________________________");
                                    }
                                    else
                                        flag = false;
                                }
                                break;
                        }
                        break;
                    case 4:
                        int c4input;
                        Console.WriteLine("Выберите количество \n1 Все \n2 Один \n3 Несколько");
                        c4input = Convert.ToInt32(Console.ReadLine());
                        switch (c4input)
                        {
                            case 1:
                                for (int i = 0; i < Employers.Length; i++)
                                {
                                    Employers[i].SetNewExp();
                                    Console.WriteLine("\n___________________________");
                                }
                                break;
                            case 2:
                                int c42input;
                                for (int i = 0; i < Employers.Length; i++)
                                {
                                    Console.Write(i + 1 + " ");
                                    Employers[i].PrintName();
                                }
                                Console.WriteLine("Выберите сотрудника");
                                c42input = Convert.ToInt32(Console.ReadLine());
                                Employers[c42input - 1].SetNewExp();
                                Console.WriteLine("___________________________");
                                break;
                            case 3:
                                int c43input;

                                Console.WriteLine("Выберите сотрудника");
                                Console.WriteLine("0 для возврата в предыдущее меню\n-------");
                                for (int i = 0; i < Employers.Length; i++) //выводит ФИО сотрудника
                                {
                                    Console.Write(i + 1 + " ");
                                    Employers[i].PrintName();
                                }
                                bool flag = true;
                                while (flag) //пока не введен 0, можно вводить индексы сотрудников
                                {

                                    c43input = Convert.ToInt32(Console.ReadLine());
                                    if (c43input != 0)
                                    {
                                        Employers[c43input - 1].SetNewExp();
                                        Console.WriteLine("___________________________");
                                    }
                                    else
                                        flag = false;
                                }
                                break;
                        }
                        break;
                    case 5:
                        int c5input;
                        Console.WriteLine("Выберите количество \n1 Все \n2 Один \n3 Несколько");
                        c5input = Convert.ToInt32(Console.ReadLine());
                        switch (c5input)
                        {
                            case 1:
                                for (int i = 0; i < Employers.Length; i++)
                                {
                                    Employers[i].SetNewSalary();
                                    Console.WriteLine("\n___________________________");
                                }
                                break;
                            case 2:
                                int c52input;
                                for (int i = 0; i < Employers.Length; i++)
                                {
                                    Console.Write(i + 1 + " ");
                                    Employers[i].PrintName();
                                }
                                Console.WriteLine("Выберите сотрудника");
                                c52input = Convert.ToInt32(Console.ReadLine());
                                Employers[c52input - 1].SetNewSalary();
                                Console.WriteLine("___________________________");
                                break;
                            case 3:
                                int c53input;
                               
                                Console.WriteLine("Выберите сотрудника");
                                Console.WriteLine("0 для возврата в предыдущее меню\n-------");
                                for (int i = 0; i < Employers.Length; i++) //выводит ФИО сотрудника
                                {
                                    Console.Write(i + 1 + " ");
                                    Employers[i].PrintName();
                                }
                                bool flag = true;
                                while (flag) //пока не введен 0, можно вводить индексы сотрудников
                                {

                                    c53input = Convert.ToInt32(Console.ReadLine());
                                    if (c53input != 0)
                                    {
                                        Employers[c53input - 1].SetNewSalary();
                                        Console.WriteLine("___________________________");
                                    }
                                    else
                                        flag = false;
                                }
                                break;
                        }
                        break;
                    case 6:
                        int c6input;
                        Console.WriteLine("Выберите количество \n1 Все \n2 Один \n3 Несколько");
                        c6input = Convert.ToInt32(Console.ReadLine());
                        switch (c6input)
                        {
                            case 1:
                                for (int i = 0; i < Employers.Length; i++)
                                {
                                    Employers[i].SetNewStatus();
                                    Console.WriteLine("\n___________________________\n");
                                }
                                break;
                            case 2:
                                int c62input;
                                for (int i = 0; i < Employers.Length; i++)
                                {
                                    Console.Write(i + 1 + " ");
                                    Employers[i].PrintName();
                                }
                                Console.WriteLine("Выберите сотрудника");
                                c62input = Convert.ToInt32(Console.ReadLine());
                                Employers[c62input - 1].SetNewStatus();
                                Console.WriteLine("___________________________");
                                break;
                            case 3:
                                int c63input;
                                
                                Console.WriteLine("Выберите сотрудника");
                                Console.WriteLine("0 для возврата в предыдущее меню\n-------");
                                for (int i = 0; i < Employers.Length; i++) //выводит ФИО сотрудника
                                {
                                    Console.Write(i + 1 + " ");
                                    Employers[i].PrintName();
                                }
                                bool flag = true;
                                while (flag) //пока не введен 0, можно вводить индексы сотрудников
                                {

                                    c63input = Convert.ToInt32(Console.ReadLine());
                                    if (c63input != 0)
                                    {
                                        Employers[c63input - 1].SetNewStatus();
                                        Console.WriteLine("___________________________");
                                    }
                                    else
                                        flag = false;
                                }
                                break;
                        }
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
