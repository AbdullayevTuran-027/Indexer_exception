using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer__exception.Models
{
    

        public class Room
        {
            private static int _id = 1;
            public int Id { get; }
            public string Name { get; set; }
            public double Price { get; set; }
            public int PersonCapacity { get; set; }
            public bool isAviable = true;

            private string ShowInfo()
            {
                return $"Id:{Id} Name:{Name} PersonCapacity{PersonCapacity} IsAviable?:{isAviable}";
            }
            public override string ToString()
            {

                return ShowInfo();
            }
            public Room(string Name, double Price, int PersonCapacity)
            {
                this.Name = Name;
                this.Price = Price;
                this.PersonCapacity = PersonCapacity;
                Id = _id++;
            }

        }
    }

