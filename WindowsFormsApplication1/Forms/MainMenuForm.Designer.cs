namespace WindowsFormsApplication1
{
    partial class MainMenu
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
            this.newWeaveButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearWeaveButton = new System.Windows.Forms.Button();
            this.weaveViewer = new System.Windows.Forms.PictureBox();
            this.plotPropertiesPanel = new System.Windows.Forms.Panel();
            this.input4 = new System.Windows.Forms.NumericUpDown();
            this.inputLabel4 = new System.Windows.Forms.Label();
            this.inputLabel2 = new System.Windows.Forms.Label();
            this.input3 = new System.Windows.Forms.NumericUpDown();
            this.input2 = new System.Windows.Forms.NumericUpDown();
            this.inputLabel3 = new System.Windows.Forms.Label();
            this.inputLabel1 = new System.Windows.Forms.Label();
            this.input1 = new System.Windows.Forms.NumericUpDown();
            this.plotInputPanelHeader = new System.Windows.Forms.Label();
            this.plotTypeLabel = new System.Windows.Forms.Label();
            this.plotButton = new System.Windows.Forms.Button();
            this.plotTypesComboBox = new System.Windows.Forms.ComboBox();
            this.plotViewer = new System.Windows.Forms.PictureBox();
            this.weavePropertiesButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weaveViewer)).BeginInit();
            this.plotPropertiesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.input1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plotViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // newWeaveButton
            // 
            this.newWeaveButton.Location = new System.Drawing.Point(11, 14);
            this.newWeaveButton.Name = "newWeaveButton";
            this.newWeaveButton.Size = new System.Drawing.Size(105, 23);
            this.newWeaveButton.TabIndex = 0;
            this.newWeaveButton.Text = "New Weave";
            this.newWeaveButton.UseVisualStyleBackColor = true;
            this.newWeaveButton.Click += new System.EventHandler(this.newWeaveButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.weavePropertiesButton);
            this.panel1.Controls.Add(this.clearWeaveButton);
            this.panel1.Controls.Add(this.newWeaveButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 477);
            this.panel1.TabIndex = 1;
            // 
            // clearWeaveButton
            // 
            this.clearWeaveButton.Location = new System.Drawing.Point(11, 43);
            this.clearWeaveButton.Name = "clearWeaveButton";
            this.clearWeaveButton.Size = new System.Drawing.Size(105, 23);
            this.clearWeaveButton.TabIndex = 1;
            this.clearWeaveButton.Text = "Clear Weave";
            this.clearWeaveButton.UseVisualStyleBackColor = true;
            this.clearWeaveButton.Click += new System.EventHandler(this.clearWeaveButton_Click);
            // 
            // weaveViewer
            // 
            this.weaveViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weaveViewer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.weaveViewer.Location = new System.Drawing.Point(133, 371);
            this.weaveViewer.Name = "weaveViewer";
            this.weaveViewer.Size = new System.Drawing.Size(395, 106);
            this.weaveViewer.TabIndex = 4;
            this.weaveViewer.TabStop = false;
            // 
            // plotPropertiesPanel
            // 
            this.plotPropertiesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plotPropertiesPanel.Controls.Add(this.input4);
            this.plotPropertiesPanel.Controls.Add(this.inputLabel4);
            this.plotPropertiesPanel.Controls.Add(this.inputLabel2);
            this.plotPropertiesPanel.Controls.Add(this.input3);
            this.plotPropertiesPanel.Controls.Add(this.input2);
            this.plotPropertiesPanel.Controls.Add(this.inputLabel3);
            this.plotPropertiesPanel.Controls.Add(this.inputLabel1);
            this.plotPropertiesPanel.Controls.Add(this.input1);
            this.plotPropertiesPanel.Controls.Add(this.plotInputPanelHeader);
            this.plotPropertiesPanel.Controls.Add(this.plotTypeLabel);
            this.plotPropertiesPanel.Controls.Add(this.plotButton);
            this.plotPropertiesPanel.Controls.Add(this.plotTypesComboBox);
            this.plotPropertiesPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.plotPropertiesPanel.Location = new System.Drawing.Point(528, 0);
            this.plotPropertiesPanel.Name = "plotPropertiesPanel";
            this.plotPropertiesPanel.Size = new System.Drawing.Size(321, 477);
            this.plotPropertiesPanel.TabIndex = 2;
            // 
            // input4
            // 
            this.input4.DecimalPlaces = 5;
            this.input4.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.input4.Location = new System.Drawing.Point(196, 311);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(112, 20);
            this.input4.TabIndex = 20;
            // 
            // inputLabel4
            // 
            this.inputLabel4.AutoSize = true;
            this.inputLabel4.Location = new System.Drawing.Point(14, 318);
            this.inputLabel4.Name = "inputLabel4";
            this.inputLabel4.Size = new System.Drawing.Size(43, 13);
            this.inputLabel4.TabIndex = 19;
            this.inputLabel4.Text = "Strain 2";
            // 
            // inputLabel2
            // 
            this.inputLabel2.AutoSize = true;
            this.inputLabel2.Location = new System.Drawing.Point(14, 223);
            this.inputLabel2.Name = "inputLabel2";
            this.inputLabel2.Size = new System.Drawing.Size(43, 13);
            this.inputLabel2.TabIndex = 18;
            this.inputLabel2.Text = "Strain 1";
            // 
            // input3
            // 
            this.input3.DecimalPlaces = 5;
            this.input3.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.input3.Location = new System.Drawing.Point(196, 279);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(112, 20);
            this.input3.TabIndex = 17;
            // 
            // input2
            // 
            this.input2.DecimalPlaces = 5;
            this.input2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.input2.Location = new System.Drawing.Point(196, 216);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(112, 20);
            this.input2.TabIndex = 16;
            // 
            // inputLabel3
            // 
            this.inputLabel3.AutoSize = true;
            this.inputLabel3.Location = new System.Drawing.Point(14, 286);
            this.inputLabel3.Name = "inputLabel3";
            this.inputLabel3.Size = new System.Drawing.Size(45, 13);
            this.inputLabel3.TabIndex = 15;
            this.inputLabel3.Text = "Stress 2";
            // 
            // inputLabel1
            // 
            this.inputLabel1.AutoSize = true;
            this.inputLabel1.Location = new System.Drawing.Point(14, 191);
            this.inputLabel1.Name = "inputLabel1";
            this.inputLabel1.Size = new System.Drawing.Size(45, 13);
            this.inputLabel1.TabIndex = 14;
            this.inputLabel1.Text = "Stress 1";
            // 
            // input1
            // 
            this.input1.DecimalPlaces = 5;
            this.input1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.input1.Location = new System.Drawing.Point(196, 184);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(112, 20);
            this.input1.TabIndex = 13;
            // 
            // plotInputPanelHeader
            // 
            this.plotInputPanelHeader.AutoSize = true;
            this.plotInputPanelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plotInputPanelHeader.Location = new System.Drawing.Point(71, 14);
            this.plotInputPanelHeader.Name = "plotInputPanelHeader";
            this.plotInputPanelHeader.Size = new System.Drawing.Size(154, 31);
            this.plotInputPanelHeader.TabIndex = 12;
            this.plotInputPanelHeader.Text = "Plot Inputs";
            // 
            // plotTypeLabel
            // 
            this.plotTypeLabel.AutoSize = true;
            this.plotTypeLabel.Location = new System.Drawing.Point(14, 93);
            this.plotTypeLabel.Name = "plotTypeLabel";
            this.plotTypeLabel.Size = new System.Drawing.Size(67, 13);
            this.plotTypeLabel.TabIndex = 5;
            this.plotTypeLabel.Text = "Select a Plot";
            // 
            // plotButton
            // 
            this.plotButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.plotButton.Location = new System.Drawing.Point(17, 434);
            this.plotButton.Name = "plotButton";
            this.plotButton.Size = new System.Drawing.Size(291, 30);
            this.plotButton.TabIndex = 4;
            this.plotButton.Text = "Plot";
            this.plotButton.UseVisualStyleBackColor = true;
            this.plotButton.Click += new System.EventHandler(this.plotButton_Click);
            // 
            // plotTypesComboBox
            // 
            this.plotTypesComboBox.DisplayMember = "iii";
            this.plotTypesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.plotTypesComboBox.FormattingEnabled = true;
            this.plotTypesComboBox.Items.AddRange(new object[] {
            "Stress-Strain Curve",
            "Bending Moment-Curvature Curve",
            "Shear Stiffness Curve",
            "Drape 2D"});
            this.plotTypesComboBox.Location = new System.Drawing.Point(17, 119);
            this.plotTypesComboBox.Name = "plotTypesComboBox";
            this.plotTypesComboBox.Size = new System.Drawing.Size(291, 21);
            this.plotTypesComboBox.TabIndex = 3;
            this.plotTypesComboBox.Tag = "";
            this.plotTypesComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // plotViewer
            // 
            this.plotViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.plotViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotViewer.Location = new System.Drawing.Point(133, 0);
            this.plotViewer.Name = "plotViewer";
            this.plotViewer.Size = new System.Drawing.Size(395, 371);
            this.plotViewer.TabIndex = 5;
            this.plotViewer.TabStop = false;
            // 
            // weavePropertiesButton
            // 
            this.weavePropertiesButton.Location = new System.Drawing.Point(11, 72);
            this.weavePropertiesButton.Name = "weavePropertiesButton";
            this.weavePropertiesButton.Size = new System.Drawing.Size(105, 23);
            this.weavePropertiesButton.TabIndex = 2;
            this.weavePropertiesButton.Text = "Weave Properties";
            this.weavePropertiesButton.UseVisualStyleBackColor = true;
            this.weavePropertiesButton.Click += new System.EventHandler(this.weavePropertiesButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 477);
            this.Controls.Add(this.plotViewer);
            this.Controls.Add(this.weaveViewer);
            this.Controls.Add(this.plotPropertiesPanel);
            this.Controls.Add(this.panel1);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.weaveViewer)).EndInit();
            this.plotPropertiesPanel.ResumeLayout(false);
            this.plotPropertiesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.input4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.input1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plotViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button newWeaveButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel plotPropertiesPanel;
        private System.Windows.Forms.ComboBox plotTypesComboBox;
        private System.Windows.Forms.Button plotButton;
        private System.Windows.Forms.PictureBox weaveViewer;
        private System.Windows.Forms.Label plotTypeLabel;
        private System.Windows.Forms.PictureBox plotViewer;
        private System.Windows.Forms.Label plotInputPanelHeader;
        private System.Windows.Forms.NumericUpDown input1;
        private System.Windows.Forms.NumericUpDown input4;
        private System.Windows.Forms.Label inputLabel4;
        private System.Windows.Forms.Label inputLabel2;
        private System.Windows.Forms.NumericUpDown input3;
        private System.Windows.Forms.NumericUpDown input2;
        private System.Windows.Forms.Label inputLabel3;
        private System.Windows.Forms.Label inputLabel1;
        private System.Windows.Forms.Button clearWeaveButton;
        private System.Windows.Forms.Button weavePropertiesButton;
    }
}