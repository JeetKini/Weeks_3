using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Practice
{
    public class Emp
    {
        public int id { get; set; }

    }
    public  interface I1 { }
    public class SubClass   
    {
        public  int id { get; set; }
        private string name="Jeet";
        public string GetName()
        {
            return name;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public static int i = 34;
       public string s = "Hi";
        public int Add( int[]num)
        {
            int count = 0;
            for (int i = 0; i < num.Length; i++)
            {
                count++;
            }
            return count;
        }
        public int Count(List<int> list)
        {

            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                count++;
            }
            return count;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //var v=new SubClass();
            //int[] a = new int[5];
            //a[0] = 2;
            //a[1] = 3;
            //a[2]= 4;
            //a[3]= 5;
            //Console.WriteLine(v.Add(a));
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            //Console.WriteLine(v.Count(list));
            //Console.WriteLine(v.id);
            //Console.WriteLine(v.GetName());
            // v.SetName("Kini");
            //Console.WriteLine(v.GetName());
            //DateTime now = DateTime.Now;
            //Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm:ss")); // Outputs: 2022-12-31 23:59:59
            //int f = 10;
            //test(out f);
            //method();
            //Console.WriteLine("Hello ");

            //Console.ReadLine();
            //Name nn = new Name(lTest);
            //nn();
            //Func<int, int> add = n => n * n;
            //Console.WriteLine(add(2));
            //Name store = lTest;
            //store.Invoke();
            IQueryable<int> lt = list.AsQueryable();
            foreach (var i in lt)
            {
                Console.WriteLine(i);
            }

            Dictionary<int ,string>dt= new Dictionary<int ,string>();
            dt.Add(1, "A");
            dt.Add(2, "B");
            dt.Add(3, "C");
            dt.Add(4, "D");
            dt.Add(5, "E");
            Emp eee = new Emp();

            List<Emp> ll=new List<Emp>() { new Emp()};
          //  IQueryable<int> q = dt.Where()
          
           
            





        }

        public static void test(out int a) {
            a = 9;
        a=a+1;
            Console.WriteLine(a);
        }
        delegate void Name();
        public async static void method() {
            await Task.Run(new Action(lTest));
        }
        public static void lTest() {

            Console.WriteLine(1);
            Thread.Sleep(1000);
            Console.WriteLine(2);
            Thread.Sleep(1000);
            Console.WriteLine(3);
            Thread.Sleep(1000);
            Console.WriteLine(4);
        }        
    }
}
