using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer__exception.Models
{
    
    
        class Hotel
        {
            public string Name { get; set; }
            private Room[] Rooms;
            public void AddRoom(Room NewRoom)
            {
                Array.Resize(ref Rooms, Rooms.Length + 1);
                Rooms[Rooms.Length - 1] = NewRoom;
            }
            public void MakeReservation(int? Id)
            {
                if (Id == null)
                {
                    throw new NullReferenceException();
                }
                else
                {
                    foreach (Room item in Rooms)
                    {
                        if (item.Id == Id)
                        {
                            if (item.isAviable == false)
                            {
                                throw new NotAvailableException();
                            }
                            else
                            {
                                item.isAviable = true;
                            }
                        }

                    }
                }
            }

            public Room this[int index]
            {
                get
                {
                    if (index < Rooms.Length)
                    {
                        return Rooms[index];
                    }
                    throw new Exception();
                }
                set
                {
                    if (index < Rooms.Length)
                    {
                        Rooms[index] = value;
                        return;

                    }
                    throw new Exception();
                }
            }
            public Hotel(string Name)
            {
                this.Name = Name;
                Rooms = new Room[0];
            }
        }
    }     


