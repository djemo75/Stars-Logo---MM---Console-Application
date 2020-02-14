using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowSymbols
{
    class Star
    {
        public int width;
        public int starCount;
        public int starCountHelper;
        public Star(int width)
        {
            this.width = width;
        }
        public void CreateStars(int starCount)
        {
            for (int a = 0; a < starCount; a++)
            {
                Console.Write("*");
            }
        }
        public void SetStarCount(int value)
        {
            starCount = value;
        }
        public void SetStarCountHelper(int value)
        {
            starCountHelper = value;
        }
    }
}
