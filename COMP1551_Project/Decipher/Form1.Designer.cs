namespace Decipher
{
    partial class DecipherForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            StringContainer = new TextBox();
            IntegerContainer = new TextBox();
            StringLabel = new Label();
            IntegerLabel = new Label();
            SubmitButton = new Button();
            OutputLabel = new Label();
            InputAsciiLabel = new Label();
            OutputAsciiLabel = new Label();
            SortedStringLabel = new Label();
            SubmitLabel = new Label();
            StringErrorLabel = new Label();
            IntegerErrorLabel = new Label();
            SuspendLayout();
            // 
            // StringContainer
            // 
            StringContainer.Location = new Point(515, 6);
            StringContainer.Name = "StringContainer";
            StringContainer.PlaceholderText = "Capital letters only, maximum 40 letters...";
            StringContainer.Size = new Size(435, 27);
            StringContainer.TabIndex = 0;
            // 
            // IntegerContainer
            // 
            IntegerContainer.Location = new Point(515, 45);
            IntegerContainer.Name = "IntegerContainer";
            IntegerContainer.PlaceholderText = "Integer range [-25, 25]";
            IntegerContainer.Size = new Size(435, 27);
            IntegerContainer.TabIndex = 1;
            // 
            // StringLabel
            // 
            StringLabel.AutoSize = true;
            StringLabel.Location = new Point(395, 9);
            StringLabel.Name = "StringLabel";
            StringLabel.Size = new Size(114, 20);
            StringLabel.TabIndex = 2;
            StringLabel.Text = "Type string here";
            // 
            // IntegerLabel
            // 
            IntegerLabel.AutoSize = true;
            IntegerLabel.Location = new Point(381, 48);
            IntegerLabel.Name = "IntegerLabel";
            IntegerLabel.Size = new Size(128, 20);
            IntegerLabel.TabIndex = 3;
            IntegerLabel.Text = "Type number here";
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(685, 78);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(94, 29);
            SubmitButton.TabIndex = 4;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            // 
            // OutputLabel
            // 
            OutputLabel.Anchor = AnchorStyles.None;
            OutputLabel.Location = new Point(371, 136);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(717, 20);
            OutputLabel.TabIndex = 5;
            OutputLabel.Text = "Output Code";
            OutputLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InputAsciiLabel
            // 
            InputAsciiLabel.Anchor = AnchorStyles.None;
            InputAsciiLabel.Location = new Point(357, 112);
            InputAsciiLabel.Name = "InputAsciiLabel";
            InputAsciiLabel.Size = new Size(738, 20);
            InputAsciiLabel.TabIndex = 6;
            InputAsciiLabel.Text = "Input Code";
            InputAsciiLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OutputAsciiLabel
            // 
            OutputAsciiLabel.Anchor = AnchorStyles.None;
            OutputAsciiLabel.Location = new Point(371, 160);
            OutputAsciiLabel.Name = "OutputAsciiLabel";
            OutputAsciiLabel.Size = new Size(717, 20);
            OutputAsciiLabel.TabIndex = 7;
            OutputAsciiLabel.Text = "Output Code";
            OutputAsciiLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SortedStringLabel
            // 
            SortedStringLabel.Anchor = AnchorStyles.None;
            SortedStringLabel.Location = new Point(370, 184);
            SortedStringLabel.Name = "SortedStringLabel";
            SortedStringLabel.Size = new Size(717, 20);
            SortedStringLabel.TabIndex = 8;
            SortedStringLabel.Text = "Sorted String";
            SortedStringLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SubmitLabel
            // 
            SubmitLabel.Anchor = AnchorStyles.None;
            SubmitLabel.ImageAlign = ContentAlignment.MiddleLeft;
            SubmitLabel.Location = new Point(785, 82);
            SubmitLabel.Name = "SubmitLabel";
            SubmitLabel.Size = new Size(465, 20);
            SubmitLabel.TabIndex = 9;
            SubmitLabel.Text = "Success or Not?";
            SubmitLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // StringErrorLabel
            // 
            StringErrorLabel.Anchor = AnchorStyles.None;
            StringErrorLabel.ImageAlign = ContentAlignment.MiddleLeft;
            StringErrorLabel.Location = new Point(956, 9);
            StringErrorLabel.Name = "StringErrorLabel";
            StringErrorLabel.Size = new Size(433, 20);
            StringErrorLabel.TabIndex = 10;
            StringErrorLabel.Text = "Error message?";
            StringErrorLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // IntegerErrorLabel
            // 
            IntegerErrorLabel.Anchor = AnchorStyles.None;
            IntegerErrorLabel.ImageAlign = ContentAlignment.MiddleLeft;
            IntegerErrorLabel.Location = new Point(956, 48);
            IntegerErrorLabel.Name = "IntegerErrorLabel";
            IntegerErrorLabel.Size = new Size(433, 20);
            IntegerErrorLabel.TabIndex = 11;
            IntegerErrorLabel.Text = "Error message?";
            IntegerErrorLabel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // DecipherForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1401, 450);
            Controls.Add(IntegerErrorLabel);
            Controls.Add(StringErrorLabel);
            Controls.Add(SubmitLabel);
            Controls.Add(SortedStringLabel);
            Controls.Add(OutputAsciiLabel);
            Controls.Add(InputAsciiLabel);
            Controls.Add(OutputLabel);
            Controls.Add(SubmitButton);
            Controls.Add(IntegerLabel);
            Controls.Add(StringLabel);
            Controls.Add(IntegerContainer);
            Controls.Add(StringContainer);
            Name = "DecipherForm";
            Text = "DecipherForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox StringContainer;
        private TextBox IntegerContainer;
        private Label StringLabel;
        private Label IntegerLabel;
        private Button SubmitButton;
        private Label OutputLabel;
        private Label InputAsciiLabel;
        private Label OutputAsciiLabel;
        private Label SortedStringLabel;
        private Label SubmitLabel;
        private Label StringErrorLabel;
        private Label IntegerErrorLabel;
    }
}
