using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FraudulentActivityNotification
{
    public class FraudulentActivityNotification
    {
        public static void GetNotification(int[] expenditure, int d)
        {
            int notifications = 0;
            var previousExpenditures = new List<int>();

            for (int i = 0; i < d; i++) //Add initial expenditures
            {
                previousExpenditures.Add(expenditure[i]);
            }
            previousExpenditures.Sort();

            for (int i = d; i < expenditure.Length; i++)
            {
                if (expenditure[i] >= 2 * Median(previousExpenditures))
                {
                    notifications++;
                }

                //Remove first item
                int removeIndex = previousExpenditures.BinarySearch(expenditure[i - d]);
                if (removeIndex >= 0)
                {
                    previousExpenditures.RemoveAt(removeIndex);
                }
                //previousExpenditures.Add(expenditure[i]);

                //Add new item
                int insertIndex = previousExpenditures.BinarySearch(expenditure[i]);
                if (insertIndex < 0) insertIndex = ~insertIndex;
                previousExpenditures.Insert(insertIndex, expenditure[i]);
            }

            Console.WriteLine(notifications.ToString());
        }

        public static double Median(List<int> ar)
        {
            int n = ar.Count;
            double median = (ar[n / 2] + ar[(n - 1) / 2]) / 2.0;
            return median;
        }

        #region Generic SortedList
        internal class SortedList<T>
        {
            private readonly List<T> src;
            public SortedList() => this.src = new List<T>();

            public int Count => src.Count;

            public void Add(T item)
            {
                int insertIndex = src.BinarySearch(item);
                if (insertIndex < 0) insertIndex = ~insertIndex;
                src.Insert(insertIndex, item);
            }

            public T this[int index] => src[index];


        }
        #endregion

    }
}