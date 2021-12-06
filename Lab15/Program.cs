using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression();
            Console.WriteLine("Начать с числа 7");
            arithProgression.setStart(7);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("следующее число = " + arithProgression.getNext());
            }
            Console.WriteLine("Сбросить");
            arithProgression.reset();
            Console.WriteLine("Начать с числа 10");
            arithProgression.setStart(10);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("следующее число = " + arithProgression.getNext());
            }
            GeomProgression geomProgression = new GeomProgression();
            Console.WriteLine("Начать с числа 1");
            geomProgression.setStart(1);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("следующее число = " + geomProgression.getNext());
            }
            Console.WriteLine("Сбросить");
            geomProgression.reset();
            Console.ReadKey();
        }
    }
    interface ISeries
    {
        void setStart(int x);
        int getNext();
        void reset();
    }
    class ArithProgression : ISeries
    {

        int difference = 5;
        int start;
        int val;
        public ArithProgression()
        {
            start = 0;
            val = 0;
        }
        public void setStart(int x)
        {
            start = x;
            val = start;
        }

        public int getNext()
        {
            val += difference;
            return val;
        }

        public void reset()
        {
            val = start;
        }
    }
    class GeomProgression : ISeries
    {

        int difference = 5;
        int start;
        int val;
        public GeomProgression()
        {
            start = 0;
            val = 0;
        }
        public void setStart(int x)
        {
            start = x;
            val = start;
        }

        public int getNext()
        {
            val *= difference;
            return val;
        }

        public void reset()
        {
            val = start;
        }
    }
}
