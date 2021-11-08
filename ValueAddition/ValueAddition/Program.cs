using System;

namespace ValueAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[1];
            
            AddValue(arr);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        static void AddValue(int[] arr)
        {
            try
            {
                Console.Write("Ededi daxil edin: ");
                int num = Convert.ToInt32(Console.ReadLine());
                arr[0] = num;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }


}
