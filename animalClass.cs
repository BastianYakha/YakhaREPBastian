using System;

namespace YakhaTraining
{

    abstract class Animal
    {
        public string sound = "";
        public int weight = 0;
        public int sellPrice;
        public void defSound(string snd)
        {
            this.sound = snd;
            //Console.WriteLine(this.sound);
            this.DoTrick();
        }      
        public void defWeight(int weightAnimal)
        {
            this.weight = weightAnimal;
        }
        public void defPrice(int price)
        {
            this.sellPrice = price;
        }
        public abstract void DoTrick();
        public int GetPrice()
        {
            return sellPrice;
        }
    }

    class Dog : Animal
    {
        public string mySound = "woof";
        public int myWeight = 15;
        public int Sellprice = 80;
        public Dog()
        {
            this.defSound(mySound);
            this.defWeight(myWeight);
            this.defPrice(Sellprice);
        }

        public enum BodyParts
        {
            Paws,
            Tail,
            Ears,
            Nose
        }
        public override void DoTrick()
        {
            //Console.WriteLine("I can daaance");
        }
    }

    class Cat : Animal
    {
        public string mySound = "meeooww";
        public int myWeight = 5;
        public int Sellprice = 50;
        public Cat()
        {
            this.defSound(mySound);
            this.defWeight(myWeight);
            this.defPrice(Sellprice);
        }

        public enum BodyParts
        {
            Teeth,
            Tail,
            Fur,
            Nose
        }
        public override void DoTrick()
        {
            //Console.WriteLine("I can break your favorite Mug!");
        }
    }

    class Bird : Animal
    {
        public string mySound = "I do my sound...PIEPS";
        public int myWeight = 5;
        public int Sellprice = 15;
        public Bird()
        {
            this.defSound(mySound);
            this.defWeight(myWeight);
            this.defPrice(Sellprice);
        }
        public enum BodyParts
        {
            Wing,
            Break,
            Feather,
            Claw
        }
        public override void DoTrick()
        {
            //Console.WriteLine("Im the coolest");
        }
    }


}
