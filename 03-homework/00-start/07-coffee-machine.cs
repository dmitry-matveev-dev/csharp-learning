//using System;

//namespace CoffeeMachineInk
//{
//    class CoffeeMachine
//    {
//        private int _water = 1000;
//        private int _beans = 100;
//        private List<string> _coffeeLog = new List<string>();

//        public static CoffeeMachine BuyMachine()
//        {
//            return new CoffeeMachine();
//        }
//        public string MakeCoffee(string size = "Medium", int waterNeeded = 50, int beansNeeded = 10)
//        {
//            if ((_water >= waterNeeded) && (_beans >= beansNeeded))
//            {
//                _water -= waterNeeded;
//                _beans -= beansNeeded;

//                _coffeeLog.Add($"{size} coffee");

//                return "Your coffee is ready!";
//            }
//            else
//            {
//                return "Error, dont have ingridients!";
//            }
//        }
//        public void Refil(int waterAmount, int beansAmount)
//        {
//            _water += waterAmount;
//            _beans += beansAmount;
//        }
//        public string[] CoffeeHistory()
//        {
//            string[] history = new string[_coffeeLog.Count];
//            for (int coffee = 0; coffee < _coffeeLog.Count; coffee++)
//            {
//                history[coffee] = _coffeeLog[coffee];
//            }
//            return history;
//        }
//    }
//    class Program
//    {
//        static void Main()
//        {
//            CoffeeMachine coffeeMachine = CoffeeMachine.BuyMachine();

//            Console.WriteLine(coffeeMachine.MakeCoffee());
//            Console.WriteLine(coffeeMachine.MakeCoffee());
//            Console.WriteLine(coffeeMachine.MakeCoffee("Large", 150, 25));

//            for (int i = 0; i < 20; i++)
//            {
//                Console.WriteLine(coffeeMachine.MakeCoffee());
//            }

//            Console.WriteLine("\nSee your coffee log:");
//            string[] history = coffeeMachine.CoffeeHistory();
//            foreach (string coffee in history)
//            {
//                Console.WriteLine($"{coffee}");
//            }

//            Console.WriteLine("\nYour coffee machine dont have igridients!");
//            Console.Write("Enter water in your machine: ");
//            int waterAmount = int.Parse(Console.ReadLine());
//            Console.Write("Enter beans in your machine: ");
//            int beansAmount = int.Parse(Console.ReadLine());
//            coffeeMachine.Refil(waterAmount, beansAmount);
//            Console.WriteLine("Ingridients are refil!");
//        }
//    }
//}