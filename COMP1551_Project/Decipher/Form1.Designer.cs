namespace Decipher
{
    partial class Form1
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
            InputLabel = new Label();
            SuspendLayout();
            // 
            // StringContainer
            // 
            StringContainer.Location = new Point(368, 12);
            StringContainer.Name = "StringContainer";
            StringContainer.Size = new Size(125, 27);
            StringContainer.TabIndex = 0;
            // 
            // IntegerContainer
            // 
            IntegerContainer.Location = new Point(368, 45);
            IntegerContainer.Name = "IntegerContainer";
            IntegerContainer.Size = new Size(125, 27);
            IntegerContainer.TabIndex = 1;
            // 
            // StringLabel
            // 
            StringLabel.AutoSize = true;
            StringLabel.Location = new Point(248, 15);
            StringLabel.Name = "StringLabel";
            StringLabel.Size = new Size(114, 20);
            StringLabel.TabIndex = 2;
            StringLabel.Text = "Type string here";
            // 
            // IntegerLabel
            // 
            IntegerLabel.AutoSize = true;
            IntegerLabel.Location = new Point(234, 48);
            IntegerLabel.Name = "IntegerLabel";
            IntegerLabel.Size = new Size(128, 20);
            IntegerLabel.TabIndex = 3;
            IntegerLabel.Text = "Type number here";
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(385, 78);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(94, 29);
            SubmitButton.TabIndex = 4;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            // 
            // OutputLabel
            // 
            OutputLabel.Anchor = AnchorStyles.None;
            OutputLabel.AutoSize = true;
            OutputLabel.Location = new Point(384, 136);
            OutputLabel.Name = "OutputLabel";
            OutputLabel.Size = new Size(94, 20);
            OutputLabel.TabIndex = 5;
            OutputLabel.Text = "Output Code";
            // 
            // InputLabel
            // 
            InputLabel.Anchor = AnchorStyles.None;
            InputLabel.AutoSize = true;
            InputLabel.Location = new Point(384, 112);
            InputLabel.Name = "InputLabel";
            InputLabel.Size = new Size(82, 20);
            InputLabel.TabIndex = 6;
            InputLabel.Text = "Input Code";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(InputLabel);
            Controls.Add(OutputLabel);
            Controls.Add(SubmitButton);
            Controls.Add(IntegerLabel);
            Controls.Add(StringLabel);
            Controls.Add(IntegerContainer);
            Controls.Add(StringContainer);
            Name = "Form1";
            Text = "Form1";
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
        private Label InputLabel;
    }
}
