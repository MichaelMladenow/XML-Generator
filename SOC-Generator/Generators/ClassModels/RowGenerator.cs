namespace SOC_Generator.Generators.ClassModels
{
    using System;
    using System.Collections.Generic;
    using SOC_Generator.Generators.ClassModels.xmlModels;

    public class RowGenerator : GeneratorBase
    {
        private List<Row> generatedOutput = new List<Row>();
        private List<Dictionary<string, string>> rowGenerationData = new List<Dictionary<string, string>>();
        private int rowCount = 0;

        public RowGenerator(List<Dictionary<string, string>> rowsData)
        {
            this.rowGenerationData = rowsData;
        }

        public List<Dictionary<string, string>> InputData
        {
            get
            {
                return this.rowGenerationData;
            }

            set
            {
                // TODO: Validate inputdata
                this.rowGenerationData = value;
            }
        }

        public override void Generate(List<Dictionary<string, string>> tagData)
        {
            foreach (var item in tagData)
            {
                Row tempRow = new Row(rowCount + 1, item);

                // TODO: ADD THE ROW IN THE INPUT DATA
                this.generatedOutput.Add(tempRow);
                this.rowCount++;
            }
        }
    }
}