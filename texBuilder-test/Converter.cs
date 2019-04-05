using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace texBuilder_test
{
    class Converter
    {

        //
        //  \func(commandName, option) 
        //      stirng
        //  \end
        //

        private const string funcSign = "\\func";
        private const string funcBegin = "begin{";
        private const string funcEnd = "\\end";

        private readonly Action<string> inputDisp;
        private readonly Action<string> outputDisp;
        private readonly Stack<string> commandStack;

        public Converter(Action<string> source, Action<string> output) 
        {
            inputDisp += source;
            outputDisp = output;
            commandStack = new Stack<string>();
        }

        public void Start(TextReader reader)
        {
            while (reader.Peek() > -1)
            {
                string line = reader.ReadLine();
                inputDisp(line);
                outputDisp(Convert(line));
            }
        }

        private string Convert(string input)
        {
            //拡張コマンドの開始位置
            if (input.Contains(funcSign)) {

                //Console.WriteLine(input.IndexOf("(") + 1);
                //Console.WriteLine(input.IndexOf(")") - 1);

                int start = input.IndexOf("(") + 1;
                int end = input.IndexOf(")");
                string[] extended = input.Substring(start, end - start).Split(',');
                string value = input.Substring(end + 1);
                //string value = input.Substring(input.IndexOf(funcBegin) + funcBegin.Length);
                input = $"\\begin{{{extended[0]}}}{(extended.Length > 1 ? extended[1] : "")}{value}";

                commandStack.Push($"\\end{{{extended[0]}}}");
            }

            //拡張コマンドの終了位置
            if(input.Contains(funcEnd))
            {
                if(commandStack.Count != 0)
                {
                    input = input.Replace(funcEnd, commandStack.Pop());
                    //Console.WriteLine(input);
                }
            }

            return input.TrimStart();
        }
    }
}
