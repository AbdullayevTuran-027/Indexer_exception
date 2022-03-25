using System;

namespace Indexer__exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Otel adi:");
            Hotel hotel = new Hotel(Console.ReadLine());
            bool test = true;
            do
            {
                Console.WriteLine("1.AddRoom");
                Console.WriteLine("2.MakeReservation");
                Console.WriteLine("3.Quite");
                int button = Convert.ToInt32(Console.ReadLine());
                switch (button)
                {
                    case 1:
                        Console.Write("Name:");
                        string name = Console.ReadLine();
                        Console.Write("Price:");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Pc:");
                        int pc = Convert.ToInt32(Console.ReadLine());
                        Room NewRoom = new Room(name, price, pc);
                        hotel.AddRoom(NewRoom);
                        return;
                    case 2:
                        Console.WriteLine("Room No?:");
                        try
                        {
                            hotel.MakeReservation(Convert.ToInt32(Console.ReadLine()));

                        }
                        catch (NotAvailableException ex)
                        {

                            Console.WriteLine(ex.Message);
                        }
                        catch (NullReferenceException ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        return;
                    case 3:
                        test = false;
                        return;
                    default:
                        break;
                }

            } while (test);

        }
    }
}
