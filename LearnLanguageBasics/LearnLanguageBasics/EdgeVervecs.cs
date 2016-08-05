using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnLanguageBasics
{
    public class Queue<T>
    {
        Stack<T> firstStack = new Stack<T>();
        Stack<T> secondStack = new Stack<T>();
        public void queue(T item)
        {
            firstStack.Push(item);
        }
        public T dequeue()
        {
            if (secondStack.Count ==0)
            {
                while (firstStack.Count!=0)
                {
                    secondStack.Push(firstStack.Pop());
                }
            }
            return secondStack.Pop();
        }
        
    }
    class EdgeVervecs
    {
        
        public int MultiplesOf3or5(int inputNo)
        {
            int i = 1;
            int result=0;
            while (i < inputNo)
            {
                if ((i % 3 == 0) || ((i % 5 == 0)))
                {
                    result += i;
                }
                i++;
                
            }
            return result;
        }
        public void PrimeFactors(Int64 inputNo)
        {
            
            try
            {
                Int64 i = 2;
                List<Int64> result = new List<Int64>();
                
                    for (; inputNo > 1; i++)
                    {
                        if (inputNo % i == 0)
                        {
                            int x = 0;
                            while (inputNo % i == 0)
                            {
                                inputNo /= i;


                                x++;

                            }
                        result.Add(i);
                            Console.Write(" {0} ",  i);
                                                    }
                    }

                Console.WriteLine("Result is {0}",result[result.Count - 1]);
              
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
        public void FibonaciSeries(int inputNo)
        {
            int prevNo = 0;
            for (int i = 0; i < inputNo; i++)
            {
                if (i != 0) prevNo = i-1;
                int f = 0;
                f = prevNo + i;
                Console.Write("{0}{1}", i,f);
            }
        }
        public bool IsPrimeNumber(int inputNo)
        {
         
            int i = 1;
            while (i< inputNo)
            {
                if (inputNo % i == 0)
                {
                    return false;
                }
                i++;
            }
            return (true);
        }
    }
}
