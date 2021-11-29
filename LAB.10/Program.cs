using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB._10
{
    class Program
    {
        //Перевод из градусов в радианы. Вводить значения нужно строго верно
        static void Main(string[] args)
        {


            Console.Write("Ввелите ед.измерения угла\n - градусы = ");
            int gradus = Convert.ToInt32(Console.ReadLine());
            Console.Write("- минуты = ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("- секунды = ");
            int sec = Convert.ToInt32(Console.ReadLine());
            Angle angle = new Angle(gradus, min, sec);
            angle.ToRadians();
            Console.ReadKey();
        }
        class Angle
        {
            private int gradus;
            private int min;
            private int sec;

            public int Gradus
            {
                get
                {
                    return gradus;
                }
                set
                {
                    if (value >= 0 && value <= 360)
                    {
                        gradus = value;
                    }

                    else
                    {
                        Console.WriteLine("Введите значение градусов от  0 до 360 градусов");
                    }
                }

            }
            public int Min
            {
                get
                {

                    return min;
                }
                set
                {
                    if (value >= 0 && value <= 60)
                    {
                        min = value;
                    }

                    else
                    {
                        Console.WriteLine("Введите значение угловых минут от 0 до 60 ");
                    }
                }
            }
            public int Sec
            {
                get
                {

                    return sec;
                }
                set
                {
                    if (value >= 0 && value <= 60)
                    {
                        sec = value;

                    }

                    else
                    {
                        Console.WriteLine("Введите значение угловых секунд от 0 до 60 ");
                    }

                }

            }
            public Angle(int gradus, int min, int sec)
            {
                Gradus = gradus;
                Min = min;
                Sec = sec;
            }

            public void ToRadians()
            {
                double radians = (Gradus + Min / 60 + Sec / 3600) * (Math.PI) / 180;
                if (radians >= 0 && radians < 6.2832)
                {
                    Console.WriteLine("Угол равен {0:f2} радиан", radians);
                }
                else
                {
                    Console.WriteLine("Введенные значения превышают допустимые");
                }

            }
        }
    }
}
