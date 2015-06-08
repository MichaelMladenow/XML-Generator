namespace SOC_Generator.Generators.ClassModels.xmlModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class representing a question row in XML format    
    /// </summary>
    public class Row : Tag
    {
        private const string RowTagName = "row";
        private const string RowLabelFormat = "r{0}";

        /// <summary>
        /// Row Constructor
        /// </summary>
        /// <param name="index">The index we use for labeling.</param>
        /// <param name="attributes">List of KV string string pairs.</param>
        public Row(int index, Dictionary<string, string> attributes)
            : base(RowTagName, attributes)
        {
            this.Attributes["label"] = string.Format(RowLabelFormat, index);
        }
    }
}