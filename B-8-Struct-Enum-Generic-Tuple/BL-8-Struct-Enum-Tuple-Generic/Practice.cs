using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_8_Struct_Enum_Tuple_Generic
{
    partial class Practice
    {
        public static Random rand = new Random();


        /// <summary>
        /// BL8-P1/3. Cоздать структуру 2DRectangle, которая будет содержать ширину, высоту и координату.
        /// </summary>
        
            
        public struct Rectangle
        {
            public int width, height, coordX, coordY;

            public Rectangle(int w, int h, int cX, int cY)
            {
                this.width = w;
                this.height = h;
                this.coordX = cX;
                this.coordY = cY;
            }

            //public override bool Equals(object obj)
            //{
            //    return width == obj.width && height == obj.height && coordX == obj.coordX && coordY == obj.coordY;
            //}
        }


        /// <summary>
        /// BL8-P2/3. Cоздать случайный массив квадратов с количеством элементов 100. 
        /// Используйте класс Random(10), чтоб установить значения сторон. 
        /// </summary>
        public static int Lb8_P2_3()
        {
            int collCtr = 0; 
            Rectangle[] rectArr = new Rectangle[100];

            for(int i = 0; i < rectArr.Length; i++)
            {
                Practice.Rectangle rect = new Practice.Rectangle(rand.Next(10),rand.Next(10),rand.Next(10),rand.Next(10));
                rectArr.Append(rect);
            }

            for (int i = 0; i < rectArr.Length - 1; i++)
            {
                var n = rectArr[i];

                for(int f = i + 1; f < rectArr.Length; f++)
                {
                    if (rectArr[f].Equals(n))
                        collCtr++;
                }
            }

            return collCtr;
        }

        /// <summary>
        /// BL8-P3/3.Anonymous. Создать метод GetSongData, 
        /// который принимает обьекта типа Song и возвращает анонимный тип, 
        /// который содержит Title, Minutes, Seconds и AlbumYear. 
        /// </summary>
        public static void Lb8_P3_3_Anonymous()
        {            
        }
    }
}