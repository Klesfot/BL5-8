using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

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
            //ReplaceInPoem();
            Pyatnashki();
            Console.ReadLine();
        }

        public static void Pyatnashki()
        {
            int[,] arr = new int[4, 4];
            initarr(arr);
            Console.WriteLine();
            Console.WriteLine("Controls: W - up, S - Down, A - Left, D - Right");
            printarr(arr);
            int x,y;

            while (true)
            {
                switch (ReadLine())
                {
                    case "w":
                    {
                        x = zeroXpos(arr);
                        y = zeroYpos(arr);

                        arr[x,y] = arr[x-1,y];
                        arr[x-1,y] = 0;
                                
                        Console.Clear();
                        printarr(arr);
                        break;
                    }

                    case "s":
                    {
                        x = zeroXpos(arr);
                        y = zeroYpos(arr);
                        
                        arr[x,y] = arr[x+1,y];
                        arr[x+1,y] = 0;
                                
                        Console.Clear();
                        printarr(arr);
                        break;
                    }

                    case "a":
                    {
                        x = zeroXpos(arr);
                        y = zeroYpos(arr);
                        
                        arr[x,y] = arr[x,y-1];
                        arr[x,y-1] = 0;
                                
                        Console.Clear();
                        printarr(arr);
                        break;
                    }

                    case "d":
                    {
                        x = zeroXpos(arr);
                        y = zeroYpos(arr);
                        
                        arr[x,y] = arr[x,y+1];
                        arr[x,y+1] = 0;
                                
                        Console.Clear();
                        printarr(arr);
                        break;
                    }
                }
            }

        }


        private static int zeroXpos(int[,] arr)
        {
            int zeroxpos = 0;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (arr[x,y] == 0)
                    {
                        zeroxpos = x;
                        return zeroxpos;
                    }
                }
            }
            return 0;
        }


        private static int zeroYpos(int[,] arr)
        {
            int zeroypos = 0;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (arr[x,y] == 0)
                    {
                        zeroypos = y;
                        return zeroypos;
                    }
                }
            }
            return 0;
        }


        private static void printarr(int[,] arr)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                Console.Write($"{arr[i,j]} ");
                }
                Console.WriteLine();
            }
          
        }

        static Random rand = new Random();
        private static void initarr(int[,] arr)
        {
            
            int[,] normalArr = new int[4,4]
            {                         {1,2,3,4},
                                      {5,6,7,8},
                                      {9,10,11,12},
                                      {13,14,15,0}
            };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    //control goes here if the variable in normal array under the index of [r1,r2] equals 88 
                    //the point of doing so is to prevent collisions between the elements of target array
                    sameInt: 
                    int r1 = rand.Next(4);
                    int r2 = rand.Next(4);
                    if (normalArr[r1,r2] != 88)
                    {
                        arr[i,j] = normalArr[r1, r2];
                        normalArr[r1, r2] = 88;
                    }
                    else goto sameInt;
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

            for (int i = 0; i < 3; i++)
            {
                int rowMax = 0;

                for (int j = 0; j < 3; j++)
                {
                    if (arr[i,j] > rowMax)
                        rowMax = arr[i,j];
                }

                if ((i == 0) || (i == 1) || (i == 2))
                    Console.WriteLine("Max for row " + " " + (i + 1) + " " + " is: " + rowMax);
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
            
            if (len > 14)
                input = input.Remove(14);
            input = input.Insert(14, "...");
            
            Console.WriteLine(input);
        }

        internal static void ReplaceInPoem()
        {
            Console.WriteLine("Please input a poem in one line, dividing each line of poem with a semicolon");
            string poem = Console.ReadLine();
            poem = poem.Replace("о","а").Replace("л","ль").Replace("ть","т").Replace
                               ("О","А").Replace("Л","Ль").Replace("Ть","Т");

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
