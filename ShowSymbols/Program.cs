using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            if (CheckNumber(width) == false){
                ShowSymbol(width);
            }
            Console.ReadKey();
        }
        public static bool CheckNumber(int width)
        {
            bool hasError = false;
            if ((width < 2) || (width > 10000))
            {
                Console.WriteLine("The number must be in area: 2<N<10000.Try again!");
                hasError = true;
            }
            if (width % 2 != 1)
            {
                Console.WriteLine("The number must be odd.Try again!");
                hasError = true;
            }
            return hasError;
        }
        public static void IfFunction(int i, int lines, Star star)
        {
            if (i + 1 > lines / 2)
            {
                star.SetStarCount(star.width);
            }
        }
        public static void ShowSymbol(int width)
        {
            Star star = new Star(width);
            Dash dash = new Dash();
            int lines = star.width + 1;

            star.SetStarCount(star.width);
            star.SetStarCountHelper(star.width - 1);
            dash.SetDashCount(star.width);
            dash.SetDashCountHelper(star.width);
            dash.SetDashCountHelper2(-1);
            for (int i = 0; i < lines; i++){
                IfFunction(i,lines,star);
                dash.CreateDashes(dash.dashCount);
                star.CreateStars(star.starCount);
                if (i + 1 >= lines / 2)
                {
                    dash.CreateDashes(dash.dashCountHelper2);
                }
                if (i < lines / 2)
                {
                    dash.CreateDashes(dash.dashCountHelper);
                }
                star.CreateStars(star.starCount);
                if (i >= lines / 2)
                {
                    star.CreateStars(star.starCountHelper);
                }
                if (i + 1 >= lines / 2)
                {
                    dash.CreateDashes(dash.dashCountHelper2);
                }
                if (i >= lines / 2)
                {
                    star.CreateStars(star.width);
                }
                dash.CreateDashes(dash.dashCount);


                IfFunction(i, lines, star);
                dash.CreateDashes(dash.dashCount);
                star.CreateStars(star.starCount);
                if (i + 1 >= lines / 2)
                {
                    dash.CreateDashes(dash.dashCountHelper2);
                }
                if (i < lines / 2)
                {
                    dash.CreateDashes(dash.dashCountHelper);
                    dash.SetDashCountHelper(dash.dashCountHelper - 2);
                }
                star.CreateStars(star.starCount);
                if (i >= lines / 2)
                {
                    star.CreateStars(star.starCountHelper);
                    star.SetStarCountHelper(star.starCountHelper-2);
                }
                if (i + 1 >= lines / 2)
                {
                    dash.CreateDashes(dash.dashCountHelper2);
                    dash.SetDashCountHelper2(dash.dashCountHelper2+2);
                }
                if (i >= lines / 2)
                {
                    star.CreateStars(star.width);
                }
                dash.CreateDashes(dash.dashCount);
                dash.SetDashCount(dash.dashCount-1);
                star.SetStarCount(star.starCount+2);
                Console.WriteLine();
            }

        }
        
    }
}
