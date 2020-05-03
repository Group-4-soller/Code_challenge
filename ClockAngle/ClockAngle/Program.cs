using System;

namespace ClockAngle
{
    class Program
    {
        public static void FindAngle(decimal Hour, decimal Minutes)
        {
            // Checking for Edge Cases
            if(Hour > 12 | Minutes > 59)
            {
                Console.WriteLine("Enter correct hours and minutes");
                
            } else
            {
                // Convert Hours to Minutes
                var HourToMinutes = Hour * 5;

                if(HourToMinutes > Minutes)
                {
                    // Calculating Angle
                    decimal Output = ((HourToMinutes - Minutes) / 60m) * 360m;

                    Console.WriteLine(Output);
                } else
                {
                    // Calculating Angle
                    decimal Output = ((Minutes - HourToMinutes)/60m) * 360m;

                    Console.WriteLine(Output);
                }
            }
        }
        static void Main()
        {
            // Hour is greater than minutes
            FindAngle(12m, 59m);
            // Error
            FindAngle(13m, 59m);
            // Error
            FindAngle(12m, 60m);
            // Minutes are greater than hour
            FindAngle(1m, 10m);
            
        }
    }
}
