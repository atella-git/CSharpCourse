using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Linq;
using _01Assignment;


namespace _01Assignment
{
   
    class CanRack
    {
        private int[] rack = new int[Enum.GetValues(typeof(Flavortype)).Length];

        public CanRack()
        {
          
        }
        public void AddACanof(Flavortype FlavorOfCanTOBeAdded)

        {

            switch (FlavorOfCanTOBeAdded)
            {
                case Flavortype.REGUALR:
                    if (regular < 3) 
                    {
                        regular++;
                        Console.WriteLine("Regular flavor can has been added to bin");
                    }
                        
                    break;
                case Flavortype.LEMON:
                    if (lemon < 3)
                    {
                        regular++;
                        Console.WriteLine("Lemon flavor can has been added to bin");
                    }

                    break;
                case Flavortype.ORANGE:
                    if (orange < 3)
                    {
                        regular++;
                        Console.WriteLine("Ornage flavor can has been added to bin");
                    }

                    break;

            }

        }
        public void RemoveACanof(Flavortype FlavorOfCanTOBeRemoved)
        {

            switch (FlavorOfCanTOBeRemoved)
            {
                case Flavortype.REGUALR:
                    if (regular > 0 || regular < 3) 
                    {
                        regular--;
                        Console.WriteLine("Regular flavor can has been removed from bin");
                    }
                    break;
                case Flavortype.LEMON:
                    if (lemon > 0 || lemon < 3) 
                    {
                        lemon--;
                        Console.WriteLine("Lemon flavor can has been removed from bin");
                    } 
                    break;
                case Flavortype.ORANGE:
                    if (orange > 0 || orange < 3)
                    {
                        orange--;
                        Console.WriteLine("Orange flavor can has been removed from bin");
                    }
                    break;

            }

        }
        public void FillTheCanRack()
        {
            Console.WriteLine("Fill the rack.");
            regular = 3;
            orange = 3;
            lemon = 3;
        }


        public void EmptyCanRackOf(Flavortype FlavorOfBinToBeEmptied)
        {


            switch (FlavorOfBinToBeEmptied)
            {
                case Flavortype.REGUALR:
                    if (regular > 0 || regular < 3) 
                    {
                        regular = 0;
                        Console.WriteLine("Regular flavor bin has been emptied");
                    }
                    break;
                case Flavortype.LEMON:
                    if (lemon > 0 || lemon < 3)
                    {
                        lemon = 0;
                        Console.WriteLine("Lemon flavor bin has been emptied");
                    }
                    break;
                case Flavortype.ORANGE:
                    if (orange > 0 || orange < 3)
                    {
                        orange = 0;
                        Console.WriteLine("Orange flavor bin has been emptied");
                    }
                    break;

            }

        }

    }
}
