using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanei15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression(44);
            GeomProgression geomProgression = new GeomProgression(4);
            arithProgression.setStart(12);
            Console.WriteLine(" Следующее значение равно " + arithProgression.getNext());
            geomProgression.setStart(12);
            Console.WriteLine(" Следующее значение равно " + geomProgression.getNext());
            Console.Read();
        }
        interface ISeries
        {
            int d { get; set; }
            void setStart(int x);
            int getNext();
            void reset();
        }
        class ArithProgression : ISeries
        {
            int xNext;
            int xStart;
            int D;
            public int d
            {
                get
                {
                    return d;
                }
                set
                {
                    d = value;
                }
            }
            public ArithProgression(int d)
            {
                D = d;
            }
            public int getNext()
            {
                xNext = xNext + D;
                return xNext;
            }

            public void reset()
            {
                xNext = xStart;
            }

            public void setStart(int x)
            {
                xStart = x;
                xNext = xStart;
                Console.WriteLine($"Начальное значение = {x}");
            }
        }
        class GeomProgression : ISeries
        {
            int xNext;
            int xStart;
            int D;
            public int d
            {
                get
                {
                    return d;
                }

                set
                {
                    if (d != 0)
                    {
                        d = value;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка знаменатель прогрессии не должен быть равен нулю");
                    }
                }
            }
            public GeomProgression(int d)
            {
                D = d;
            }
            public int getNext()
            {
                xNext = xNext * D;
                return xNext;
            }

            public void reset()
            {
                xNext = xStart;
            }

            public void setStart(int x)
            {
                if (x != 0)
                {
                    xStart = x;
                    xNext = xStart;
                    Console.WriteLine($"Начальное значение = {x}");
                }
                else
                {
                    Console.WriteLine("Ошибка член геометрической прогрессии не должен быть равен нулю");
                }
            }
        }

    }
}
