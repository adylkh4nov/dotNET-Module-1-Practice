using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotNET_Module_2_Practice
{
    internal class Class1
    {
        public void example1()
        {
            Console.WriteLine(5 + "\n" + 10 + "\n" + 21);
        }
        public void example2()
        {
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine(a / 100 + " метра");
        }
        public void example3()
        {
            int days = 234;
            Console.WriteLine(234 / 7);
        }
        public void example4()
        {
            int a = new Random().Next(10, 100);
            int desatki = a / 10;
            int edinitsy = a % 10;
            int sum = (desatki + edinitsy);
            int proizv = (desatki * edinitsy);
            Console.WriteLine("Число: " + a);
            Console.WriteLine("Десятки: " + desatki);
            Console.WriteLine("Единицы: " + edinitsy);
            Console.WriteLine("Сумма: " + sum);
            Console.WriteLine("Произведение " + proizv);
        }
        public void example5()
        {
            bool a = true;
            bool b = false;
            bool c = false;
            Console.WriteLine(a || b);
            Console.WriteLine(a && b);
            Console.WriteLine(b || c);
        }
        public void example6()
        {
            int radius;
            Console.WriteLine("Введите радиус:");
            while (!int.TryParse(Console.ReadLine(), out radius))
            {
                Console.WriteLine("Нужно ввести тип значения int");
            }
            int storona;
            Console.WriteLine("Введите сторону квадрата:");
            while (!int.TryParse(Console.ReadLine(), out storona))
            {
                Console.WriteLine("Нужно ввести тип значения int");
            }
            if (Math.Pow(storona, 2) > Math.PI * Math.Pow(radius, 2))
            {
                Console.WriteLine("Площадь квадрата:" + Math.Pow(storona, 2));
                Console.WriteLine("Площадь круга:" + Math.PI * Math.Pow(radius, 2));
                Console.WriteLine("Площадь квадрата больше");
            }
            else if (Math.Pow(storona, 2) < Math.PI * Math.Pow(radius, 2))
            {
                Console.WriteLine("Площадь квадрата:" + Math.Pow(storona, 2));
                Console.WriteLine("Площадь круга:" + Math.PI * Math.Pow(radius, 2));
                Console.WriteLine("Площадь круга больше");
            }
            else Console.WriteLine("они равны");
            Console.ReadLine();
        }
        public void example7()
        {
            double v1, v2, m1, m2;
            Console.WriteLine("v1: ");
            while (!double.TryParse(Console.ReadLine(), out v1))
            {
                Console.WriteLine("Не правильный ввод");
            }

            Console.WriteLine("v2: ");
            while (!double.TryParse(Console.ReadLine(), out v2))
            {
                Console.WriteLine("Не правильный ввод");
            }
            Console.WriteLine("m1: ");
            while (!double.TryParse(Console.ReadLine(), out m1))
            {
                Console.WriteLine("Не правильный ввод");
            }
            Console.WriteLine("m2: ");
            while (!double.TryParse(Console.ReadLine(), out m2))
            {
                Console.WriteLine("Не правильный ввод");
            }

            Console.WriteLine("Материал 1: " + v1 * m1 + "; Материал 2: " + v2 * m2);
            if (v1 * m1 > v2 * m2) Console.WriteLine("Материал 1 плотнее");
            else if (v1 * m1 == v2 * m2) Console.WriteLine("Они идентичны");
            else Console.WriteLine("Материал 2 плотнее");
        }
        public void example8()
        {
            Console.WriteLine("r1: ");
            int r1 = int.Parse(Console.ReadLine());
            Console.WriteLine("r2: ");
            int r2 = int.Parse(Console.ReadLine());
            Console.WriteLine("u1: ");
            int u1 = int.Parse(Console.ReadLine());
            Console.WriteLine("u2: ");
            int u2 = int.Parse(Console.ReadLine());
            int i1 = u1 / r1;
            int i2 = u2 / r2;
            if (i1 > i2) Console.WriteLine(i1 + " > " + i2);
            else if (i2 > i1) Console.WriteLine(i2 + " > " + i1);
            else Console.WriteLine(i1 + " = " + i2);
        }
        public void example9()
        {
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("вверхняя граница b: ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 10; i <= b; i++)
            {
                Console.WriteLine(i * i);
            }
            Console.WriteLine("input a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("input b: ");
            b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void example10()
        {
            Console.WriteLine("input x: ");
            double x = double.Parse(Console.ReadLine());
            double y = 7 * x * x - 3 * x + 6;
            Console.WriteLine("y=7x^2 - 3x + 6 = " + y);
        }
        public void example11()
        {
            Console.WriteLine("input a: ");
            int a = int.Parse((Console.ReadLine()));
            int x = 12 * a * a + 7 * a - 16;
            Console.WriteLine("x= 12a^2+7a-16 = " + x);
        }
        public void example12()
        {
            Console.WriteLine("введите сторону квадрата: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Периметр: " + a * 4);

        }
        public void example13(ref int a, ref int b)
        {
            //Напишите функцию swap(int* a, int* b),
            //которая изменяет значения параметров a и b так,
            //что новое значение a рав- но старому значению b и наоборот.
            a += b;
            b = a - b;
            a -= b;
        }
        public bool example14(int n)
        {
            //Напишите функцию bool even(int n),
            //определяет четность числа n и возвращает true
            //для четного числа и false для нечетного числа.
            if (n == 0) return false;
            if (n % 2 == 0)
            {
                return true;
            }
            else return false;
        }
        public int example15(int m1, int m2 = 0, int m3 = 0)
        {
            //Напишите функцию int f(int m1, int m2, int m3)
            //с аргументами по умолчанию, которая находит наименьшее
            //из од- ного, двух или трех целых чисел
            int min = m1;

            if (m2 < min)
                min = m2;

            if (m3 < min)
                min = m3;

            return min;
        }
        public string example16()
        {
            Random rand = new Random();
            int score = rand.Next(2, 6);
            switch (score)
            {
                case 2:
                    return "Неуд";
                case 3:
                    return "Удовл";
                case 4:
                    return "Хорошо";
                case 5:
                    return "Отлично";
                default:
                    return "Недопустимая оценка";
            }
        }
        public int example17(int n, int m)
        {
            int sum = 0;
            for (int i = n; i <= m; i++)
            {
                if (i % 2 != 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
        public List<int> example18(int n, int m)
        {
            List<int> arr = new List<int>();
            for (int i = n; i <= m; i++)
            {
                if (i % 2 != 0)
                {
                    arr.Add(i);
                }
            }
            return arr;
        }
        public int[] example19(ref int[] arr)
        {
            int length = arr.Length;
            int[] arr2 = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr2[i] = arr[length - 1 - i];
            }
            arr = arr2;
            return arr;
        }
        public int[] example20(ref int[] arr, ref int[] arr2)
        {
            int[] arrayList =new int[arr.Length + arr2.Length];
            for (int i = 0;i < arr.Length; i++)
            {
                arrayList[i] = arr[i];
            }
            for (int i = arr.Length; i < arrayList.Length; i++)
            {
                arrayList[i] = arr2[Math.Abs(arr.Length - i)];
            }
            return arrayList;
        }

    }
}
