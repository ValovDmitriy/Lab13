using System;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Building dom = new Building("Невский проспект", 30, 50, 10);
            //dom.Print();
            MultiBuilding multiDom = new MultiBuilding("Вознесенский проспект", 15, 15, 9, 3);
            multiDom.MultiPrint();
        }
    }
    class Building
    {
        public string buildingAddress { get; set; }
        public int buildingLenght { get; set; }
        public int buildingWidth { get; set; }
        public int buildingHeight { get; set; }

        public Building(string buildingAddress, int buildingLenght, int buildingWidth, int buildingHeight)
        {
            this.buildingAddress = buildingAddress;
            this.buildingLenght = buildingLenght;
            this.buildingWidth = buildingWidth;
            this.buildingHeight = buildingHeight;
        }
        public void Print()
        {
            Console.WriteLine("Адрес здания - {0}", buildingAddress);
            Console.WriteLine("Длина здания - {0} м", buildingLenght);
            Console.WriteLine("Ширина здания - {0} м", buildingWidth);
            Console.WriteLine("Высота здания - {0} м", buildingHeight);
        }
    }
    sealed class MultiBuilding : Building
    {
        public int buildingFloor { get; set; }

        public MultiBuilding(string buildingAddress, int buildingLenght, int buildingWidth, int buildingHeight, int buildingFloor)
            :base(buildingAddress, buildingLenght, buildingWidth, buildingHeight)
        {
            this.buildingFloor = buildingFloor;
        }
        public void MultiPrint()
        {
            base.Print();
            Console.WriteLine("Количество этажей здания - {0} м", buildingFloor);
        }
    }
}
