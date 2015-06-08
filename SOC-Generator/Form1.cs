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
        private OpenFileDialog outputPathDialog = new OpenFileDialog();
        private Stream readStream;
        private bool fileSelected = false;
        private StreamReader reader;

        public Generator()
        {
            InitializeComponent();
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

                MessageBox.Show(fileSelected ? "File selected" : "Using input box");
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
                        if (fileSelected)
                        {
                            using (reader = new StreamReader(readStream))
                            {
                                rawData = FormatFactory.parseXmlAttributes(FormatFactory.streamReaderToList(reader), Delimiter);
                            }
                        }
                        else
                        {
                            // TODO: OGM
                            rawData = FormatFactory.parseXmlAttributes(new List<string>(
                                             txtInput.Text.Split(new string[] { "\r\n", "\n" },
                                             StringSplitOptions.None)), Delimiter);
                        }

                        foreach (var rowDictData in rawData)
                        {

                            txtDebug.Text += "*********" + Environment.NewLine;
                            foreach (KeyValuePair<string, string> kvp in rowDictData)
                            {
                                txtDebug.Text += string.Format("Name = {0}, Value = {1}" + Environment.NewLine, kvp.Key, kvp.Value);
                            }
                        }


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