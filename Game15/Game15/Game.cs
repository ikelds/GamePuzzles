using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game15
{
    class Game
    {
        static int _size;
        int[,] massiv;
        int space_x, space_y;
        static int lngMass = _size * _size;
        public int[] numbInMasss;
        public int[] rightNumb;
         
        static Random rand = new Random();
        
        public Game(int size)
        {
            _size = size;
            massiv = new int[size, size];
            numbInMasss = new int[size * size];
            rightNumb = new int[size * size];
        }

        public void start()
        {
            int z = 0;

            for (int x = 0; x < _size; x++)
            {
                for (int y = 0; y < _size; y++)
                {
                    massiv[x, y] = coordsToPosition(x, y);
                    rightNumb[z] = massiv[x, y];
                    z++;
                }
            }
        }

        public int get_number(int pos)
        {
            int x, y;
            position_to_coords(pos, out x, out y);          
            return massiv[x, y];
        }

        public void insertTail(int index)
        {
            int x, y;
            position_to_coords(index, out x, out y);
            massiv[x, y] = 0;
        }

        public void mixTails()
        {
            for (int i = 0; i < 1000000; i++)            
                swapTails(rand.Next(0, _size * _size));            
        }

        public void swapPictures(int pic1, int pic2)
        {
            int xPic1, yPic1;
            int xPic2, yPic2;
            int temp;

            position_to_coords(pic1, out xPic1, out yPic1);
            position_to_coords(pic2, out xPic2, out yPic2);

            temp = massiv[xPic1, yPic1];

            massiv[xPic1, yPic1] = massiv[xPic2, yPic2];
            massiv[xPic2, yPic2] = temp;
        }


        public void swapTails(int index)
        {
            int x, y, xNew, yNew, tempCurrent;

            position_to_coords(index, out x, out y);

            tempCurrent = massiv[x, y];               
            xNew = space_x;
            yNew = space_y;
        

            if (space_x == x & (space_y + 1 == y || space_y - 1 == y))
            {
                space_x = x;
                space_y = y;
                massiv[space_x, space_y] = 0;
                massiv[xNew, yNew] = tempCurrent;
            }       
            else if (space_y == y & (space_x + 1 == x || space_x - 1 == x))
            {
                space_x = x;
                space_y = y;
                massiv[space_x, space_y] = 0;
                massiv[xNew, yNew] = tempCurrent;
            }

        }

        public bool checkToEndGame()
        {
            int z = 0;

            for (int x = 0; x < _size; x++)
            {
                for (int y = 0; y < _size; y++)
                {
                    numbInMasss[z] = massiv[x, y];
                    z++;
                }
            }            

            return rightNumb.SequenceEqual(numbInMasss);       
        }



        private int coordsToPosition(int x, int y)
        {
            return y * _size + x;
        }

        private void position_to_coords(int pos, out int x, out int y)
        {
            x = pos % _size;
            y = pos / _size;
        }
    }
}
