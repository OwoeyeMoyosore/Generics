using System;
namespace Generic
{
    public class Program
    {
        static void Main()
        {
            Addition<int, double> sum = new Addition<int, double>();// or var sum = new Addition<int, double>();
            sum.Add(100, 89.4, 42);
            // Generic interface declaration
            var data = new Data<object>();
            data.Add(1);
            data.Add(true);
            data.Add('\n');

            

        }

    }

    public class Addition<T, R>
    {
        public void Add(T parameter1, R parameter2, int p3)
        {

        }
    }

    //Base class Generic
    public class Shape<P>
    {
        public P Radius { get; set; }

    }

    public class Circle<P> : Shape<P>
    {
        public Circle(P p1)
        {

        }
    }// end of base class generic

    //Generic Interface
    public interface IData<D>
    {
        void Add(D item);

    }
    public class Data<D> : IData<D>
    {
        private D[] _data;
        private int _count;

        public Data()
        {
            _data = new D[10];
        }
        public void Add(D item)
        {
            _data[_count++] = item;
        }
    }

    public class IShape
    {
        public class Square : IShape
        {
            private Square()
            {

            }
        }
        public class Circle
        {
            public Circle()
            {

            }
        }

        public class Shape<U, T> where U : new() where T : struct
        {

        }
        public class Triangle : Shape<Circle>
        {

        }
    }

    
}


