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

            if (input == null) return null;
            if (column < 1) return input;

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
            String str1 = "The quick brown fox jumped over the lazy dog.";
            String str2 = getWordBreak(str1, 15);
            System.Console.Write(str2);

            System.Console.WriteLine();

            String str3 = "Wrap fixed width text at word breaks. Given a string and a column number, return the string with line breaks.";
            String str4 = getWordBreak(str3, 10);
            System.Console.Write(str4);
        }
    }
}
