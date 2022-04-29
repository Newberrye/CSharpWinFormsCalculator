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
            // Adds equal and operation name.
            this.NumberInput.Text += " = " + ParseOperation();
            FocusInput();
        }

        /// <summary>
        /// Parses input equation and calculates the result.
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

                /* Order of Operations Flow
                 * Parse for * and /
                 */

                // Checks if any multiplication or division
                if(input.Contains("*") || input.Contains("/"))
                {
                    // Sets variables for figuring out multiplication and division; separate cause these are unneeded if there is no multiplication or division.
                    int multiplyIndex = input.IndexOf("*");
                    int divideIndex = input.IndexOf("/");
                    // Records position in string
                    int leftIndex = 0;
                    int rightIndex = 0;
                    // Stops recording of operands when triggered
                    bool leftStopper = true;
                    bool rightStopper = true;
                    // Holds calculation number for multiplication and division.
                    string operationNumber = "";

                    // Loops while multiplication and division signs exist
                    while(multiplyIndex != -1 || divideIndex != -1)
                    {

                        // Checks if multiplication symbol is before division
                        if((multiplyIndex < divideIndex && multiplyIndex != -1) || divideIndex == -1)
                        {
                            operation.OperationType = OperationType.Multiply;

                            // Finds first operand and records it in reverse
                            for(int i = multiplyIndex - 1; i != -1; i--)
                            {
                                if (numberString.Any(character => input[i] == character) && leftStopper)
                                {
                                    operation.LeftSide = AddNumberPart(operation.LeftSide, input[i]);
                                    leftIndex = i;
                                }
                                else
                                {
                                    leftStopper = false;
                                }
                            }

                            // Turns reversed operand into an array, flips it, and turns back into a fixed array.
                            char[] multiplyArray = operation.LeftSide.ToCharArray();
                            Array.Reverse(multiplyArray);
                            operation.LeftSide = "";
                            foreach(char c in multiplyArray)
                            {
                                operation.LeftSide += c;
                            }

                            // Finds second operand and records it
                            for (int i = multiplyIndex + 1; i <= input.Length - 1; i++)
                            {
                                if(numberString.Any(character => input[i] == character) && rightStopper)
                                {
                                    operation.RightSide = AddNumberPart(operation.RightSide, input[i]);
                                    rightIndex = i;
                                }
                                else
                                {
                                    rightStopper = false;
                                }
                            }

                            // Calculates Operation and records it to a string
                            operationNumber = CalculateOperation(operation);

                            // Multiplication value is removed and replaced with operation number
                            input = input.Remove(leftIndex, rightIndex - leftIndex + 1);
                            input = input.Insert(leftIndex, operationNumber);
                        }
                        else if(divideIndex != -1)
                        {
                            operation.OperationType = OperationType.Divide;

                            // Finds first operand and records it in reverse
                            for (int i = divideIndex - 1; i != -1; i--)
                            {
                                if (numberString.Any(character => input[i] == character) && leftStopper)
                                {
                                    operation.LeftSide = AddNumberPart(operation.LeftSide, input[i]);
                                    leftIndex = i;
                                }
                                else
                                {
                                    leftStopper = false;
                                }
                            }

                            // Turns reversed operand into an array, flips it, and turns back into a fixed array.
                            char[] divideArray = operation.LeftSide.ToCharArray();
                            Array.Reverse(divideArray);
                            operation.LeftSide = "";
                            foreach (char c in divideArray)
                            {
                                operation.LeftSide += c;
                            }

                            // Finds second operand and records it
                            for (int i = divideIndex + 1; i <= input.Length - 1; i++)
                            {
                                if (numberString.Any(character => input[i] == character) && rightStopper)
                                {
                                    operation.RightSide = AddNumberPart(operation.RightSide, input[i]);
                                    rightIndex = i;
                                }
                                else
                                {
                                    rightStopper = false;
                                }
                            }

                            // Calculates Operation and records it to a string
                            operationNumber = CalculateOperation(operation);

                            // Multiplication value is removed and replaced with operation number
                            input = input.Remove(leftIndex, rightIndex - leftIndex + 1);
                            input = input.Insert(leftIndex, operationNumber);
                        }

                        // End loop check to update multiplication and division existence in equation.
                        multiplyIndex = input.IndexOf("*");
                        divideIndex = input.IndexOf("/");
                        // Resets left and right operands for + and - operations
                        operation.LeftSide = "";
                        operation.RightSide = "";
                        // Resets stoppers for 
                        leftStopper = true;
                        rightStopper = true;
                    }
                }

                if (input.Contains("+") || input.Contains("-"))
                {
                    // Loops from input string from left to right
                    for (int i = 0; i < input.Length; i++)
                    {
                        // Catches numbers and period.
                        if (numberString.Any(character => input[i] == character))
                        {
                            // Creates left side operand if on left side
                            if (leftSide)
                                operation.LeftSide = AddNumberPart(operation.LeftSide, input[i]);
                            else
                                operation.RightSide = AddNumberPart(operation.RightSide, input[i]);
                        }
                        // Catches operator type
                        else if ("+-*/".Any(character => input[i] == character))
                        {
                            // Right side, calculate operation and set result to left side
                            if (!leftSide)
                            {
                                // Gets operator
                                var operationType = GetOperationType(input[i]);

                                //Check if we have a right side member
                                if (operation.RightSide.Length == 0)
                                {
                                    // Check operator is not a minus
                                    if (operationType != OperationType.Minus)
                                    {
                                        throw new InvalidOperationException($"Operators +, *, /, or more than one - specified without a number.");
                                    }
                                    // Add minus to number if there is no left number
                                    operation.RightSide += input[i];
                                }
                                else
                                {
                                    // Calculate previous equation and set to the left side
                                    operation.LeftSide = CalculateOperation(operation);

                                    // Set new operator
                                    operation.OperationType = operationType;

                                    //Clear the previous right number
                                    operation.RightSide = string.Empty;
                                }
                            }
                            else
                            {
                                // Get operator
                                var operationType = GetOperationType(input[i]);

                                //Check if there is an operator left side number with no number on left side.
                                if (operation.LeftSide.Length == 0)
                                {
                                    // Check operator is not a minus
                                    if (operationType != OperationType.Minus)
                                    {
                                        throw new InvalidOperationException($"Operators +, *, /, or more than one - specified without a number.");
                                    }

                                    // Add minus to number if there is no left number
                                    operation.LeftSide += input[i];
                                }
                                else
                                {
                                    // Left number and operator are now parsed, so move to the right

                                    // set operation type
                                    operation.OperationType = operationType;

                                    // Move to the right side
                                    leftSide = false;
                                }
                            }
                        }
                    }
                }

                // If done parsing and no exceptions
                // Input calculates any last minute equations, or returns input if there was only one * or /: Example 5 * 5 would trigger else.
                if(input.Contains("+") || input.Contains("-"))
                {
                    // Calculates Operation
                    return CalculateOperation(operation);
                }
                else
                {
                    return input;
                }

            }
            catch (Exception ex)
            {
                return $"Invalid equition. {ex.Message}";
            }
        }

        /// <summary>
        /// Calculates an operation and returns the result
        /// </summary>
        /// <param name="operation">Operation object to be calculated.</param>
        private string CalculateOperation(Operation operation)
        {
            // Store the number values
            double left = 0;
            double right = 0;

            // Check if valid left side number
            if (string.IsNullOrEmpty(operation.LeftSide) || !double.TryParse(operation.LeftSide, out left))
            {
                throw new InvalidOperationException($"Left side of the operation was not a number: {operation.LeftSide}");
            }

            // Check if valid right side number
            if (string.IsNullOrEmpty(operation.RightSide) || !double.TryParse(operation.RightSide, out right))
            {
                throw new InvalidOperationException($"Left side of the operation was not a number: {operation.RightSide}");
            }

            // Tries to operate equation and throws an exception if it cannot.
            try
            {
                switch (operation.OperationType)
                {
                    case OperationType.Add:
                        return Math.Round(left + right, 5).ToString();
                    case OperationType.Minus:
                        return Math.Round(left - right, 5).ToString();
                    case OperationType.Multiply:
                        return Math.Round(left * right, 5).ToString();
                    case OperationType.Divide:
                        return Math.Round(left / right, 5).ToString();
                    default:
                        throw new InvalidOperationException($"Unknown Operator type when calculating: {operation.OperationType}");
                }
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Failed calculation of: {left} {operation.OperationType} {right} | {ex.Message}");
            }
        }

        /// <summary>
        /// Accepts characters and returns the known <see cref="OperationType"/>
        /// </summary>
        /// <param name="character">The character being parsed.</param>
        private OperationType GetOperationType(char character)
        {
            switch (character)
            {
                case '+':
                    return OperationType.Add;
                case '-':
                    return OperationType.Minus;
                case '*':
                    return OperationType.Multiply;
                case '/':
                    return OperationType.Divide;
                default:
                    throw new InvalidOperationException($"Unknown operator type: {character}");
            }
        }

        /// <summary>
        /// Attempts to add new char to current number, checking for valid character.
        /// </summary>
        /// <param name="currentNumber">The current number string.</param>
        /// <param name="currentCharacter">The new character being added.</param>
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
            // Focuses on text box and unhighlights
            this.NumberInput.Focus();
            this.NumberInput.SelectionLength = 0;
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