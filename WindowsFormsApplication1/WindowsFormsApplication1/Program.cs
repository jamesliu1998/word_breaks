using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace WindowsFormsApplication1
{
    static class Program
    {

        public static String getWordBreak(String input, int column)
        {

            if (input == null) return "Error: Input cannot have null string";
            if (column < 1) return "Error: column must be >0";

            //to see how many line break need to insert
            int s = input.Length / column;
            int flag = input.Length % column;

            StringBuilder strb = new StringBuilder();

            for (int i = 0; i < s; i++)
            {
                strb.Append(input.Substring(i * column, column));
                strb.Append("\n");
            }

            if (flag != 0) strb.Append(input.Substring(s * column));

            return strb.ToString();
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(String [] args)
        {
            //test case 1: Given "The quick brown fox jumped over the lazy dog.", column 15; 
            String str1 = "The quick brown fox jumped over the lazy dog.";
            String str2 = getWordBreak(str1, 15);
            System.Console.Write(str2);

            System.Console.WriteLine();

            //test case 2: Given: "Wrap fixed width text at word breaks. Given a string and a column number, return the string with line breaks.” Column 10
            String str3 = "Wrap fixed width text at word breaks. Given a string and a column number, return the string with line breaks.";
            String str4 = getWordBreak(str3, 10);
            System.Console.Write(str4);
            System.Console.WriteLine();
            System.Console.WriteLine();

            //test case 3: Given: null, column 5
            String str5 = null;
            String str6 = getWordBreak(str5, 10);
            System.Console.Write(str6);
            System.Console.WriteLine();
            System.Console.WriteLine();

            //test case 4: Given: “Development”, column 0
            String str7 ="Development";
            String str8 = getWordBreak(str7, 0);
            System.Console.Write(str8);
            System.Console.WriteLine();
            System.Console.WriteLine();

            //test case 5: Given: “the repetition of a development cycle” column 500
            String str9 = "the repetition of a development cycle";
            String str10 = getWordBreak(str9, 500);
            System.Console.Write(str10);
            System.Console.WriteLine();
        }
    }
}
