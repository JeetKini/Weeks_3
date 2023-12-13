using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleApp1;


namespace Review_Practice
{
    delegate  void call();
   public  class Abss {
        //public  sealed override void poly()
        //{
        //    Console.WriteLine("Ployye");
        //    call c = test;
        //    c.Invoke();
        //    c = test1;
        //    c.Invoke();
        //}
        public void test1()
        {
            Console.WriteLine("I am test 1");
        }
        public void test() {
            Console.WriteLine("I am test");
        }

    }
    public  class AB
    {
        int a;
        public AB()
        {
           
        }
        public AB(int a)
        {

         this.a = a;

        }
        public AB(AB ab)
        {
            a=ab.a;
        }

        public  int id;
     public   string name;
        public virtual void poly() {
            Console.WriteLine("Ployye");
        }
        
        public AB(int id,string name)
        {
            this.id = id;
            this.name = name;
        }

    }
    interface I
    {
       int a { get; set; }
        void test();
    }
    internal class Program
    {
        private static string ss = "jeet";
        static  void Main(string[] args)
        {
         //   int a = 5;
            
            //Convert.ToBoolean(a);
            //Console.WriteLine(Convert.ToBoolean(a));
            //Console.WriteLine((int)Hello.a);
            //I cl=new A();
            //A.main();
            //Hashtable hashtable=new Hashtable();
            //hashtable.Add(1,"Jeet");
            //hashtable.Add(2,"Jeet");
            //hashtable.Add(3,"Jeet");
            //hashtable.Add(4,"Jeet");
            //Dictionary<int,string> d=new Dictionary<int,string>();
            //d.Add(1, "Jeet");
            //d.Add(2, "Jeet");
            //d.Add(3, "Jeet");
            //d.Add(4, "Jeet");

            //foreach (var item in d) {
            //    Console.WriteLine(item.Key);
            //}

            //cl.test();
            //cl.a = 54;
            //Console.WriteLine(cl.a);
            //Directory.CreateDirectory(@"C:\\Users\\hp\\Desktop\\log");
            //Console.WriteLine("Created");
          //var get=  Path.GetFileName(@"C:\\Users\\hp\\Desktop\\log");
          //  Console.WriteLine(get);
          //  B b = new B();
          //  b.X = 5;
          //  Console.WriteLine(ss);
            //var ab=new AB();
            //Console.WriteLine(ab.name);
            //Console.WriteLine(ab.id);
            //AB aB = new AB(1,"Jeet");
            //Console.WriteLine(aB.name);
            //Console.WriteLine(aB.id);
            //var z = new zzz();
            var vv = new Abss();
            // Abss.poly();
            // vv.poly();
            //call cc = vv.test;
            //cc.Invoke();
            //cc=vv.test1;
            //cc.Invoke();

            //Func<int,int> name = n => n * n;
            //name(5);
            List<int> list = new List<int>() {1,2,3,4,5,1,3 };
            list.Sort();
            foreach (var v in list)
            {
                Console.WriteLine(v);
            }
            //var highnum = from n in list where n > 2 select (n);
            //foreach (int n in highnum)
            //{
            //    Console.WriteLine(n);
            //}
            //string s = "sds";
            //s.GetHashCode();
            //met();
            //Console.WriteLine("hey");
            //Console.ReadKey();
            //SortedList sl = new SortedList() ;
            //sl.Add(1,"j");
        }
        public async static void met()
        {
          await   Task.Run(longtask);
           
        }
        public static void longtask()
        {
            Console.WriteLine(1);
            Thread.Sleep(1000);
            Console.WriteLine(1);
            Thread.Sleep(1000);
            Console.WriteLine(1);
            Thread.Sleep(1000);
            Console.WriteLine(1);
            Thread.Sleep(1000);
        }
        public static void poly()
        {
            Console.WriteLine("ploy");
        }
        public static void poly(int a)
        {
            Console.WriteLine("ploy");
            
        }

        public static void main()
        {
            Console.WriteLine("I am A class");
        }
        enum Hello { 
        a=1, b=2, c=3
        }
    }
}
