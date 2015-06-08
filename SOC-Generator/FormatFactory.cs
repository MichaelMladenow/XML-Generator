namespace SOC_Generator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    using SOC_Generator.Generators.ClassModels;
    using SOC_Generator.Generators.ClassModels.xmlModels;

    static class FormatFactory
    {
        public static string[] GenerateRows(List<Dictionary<string, string>> xmlData)
        {
            // TODO: User the looprow generator to return a collection of looprows
            RowGenerator generator = new RowGenerator(xmlData);
            generator.Generate();
            return xmlRowsToStringArray(generator.GeneratedOutput);

        }

        public static string GenerateImageRows(string[] input)
        {
            throw new NotImplementedException();
        }

        public static string[] xmlRowsToStringArray(List<Row> tagInput)
        {
            string[] stringedXmlTags = new string[tagInput.Count];
            for (int i = 0; i < tagInput.Count; i++)
            {
                stringedXmlTags[i] = tagInput[i].ToString();
            }

            return stringedXmlTags;
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

        /// <summary>
        /// Parses attributes from string array[] for xml conversion
        /// </summary>
        /// <param name="textData">String array, holding each data line</param>
        /// <returns>Returns a collection of string kv pairs, or empty collection
        /// if nothing was parsed. Each element from the list represents the data
        /// for one xml tag element.</returns>
        public static List<Dictionary<string, string>> parseXmlAttributes(List<string> textData, char delimiter)
        {
            string[] attributeNames = textData[0].Split(delimiter);
            List<Dictionary<string, string>> outputData = new List<Dictionary<string, string>>();
            foreach (var dataRow in textData)
            {
                Dictionary<string, string> currentTagAttributes = new Dictionary<string, string>();
                string[] currentTagData = dataRow.Split(delimiter);
                for (int i = 0; i < currentTagData.Length; i++)
                {
                    currentTagAttributes[attributeNames[i]] = currentTagData[i];
                }
                outputData.Add(currentTagAttributes);
            }
            return outputData;
        }
    }
}
