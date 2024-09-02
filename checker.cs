using System;

namespace paradigm_shift_csharp
{
    class Checker
    {
        static bool batteryIsOk(float temperature, float soc, float chargeRate)
        {
            // Combined conditions into a single decision point
            if (temperature >= 0 && temperature <= 45 &&
                soc >= 20 && soc <= 80 &&
                chargeRate <= 0.8)
            {
                return true;
            }

            Console.WriteLine("One or more parameters are out of range!");
            return false;
        }

        static void ExpectTrue(bool expression)
        {
            if (!expression)
            {
                Console.WriteLine("Expected true, but got false");
                Environment.Exit(1);
            }
        }

        static void ExpectFalse(bool expression)
        {
            if (expression)
            {
                Console.WriteLine("Expected false, but got true");
                Environment.Exit(1);
            }
        }

        static int Main()
        {
            ExpectTrue(batteryIsOk(25, 70, 0.7f));  // All values within the range
            ExpectFalse(batteryIsOk(50, 85, 0.0f));  // All values out of the range
            Console.WriteLine("All ok");
            return 0;
        }
    }
}
