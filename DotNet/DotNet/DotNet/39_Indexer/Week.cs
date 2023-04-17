using System;

namespace WeekDemo
{
    
    public class Week
    {
        
        private string[] _week;

        
        public Week()
        {
            Length = 7; 
            _week = new string[Length]; 
        }
        
        public Week(int length)
        {
            Length = length;
            _week = new string[Length];
        }

        
        public int Length { get; }

        
        public string this[int index]
        {
            get { return _week[index]; }
            set { _week[index] = value; }
        }
    }

    class WeekDemo
    {
        static void Main()
        {
            
            Week week = new Week(3);

            
            week[0] = "일요일";
            week[1] = "월요일";
            week[2] = "화요일";

            
            for (int i = 0; i < week.Length; i++)
            {
                Console.WriteLine($"{week[i]}");
            }
        }
    }
}