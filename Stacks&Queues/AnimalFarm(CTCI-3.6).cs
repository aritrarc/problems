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
            static LinkedListNode<int> catStart = null;
            static LinkedListNode<int> dogStart = null;
            LinkedListNode<int> catCurrent = catStart;
            LinkedListNode<int> dogCurrent = dogStart;
            int index = 0;
            public void Enqueue(char c)
            {
                //LinkedListNode<int> dataNode = new LinkedListNode<int>(index + 1);
                if (c == 'C')
                {
                    if (catCurrent != null)
                    {
                        cats.Append(index+1)
                        catCurrent = catCurrent.Next;
                    }
                    else
                    {
                        catCurrent = new LinkedListNode<int>(index + 1);
                        catStart = catCurrent;
                    }
                    index++;
                }
                else if (c == 'D')
                {
                    if (dogCurrent != null)
                    {
                        LinkedListNode<int> newnode = new LinkedListNode<int>(index + 1);
                        newnode  = dogCurrent.Next;
                        dogCurrent = dogCurrent.Next;
                    }
                    else
                    {
                        dogCurrent = new LinkedListNode<int>(index + 1);
                        dogStart = dogCurrent;
                    }
                    index++;
                }

            }

            public int DequeueCat()
            {
                if (catStart == null)
                {
                    Console.WriteLine("No Cats left to dequeue");
                    return 0;
                }
                else
                {
                    int value = catStart.Value;
                    catStart = catStart.Next;
                    return value;
                }
            }

            public int DequeueDog()
            {
                if (dogStart == null)
                {
                    Console.WriteLine("No Dogs left to dequeue");
                    return 0;
                }
                else
                {
                    int value = dogStart.Value;
                    dogStart = dogStart.Next;
                    return value;
                }
            }

            public int DequeueAny()
            {
                if (catStart == null && dogStart == null)
                {
                    Console.WriteLine("Animal farm is empty");
                    return 0;
                }
                else if (catStart != null)
                {
                    if (dogStart != null)
                    {
                        if (catStart.Value <= dogStart.Value)
                        {
                            int value = catStart.Value;
                            catStart = catStart.Next;
                            return value;
                        }
                        else
                        {
                            int value = dogStart.Value;
                            dogStart = dogStart.Next;
                            return value;
                        }
                    }
                    else
                    {
                        int value = catStart.Value;
                        catStart = catStart.Next;
                        return value;
                    }
                }
                else
                {
                    int value = dogStart.Value;
                    dogStart = dogStart.Next;
                    return value;
                }
            }

            public void display ()
            {
                Console.WriteLine("Animal Farm Animals:");
                Console.WriteLine("###################");
                LinkedListNode<int> counter = catStart;
                while(counter != null){
                    Console.Write(counter.Value + ",");
                    counter = counter.Next;
                }
                counter = dogStart;
                while(counter != null){
                    Console.Write(counter.Value + ",");
                    counter = counter.Next;
                }
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