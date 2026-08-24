namespace WindowsFormsApplication1
{
    partial class WeaveDesigner
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
            this.repeatYLabel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.repeatXLabel = new System.Windows.Forms.Label();
            this.repeatYInput = new System.Windows.Forms.NumericUpDown();
            this.repeatXInput = new System.Windows.Forms.NumericUpDown();
            this.insertWeaveButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.yarnSpacingLabel = new System.Windows.Forms.Label();
            this.yarnThicknessLabel = new System.Windows.Forms.Label();
            this.yarnWidthLabel = new System.Windows.Forms.Label();
            this.weftCountLabel = new System.Windows.Forms.Label();
            this.warpCountLabel = new System.Windows.Forms.Label();
            this.yarnSpacingInput = new System.Windows.Forms.NumericUpDown();
            this.yarnThicknessInput = new System.Windows.Forms.NumericUpDown();
            this.yarnWidthInput = new System.Windows.Forms.NumericUpDown();
            this.weftCountInput = new System.Windows.Forms.NumericUpDown();
            this.warpCountInput = new System.Windows.Forms.NumericUpDown();
            this.weaveButton = new System.Windows.Forms.Button();
            this.repeatYLabel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repeatYInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeatXInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yarnSpacingInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yarnThicknessInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yarnWidthInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weftCountInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warpCountInput)).BeginInit();
            this.SuspendLayout();
            // 
            // repeatYLabel
            // 
            this.repeatYLabel.AccessibleName = "";
            this.repeatYLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.repeatYLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.repeatYLabel.Controls.Add(this.label1);
            this.repeatYLabel.Controls.Add(this.repeatXLabel);
            this.repeatYLabel.Controls.Add(this.repeatYInput);
            this.repeatYLabel.Controls.Add(this.repeatXInput);
            this.repeatYLabel.Controls.Add(this.insertWeaveButton);
            this.repeatYLabel.Controls.Add(this.label6);
            this.repeatYLabel.Controls.Add(this.yarnSpacingLabel);
            this.repeatYLabel.Controls.Add(this.yarnThicknessLabel);
            this.repeatYLabel.Controls.Add(this.yarnWidthLabel);
            this.repeatYLabel.Controls.Add(this.weftCountLabel);
            this.repeatYLabel.Controls.Add(this.warpCountLabel);
            this.repeatYLabel.Controls.Add(this.yarnSpacingInput);
            this.repeatYLabel.Controls.Add(this.yarnThicknessInput);
            this.repeatYLabel.Controls.Add(this.yarnWidthInput);
            this.repeatYLabel.Controls.Add(this.weftCountInput);
            this.repeatYLabel.Controls.Add(this.warpCountInput);
            this.repeatYLabel.Controls.Add(this.weaveButton);
            this.repeatYLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.repeatYLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.repeatYLabel.Location = new System.Drawing.Point(446, 0);
            this.repeatYLabel.Name = "repeatYLabel";
            this.repeatYLabel.Size = new System.Drawing.Size(316, 477);
            this.repeatYLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Repeat Y";
            // 
            // repeatXLabel
            // 
            this.repeatXLabel.AutoSize = true;
            this.repeatXLabel.Location = new System.Drawing.Point(30, 306);
            this.repeatXLabel.Name = "repeatXLabel";
            this.repeatXLabel.Size = new System.Drawing.Size(52, 13);
            this.repeatXLabel.TabIndex = 15;
            this.repeatXLabel.Text = "Repeat X";
            // 
            // repeatYInput
            // 
            this.repeatYInput.Location = new System.Drawing.Point(173, 335);
            this.repeatYInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repeatYInput.Name = "repeatYInput";
            this.repeatYInput.Size = new System.Drawing.Size(120, 20);
            this.repeatYInput.TabIndex = 14;
            this.repeatYInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // repeatXInput
            // 
            this.repeatXInput.Location = new System.Drawing.Point(173, 299);
            this.repeatXInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.repeatXInput.Name = "repeatXInput";
            this.repeatXInput.Size = new System.Drawing.Size(120, 20);
            this.repeatXInput.TabIndex = 13;
            this.repeatXInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // insertWeaveButton
            // 
            this.insertWeaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.insertWeaveButton.Location = new System.Drawing.Point(33, 426);
            this.insertWeaveButton.Name = "insertWeaveButton";
            this.insertWeaveButton.Size = new System.Drawing.Size(260, 34);
            this.insertWeaveButton.TabIndex = 12;
            this.insertWeaveButton.Text = "Insert";
            this.insertWeaveButton.UseVisualStyleBackColor = true;
            this.insertWeaveButton.Click += new System.EventHandler(this.insertWeaveButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Weave Designer";
            // 
            // yarnSpacingLabel
            // 
            this.yarnSpacingLabel.AutoSize = true;
            this.yarnSpacingLabel.Location = new System.Drawing.Point(30, 244);
            this.yarnSpacingLabel.Name = "yarnSpacingLabel";
            this.yarnSpacingLabel.Size = new System.Drawing.Size(94, 13);
            this.yarnSpacingLabel.TabIndex = 10;
            this.yarnSpacingLabel.Text = "Yarn spacing (mm)";
            // 
            // yarnThicknessLabel
            // 
            this.yarnThicknessLabel.AutoSize = true;
            this.yarnThicknessLabel.Location = new System.Drawing.Point(30, 208);
            this.yarnThicknessLabel.Name = "yarnThicknessLabel";
            this.yarnThicknessLabel.Size = new System.Drawing.Size(102, 13);
            this.yarnThicknessLabel.TabIndex = 9;
            this.yarnThicknessLabel.Text = "Yarn thickness (mm)";
            // 
            // yarnWidthLabel
            // 
            this.yarnWidthLabel.AutoSize = true;
            this.yarnWidthLabel.Location = new System.Drawing.Point(30, 171);
            this.yarnWidthLabel.Name = "yarnWidthLabel";
            this.yarnWidthLabel.Size = new System.Drawing.Size(82, 13);
            this.yarnWidthLabel.TabIndex = 8;
            this.yarnWidthLabel.Text = "Yarn width (mm)";
            // 
            // weftCountLabel
            // 
            this.weftCountLabel.AutoSize = true;
            this.weftCountLabel.Location = new System.Drawing.Point(30, 113);
            this.weftCountLabel.Name = "weftCountLabel";
            this.weftCountLabel.Size = new System.Drawing.Size(60, 13);
            this.weftCountLabel.TabIndex = 7;
            this.weftCountLabel.Text = "Weft count";
            // 
            // warpCountLabel
            // 
            this.warpCountLabel.AutoSize = true;
            this.warpCountLabel.Location = new System.Drawing.Point(30, 76);
            this.warpCountLabel.Name = "warpCountLabel";
            this.warpCountLabel.Size = new System.Drawing.Size(63, 13);
            this.warpCountLabel.TabIndex = 6;
            this.warpCountLabel.Text = "Warp count";
            // 
            // yarnSpacingInput
            // 
            this.yarnSpacingInput.DecimalPlaces = 1;
            this.yarnSpacingInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.yarnSpacingInput.Location = new System.Drawing.Point(173, 237);
            this.yarnSpacingInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yarnSpacingInput.Name = "yarnSpacingInput";
            this.yarnSpacingInput.Size = new System.Drawing.Size(120, 20);
            this.yarnSpacingInput.TabIndex = 5;
            this.yarnSpacingInput.Value = new decimal(new int[] {
            70,
            0,
            0,
            0});
            // 
            // yarnThicknessInput
            // 
            this.yarnThicknessInput.DecimalPlaces = 1;
            this.yarnThicknessInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.yarnThicknessInput.Location = new System.Drawing.Point(173, 201);
            this.yarnThicknessInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yarnThicknessInput.Name = "yarnThicknessInput";
            this.yarnThicknessInput.Size = new System.Drawing.Size(120, 20);
            this.yarnThicknessInput.TabIndex = 4;
            this.yarnThicknessInput.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // yarnWidthInput
            // 
            this.yarnWidthInput.DecimalPlaces = 1;
            this.yarnWidthInput.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.yarnWidthInput.Location = new System.Drawing.Point(173, 164);
            this.yarnWidthInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.yarnWidthInput.Name = "yarnWidthInput";
            this.yarnWidthInput.Size = new System.Drawing.Size(120, 20);
            this.yarnWidthInput.TabIndex = 3;
            this.yarnWidthInput.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // weftCountInput
            // 
            this.weftCountInput.Location = new System.Drawing.Point(173, 106);
            this.weftCountInput.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.weftCountInput.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.weftCountInput.Name = "weftCountInput";
            this.weftCountInput.Size = new System.Drawing.Size(120, 20);
            this.weftCountInput.TabIndex = 2;
            this.weftCountInput.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // warpCountInput
            // 
            this.warpCountInput.Location = new System.Drawing.Point(173, 69);
            this.warpCountInput.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.warpCountInput.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.warpCountInput.Name = "warpCountInput";
            this.warpCountInput.Size = new System.Drawing.Size(120, 20);
            this.warpCountInput.TabIndex = 1;
            this.warpCountInput.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // weaveButton
            // 
            this.weaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.weaveButton.Location = new System.Drawing.Point(33, 386);
            this.weaveButton.Name = "weaveButton";
            this.weaveButton.Size = new System.Drawing.Size(260, 34);
            this.weaveButton.TabIndex = 0;
            this.weaveButton.Text = "Weave";
            this.weaveButton.UseVisualStyleBackColor = true;
            this.weaveButton.Click += new System.EventHandler(this.weaveButton_Click);
            // 
            // WeaveDesigner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 477);
            this.Controls.Add(this.repeatYLabel);
            this.Name = "WeaveDesigner";
            this.Text = "Weave Maker";
            this.repeatYLabel.ResumeLayout(false);
            this.repeatYLabel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repeatYInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repeatXInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yarnSpacingInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yarnThicknessInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yarnWidthInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weftCountInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warpCountInput)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel repeatYLabel;
        private System.Windows.Forms.NumericUpDown yarnWidthInput;
        private System.Windows.Forms.NumericUpDown weftCountInput;
        private System.Windows.Forms.NumericUpDown warpCountInput;
        private System.Windows.Forms.Button weaveButton;
        private System.Windows.Forms.NumericUpDown yarnSpacingInput;
        private System.Windows.Forms.NumericUpDown yarnThicknessInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label yarnSpacingLabel;
        private System.Windows.Forms.Label yarnThicknessLabel;
        private System.Windows.Forms.Label yarnWidthLabel;
        private System.Windows.Forms.Label weftCountLabel;
        private System.Windows.Forms.Label warpCountLabel;
        private System.Windows.Forms.Button insertWeaveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label repeatXLabel;
        private System.Windows.Forms.NumericUpDown repeatYInput;
        private System.Windows.Forms.NumericUpDown repeatXInput;
    }
}

