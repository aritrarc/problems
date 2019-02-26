using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace nsStacksQueues
{

    public class AnimalFarmDataStructure
    {
        private interface AnimalFarminterface
        {
            void Enqueue(char c);
            int DequeueAny();
            int DequeueDog();
            int DequeueCat();
            void display();

        }

        class AnimalFarm : AnimalFarminterface
        {
            LinkedList<int> dogs = new LinkedList<int>();
            LinkedList<int> cats = new LinkedList<int>();
            int index = 0;
            public void Enqueue(char c)
            {
                if (c == 'C')
                {
                    cats.AddLast(index + 1);
                    index++;
                }
                else if (c == 'D')
                {
                    dogs.AddLast(index + 1);
                    index++;
                }

            }

            public int DequeueCat()
            {
                if (cats.Count == 0)
                {
                    Console.WriteLine("No Cats left to dequeue");
                    return 0;
                }
                else
                {
                    int value = cats.First.Value;
                    cats.RemoveFirst();
                    return value;
                }
            }

            public int DequeueDog()
            {
                if (dogs.Count == 0)
                {
                    Console.WriteLine("No Dogs left to dequeue");
                    return 0;
                }
                else
                {
                    int value = dogs.First.Value;
                    dogs.RemoveFirst();
                    return value;
                }
            }

            public int DequeueAny()
            {
                if (cats.Count == 0 && dogs.Count == 0)
                {
                    Console.WriteLine("Animal farm is empty");
                    return 0;
                }
                else if (cats.Count > 0)
                {
                    if (dogs.Count > 0)
                    {
                        if (cats.First.Value <= dogs.First.Value)
                        {
                            int value = cats.First.Value;
                            cats.RemoveFirst();
                            return value;
                        }
                        else
                        {
                            int value = dogs.First.Value;
                            dogs.RemoveFirst();
                            return value;
                        }
                    }
                    else
                    {
                        int value = cats.First.Value;
                        cats.RemoveFirst();
                        return value;
                    }
                }
                else
                {
                    int value = dogs.First.Value;
                    dogs.RemoveFirst();
                    return value;
                }
            }

            public void display()
            {
                Console.WriteLine("Animal Farm Animals:");
                Console.WriteLine("###################");
                Console.Write("DOG: ");
                foreach (int i in dogs)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("");
                Console.Write("CATS: ");
                foreach (int i in cats)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("");
                Console.WriteLine("###################");
            }
        }

        public static void ImplementAnimalFarm()
        {
            AnimalFarm farm = new AnimalFarm();
            farm.Enqueue('D');
            farm.Enqueue('C');
            farm.Enqueue('C');
            farm.Enqueue('C');
            farm.Enqueue('C');
            farm.Enqueue('D');
            farm.Enqueue('D');
            farm.Enqueue('D');
            farm.Enqueue('D');
            farm.Enqueue('C');
            farm.Enqueue('D');

            farm.display();
            Console.WriteLine(farm.DequeueAny());
            Console.WriteLine(farm.DequeueDog());
            Console.WriteLine(farm.DequeueDog());
            Console.WriteLine(farm.DequeueCat());
            Console.WriteLine(farm.DequeueAny());
            Console.WriteLine(farm.DequeueDog());
            Console.WriteLine(farm.DequeueAny());

            farm.Enqueue('C');
            farm.Enqueue('C');
            farm.Enqueue('D');

            Console.WriteLine(farm.DequeueDog());
            Console.WriteLine(farm.DequeueCat());
            Console.WriteLine(farm.DequeueAny());
            Console.WriteLine(farm.DequeueDog());
            farm.display();
        }
    }
}