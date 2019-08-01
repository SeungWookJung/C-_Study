using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Generic
{
    /*class WrapperInt
    {
        int Value;
        public WrapperInt() { Value = 0; }
        public WrapperInt(int avalue) { Value = avalue; }
        public int data
        {
            get { return Value; }
            set { Value = value; }
        }
        public void OutValue()
        {
            Console.WriteLine(Value);
        }
    }

    class WrapperString
    {
        string Value;
        public WrapperString() { Value = null; }
        public WrapperString(string avalue) { Value = avalue; }
        public string data
        {
            get { return Value; }
            set { Value = value; }
        }
        public void OutValue()
        {
            Console.WriteLine(Value);
        }
    }*/

    class Wrapper<T>
    {
        T Value;
        public Wrapper() { Value = default(T); }
        public Wrapper(T avalue) { Value = avalue; }
        public T Data
        {
            get { return Value; }
            set { Value = value; }
        }
        public void OutValue()
        {
            Console.WriteLine(Value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            /* WrapperInt gi = new WrapperInt(1234);
             gi.OutValue();
             WrapperString gs = new WrapperString("문자열");
             gs.OutValue();*/
            Wrapper<int> gi = new Wrapper<int>(1234);
            gi.OutValue();
            Wrapper<string> gs = new Wrapper<string>("문자열");
            gs.OutValue();
        }
    }
}
