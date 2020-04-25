using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    public class TerToOct 
    { 

    public string Convert3To8(string ter)
    {
        if (ter == "0" || ter == "") return "0";
        else
        {
            int dec = 0;
            string oct = "";
            var chars = ter.ToCharArray();
            int pow = ter.Length - 1;
            for (int i = 0; i < chars.Length; i++)
            {
                if (Convert.ToInt32(chars[i]) >= 48 && Convert.ToInt32(chars[i]) <= 50)
                {
                    int N;
                    N = int.Parse(chars[i].ToString());
                    dec += N * (int)Math.Pow(3, pow);
                    pow--;
                }
                else throw new ArgumentException("Error! Wrong symbols in strings!");
            }

            var chars2 = Convert.ToString(dec).ToCharArray();
            while (dec != 0)
            {
                int c = dec % 8;
                dec /= 8;
                oct += c;
            }
            char[] CA = oct.ToCharArray();
            Array.Reverse(CA);
            return new string(CA);
        }
    }
}
}
