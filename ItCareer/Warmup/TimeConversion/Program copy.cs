using System;

namespace TimeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            System.Console.Write(ConvertTime(input));
        }
        
        static string ConvertTime(string inputTime)
        {
            //From 12:01:00PM to 12:00:00 (afternoon)
            //From 12:01:00AM to 00:01:00 (morning)
            string[] time = inputTime.Split(':');
            int hh = int.Parse(time[0]);
            int mm = int.Parse(time[1]);
            string SS = time[2];

            if(SS[2] == 'A')
                if(hh == 12) hh = 0;
                
            if(SS[2] == 'P')
                if (hh != 12) hh += 12;

            int ss = int.Parse($"{time[2][0]}{time[2][1]}");
            return $"{hh:D2}:{mm:D2}:{ss:D2}";
        }
    }
}
