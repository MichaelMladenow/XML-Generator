namespace SOC_Generator
{
    partial class Generator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstPresets = new System.Windows.Forms.ComboBox();
            this.labelPresetSelector = new System.Windows.Forms.Label();
            this.inputContainer = new System.Windows.Forms.TextBox();
            this.presetsPanel = new System.Windows.Forms.Panel();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonFileBrowser = new System.Windows.Forms.Button();
            this.inputLabel = new System.Windows.Forms.Label();
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.presetsPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstPresets
            // 
            this.lstPresets.FormattingEnabled = true;
            this.lstPresets.Items.AddRange(new object[] {
            "Rows",
            "Image Rows",
            "Choices",
            "Columns",
            "Looprows",
            "Hotspot row",
            "Hotspot Toggle rows"});
            this.lstPresets.Location = new System.Drawing.Point(12, 32);
            this.lstPresets.Name = "lstPresets";
            this.lstPresets.Size = new System.Drawing.Size(179, 21);
            this.lstPresets.TabIndex = 0;
            // 
            // labelPresetSelector
            // 
            this.labelPresetSelector.AutoSize = true;
            this.labelPresetSelector.Location = new System.Drawing.Point(9, 16);
            this.labelPresetSelector.Name = "labelPresetSelector";
            this.labelPresetSelector.Size = new System.Drawing.Size(145, 13);
            this.labelPresetSelector.TabIndex = 1;
            this.labelPresetSelector.Text = "Please select a preset below:";
            // 
            // inputContainer
            // 
            this.inputContainer.Location = new System.Drawing.Point(45, 62);
            this.inputContainer.Multiline = true;
            this.inputContainer.Name = "inputContainer";
            this.inputContainer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputContainer.Size = new System.Drawing.Size(485, 288);
            this.inputContainer.TabIndex = 2;
            // 
            // presetsPanel
            // 
            this.presetsPanel.Controls.Add(this.lstPresets);
            this.presetsPanel.Controls.Add(this.labelPresetSelector);
            this.presetsPanel.Location = new System.Drawing.Point(12, 12);
            this.presetsPanel.Name = "presetsPanel";
            this.presetsPanel.Size = new System.Drawing.Size(257, 89);
            this.presetsPanel.TabIndex = 3;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(44, 394);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(484, 32);
            this.buttonGenerate.TabIndex = 4;
            this.buttonGenerate.Text = "Generate!";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonFileBrowser);
            this.panel1.Controls.Add(this.inputLabel);
            this.panel1.Controls.Add(this.inputContainer);
            this.panel1.Controls.Add(this.buttonGenerate);
            this.panel1.Location = new System.Drawing.Point(275, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 450);
            this.panel1.TabIndex = 5;
            // 
            // buttonFileBrowser
            // 
            this.buttonFileBrowser.Location = new System.Drawing.Point(45, 356);
            this.buttonFileBrowser.Name = "buttonFileBrowser";
            this.buttonFileBrowser.Size = new System.Drawing.Size(216, 32);
            this.buttonFileBrowser.TabIndex = 6;
            this.buttonFileBrowser.Text = "Select file:";
            this.buttonFileBrowser.UseVisualStyleBackColor = true;
            this.buttonFileBrowser.Click += new System.EventHandler(this.buttonFileBrowser_Click);
            // 
            // inputLabel
            // 
            this.inputLabel.AutoSize = true;
            this.inputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputLabel.Location = new System.Drawing.Point(42, 23);
            this.inputLabel.Name = "inputLabel";
            this.inputLabel.Size = new System.Drawing.Size(294, 18);
            this.inputLabel.TabIndex = 5;
            this.inputLabel.Text = "Select values from file or paste them below:";
            // 
            // txtDebug
            // 
            this.txtDebug.Location = new System.Drawing.Point(12, 117);
            this.txtDebug.Multiline = true;
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.Size = new System.Drawing.Size(257, 320);
            this.txtDebug.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "The first line must hold the attribute names.";
            // 
            // Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 501);
            this.Controls.Add(this.txtDebug);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.presetsPanel);
            this.Name = "Generator";
            this.Text = "SOC Generator";
            this.presetsPanel.ResumeLayout(false);
            this.presetsPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lstPresets;
        private System.Windows.Forms.Label labelPresetSelector;
        private System.Windows.Forms.TextBox inputContainer;
        private System.Windows.Forms.Panel presetsPanel;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label inputLabel;
        private System.Windows.Forms.Button buttonFileBrowser;
        private System.Windows.Forms.TextBox txtDebug;
        private System.Windows.Forms.Label label1;
    }
}