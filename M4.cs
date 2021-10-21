using System;

namespace M4
{
    delegate void Message();

    interface IAccount<T>
    {
        double CurrentSum { get; } //Текущая сумма на счету
        void Deposit(double sum); //Положить деньги на счет
        void Withdraw(double sum); //Снять деньги со счета
        void Transfer(double sum, T account); //Перевод на другой счет
        void OpenAccount(); //Открытие счета
        void CloseAccount(); // Закрытие счета

    }
    class CheckingAccount : IAccount<SavingsAccount>
    {
        double _sum;
        public void OpenAccount()
        {
            _sum = 0;
            Console.WriteLine("Расчетный счет успешно создан");
        }
        public void CloseAccount()
        {
            _sum = 0;
            Console.WriteLine("Расчетный счет успешно закрыт");
        }
        public double CurrentSum { get { return _sum; } }
        public void Deposit(double sum) { _sum += sum; }
        public void Withdraw(double sum)
        {
            if (_sum >= sum)
            {
                _sum -= sum;
            }
        }
        public void Transfer(double sum, SavingsAccount account)
        {
            Withdraw(sum);
            account.Deposit(sum);
        }
    }
    class SavingsAccount : IAccount<CheckingAccount>
    {
        double _sum;
        double percent = 3.4;
        public void OpenAccount()
        {
            _sum = 0;
            Console.WriteLine("Накопительный счет успешно создан");
        }
        public void CloseAccount()
        {
            _sum = 0;
            Console.WriteLine("Накопительный счет успешно закрыт");
        }
        public double CurrentSum { get { return _sum; } }
        public void Percent()
        {
           _sum *= percent;
        }
        public void Deposit(double sum) { _sum += sum; }
        public void Withdraw(double sum)
        {
            if (_sum >= sum)
            {
                _sum -= sum;
            }
            else
            {
                Console.WriteLine($"Недостаточно средств на счету, у вас {sum}");
            }
        }
        public void Transfer(double sum, CheckingAccount account)
        {
            Withdraw(sum);
            account.Deposit(sum);
        }
    }
    class FrozenAccount : IAccount<CheckingAccount>
    {
        double _sum;
        public void OpenAccount()
        {
            Console.WriteLine("Нельзя создавать замороженный счет");
        }
        public void CloseAccount()
        {
            _sum = -1;
        }
        public double CurrentSum { get { return _sum; } }
        public void Deposit(double sum) { Console.WriteLine("Вы не можете пополнять замороженный счет"); }
        public void Withdraw(double sum) { Console.WriteLine("Вы не можете снимать с замороженного счета"); }
        public void Transfer(double sum, CheckingAccount account) { Console.WriteLine("Вы не можете переводить с замороженного счета"); }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FrozenAccount fTom = new FrozenAccount();
            fTom.OpenAccount();
            fTom.Deposit(4230.32);
            CheckingAccount cClient = new CheckingAccount();
            SavingsAccount sClient = new SavingsAccount();
            cClient.OpenAccount();
            sClient.OpenAccount();
            cClient.Deposit(4504.22);
            cClient.Transfer(800.300, sClient);
            Console.WriteLine(sClient.CurrentSum);
        }
    }
}
