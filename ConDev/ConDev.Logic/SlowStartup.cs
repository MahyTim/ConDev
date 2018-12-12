using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConDev.Logic
{
    public class SlowStartup 
    {
        public SlowStartup()
        {
            for (int i = 0; i < 1000; i++)
            {
                try
                {
                    throw new ArgumentException("Test");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }

        public void Execute(string email)
        {
            Console.WriteLine(email);
        }
    }
}