using System;
using System.Collections.Generic;

namespace _06_nim
{
    /// <summary>
    /// Keeps track of all of the pieces in play.
    /// 
    /// Stereotype:
    ///     Information Holder
    /// </summary>
    class Board
    {
        // TODO: Declare any member variables here.
        Random r = new Random();
        string pile0 = "";
        string pile1 = "";
        string pile2 = "";
        string pile3 = "";
        string pile4 = "";
        /// <summary>
        /// Initialize the Board
        /// </summary>
        public Board()
        {
            Prepare();
        }

        /// <summary>
        /// A helper method that sets up the board in a new random state.
        /// This could be called by the constructor, or if it is desired
        /// to play again.
        /// 
        /// It should have 2-5 piles with 1-9 stones in each.
        /// </summary>
        private void Prepare()
        {
            for (int i = 0; i< r.Next(2,6);i++)
            {
                switch (i)
                {
                    case 0:
                        for (int j = 0; j <r.Next(1,9);j++)
                        {
                            pile0 += "O ";
                        }
                        break;
                    case 1:
                        for (int j = 0; j <r.Next(1,9);j++)
                        {
                            pile1 += "O ";
                        }
                        break;
                    case 2:
                        for (int j = 0; j <r.Next(1,9);j++)
                        {
                            pile2 += "O ";
                        }
                        break;
                    case 3:
                        for (int j = 0; j <r.Next(1,9);j++)
                        {
                            pile3 += "O ";
                        }
                        break;
                    case 4:
                        for (int j = 0; j <r.Next(1,9);j++)
                        {
                            pile4 += "O ";
                        }
                        break;
                    default: 
                        break;
                }
                
            }
        }

        /// <summary>
        /// Applies this move by removing the number of stones
        /// from the pile specified in the move.
        /// </summary>
        /// <param name="move">Contains the pile and the number of stones</param>
        public void Apply(Move move)
        {
            string newPile;
            if (move.GetPile()==0)
            {
                newPile=pile0;
                for(int i = 0; i < move.GetStones(); i++)
                {
                    newPile = newPile.Remove(0, 2);
                }
                pile0 = newPile;
            }       
            if (move.GetPile()==1)
            {
                newPile=pile1;
                for(int i = 0; i < move.GetStones(); i++)
                {
                    newPile = newPile.Remove(0, 2);
                }
                pile1 = newPile;
            } 
            if (move.GetPile()==2)
            {
                newPile=pile2;
                for(int i = 0; i < move.GetStones(); i++)
                {
                    newPile = newPile.Remove(0, 2);
                }
                pile2 = newPile;
            } 
            if (move.GetPile()==3)
            {
                newPile=pile3;
                for(int i = 0; i < move.GetStones(); i++)
                {
                    newPile = newPile.Remove(0, 2);
                }
                pile3 = newPile;
            } 
            if (move.GetPile()==4)
            {
                newPile=pile4;
                for(int i = 0; i < move.GetStones(); i++)
                {
                    newPile = newPile.Remove(0, 2);
                }
                pile4 = newPile;
            }    
        }

        /// <summary>
        /// Indicates if the board is empty (no more stones)
        /// </summary>
        /// <returns>True, if there are no more stones</returns>
        public bool IsEmpty()
        {
            int numStones = 0;
            if (pile0.Contains("O"))
            {
                numStones++;
            }
            if (pile1.Contains("O"))
            {
                numStones++;
            }
            if (pile2.Contains("O"))
            {
                numStones++;
            }
            if (pile3.Contains("O"))
            {
                numStones++;
            }
            if (pile4.Contains("O"))
            {
                numStones++;
            }
            return !(numStones>0);
        }

        /// <summary>
        /// Get's a string representation of the board in the format:
        /// 
        /// --------------------
        /// 0: O O O O O O 
        /// 1: O O O O O O O
        /// 2: O O O O O O O O 
        /// 3: O O O O 
        /// --------------------
        /// </summary>
        /// <returns>The string representation.</returns>
        public override string ToString()
        {
            string board = "";
            board += @"--------------------";
            if (pile0.Contains("O"))
            {
                board += $"\n0: {pile0}";
            }
            if (pile1.Contains("O"))
            {
                board += $"\n1: {pile1}";
            }
            if (pile2.Contains("O"))
            {
                board += $"\n2: {pile2}";
            }
            if (pile3.Contains("O"))
            {
                board += $"\n3: {pile3}";
            }
            if (pile4.Contains("O"))
            {
                board += $"\n4: {pile4}";
            }
            board += "\n--------------------";
            return board;
        }

        /// <summary>
        /// A helper function that is used by the general ToString method.
        /// This one gets the text for a specific pile in the format:
        /// 
        /// 2: O O O O O O O O 
        /// 
        /// </summary>
        /// <param name="pileNumber">The pile number to display at the front of the line.</param>
        /// <param name="stones">The number of stones in the pile</param>
        /// <returns></returns>
        private string GetTextForPile(int pileNumber, int stones)
        {
            throw new NotImplementedException();
        }
    }
}
