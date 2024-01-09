namespace Gazi.DizilerApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizi=Array

            //int[] numbers = new int [3];
            //numbers[0] = 10;
            //numbers[1] = 20;
            //numbers[2] = 30;
            ////index


            //int[] numbers = {50,20,30};

            //Array.Sort(numbers); //sıralama yapar 
            //Array.Reverse(numbers);//ters çevirir yani büyükten küçüğe

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            //Console.WriteLine("How many names do you want to sort?");
            //byte count = byte.Parse(Console.ReadLine());

            //string[] names = new string[count];

            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine($"Enter {i + 1}.name");
            //    names[i] = Console.ReadLine();
            //}
            //Array.Sort(names);
            //Console.WriteLine("Sorted names");
            //for (int i = 0; i < count; i++)
            //{
            //    Console.WriteLine($"{i + 1}-{names[i]}");
            //}


            //Console.WriteLine("How many numbers do you want to sort?");
            //byte count = byte.Parse(Console.ReadLine());

            //int[] numbers = new int[count];
            //Random rnd = new Random();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = rnd.Next(1000);
            //}
            //Array.Sort(numbers);

            //Console.WriteLine("Sorted numbers");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}



            Random rnd = new Random();
            Console.Write("Enter a number: ");
            int count = int.Parse(Console.ReadLine());
            int[] numbers = new int[count];
            int num = 0;
            for (int i = 0; i < count; i++)
            {

                numbers[i] = rnd.Next(0, 100);
                if (numbers[i] == numbers[i])
                {
                    while (num == i)
                    {
                        numbers[i] = rnd.Next(0, 100);
                        if (numbers[i] != numbers[i])
                        {
                            num++;
                            numbers[i] = numbers[i];
                            break;
                            

                        }
                        num++;
                    }

                }
            }

            Array.Sort(numbers);
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}-{numbers[i]}");
            }










            //{
            //    Random rnd = new Random();

            //    Console.WriteLine("Enter a number:");
            //    byte start = byte.Parse(Console.ReadLine());

            //    Console.WriteLine("How many numbers:");
            //    byte count = byte.Parse(Console.ReadLine());


            //    int[] numbers = new int[count];
            //    int num;
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        num = rnd.Next(start);
            //        if (i == 0)
            //        {
            //            numbers[i] = num;
            //        }
            //        for (int j = 0; j < i; j++)
            //        {
            //            if (numbers[j] == num)
            //            {
            //                i--;
            //                break;
            //            }
            //            else
            //            {
            //                numbers[i] = num;
            //            }
            //        }
            //    }
            //    Array.Sort(numbers);
            //    for (int i = 0; i < numbers.Length; i++)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }

            //}
        }
    }
}

//Referans:Heap bölgesindeki değerlerin adreslerini tutan yapılardır.