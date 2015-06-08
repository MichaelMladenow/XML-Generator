namespace SOC_Generator.Generators.ClassModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using SOC_Generator.Generators.ClassModels.xmlModels;

    abstract class GeneratorBase
    {
        protected string xmlTagName = string.Empty;

        public abstract void Generate(List<Dictionary<string, string>> generationData);
    }
}