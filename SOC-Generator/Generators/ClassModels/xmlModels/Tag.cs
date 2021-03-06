﻿namespace SOC_Generator.Generators.ClassModels.xmlModels
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Tag
    {
        private const string TagRepresentFormat = "<{0} {1}>{2}</{0}>";
        private const string AttributeRepresentFormat = " {0}=\"{1}\"";
        private string tagName;
        private string content;
        private Dictionary<string, string> attributes = new Dictionary<string, string>();

        public Tag(string tagXMLName, Dictionary<string, string> tagAttributes, string contentData = "")
        {
            this.TagName = tagXMLName;
            this.Content = contentData;
            foreach (KeyValuePair<string, string> attribute in tagAttributes)
            {

                this.Attributes[attribute.Key.Trim()] = attribute.Value.Trim();
            }
        }

        public string TagName
        {
            get
            {
                return this.tagName;
            }

            set
            {
                // TODO: Validate tagname
                this.tagName = value;
            }
        }

        public string Content
        {
            get
            {
                return this.content;
            }

            set
            {
                this.content = value;
            }
        }

        public Dictionary<string, string> Attributes
        {
            get
            {
                return this.attributes;
            }

            protected set
            {
                // TODO: Validate attribs
                this.attributes = value;
            }
        }

        public override string ToString()
        {
            StringBuilder attributesLine = new StringBuilder();

            if (this.Attributes.Count > 0)
            {
                foreach (KeyValuePair<string, string> entry in this.Attributes)
                {
                    if (entry.Key.Trim().ToLower() != "content")
                    {
                        attributesLine.AppendFormat(AttributeRepresentFormat, entry.Key, entry.Value);
                    }
                }
            }

            return string.Format(TagRepresentFormat, this.TagName, attributesLine.ToString(), this.Content);
        }

    }
}