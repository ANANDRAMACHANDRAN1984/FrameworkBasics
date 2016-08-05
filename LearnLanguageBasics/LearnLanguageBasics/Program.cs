using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.XPath;

namespace LearnLanguageBasics
{
    class Program
    {
        delegate  int myDelegate(int y,int z);
        static void Main(string[] args)
        {
            try
            {



                //foreach (var item in args)
                //{
                //    Console.WriteLine(item);
                //}
                Queue<int> obj = new Queue<int>();
                obj.queue(1);
                obj.queue(2);
                obj.queue(3);
                obj.queue(4);
                int result=obj.dequeue();
                Console.WriteLine(result);
                //EdgeVervecs edgeverve = new EdgeVervecs();

                //edgeverve.ImplementQUsingTwoStacks();
                //Int64 a = Int64.Parse(Console.ReadLine());
                // edgeverve.PrimeFactors(a);
                //foreach (var item in result)
                //{
                //    Console.Write(" {0}",item);

                //}
                Console.ReadLine();
                // int result= edgeverve.MultiplesOf3or5(20);
                //int i = 0;
                //while (i < 10)
                //{
                //    bool result = edgeverve.IsPrimeNumber(Convert.ToInt32(Console.ReadLine()));
                //    Console.WriteLine("Result is :" + result);
                //    Console.ReadLine();
                //    i++;
                //}

                //Animal O = new Dog();
                //O.Walk();

                //int i = 0;
                //for (; i < 10; i++)
                //{
                //    for (; ; i++)
                //    {
                //        Console.WriteLine("Print i value {0}", i);
                //    }
                //}

                ////Test.CreateObjectTest();
                //Console.ReadLine();
            }
           
            catch (DivideByZeroException ex)
            {
            }
            catch (Exception ex)
            {
            }
            //  XmlParser();
            //var t1 = new myDelegate(Add);
            //var t2 = new myDelegate(Multiply);
            //int resultAdd=t1(5, 4);
            //int resultMultiply = t2(5, 4);
            //var test=resultAdd + resultMultiply;
        }
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        private static void XmlParser()
        {
       
            XDocument doc = XDocument.Load(@"D:\anand\Learn\LearnLanguageBasics\LearnLanguageBasics\PlanDetails.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(@"D:\anand\Learn\LearnLanguageBasics\LearnLanguageBasics\PlanDetails.xml");

            var result=doc.Descendants("Plan").Select(e => new {
                PlanId = e.Attribute("id"),
                Employer = e.Elements("Employer").Select(i => new { EmployerId= i.Attribute("id").Value, Amount= i.Element("Amount") })
                }
                );
            
            DataTable dtMyPlan = new DataTable();
         
            dtMyPlan.Columns.Add("PlanId");
            dtMyPlan.Columns.Add("EmployerId");
            dtMyPlan.Columns.Add("Amount");
            int row = 0;
           
            foreach (var item in result)
            {
             dtMyPlan.NewRow();
               
                foreach (var Employer in item.Employer)
                {
                    dtMyPlan.Rows.Add();
                    dtMyPlan.Rows[row]["Amount"] = Employer.Amount;
                    dtMyPlan.Rows[row]["PlanId"] = item.PlanId.Value;
                    dtMyPlan.Rows[row]["EmployerId"] = Employer.EmployerId;

                    row += 1;
                   
                }
               
                //Debug.WriteLine(item.Amount);
                //Debug.WriteLine(item.PlanId);
            }
           
    
        }
        private void AnotherWay()
        {
            MemoryStream objMS = new MemoryStream();
            DataTable oDT = new DataTable();//Your DataTable which you want to convert
            oDT.WriteXml(objMS);
            objMS.Position = 0;
            XPathDocument result = new XPathDocument(objMS);
        }
    }
    public static class Test
    {
        internal static void CreateObjectTest()
        {
            Animal objAnimal = new Dog();
            objAnimal.Swim();
        }
    }
    abstract class Animal
    {
        internal virtual void Swim()
        {
            Console.WriteLine("Virtual Called");
        }
        internal abstract void Walk();
    }
     class Dog : Animal
    {
        internal override void Walk()
        {

            Console.WriteLine("Dog Walk Called");
        }
        //internal override void Swim()
        //{
        //    base.Swim();
        //    Debug.WriteLine("Dog Swim Called");
        //}



    }
    class Cat : Animal
    {
        internal override void Walk()
        {
            Debug.WriteLine("Cats Walk Called");
        }

    }

}
