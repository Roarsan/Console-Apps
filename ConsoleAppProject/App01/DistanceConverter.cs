using System;
using ConsoleAppProject.Helpers;

namespace ConsoleAppProject.App01
{

    public class DistanceConverter
    {
        private const int MILES_AND_FEET = 5280;
        private const double MILES_AND_METRES = 1609.34;
        private const double METRES_AND_FEET = 3.28084;

        private DistanceUnits fromUnit;
        private DistanceUnits toUnit;



        private double fromDistance;
        private double toDistance;

        private const int MAX_UNITS = 3;

        private string[] units = new string[MAX_UNITS];



        private void InitialiseUnitArray()
        {
            units[0] = DistanceUnits.Feet.ToString();
            units[1] = DistanceUnits.Miles.ToString();
            units[2] = DistanceUnits.Metres.ToString();

        }


        public void Run()
        {
            Heading();
            InitialiseUnitArray();
            fromUnit = Input("FROM");
            toUnit = Input("TO");

            InputFromDistance();

            Calculate();

            Output();



        }

        private void Heading()
        {
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine();
            Console.WriteLine(" =================================================");
            Console.WriteLine("    BNU CO453 Distance Converter ");
            Console.WriteLine("          Roshan Gauchan                                  ");
            Console.WriteLine(" =================================================");
            Console.WriteLine();
        }

        private DistanceUnits Input(string unit)
        {
            Console.WriteLine($" Please Choose One Of the Following Units to convert {unit}");
            int option = ConsoleHelper.SelectChoice(units);

            if (option == 1)
                return DistanceUnits.Feet;
            else if (option == 2)
                return DistanceUnits.Miles;
            else if (option == 3)
                return DistanceUnits.Metres;
            else
                return DistanceUnits.NoUnit;
        }

        /// <summary>
        /// Prompt the user to enter desired distance.
        /// Inputs the number in double.
        /// </summary>
        private void InputFromDistance()
        {
            Console.WriteLine("Please enter the number of " + fromUnit);

            fromDistance = Convert.ToDouble(Console.ReadLine());
        }



        /// <summary>
        /// Gives the output of calculate method .
        /// </summary>
        private void Output()
        {
            Console.WriteLine(fromDistance + " " + fromUnit.ToString() + " is " + toDistance + " " + toUnit);

        }

        /// <summary>
        /// calculates distance by multipying or dividing  using from unit and to unit
        /// </summary>
        private void Calculate()
        {
            if (fromUnit == DistanceUnits.Miles && toUnit == DistanceUnits.Feet)
            {
                toDistance = fromDistance * MILES_AND_FEET;
            }
            else if (fromUnit == DistanceUnits.Feet && toUnit == DistanceUnits.Miles)
            {
                {
                    toDistance = fromDistance / MILES_AND_FEET;
                }
            }
            else if (fromUnit == DistanceUnits.Miles && toUnit == DistanceUnits.Metres)
            {
                toDistance = fromDistance * MILES_AND_METRES;
            }
            else if (fromUnit == DistanceUnits.Metres && toUnit == DistanceUnits.Miles)
            {
                {
                    toDistance = fromDistance / MILES_AND_METRES;
                }
            }
            else if (fromUnit == DistanceUnits.Metres && toUnit == DistanceUnits.Feet)
            {
                toDistance = fromDistance * METRES_AND_FEET;
            }
            else if (fromUnit == DistanceUnits.Feet && toUnit == DistanceUnits.Metres)
            {
                {
                    toDistance = fromDistance / METRES_AND_FEET;
                }
            }

        }





    }
}