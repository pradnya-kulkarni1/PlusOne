namespace PlusOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! We are adding 1 to last digit of array here");
            Console.WriteLine("Enter the length of Array");
            String length = Console.ReadLine();
            int arrayLength = Convert.ToInt32(length);
            int[] numberArray = new int[arrayLength];
            Console.Write($"Enter total {arrayLength} values : ");
            for (int i = 0; i < arrayLength; i++)
            {
                String temp = Console.ReadLine();
                int t = Convert.ToInt32(temp);
                numberArray[i] = t;
            }

            int[] result = new int[numberArray.Length];
            result = PlusOne(numberArray);
            
        }
        public static int[] PlusOne(int[] digits)
        {
            if (digits[digits.Length - 1] == 9)
            {
                if (digits.Length == 1)
                {
                    int[] num = new int[2];
                    num[0] = 1;
                    num[1] = 0;
                    Console.WriteLine(num[0] + " "+num[1]);
                    return num;
                }
                else if (digits.Length > 1)
                {
                    digits[digits.Length - 2]++;
                    digits[digits.Length - 1] = 0;
                }
            }
            else
            {
                digits[digits.Length - 1]++;
            }

            for (int i = 0; i < digits.Length; i++)
            {
                Console.Write(digits[i] + " ");
            }
            return digits;
        }

    }
}
