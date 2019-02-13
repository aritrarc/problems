using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace nsStrings
{
    public class StringCompression
    {

        // This code is used to reverse a string without using any other DS.
        public static void CompressString()
        {
            string str = "aabbccda";

            StringBuilder builder = new StringBuilder();
            int count = 1;

            for(int i=1; i< str.Length; i++)
            {
                if(str[i] == str[i-1]){
                    count++;
                }else{
                    builder.Append(str[i-1].ToString() + count);
                    count = 1;
                }
            }
            builder.Append(str[str.Length - 1].ToString() + count);

            if(str.Length == builder.ToString().Length)
            {
                Console.WriteLine(str);
            }else {
                Console.WriteLine(builder.ToString());
            }    
        }
    }

}
 