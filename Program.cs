using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using YakhaTraining;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace YakhaTraining
{
    class Day1
    {
        public static void Main(string[] args)
        {
            //List<Cars> Garage = new List<Cars>();

            /*
            Console.WriteLine("Hello World");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name);
            Console.Write(" eeee");

            string txt = "We are the so-called \"Vikings\" from the north.";
            */

            /*
            var calc = new Calculator();
            var sum_v1 = calc.Add(1, 2);
            var sum_v2 = calc.Add(x: 1, y: 2);

            Calculator.Multiply(2, 4);
            */


            /*
            Booleans testBool = new Booleans();
            testBool.TestBool();
            */

            /*
            Numbers hehe = new Numbers();
            int num = hehe.Testing();
            Console.WriteLine(num);

            Numbers db = new Numbers();
            double d1 = 0.35;
            double d2 = 0.43;

            double result;
            result = db.Eh(d1, d2);
            Console.WriteLine(result);Top Speed: 
            */
            /*
            int i;
            int CarCount = Convert.ToInt32(Console.ReadLine());

            for(i=0;i < CarCount; i++)
            {
                Cars TestCar = new Cars();
                TestCar.GenInfo();
                bool Caralready = false;

                foreach(Cars carG in Garage)
                {

                    if (TestCar.GetCarMaker() == carG.GetCarMaker())
                    {
                        Caralready = true;
                    }
                }

                if(Caralready == false)
                {
                    Garage.Add(TestCar);

                }
                if(Caralready == true) 
                { Console.WriteLine("car already owned");
                  Console.WriteLine("____________________________");
                }
            }
        
            foreach(Cars OC in Garage)
            {
                OC.printInfo();
            }
            */

            //Animal puppy = new Dog();
            //Animal kitten = new Cat();
            AnimalShopClass AnimalShop = new AnimalShopClass();
            //Animal budgie = new Bird(0,0);
            //AnimalShop.animalList.Add(budgie);

            Random rnd = new Random();
            int rndNum = rnd.Next(0, 100);

            for(int I = rndNum; I > 0; I--)
            {
                int animalSel = rnd.Next(0, 3);
                switch(animalSel)
                {
                    case 0:
                        Animal budgie = new Bird();
                        AnimalShop.animalList.Add(budgie);
                        break;
                    case 1:
                        Animal doggy = new Dog();
                        AnimalShop.animalList.Add(doggy);
                        break;
                    case 2:
                        Animal kitty = new Cat();
                        AnimalShop.animalList.Add(kitty);
                        break;
                }
            }
            foreach (Animal anim in AnimalShop.animalList) 
            {
                Console.WriteLine(anim);
            }
            int SellAmount = rnd.Next(0, AnimalShop.animalList.Count());
            for(int J = SellAmount; J>0; J--)
            {
                int sellID = rnd.Next(0, AnimalShop.animalList.Count());
                AnimalShop.SellAnimal(sellID);
                Console.WriteLine("REMOVED at " + sellID);
            }
            Console.WriteLine("Money made: " +  AnimalShop.getMoney());
            Console.WriteLine("Animals left: " + AnimalShop.animalList.Count());
        }
    }

    class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public static int Multiply(int x, int y)
        {
            return (x * y);
        }
    }

    class Booleans
    {
        public bool bool1 = true;
        public bool bool2 = false;

        public void TestBool()
        {
            if (bool1 == true && bool2 == false)
            {
                Console.WriteLine("eee");
            }
        }

    }

    class Strings
    {
        public void StringStuff()
        {
            string fruit = "Apple";

            //SAME STRING, DIFFErENT WAYS
            //string String1 = "c:\\test.txt";
            //string String2 = @"c:\\test.txt";

            string Sent = "Hello there";
            Sent.Substring(5);

            string name = "bastian";
            string surname = "baumann";

            string fullName = name + " " + surname;
            Console.WriteLine(fullName);

        }
    }

    class Numbers
    {
        int i = 27;
        double j = 56.7;

        int BIG = 1_000_000;

        public int Testing()
        {
            return this.i;
        }

        public double Eh(double db1, double db2)
        {
            return (db1 + db2);
        }
    }

    class Cars
    {
        Random rnd = new Random();

        public int PS;
        public double TopSpeed;
        public double weight;
        public string maker = "a";

        List<string> MakerList = new List<string>(){"Audi","VW","BMW","Mercedes","Subaru","Lexus","Nissan"};

        public string GetCarMaker()
        {
            return this.maker;
        }

        public double GetTopSpeed()
        {
            return this.TopSpeed;
        }

        public void GenInfo()
        {
            int rndPS = rnd.Next(0, 500);
            this.PS = rndPS;

            double cubeRoot = Math.Ceiling(Math.Cbrt(this.PS));
            double TS = cubeRoot * 20.00;
            this.TopSpeed = TS;

            int makerINDEX = rnd.Next(0, this.MakerList.Count);
            this.maker = this.MakerList[makerINDEX];
        }

        public void printInfo()
        {
            Console.WriteLine("PS: \t\t" + this.PS);
            Console.WriteLine("Top Speed: \t" + this.TopSpeed);
            Console.WriteLine("Maker: \t\t" + this.maker);
            Console.WriteLine("____________________________");
        }
    }

}