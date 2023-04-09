using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK_1
{
    class Program
    {
        static void Main(string[] args)
        {
            add();
        }
        static void task1()
        {
            Console.Write("Hello world!!!!");
            Console.Write("Hello world!!!!");
            Console.ReadKey();
        }
        static void task2()
        {
            Console.WriteLine("Hello world!!!!");
            Console.WriteLine("Hello world!!!!");
            Console.ReadKey();
        }
        static void task3()
        {
            int length;
            int area;
            Console.WriteLine("ENTER LENGTH!!!!");
            length=int.Parse(Console.ReadLine());
            area = length * length;
            Console.WriteLine("AREA IS!!!!");
            Console.WriteLine(area);
            Console.ReadKey();
        }
        static void task4()
        {
            int marks;
            Console.WriteLine("ENTER MARKKS!!!!");
            marks = int.Parse(Console.ReadLine());
            if(marks>50)
            {
                Console.WriteLine("YOU ARE PASSED!!!!");
            }
            else
            {
                Console.WriteLine("YOU ARE FAILED!!!!");               
            }
            Console.ReadKey();
        }
        static void task5()
        {
            for(int i =0; i <5; i++)
            {
                Console.WriteLine("WELCOME JACK!!!!");              
            }
            Console.ReadKey();
        }
        static void task6()
        {
            int num=0;
            int sum = 0;
            while(num!=-1)
            {
                Console.WriteLine("ENTER NUMBER!!!!");
                num = int.Parse(Console.ReadLine());
                if(num!=-1)
                {
                    sum = sum + num;
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        static void task7()
        {
            int num = 0;
            int sum = 0;
            do
            {
                Console.WriteLine("ENTER NUMBER!!!!");
                num = int.Parse(Console.ReadLine());
                if (num != -1)
                {
                    sum = sum + num;
                }
            }
            while (num != -1);
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        static void task8()
        {
            int[] numbers = new int[3];
            for(int i =0; i<3; i++)
            {
                Console.WriteLine("ENTER NUMBER!!!!{0}",i);
                numbers[i] = int.Parse (Console.ReadLine());
            }
            int largest=-1;
            for (int i = 0; i < 3; i++)
            {
               if(numbers[i]>largest)
                {
                    largest = numbers[i];
                }
            }
            Console.WriteLine("LAEGEST NUMBER IS!!!!");
            Console.WriteLine(largest);
            Console.ReadKey();
        }
        static void task9()
        {
            float age;
            float toyprice;
            float machprice;
            Console.WriteLine("ENTER AGE!!!!");
            age=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter toy price!!!!");
            toyprice = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter wasing machine price!!!!");
            machprice = float.Parse(Console.ReadLine());
            float ans;
            float q;
            float p;
            q = age / 2;
            p = age - q;
            int c = 1;
            int num = 1;
            int sum = 0;
            while (c <= q)
            {

                sum = sum + (num * 10);
                c = c + 1;
                num = num + 1;
            }
            float total;
            total = p * toyprice;
            ans = total + sum;
            ans = ans - q;
            if (ans > machprice)
            {
                Console.WriteLine("YES!!!!You can buy");
            }
            else
            {
                ans = machprice - ans;
                Console.WriteLine("NO!!!!You cannot buy");
                Console.WriteLine("MISSING!!!!", ans , "$");
            }
            Console.ReadKey();
        }
        static void add()
        {
            int n1;
            int n2;
            int sum = 0;
            Console.WriteLine("ENTER FIRST NUMBER!!!!");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER SECOND NUMBER!!!!");
            n2 = int.Parse(Console.ReadLine());
            sum = n1 + n2;
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}