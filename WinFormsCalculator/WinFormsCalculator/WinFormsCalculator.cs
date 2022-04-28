namespace WinFormsCalculator
{
    /// <summary>
    /// This is my Calculator app I created to explore WinForms.
    /// </summary>
    public partial class CalculatorBase : Form
    {
        #region Constructor
        /// <summary>
        /// Default Constructor
        /// </summary>
        public CalculatorBase()
        {
            InitializeComponent();
        }
        #endregion

        #region Clear and Backspace Methods
        /// <summary>
        /// Clears all text from text box.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event.</param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            this.NumberInput.Text = String.Empty;

            FocusInput();
        }

        /// <summary>
        /// Deletes a character from the text box, functions the same as
        ///     using the delete key.
        /// </summary>
        /// <param name="sender">Event sender is here.</param>
        /// <param name="e">Event is here.</param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteTextFunction();

            FocusInput();
        }
        #endregion

        #region Operator Methods
        /// <summary>
        /// These methods insert values into the text box and refocuses the
        ///     text box.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event.</param>
        private void DivideButton_Click(object sender, EventArgs e)
        {
            InsertTextFunction(" / ");
            FocusInput();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            InsertTextFunction(" * ");
            FocusInput();
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            InsertTextFunction(" - ");
            FocusInput();
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            InsertTextFunction(" + ");
            FocusInput();
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {
            CalculateTotal();
            FocusInput();
        }
        #endregion

        #region Number Methods
        /// <summary>
        /// Number Methods: These methods all deal with entering values into
        ///     the text box when clicked and refocusing the text box.
        /// </summary>
        /// <param name="sender">Event sender enters here.</param>
        /// <param name="e">The Event triggered goes here.</param>
        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertTextFunction("7");
            FocusInput();
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertTextFunction("8");
            FocusInput();
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            InsertTextFunction("9");
            FocusInput();
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            InsertTextFunction("4");
            FocusInput();
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextFunction("5");
            FocusInput();
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextFunction("6");
            FocusInput();
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextFunction("1");
            FocusInput();
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextFunction("2");
            FocusInput();
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextFunction("3");
            FocusInput();
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextFunction("0");
            FocusInput();
        }
        private void DotButton_Click(object sender, EventArgs e)
        {
            InsertTextFunction(".");
            FocusInput();
        }

        #endregion

        #region Calculation
        /// <summary>
        /// Calculates the equation and implements equation.
        /// </summary>
        private void CalculateTotal()
        {
            /*
             * Todo
             * Operator handler
             * Right side Operand
             * Calculation
             */
            this.NumberInput.Text += " " + ParseOperation();
            FocusInput();
        }

        /// <summary>
        /// Parses input eqution and calculates the result.
        /// </summary>
        private string ParseOperation()
        {
            try
            {
                // Get the user equation
                var input = this.NumberInput.Text;

                // Remove all spaces
                input = input.Replace(" ", "");

                // Creates an operation instance.
                var operation = new Operation();
                // Figures out which operand you are on.
                var leftSide = true;
                // Holds numbers and dot for parsing.
                var numberString = "0123456789.";

                // Loops from input string from left to right
                for(int i = 0; i < input.Length; i++)
                {
                    // Catches numbers and period.
                    if(numberString.Any(character => input[i] == character))
                    {
                        // Creates left side operand if on left side
                        if (leftSide)
                            operation.LeftSide = AddNumberPart(operation.LeftSide, input[i]);
                    }
                }

                return String.Empty;
            }
            catch (Exception ex)
            {
                return $"Invalid equition. {ex.Message}";
            }
        }
        /// <summary>
        /// Attempts to add new char to current number, checking for valid character.
        /// </summary>
        /// <param name="currentNumber">The current number string.</param>
        /// <param name="currentCharacter">The new character being added.</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private string AddNumberPart(string currentNumber, char newCharacter)
        {
            // Check if there is already a . in the number
            if (newCharacter == '.' && currentNumber.Contains('.'))
            {
                throw new InvalidOperationException($"Number {currentNumber} already contains a decimal point; another cannot be added.");
            }
               
            return currentNumber + newCharacter;
        }
        #endregion

        #region Method helpers
        /// <summary>
        /// Focus method for focusing on text box after button click.
        /// </summary>
        private void FocusInput()
        {
            this.NumberInput.Focus();
        }

        /// <summary>
        /// Inserts text into the text box.
        /// </summary>
        /// <param name="value"></param>
        private void InsertTextFunction(string value)
        {
            // Remembers cursor selection point.
            var selectionStart = this.NumberInput.SelectionStart;

            // Sets new text to old text plus value.
            this.NumberInput.Text = this.NumberInput.Text.Insert(this.NumberInput.SelectionStart, value);

            // Set new cursor selection to old selection point + length of
            //  characters entered.
            this.NumberInput.SelectionStart = selectionStart + value.Length;

            // Unhighlights text when new text is entered.
            this.NumberInput.SelectionLength = 0;
        }

        /// <summary>
        /// Deletes text from text box.
        /// </summary>
        private void DeleteTextFunction()
        {
            // Method does nothing if no value is there.
            if (this.NumberInput.Text.Length < this.NumberInput.SelectionStart + 1)
                return;

            // Remembers old selection point.
            var selectionStart = this.NumberInput.SelectionStart;

            // Deletes character on right and sets it as new text.
            this.NumberInput.Text = this.NumberInput.Text.Remove(this.NumberInput.SelectionStart, 1);

            // Set new selection start to old one.
            this.NumberInput.SelectionStart = selectionStart;

            // Unhighlights text when something is deleted.
            this.NumberInput.SelectionLength = 0;
        }
        #endregion
    }
}