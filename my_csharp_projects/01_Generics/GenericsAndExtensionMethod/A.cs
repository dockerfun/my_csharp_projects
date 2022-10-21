using System;
using System.Reflection;
using CustomExtension;

namespace AttributeAndFields 
{
    public abstract class A<T> //base class
    {
        public string GetData()
        {
            System.Console.WriteLine($"Type: {typeof(T)}");
            return "ok";
        }
    } 

    public class B<T>  //helper class
    {
        private A<T> _value;
        public B(A<T> value)
        {
            _value = value;
        }

        string Print()
        {
           return _value.GetData();
        } 
    }

    //[Helper(typeof(A<>))]
    public class C<T> : A<T> //inherited class
    {
        //B<T> field;
        public C()
        {
           //field = new B<T>(this);
        }

        public void Method1()
        {
            string str = this.GetSql<T>();
        }
    } 

}