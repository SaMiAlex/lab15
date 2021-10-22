using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arif = new ArithProgression();
            GeomProgression geom = new GeomProgression();
            arif.SetStart(); //метод устанавливает начальные значения
            arif.reset(); //при подключенни метода выполняется сброс к начальному значению
            arif.print(); //метод выводит последний член прогрессии, в соответствии с логикой класса
            geom.SetStart();
            geom.reset();
            geom.print();
            Console.ReadKey();

            //возможно я не верно понял задачу, поэтому реализовал так, стараясь сохранить логику задачи)
        }

        interface ISeries
        {
            void SetStart();
            int GetNext { get; }
            void reset();
            void print();
        }

        class ArithProgression : ISeries
        {
            int x;
            int d;
            int n;

            public void SetStart()
            {
                Console.WriteLine("Введите начальное значение ряда");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значение разности прогрессии");
                d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите количество шагов");
                n = Convert.ToInt32(Console.ReadLine());
            }
            public int GetNext
            {
                get
                {
                    for (int i = 0; i < n; i++)
                    {
                        x += d;
                    }
                    return x;
                }
            }
            public void reset()
            {
                n = 0;
            }
            public void print()
            {
                Console.WriteLine("Последний член прогрессии равен {0}", GetNext);
            }
        }
        class GeomProgression : ISeries
        {
            int x;
            int d;
            int n;

            public void SetStart()
            {
                Console.WriteLine("Введите начальное значение ряда");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значение знаменателя прогрессии");
                d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите количество шагов");
                n = Convert.ToInt32(Console.ReadLine());
            }
            public int GetNext
            {
                get
                {
                    for (int i = 0; i < n; i++)
                    {
                        x *= d;
                    }
                    return x;
                }
            }
            public void reset()
            {
                n = 0;
            }
            public void print()
            {
                Console.WriteLine("Последний член прогрессии равен {0}", GetNext);
            }
        }

    }
}
