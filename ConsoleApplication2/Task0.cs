using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Task0
    {
        int[] arr = { 1, 2, 3, 4, 5, 6 };
        int[][] arr2 ={
                         new int[] {1,2,3},
                         new int[] {4,5,6},
                         new int[] {7,8,9}
                        };


        //task 0.1
        public  IEnumerator Reverse(int[] array)
        {
            for (int i = array.Length-1; i >=0 ; i--)
            {
                yield return array[i];
            }
        }

        //task 0.2
        public  IEnumerator<T> Reverse<T>(T[] array)
        {
            for (int i = array.Length - 1; i >= 0; i--)
            {
                yield return array[i];
            }
        }

        //task 0.3
        public  IEnumerator<T> ArrayOnCollumn<T>(T[][] array)
        {
            for (int i = 0; i <array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    yield return array[j][i];
                }
            }
        }
        //task 0.4
        public IEnumerator Distinct(int[] array)
        {
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (set.Add(array[i]))
                {
                    yield return array[i];
                }
            }
        }

        //task 0.5
        public IEnumerator<int> Except(int[] arr1, int[] arr2)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                if (!arr2.Contains(arr1[i]))
                {
                    yield return arr1[i];
                }
            }
        }
        
    }
    
}
