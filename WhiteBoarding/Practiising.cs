using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoarding
{
    public class Practiising
    {
        public int[]  Withdraw(int n)
        {
            int[] bills = new int[3];

            bills[0] = n / 100;
            n %= 100;

            //You check if the remaining amount n is greater than or equal to 50
            //and not divisible by 20.
            //If this condition is true,
            //you set bills[1] to 1 to indicate that you're usin
            //g one 50-dollar bill and subtract 50 from n.

            if (n >= 50 && n % 20 !=0)
            {
                bills[1] = 1;
                n -= 50;
            }

            //If the remaining amount n is less than 50 and not divisible by 20,
            //you subtract 1 from bills[0] to account for the case where you had
            //initially used one 100-dollar bill,
            //then you add 100 to n to make it divisible by 100,
            //and finally, you use one 50-dollar bill and subtract 50 from n.

            else if (n < 50 && n % 20 != 0)
            {
                bills[0] -= 1;
                n += 100;

                bills[1] = 1;
                n -= 50;
            }

            bills[2] = n / 20;

            
            return bills;

           


        }
        
        public void Printout(int[] bills)
        {
           
            foreach(var item in bills)
            {
                
                Console.WriteLine(item);
            }
        }
    }
}
