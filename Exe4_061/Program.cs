using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_061
{
   class Stacks
   {
        public char [] aisah;
        public int top;
        public int max;

        public Stacks(int size)
        {
            aisah = new char [size];
            top = -1;
            max = size;
        }

        public bool empty()
        {
            if (top == -1)
                return(true);
            else
                return(false);
        }

        public void push(char item) //Method untuk menambahkan data/memasukkan data dalam stack
        {
            if( top == max - 1)
            {
                return;
            }
            else
            {
                aisah[++top] = item;
            }
        }

        public int pop() //Method untuk mengeluarkan data / menghapus data dalam stack
        {
            if (top == -1)
            {
                return -1;
            }
            else
            {
                Console.WriteLine("\nThe Poped Element Is :  " + aisah[top]);
                return aisah[top--];
            }
        }

        public void display() //Method untuk menampilkan data
        {
            if (empty())
                Console.WriteLine("\nStack Is Empty\n");

            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item [ " + (i + 1) + " ] : " + aisah [i] );
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
                Console.Write("\nEnter Your Choice : ");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                switch (ch)
                {
                    case '1':
                        Console.Write("\nEnter a character : ");
                        string sInput1 = Console.ReadLine();
                        char c = Convert.ToChar(sInput1 == "" ? "0" : sInput1);
                        s.push(c);
                        break;

                    case '2':
                        if (s.empty())
                        {
                            Console.WriteLine("\n===========Stack Is Empty============\n");
                            break;
                        }
                        s.pop();
                        break;

                    case '3':
                        s.display();
                        break;

                    case '4':
                        return;

                    default:
                        Console.WriteLine("\nInvalid Choice");
                        break;
                }
            }
        }

   }
}

//kumpulan data yg diakses hanya d salah satu ujung nya, yaitu ujung atas
//data yang trkhir di tambahkan akan pertama kali di kluarkan 