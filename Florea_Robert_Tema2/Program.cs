using static Program;
using System;
using Florea_Robert_Tema2;

public class Program
{
    static void Main(string[] args)
    {
        SmallApartment smallApartment = new SmallApartment(66);
        Person person = new Person();
        person.Name = "Robert-Alexandru";
        smallApartment.door = new House.Door("Black");
        person.House = smallApartment;
        person.ShowData();
    }

    // better to extract the classes in their own files
    public class House
    {
        public int Area { get; set; }

        public House(int area)
        {
            if (area > 50)
            {
                area = 200; // strange condition
            }
            this.Area = area;
        }

        public void ShowData()
        {
            Console.WriteLine($"I am a house, my area is {Area} m2");
        }

        public class Door
        {
            public string Color { get; set; }
            public Door(string color)
            {
                if (String.IsNullOrEmpty(color))
                    color = "brown";
                Color = color;
            }

            public void ShowData()
            {
                Console.WriteLine($"I am a door, my color is {Color}");

            }
        }
        public Door door;
        public Door GetDoor()
        {
            return door;
        }


    }

    public class SmallApartment : House
    {
        public SmallApartment(int area) : base(area)
        {
            try
            {
                if (area > 50)
                {
                    throw new Exception(); // I believe it is enough to throw the exception. No need for the try catch block.
                }

                this.Area = area;
            }
            catch
            {
                Console.WriteLine("This is not a small apartment.A small apartment is only 50 m2.");
            }
        }
    }

    public class Person : IPerson
    {
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        private House _house;
        public House House
        {
            get => _house;
            set => _house = value;
        }

        public void ShowData()
        {
            Console.WriteLine($"I am {Name} and I own a house with a door.");
            Console.WriteLine("The house says:");
            House.ShowData();
            Console.WriteLine("The door says:");
            House.GetDoor().ShowData();

        }
    }
}
