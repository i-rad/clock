using System;

namespace ClockArrowsAngle
{
    public class Program
    {
        static void Main(string[] args)
        {
            string inputStr;
            do
            {
                RunConsoleApp();
                Console.WriteLine("Run again? (y/Y for yes, press any key to exit)");
                inputStr = Console.ReadLine();
            } while (inputStr.ToLower() == "y");            
        }

        static void RunConsoleApp()
        {
            Console.Write("Enter the hours : ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Enter the Minutes : ");
            int minutes = int.Parse(Console.ReadLine());
            if (!CheckInput(hours, minutes))
            {
                Console.WriteLine("Invalid input");
                return;
            }
            else
            {
                hours = CheckFormat(hours);
                double angle = CalculateAngle(hours, minutes);
                Console.WriteLine("Angle between {hours} hour and {minutes} minute is {angle} degrees");
            }
        }

        public static bool CheckInput(int hours, int minutes)
        {
            if (hours > 24 || hours < 0 || minutes > 60 || minutes < 0)
            {
                return false;
            }
            return true;
        }

        public static int CheckFormat(int hours)
        {
            if (hours > 12)
            {
                return hours - 12;
            }
            return hours;
        }

        public static double CalculateAngle(int hours, int minutes)
        {
            // Hour angle is 30 degrees (360 / 12) + degrees calculated from minutes 
            // 30 degrees in an hour divided by 60 minutes make 0.5 degrees
            double hourAngleInDegrees = (hours * 30) + (minutes * 0.5);
            // Minute angle is 6 degrees (360 / 60)
            double minuteAngleInDegrees = minutes * 6;
            double differenceAngle = Math.Abs(hourAngleInDegrees - minuteAngleInDegrees);
            // because the lesser angle is needed
            if (differenceAngle > 180)
            {
                differenceAngle = 360 - differenceAngle;
            }
            return differenceAngle;
        }

    }
}
