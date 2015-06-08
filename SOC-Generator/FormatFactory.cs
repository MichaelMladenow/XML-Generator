namespace SOC_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    static class FormatFactory
    {
        public static string GenerateLooprows(string[] input)
        {
            // TODO: User the looprow generator to return a collection of looprows
            throw new NotImplementedException();
        }

        public static string GenerateImageRows(string[] input)
        {
            throw new NotImplementedException();
        }

        public static List<string> streamReaderToList(StreamReader reader)
        {
            List<string> lines = new List<string>();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }

            return lines;
        }
    }
}
