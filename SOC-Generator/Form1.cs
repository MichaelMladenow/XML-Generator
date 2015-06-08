namespace SOC_Generator
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using SOC_Generator.Generators.ClassModels;

    public partial class Generator : Form
    {
        private const char Delimiter = '\t';
        private SaveFileDialog outputPathDialog = new SaveFileDialog();
        private Stream readStream;
        private bool fileSelected = false;

        public Generator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Parses attributes from string array[] for xml conversion
        /// </summary>
        /// <param name="textData">String array, holding each data line</param>
        /// <returns>Returns a collection of string kv pairs, or empty collection
        /// if nothing was parsed. Each element from the list represents the data
        /// for one xml tag element.</returns>
        private List<Dictionary<string, string>> parseXmlAttributes(string[] textData)
        {
            string[] attributeNames = textData[0].Split(Delimiter);
            List<Dictionary<string, string>> outputData = new List<Dictionary<string, string>>();
            foreach (var dataRow in textData)
            {
                string[] currentTagData = dataRow.Split(Delimiter);
                Dictionary<string, string> currentTagAttributes = new Dictionary<string, string>();
                for (int i = 0; i < currentTagData.Length; i++)
                {
                    currentTagAttributes[attributeNames[i]] = currentTagData[i];
                }
            }
            return outputData;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            // Make sure something is selected from the comboBox
            if (lstPresets.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a preset.", "Select something you moron Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lstPresets.Focus();
            }
            else
            {
                switch (lstPresets.SelectedItem.ToString())
                {
                    /* Possible values for the comboBox:
                     * Rows
                     * Image Rows
                     * Choices
                     * Columns
                     * Looprows
                     * Hotspot row
                     * Hotspot Toggle rows
                     */
                    case "Rows":
                        // TODO: Generate the rows finally :D
                        txtDebug.Text += "Preset = row" + Environment.NewLine;

                        // TODO: fix populating this, either from file or the input tb
                        List<Dictionary<string, string>> rawData = new List<Dictionary<string, string>>();
                        // TODO: Prepare data for the rowGenerator constructor
                        // RowGenerator rowGenerator = new RowGenerator();
                        break;
                    case "Image Rows":
                        txtDebug.Text += "Preset = image row" + Environment.NewLine;
                        break;
                    default:
                        MessageBox.Show("Please select a valid preset.", "Preset Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }

            // TODO: Prepare output
            // TODO: check what we're generating :D


            // TODO: Write stream to file
            // this.writeStream.Close();

            // TODO: Notify for completion of operation
        }

        private void buttonFileBrowser_Click(object sender, EventArgs e)
        {
            // TODO: Extract this functionality so we don't polute the form class
            /* file browser dialog settings */
            this.outputPathDialog.FileName = "output.txt";
            this.outputPathDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            this.outputPathDialog.FilterIndex = 2;
            /* file browser dialog settings end */

            if (this.outputPathDialog.ShowDialog() == DialogResult.OK)
            {
                if ((this.readStream = this.outputPathDialog.OpenFile()) != null)
                {
                    txtDebug.Text = "Successfully loaded file! :)" + Environment.NewLine;
                    fileSelected = true;
                }

                else
                {
                    fileSelected = false;
                    throw new FileLoadException("Unable to load file :(");
                }
            }
        }
    }
}