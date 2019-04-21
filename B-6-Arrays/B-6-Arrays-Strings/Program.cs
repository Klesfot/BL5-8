using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base.Lesson_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pyatnashki();
            //MassiveMaxInRow();
            //MassiveSort();
            //CutString();
            ReplaceInPoem(); 
            Console.ReadLine();
        }

        public static void Pyatnashki()
        {
            int[,] arr = new int[3, 3];
            printarr(arr);
            initarr(arr);
            Console.WriteLine();
            printarr(arr);

        }

        private static void printarr(int[,] arr)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {

                Console.Write($"{arr[i,j]} ");
                }
                Console.WriteLine();
            }
          
        }

        static Random rand = new Random();
        private static void initarr(int[,] arr)
        {
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    arr[i, j] = rand.Next(10);
                    
                }
                
            }

        }

        internal static void MassiveMaxInRow()
        {
            int[,] arr = new int[3,3] {
                                {42,28,64},//00, 01, 02
                                {14,65,90},//10, 11, 12
                                {88,15,47} //20, 21, 22
            };

            
            int rowMax = arr[0,0];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if ((i == 0 & j == 0) || (i == 1 & j == 0) || (i == 2 & j == 0))
                        rowMax = arr[i,j];
                    
                    if (arr[i,j] > rowMax)
                        rowMax = arr[i,j];
                    
                    if ((i == 0 && j == 2) || (i == 1 && j == 2) || (i == 2 && j == 2))
                        Console.WriteLine("Max for row " + " " + (i + 1) + " " + " is: " + rowMax);
                }
            }
        }
        
        internal static void MassiveSort()
        {

            void insertSort(int[] array, int sizeN)
            {
	            int temp, prev;
	            for (int i = 0; i < sizeN; i++)
	            {
			        temp = array[i];
			        prev = i - 1;

    			    while (prev >= 0 && array[prev] > temp)
    			    {
	    			    array[prev + 1] = array[prev];
			    	    prev--;
			        }
                    array[prev + 1] = temp;
                }
            }


            int[] arr = new int[5];
            Console.WriteLine("Please input 5 numbers to insert into array");
            
            for(int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            insertSort(arr, 5);

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{arr[i]} ");
                Console.WriteLine();
            }

        }
        
        internal static void CutString()
        {
            Console.WriteLine("Please insert a string");
            string input = Console.ReadLine();
            int len = input.Length;
            
            if (len > 13)
                input = input.Remove(14);
            input = input.Insert(14, "...");
            
            Console.WriteLine(input);
        }

        internal static void ReplaceInPoem()
        {
            Console.WriteLine("Please input a poem in one line, dividing each line of poem with a semicolon");
            string poem = Console.ReadLine();
            poem = poem.Replace("о","а");
            poem = poem.Replace("О","А");
            poem = poem.Replace("л","ль");
            poem = poem.Replace("Л","Ль");
            poem = poem.Replace("ть","т");
            poem = poem.Replace("Ть","Т");

            int len = poem.Length;
            Console.WriteLine();
            Console.Write(" "); //i honestly have no clue why it prints the first line normally while next lines start with a space
                                //if there is no line 153. dunno how to fix it without it

            for (int i = 0; i < len; i++)
            {
                if (poem[i] == ';')
                {
                    i++;
                    Console.WriteLine();
                }
                Console.Write(poem[i]);
            }
        }
    }
}
