using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShutDownRestartLockLogOff
{
    public static class RandomNumberGen
    {
        //For generating the cart referenceId
        private static Random random = new Random();
        public static string GenerateRandomValues(int length = 10)
        {
            try
            {
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                return new string(Enumerable.Repeat(chars, length)
                  .Select(s => s[random.Next(s.Length)]).ToArray());
            }
            catch (Exception exMessage)
            {
                throw exMessage;
            }
        }
    }
}
