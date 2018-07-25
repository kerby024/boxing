using System;
using System.Collections.Generic;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> trial = new List<object>();
            trial.Add(7);
            trial.Add(28);
            trial.Add(-1);
            trial.Add(true);
            trial.Add("chair");
            int sum = 0;
            for(var i =0; i <trial.Count; i++)
            {
                // Console.WriteLine(trial[i]);
            if(trial[i] is int){
                sum += (int)trial[i];
                Console.WriteLine(sum);
            }
            }
        }
    }
}
