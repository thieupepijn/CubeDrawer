using System;
using System.Collections.Generic;
using System.Text;

namespace CubeDrawer
{
    public class UtilString
    {

        public static int NumberOfCharactersEqual(string line1, string line2)
        {
            if (line1.Length != line2.Length)
            {
                return 0;
            }

            int answer = 0;
            for(int counter=0; counter<line1.Length; counter++)
            {
                char character1 = line1[counter];
                char character2 = line2[counter];

                if (character1 == character2)
                {
                    answer++;
                }
            }
            return answer;
        }


    }
}
