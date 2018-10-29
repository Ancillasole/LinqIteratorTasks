using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class task2
    {
        List<int> source = new List<int>
        {
            1,2,3,4,5
        };
        //task2.1
        static int MaxAgr(IEnumerable<int> source)
        {
            return source.Aggregate((acc, elem) => elem > acc ? elem : acc);
        }
        static int MinAgr(IEnumerable<int> source)
        {
            return source.Aggregate((acc, elem) => elem < acc ? elem : acc);
        }
        static int CountAgr(IEnumerable<int> source)
        {
            return source.Aggregate(0,(acc, elem) =>++acc);
        }
        static double AverageAgr(IEnumerable<double> source)
        {
            return source.Aggregate(0.0,(acc, elem) => acc+=(double)elem/source.Count());
        }

        //task 2.3

        public static IEnumerable<int> AllPossibele(int[] arr)
        {
            HashSet<int> temp = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                    {
                        if (!temp.Contains(Int32.Parse($"{arr[i]}{arr[j]}")))
                        {
                            temp.Add((Int32.Parse($"{arr[i]}{arr[j]}")));
                            yield return Int32.Parse($"{arr[i]}{arr[j]}");
                        }
                    }
                }
            }
        }
        public static IEnumerable<int> AllPossibeleNotEqual(int[] arr)
        {
            HashSet<int> temp = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j && arr[i] != arr[j])
                    {
                        if (!temp.Contains(Int32.Parse($"{arr[i]}{arr[j]}")))
                        {
                            temp.Add((Int32.Parse($"{arr[i]}{arr[j]}")));
                            yield return Int32.Parse($"{arr[i]}{arr[j]}");
                        }
                    }
                }
            }
        }
        public static IEnumerable<int> AllPossibeleNotDublicate(int[] arr)
        {
            HashSet<int> temp = new HashSet<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if (i != j)
                    {
                        if (!temp.Contains(Int32.Parse($"{arr[i]}{arr[j]}")) && !temp.Contains(Int32.Parse($"{arr[j]}{arr[]}")))
                        {
                            temp.Add((Int32.Parse($"{arr[i]}{arr[j]}")));
                            yield return Int32.Parse($"{arr[i]}{arr[j]}");
                        }
                    }
                }
            }
        }
    }
}
