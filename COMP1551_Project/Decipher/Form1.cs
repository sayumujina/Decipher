
using System.Windows.Forms.VisualStyles;

namespace Decipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Initialize variables 
        private string inputString; // Input string
        public string InputString
        {
            get => inputString;
            set => inputString = value;
        }
        private int shiftingValue; // How much the value will be shifted
        public int ShiftingValue
        {
            get => shiftingValue;
            set => shiftingValue = value;
        }

        // String processing class
        class StringProcessing
        {
            // Check if the string is not empty, contains 40 characters or less and only has capital letters
            // Check if the number is between -25 and 25 or not
            public static void CheckInput(string InputString, int ShiftingValue)
            {
                // Create a uniform error message
                string ErrorMessage = "Please re-type your input.";

                if (InputString.Length <= 40
                    && InputString.All(char.IsUpper) == true
                    // Counts 51 numbers from -25, which is the range from -25 to 25
                    && Enumerable.Range(-25, 51).Contains(ShiftingValue))
                {
                    MessageBox.Show("The input is valid.");
                }
                else
                {
                    if (InputString.Length > 40)
                    {
                        MessageBox.Show("The input string cannot be longer than 40 characters. " + ErrorMessage);
                    }
                    if (InputString.All(char.IsUpper) == false)
                    {
                        MessageBox.Show("The input string must contain only capital letters. " + ErrorMessage);
                    }
                    if (Enumerable.Range(-25, 51).Contains(ShiftingValue) == false)
                    {
                        MessageBox.Show("The shifting value must be between -25 and 25. " + ErrorMessage);
                    }
                }
            }

            // Encode the input string
            public static string Encode(string InputString, int ShiftingValue)
            {
                // Empty the output string first (in case the function is called multiple times)
                string OutputString = "";
                // Initialize the converted input string array
                int[] ConvertedInputString = {};
                int ConvertIndex = 0;
                // Loop through each value in the input string
                foreach (char c in InputString)
                {
                    // Convert the input string into ASCII values
                    int InputAsciiValue = (int)c;
                    int OutputAsciiValue = InputAsciiValue + ShiftingValue;
                    // Shift the ASCII value based on the input shifting value
                    // If the value exceeds the range of capital letters (65 - 90), loop back to the beginning
                    if (OutputAsciiValue < 65)
                    {
                       OutputAsciiValue += 26; 
                    }
                    else if (OutputAsciiValue > 90)
                    {
                        OutputAsciiValue -= 26;
                    }
                    // Convert the output ASCII value back to a character value and add it to the output string
                    char OutputChar = (char)OutputAsciiValue;
                    ConvertedInputString[ConvertIndex] = OutputAsciiValue;
                    ConvertIndex++;
                    //ConvertedInputString[ConvertIndex] = OutputAsciiValue;
                    OutputString += OutputChar;
                }
                // Set the label text to output string
                return OutputString;
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // Starts listen to the SubmitButton button being clicked
            SubmitButton.Click += (sender, e) => SubmitButton_Click(sender, e);
            OutputLabel.Text = "";
            InputLabel.Text = "";
        }

        private void SubmitButton_Click(object? sender, EventArgs e)
        {
            // Display an error message if the integer field and/ or the input string field is empty
            if (!string.IsNullOrEmpty(IntegerContainer.Text) && !string.IsNullOrEmpty(StringContainer.Text))
            {
                InputString = StringContainer.Text;
                ShiftingValue = Convert.ToInt32(IntegerContainer.Text);
                System.Diagnostics.Debug.WriteLine(Convert.ToChar(90));
            }
            else
            {
                if (string.IsNullOrEmpty(IntegerContainer.Text))
                {
                    MessageBox.Show("Please enter a text");
                }
                if (string.IsNullOrEmpty(StringContainer.Text))
                {
                    MessageBox.Show("Please enter a number");
                }
                // Stops the program if at least one field is empty
                return;
            }
            // Call the checkString function
            StringProcessing.CheckInput(InputString, ShiftingValue);
            // Call the encode function and set the output label to the output string
            OutputLabel.Text = StringProcessing.Encode(InputString, ShiftingValue);
        }
    }
}
