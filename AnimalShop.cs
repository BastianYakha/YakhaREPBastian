using System;

namespace YakhaTraining
{
    class AnimalShopClass()
    {
        public List<Animal> animalList = new List<Animal>();
        public int MadeMoney = 0;

        public void SellAnimal(int ListID)
        {
            MadeMoney += animalList[ListID].GetPrice();
            animalList.RemoveAt(ListID);
        }

        public int getMoney()
        {
            return MadeMoney;
        }

    }
}
