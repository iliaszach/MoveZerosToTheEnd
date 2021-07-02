using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoveZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = MoveZeroes(new int[] { 0, 1, 2, 5, 2, 4, 0, 8, 0 });
        }
        public static int[] MoveZeroes(int[] arr)
        {  
            var prin = 0;
            var timi = 0;
            for (int i = 0; i < arr.Length; i++) //i=3
            {
                if (arr.Contains(0))
                {
                    while (!(arr[i] is 0))
                    {
                        i++;
                    }
                    while (arr[i] == 0 && i + 1 != arr.Length)
                    {
                        if (!(arr[i + 1] == 0))
                        {
                            timi = arr[i + 1];
                            prin = Array.IndexOf(arr, 0);
                            arr[prin] = timi;
                            arr[i + 1] = 0;
                        }
                        else
                        {
                            i++;
                        }

                    }
                }

            }
            return arr;
        }
}
