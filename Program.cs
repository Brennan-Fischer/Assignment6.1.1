namespace Assignment6._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleLinkedList list = new SingleLinkedList();
            int menueSelection = 0;


            while (menueSelection != 3)
            {
                Console.WriteLine("Input requested function per corresponding number");
                Console.WriteLine("1.Add House");
                Console.WriteLine("2.Search for House");
                Console.WriteLine("3.Exit");
                menueSelection= Convert.ToInt32(Console.ReadLine());

                if (menueSelection == 1) 
                {
                    list.AddHouse(new Houses());

                }
                if (menueSelection == 2)
                {
                    list.SearchHouse();

                }
            }

            static void searchHouses(int number)
            {

            }
        }




        static void addHouse()
        {
            Console.WriteLine("Type House Numer");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type Street name");
            string street = Console.ReadLine();

            Console.WriteLine("Type House type such as Colonial or Ranch");
            string type = Console.ReadLine();


        }
    }
}
