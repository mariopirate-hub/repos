using System;
using System.Collections.Generic;
using System.Linq;

namespace Sudoku
{
    class Program
    {

        static void Main()
        {
            Program program = new Program();

           

            int[,] grille = new int[9,9];

            List<string> entree = new List<string>() {  "120070560", "507932080","000001000", "010240050", "308000402", "070085010", "000700000", "080423701","034010028" } ;

            for (int i = 0; i < 9; i++)
            {
                string line = entree[i];

                
                for(int j = 0;j<9;j++)
                {
                    grille[i, j] = int.Parse(line.Substring(j, 1));
                               
                }
                
            }
            

            
            

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(grille[i, j]);
                }
                Console.WriteLine();
            }

            program.EstValide(grille, 0);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write(grille[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        bool AbsentSurLigne(int k, int[,] grille, int i)
        {
            for (int j = 0; j < 9; j++)
                if (grille[i,j] == k)
                    return false;
            return true;
        }

        bool AbsentSurColonne(int k, int[,] grille, int j)
        {
            for (int i = 0; i < 9; i++)
                if (grille[i,j] == k)
                    return false;
            return true;
        }

        bool AbsentSurBloc(int k, int[,] grille, int i, int j)
        {
            int _i = i - (i % 3), _j = j - (j % 3);  // ou encore : _i = 3*(i/3), _j = 3*(j/3);
            for (i = _i; i < _i + 3; i++)
                for (j = _j; j < _j + 3; j++)
                    if (grille[i,j] == k)
                        return false;
            return true;
        }

        bool EstValide(int[,] grille, int position)
        {
            if (position == 9 * 9)
                return true;

            int i = position / 9, j = position % 9;

            if (grille[i,j] != 0)
                return EstValide(grille, position + 1);

            for (int k = 1; k <= 9; k++)
            {
                if (AbsentSurLigne(k, grille, i) && AbsentSurColonne(k, grille, j) && AbsentSurBloc(k, grille, i, j))
                {
                    grille[i,j] = k;

                    if (EstValide(grille, position + 1))
                        return true;
                }
            }
            grille[i,j] = 0;

            return false;
        }

        


    }

}
