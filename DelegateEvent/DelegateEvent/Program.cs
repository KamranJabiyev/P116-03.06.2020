using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    class Program
    {
        //public delegate bool Check(int n);
        //public delegate void Write(string word);
        //public delegate void WriteInt(int n);
        //public delegate void WriteDouble(double n);
        public delegate void Write<T>(T n);
        static void Main(string[] args)
        {
            #region Delegate
            //int[] arr = { 10, 15, 20, 25, 30 };
            //Console.WriteLine(Sum(arr, IsEven));
            //Console.WriteLine(Sum(arr, IsOdd));
            //Console.WriteLine(Sum(arr, IsElder));
            #region Anonim method,Lambda expression,Generic type delegate
            //Console.WriteLine(Sum(arr,delegate(int n) { return n % 10 == 0; }));
            //lambda
            //Console.WriteLine(Sum(arr, n=>n % 10 == 0));

            //Get instance from delegate
            //Write<string> write = new Write<string>(GetWord);
            //write += GetLenght;
            //write += delegate (string w) { Console.WriteLine($"Word ToUpper:{w.ToUpper()}"); };
            //write += w => Console.WriteLine($"Word ToLower:{w.ToLower()}");
            //write -= GetLenght;
            //write -= delegate (string w) { Console.WriteLine($"Word ToUpper:{w.ToUpper()}"); };
            //write("Hello");
            //Write<int> write1 = GetInt;
            //write1.Invoke(5);
            #endregion

            #region Action,Func,Predicate
            //Action<int> action = GetInt;
            //action(15);
            //Action<int, int> action1 = SumNumber;
            //action1 += delegate (int n, int m) { Console.WriteLine(n - m); };
            //action1 += (n, m) => Console.WriteLine(m/n);
            //action1(5, 20);
            //Func<int, bool> func = IsEven;
            //Console.WriteLine(func(6));
            //Func<int, int, int> func = SumNumber;
            //Console.WriteLine(func(4,7));
            //Predicate<int> predicate = n => n > 18;
            //Predicate<int> predicate = delegate(int n) { return n > 18; };
            //Predicate<int> predicate = IsElder;
            //Console.WriteLine(predicate(14));
            #endregion
            #endregion

            #region Event
            Student s1 = new Student("Orxan", 100);
            s1.Notify += delegate (bool x)
              {
                  if (x)
                  {
                      Console.WriteLine("Tebrikler oglunuz ugurla bitirdi");
                  }
                  else
                  {
                      Console.WriteLine("Teessuf kursu bitire bilmedi");
                  }
              };
            Student s2 = new Student("Javid", 65);
            s2.Notify += delegate (bool x)
            {
                if (x)
                {
                    Console.WriteLine("Tebrikler oglunuz ugurla bitirdi,Ela,Javidden yoxdu");
                }
                else
                {
                    Console.WriteLine("Javid ozu bu shad xeberi verecek Size");
                }
            };

            s1.MakeNotification();
            #endregion
        }

        #region Delegate

        static int SumNumber(int n,int m)
        {
            return n+m;
        }
        static void GetInt(int x)
        {
            Console.WriteLine(x);
        }
        static void GetLenght(string w)
        {
            Console.WriteLine($"Lenght:{w.Length}");
        }
        static void GetWord(string w)
        {
            Console.WriteLine(w);
        }
        public static int Sum(int[] arr,Func<int,bool> method)
        {
            int result = 0;
            foreach (int item in arr)
            {
                if (method(item))
                    result += item;
            }
            return result;
        }

        //static bool Test(int n,int m) { return n > m; }
        static bool IsEven(int n)
        {
            return n % 2 == 0;
        }

        static bool IsOdd(int n)
        {
            return n % 2 != 0;
        }

        static bool IsElder(int n)
        {
            return n > 20;
        }

       
        #endregion
    }


}
