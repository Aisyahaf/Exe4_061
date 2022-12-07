using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_061
{
   class Stacks
   {
        public int[] aisah;
        public int top;
        public int max;

        public Stacks(int size)
        {
            aisah = new int[size];
            top = -1;
            max = size;
        }

        bool empty()
        {
            if (top == -1)
                return(true);
            else
                return(false);
        }

        public void push(int item)
        {
            if( top == max - 1)
            {
                return;
            }
            else
            {
                aisah[top++] = item;
            }
        }

        public int pop()
        {
            if (top == -1)
            {
                return -1;
            }
            else
            {
                Console.WriteLine("\nThe Poped element is :  " + aisah[top]);
                return aisah[top--];
            }
        }

        public void display()
        {
            if (empty())
                Console.WriteLine("\nStack Empty");
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item [ " + (i + 1) + "] : " + aisah[i]);
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Stacks s = new Stacks(79);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n=======STACK MENU=======\n");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter your choice : ");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                switch (ch)
                {
                    case '1':
                        Console.Write("\nEnter a Number : ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        s.push(num);
                        break;

                    case '2':
                        if (s.empty())
                        {
                            Console.WriteLine("\nStack Is Empty");
                            break;
                        }
                        s.pop();
                        break;

                    case '3':
                        s.display();
                        break;
                }
            }
        }

   }
}
