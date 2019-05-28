/*
 * Riff Ahmad Bazlee, P465225  
 * 28/05/2019
 * Calculator App
 * Version 2.0
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// The namespace which contains classes and components of
/// the Calculator App
/// </summary>
namespace CalculatorApp
{
    /// <summary>Class <c>CalculatorForm</c> consists of the functions behind
    /// the Calculator Form.</summary>
    ///
    public partial class CalculatorForm : Form
    {
        // Double variables to store totals and input value
        double prevTotal, newTotal, inputValue; 

        // Boolean variables to check if new input or equation is starting
        bool isInputStarting, isEquationStarting;

        // Booleans to check which operator was last pressed
        bool isAddLastPressed, isMinusLastPressed, isMultiplyLastPressed, isDivideLastPressed;

        // Booleans to check which function was last pressed
        bool isSqrtLastPressed, isCbrtLastPressed, isInvLastPressed, isTanLastPressed, isSinLastPressed, isCosLastPressed;

        // String to store function, for displaying in the equation
        string functionStored;

        /// <summary>
        /// Upon Construction, initialize component initialize variables
        /// </summary>
        public CalculatorForm()
        {
            InitializeComponent();
            ClearAndReset();
        }

        /// <summary>
        /// Clicking btnOne will input 1 into the input display 
        /// </summary>
        /// <param name="sender">The object which has raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnOne_Click(object sender, EventArgs e)
        {
            InputButton(btnOne.Text);
        }

        /// <summary>
        /// Clicking btnTwo will input 2 into the input display  
        /// </summary>
        /// <param name="sender">The object which has raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnTwo_Click(object sender, EventArgs e)
        {
            InputButton(btnTwo.Text);
        }

        /// <summary>
        /// Clicking btnThree will input 3 into the input display  
        /// </summary>
        /// <param name="sender">The object which has raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnThree_Click(object sender, EventArgs e)
        {
            InputButton(btnThree.Text);
        }

        /// <summary>
        /// Clicking btnFour will input 4 into the input display 
        /// </summary>
        /// <param name="sender">The object which has raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnFour_Click(object sender, EventArgs e)
        {
            InputButton(btnFour.Text);
        }

        /// <summary>
        /// Clicking btnFive will input 5 into the input display 
        /// </summary>
        /// <param name="sender">The object which has raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnFive_Click(object sender, EventArgs e)
        {
            InputButton(btnFive.Text);
        }

        /// <summary>
        /// Clicking btnSix will input 6 into the input display  
        /// </summary>
        /// <param name="sender">The object which has raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnSix_Click(object sender, EventArgs e)
        {
            InputButton(btnSix.Text);
        }

        /// <summary>
        /// Clicking btnSeven will input 7 into the input display  
        /// </summary>
        /// <param name="sender">The object which has raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnSeven_Click(object sender, EventArgs e)
        {
            InputButton(btnSeven.Text);
        }

        /// <summary>
        /// Clicking btnEight will input 8 into the input display 
        /// </summary>
        /// <param name="sender">The object which has raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnEight_Click(object sender, EventArgs e)
        {
            InputButton(btnEight.Text);
        }

        /// <summary>
        /// Clicking btnNine will input 9 into the input display 
        /// </summary>
        /// <param name="sender">The object which has raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnNine_Click(object sender, EventArgs e)
        {
            InputButton(btnNine.Text);
        }

        /// <summary>
        /// Clicking btnZero will input 0 into the input display 
        /// </summary>
        /// <param name="sender">The object which has raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnZero_Click(object sender, EventArgs e)
        {
            InputButton(btnZero.Text);
        }

        /// <summary>
        /// Clicking btnDecimal will input . into the input display 
        /// </summary>
        /// <param name="sender">The object which has raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnDecimal_Click(object sender, EventArgs e)
        {
            InputButton(btnDecimal.Text);
        }

        /// <summary>
        /// Negate button will input negation
        /// </summary>
        /// <param name="sender">The object which has raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnNegate_Click(object sender, EventArgs e)
        {
            InputButton(btnNegate.Text);
        }

        /// <summary>
        /// Clear button will clear displays and reset booleans
        /// </summary>
        /// <param name="sender">The object which has raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAndReset();
        }

        /// <summary>
        /// Square root Button will input Square root function
        /// </summary>
        /// <param name="sender">The object which has raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            InputFunction("sqrt");
        }

        /// <summary>
        /// Cube root button will input Cube root function
        /// </summary>
        /// <param name="sender">The object which has raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnCubert_Click(object sender, EventArgs e)
        {
            InputFunction("cbrt");
        }

        /// <summary>
        /// Inverse button will input inverse function
        /// </summary>
        /// <param name="sender">The object which has raised the event.</param>
        /// <param name="e">The event data.</param>
        private void bntInv_Click(object sender, EventArgs e)
        {
            InputFunction("inv");
        }

        /// <summary>
        /// Tan button will input tangent function
        /// </summary>
        /// <param name="sender">The object which has raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnTan_Click(object sender, EventArgs e)
        {
            InputFunction("tan");
        }

        /// <summary>
        /// Sine Button will input sine function
        /// </summary>
        /// <param name="sender">The object which has raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnSin_Click(object sender, EventArgs e)
        {
            InputFunction("sin");
        }

        /// <summary>
        /// Cosine button will input cosine function
        /// </summary>
        /// <param name="sender">The object which has raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnCos_Click(object sender, EventArgs e)
        {
            InputFunction("cos");
        }

        /// <summary>
        /// Add button will input adding operative
        /// </summary>
        /// <param name="sender">The object which has raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Calculate previous equation first
            if (GetResult() == false)
            {
                return;
            }

            UpdateDisplay(btnAdd.Text);
            isEquationStarting = false;
            isInputStarting = true;
            ResetOperatorPresses();
            ResetFunctionPresses();
            isAddLastPressed = true;
        }

        /// <summary>
        /// Minus button will input subtracting operative 
        /// </summary>
        /// <param name="sender">The object which has raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnMinus_Click(object sender, EventArgs e)
        {
            // Calculate previous equation first
            if (GetResult() == false)
            {
                return;
            }

            UpdateDisplay(btnMinus.Text);
            isEquationStarting = false;
            isInputStarting = true;
            ResetOperatorPresses();
            ResetFunctionPresses();
            isMinusLastPressed = true;
        }

        /// <summary>
        /// Divide button will input dividing operative
        /// </summary>
        /// <param name="sender">The object which has raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnDivide_Click(object sender, EventArgs e)
        {
            // Calculate previous equation first
            if (GetResult() == false)
            {
                return;
            }

            UpdateDisplay(btnDivide.Text);
            isEquationStarting = false;
            isInputStarting = true;
            ResetOperatorPresses();
            ResetFunctionPresses();
            isDivideLastPressed = true;
        }

        /// <summary>
        /// Multiply button will input multiplying operative
        /// </summary>
        /// <param name="sender">The object which has raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            // Calculate previous equation first
            if (GetResult() == false)
            {
                return;
            }

            UpdateDisplay(btnMultiply.Text);
            isEquationStarting = false;
            isInputStarting = true;
            ResetOperatorPresses();
            ResetFunctionPresses();
            isMultiplyLastPressed = true;
        }

        /// <summary>
        /// Equals button will input equals operative
        /// </summary>
        /// <param name="sender">The object which has raised the event.</param>
        /// <param name="e">The event data.</param>
        private void btnEqual_Click(object sender, EventArgs e)
        {
            // Calculate previous equation first
            if (GetResult() == false)
            {
                return;
            }

            UpdateDisplay(btnEqual.Text);
            ResetOperatorPresses();
            ResetFunctionPresses();
            isEquationStarting = true;
            isInputStarting = true;
            prevTotal = 0.0;
            newTotal = 0.0;
        }

        /// <summary>
        /// InputButton Method will help determine how numeral buttons, decimal and negation are put into the input display
        /// </summary>
        /// <param name="buttonInput"> Input button which has been pressed to form a number</param>
        private void InputButton(string buttonInput)
        {
            // If a new equation is starting, clear the equation display first
            if (isEquationStarting == true)
            {
                txtBxEquationDisplay.Clear();
            }

            // De-encapsulate input if a function button is pressed
            if (CheckFunctionPressed() == true)
            {
                txtBxinputDisplay.Text = FunctionDeEncapsulate(txtBxinputDisplay.Text);
            }

            // If input is just starting, then replace the input
            if (isInputStarting == true)
            {          
                // If input contains a negated zero, replace with a negated input
                if (txtBxinputDisplay.Text == "-0")
                {
                    // If input is a decimal, replace with (-0.). If negation, then remove negation. Else replace normally
                    if (buttonInput == btnDecimal.Text)
                    {
                        txtBxinputDisplay.Text = "-0" + buttonInput;
                    }
                    else if (buttonInput == btnNegate.Text)
                    {
                        txtBxinputDisplay.Text = "0";
                    }
                    else
                    {
                        txtBxinputDisplay.Text = "-" + buttonInput;
                    }
                }
                else //Else just replace the input
                {
                    // If input is a decimal, replace with (0.). If input is negation, replace with negated 0. Else replace normally
                    if (buttonInput == btnDecimal.Text)
                    {
                        txtBxinputDisplay.Text = "0" + btnDecimal.Text;
                    }
                    else if (buttonInput == btnNegate.Text)
                    {
                        txtBxinputDisplay.Text = "-0";
                    }
                    else
                    {
                        txtBxinputDisplay.Text = buttonInput;
                    }
                }

                //The following prevents adding any more zeros when starting with a zero
                if (buttonInput != btnZero.Text && buttonInput != btnNegate.Text)
                {
                    isInputStarting = false;
                }
            }
            else  //Else if Input Starting is False, concatenate
            {
                // If input is a decimal and the input display already has a decimal, don't add anymore decimals. 
                // If input is negation times with -1. Else concatenate normally
                if (buttonInput == btnDecimal.Text && txtBxinputDisplay.Text.Contains("."))
                {
                }
                else if (buttonInput == btnNegate.Text)
                {
                    double newValue = (Double.Parse(txtBxinputDisplay.Text) * -1);
                    txtBxinputDisplay.Text = newValue.ToString();
                }
                else
                {
                    txtBxinputDisplay.Text += buttonInput;
                }
            }

            // Re-encapsulate input if the function button is pressed
            if (CheckFunctionPressed() == true)
            {
                txtBxinputDisplay.Text = FunctionEncapsulate(txtBxinputDisplay.Text);
            }
        }

        /// <summary>
        /// InputFunction Method will determine how the function will diplay in the input display
        /// </summary>
        /// <param name="functionInput">The function button which has been inputted/pressed</param>
        private void InputFunction(string functionInput)
        {
            // If No Function has already been pressed, set the right boleaan to true, and encapsulate the input display
            if (CheckFunctionPressed() == false)
            {
                SetFunctionBooleanTrue(functionInput);

                // If input is starting reset, input display to 0, before encapsulating.
                if (isInputStarting == true)
                {
                    txtBxinputDisplay.Text = "0";
                }

                txtBxinputDisplay.Text = FunctionEncapsulate(txtBxinputDisplay.Text);
            }
            else  // Else if a function has already been pressed.
            {
                // If function currently pressed matches with the function last pressed, then De-encapsulate and reset function booleans
                if (FunctionMatches(functionInput) == true)
                {
                    txtBxinputDisplay.Text = FunctionDeEncapsulate(txtBxinputDisplay.Text);
                    ResetFunctionPresses();

                }
                else //Else De-encapsulate and reset function booleans, Set right boolean to true and Re-encapsualte with new function
                {
                    txtBxinputDisplay.Text = FunctionDeEncapsulate(txtBxinputDisplay.Text);
                    ResetFunctionPresses();
                    SetFunctionBooleanTrue(functionInput);
                    txtBxinputDisplay.Text = FunctionEncapsulate(txtBxinputDisplay.Text);
                }
            }
        }

        /// <summary>
        /// Method to set the right function boolean to true, depending on what function was pressed
        /// </summary>
        /// <param name="functionPressed">The function has been pressed</param>
        private void SetFunctionBooleanTrue(string functionPressed)
        {
            switch (functionPressed)
            {
                case "sqrt":
                    isSqrtLastPressed = true;
                    break;
                case "cbrt":
                    isCbrtLastPressed = true;
                    break;
                case "inv":
                    isInvLastPressed = true;
                    break;
                case "tan":
                    isTanLastPressed = true;
                    break;
                case "sin":
                    isSinLastPressed = true;
                    break;
                case "cos":
                    isCosLastPressed = true;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Method to check if function that is currently pressed matches with the function last pressed.
        /// </summary>
        /// <param name="functionPressed">The function has been pressed</param>
        /// <returns>Returns true if a function has been previouslt pressed</returns>
        private bool FunctionMatches(string functionPressed)
        {
            if (isSqrtLastPressed == true && functionPressed == "sqrt")
            {
                return true;
            }
            else if (isCbrtLastPressed == true && functionPressed == "cbrt")
            {
                return true;
            }
            else if (isInvLastPressed == true && functionPressed == "inv")
            {
                return true;
            }
            else if (isTanLastPressed == true && functionPressed == "tan")
            {
                return true;
            }
            else if (isSinLastPressed == true && functionPressed == "sin")
            {
                return true;
            }
            else if (isCosLastPressed == true && functionPressed == "cos")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Get Result Method will calculate functions and operators into newTotal.
        /// </summary>
        /// <returns>Returns false if there is an error and no result</returns>
        private bool GetResult()
        {
            // Save new total to previous total
            prevTotal = newTotal;

            // If a function has been pressed, store the input display, decapsualte and calculate function
            if (CheckFunctionPressed() == true)
            {
                functionStored = txtBxinputDisplay.Text;
                txtBxinputDisplay.Text = FunctionDeEncapsulate(txtBxinputDisplay.Text);

                if (CalculateFunction() == false)
                {
                    return false;
                }
            }

            // If no operators has been last pressed, the new total is just the input
            if (CheckOperatorPressed() == false)
            {
                newTotal = Double.Parse(txtBxinputDisplay.Text);
            }

            // Calculate operators
            if (CalculateOperator() == false)
            {
                return false;
            }

            return true;
        }

        /// <summary>
        /// Calculate will calculate equation based on which operator was last pressed. 
        /// It uses methods called from BasicMath.dll.
        /// </summary>
        /// <returns>Returns false if there is an error and no result</returns>
        private bool CalculateOperator()
        {
            inputValue = Double.Parse(txtBxinputDisplay.Text);

            if (isAddLastPressed == true)
            {
                newTotal = BasicMath.Arithmetic.Add(prevTotal, inputValue);
                return true;
            }
            else if (isMinusLastPressed == true)
            {
                newTotal = BasicMath.Arithmetic.Subtract(prevTotal, inputValue);
                return true;
            }
            else if (isMultiplyLastPressed == true)
            {
                newTotal = BasicMath.Arithmetic.Multiply(newTotal, inputValue);
                return true;
            }
            else if (isDivideLastPressed == true)
            {
                // Catch Error if dividing by 0
                if (inputValue == 0)
                {
                    DisplayError("Cannot divide by 0");
                    return false;
                }
                else
                {
                    newTotal = BasicMath.Arithmetic.Divide(newTotal, inputValue);
                    return true;
                }
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Calculate Function Method will calculate the input based on which function was last pressed.
        /// It uses methods called from IntermediateMath.dll and AdvancedMath.dll.
        /// </summary>
        /// <returns>Returns false if there is an error and no result</returns>
        private bool CalculateFunction()
        {
            double functionValue = Double.Parse(txtBxinputDisplay.Text);

            if (isSqrtLastPressed == true)
            {
                // Catch error if value is a negative
                if (functionValue < 0)
                {
                    DisplayError("Cannot SQRT Negative");
                    return false;
                }
                else
                {
                    txtBxinputDisplay.Text = IntermediateMath.Algebraic.SquareRoot(functionValue).ToString();
                    return true;
                }
            }
            else if (isCbrtLastPressed == true)
            {
                txtBxinputDisplay.Text = IntermediateMath.Algebraic.CubeRoot(functionValue).ToString();//use library
                return true;
            }
            else if (isInvLastPressed == true)
            {
                // Catch eror if inversing a 0
                if (functionValue == 0)
                {
                    DisplayError("Cannot Divide by 0");
                    return false;
                }
                else
                {
                    txtBxinputDisplay.Text = IntermediateMath.Algebraic.Inverse(functionValue).ToString();//use library
                    return true;
                }
            }
            else if (isTanLastPressed == true)
            {
                // Catch error if finding tan of 90, 270, -90, etc..
                if ((((functionValue / 90) + 1) % 2 == 0))
                {
                    DisplayError("Invalid Input");
                    return false;
                }
                else
                {
                    txtBxinputDisplay.Text = AdvancedMath.Trigonometric.Tan(functionValue).ToString();//use library
                    return true;
                }
            }
            else if (isSinLastPressed == true)
            {
                txtBxinputDisplay.Text = AdvancedMath.Trigonometric.Sin(functionValue).ToString();//use library
                return true;
            }
            else if (isCosLastPressed == true)
            {
                txtBxinputDisplay.Text = AdvancedMath.Trigonometric.Cos(functionValue).ToString();//use library
                return true;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// Update display method will update the Equation and Input Diplays
        /// </summary>
        /// <param name="operativePressed">The operation button which has been pressed</param>
        private void UpdateDisplay(string operativePressed)
        {
            // If equation is starting display the equation with the operative at the end
            if (isEquationStarting == true)
            {
                // If a function is pressed put the function stored as part of the display. Else put the inputValue.
                if (CheckFunctionPressed() == true)
                {
                    txtBxEquationDisplay.Text = functionStored + operativePressed; 
                }
                else
                {
                    txtBxEquationDisplay.Text = inputValue.ToString() + operativePressed; 
                }
            }
            else // Else if the equation is not starting, display the following equation depending on what operator was last pressed
            {            
                if (isAddLastPressed == true)
                {
                    txtBxEquationDisplay.Text = "(" + prevTotal.ToString() + ")" + btnAdd.Text + inputValue.ToString() + btnEqual.Text;
                }
                else if (isMinusLastPressed == true)
                {
                    txtBxEquationDisplay.Text = "(" + prevTotal.ToString() + ")" + btnMinus.Text + inputValue.ToString() + btnEqual.Text;
                }
                else if (isMultiplyLastPressed == true)
                {
                    txtBxEquationDisplay.Text = "(" + prevTotal.ToString() + ")" + btnMultiply.Text + inputValue.ToString() + btnEqual.Text;
                }
                else if (isDivideLastPressed == true)
                {
                    txtBxEquationDisplay.Text = "(" + prevTotal.ToString() + ")" + btnDivide.Text + inputValue.ToString() + btnEqual.Text;
                }
            }
            txtBxinputDisplay.Text = newTotal.ToString();
        }

        /// <summary>
        /// Function encapsulate method will encapsulate the input display depending on which function was last pressed 
        /// </summary>
        /// <param name="value">The value which needs encapsulating</param>
        /// <returns>The encapsulated string</returns>
        private string FunctionEncapsulate(string value)
        {
            if (isSqrtLastPressed == true)
            {
                value = "SQRT(" + value + ")";
            }
            else if (isCbrtLastPressed == true)
            {
                value = "CBRT(" + value + ")";
            }
            else if (isInvLastPressed == true)
            {
                value = "INV(" + value + ")";
            }
            else if (isTanLastPressed == true)
            {
                value = "TAN(" + value + ")";
            }
            else if (isSinLastPressed == true)
            {
                value = "SIN(" + value + ")";
            }
            else if (isCosLastPressed == true)
            {
                value = "COS(" + value + ")";
            }
            return value;
        }

        /// <summary>
        /// Function De-encapusalate method will remove the encapsualtion from input display
        /// </summary>
        /// <param name="value">The value which needs De-Encapsulating</param>
        /// <returns>The de-encapsualted string</returns>
        private string FunctionDeEncapsulate(string value)
        {
            // If its square root or cube root
            if (isSqrtLastPressed == true || isCbrtLastPressed == true)
            {
                value = value.Substring(5, value.Length - 6);
            }
            else // else if its inverse, tan, sin, cos
            {
                value = txtBxinputDisplay.Text.Substring(4, value.Length - 5);
            }
            return value;
        }

        /// <summary>
        /// Check Function Presses Method will check if a function has been previously pressed.
        /// </summary>
        /// <returns>Returns True if there is a function previously pressed</returns>
        private bool CheckFunctionPressed()
        {
            if (isSqrtLastPressed == true || isCbrtLastPressed == true || isInvLastPressed == true || isTanLastPressed == true || isSinLastPressed == true || isCosLastPressed == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Check Operator Preses Method will check if an operator has been previously pressed
        /// </summary>
        /// <returns>Returns TRue if there is an operator prviously pressed</returns>
        private bool CheckOperatorPressed()
        {
            if (isAddLastPressed == true || isMinusLastPressed == true || isMultiplyLastPressed == true || isDivideLastPressed == true)
            {
               return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// Reset Operator Presses Method will change all operator booleans to false
        /// </summary>
        private void ResetOperatorPresses()
        {
            isAddLastPressed = false;
            isMinusLastPressed = false;
            isMultiplyLastPressed = false;
            isDivideLastPressed = false;
        }

        /// <summary>
        /// Reset Function Presses Method will change all function booleans to false
        /// </summary>
        private void ResetFunctionPresses()
        {
            isSqrtLastPressed = false;
            isCbrtLastPressed = false;
            isInvLastPressed = false;
            isTanLastPressed = false;
            isSinLastPressed = false;
            isCosLastPressed = false;
        }

        /// <summary>
        /// Display Error method will display custom error message in input display 
        /// </summary>
        /// <param name="message">THe custom error message</param>
        public void DisplayError(string message)
        {
            txtBxinputDisplay.Text = message;

            // Reset booleans, totals and inputValue, functionStored
            prevTotal = 0.0;
            newTotal = 0.0;
            inputValue = 0.0;
            isEquationStarting = true;
            isInputStarting = true;
            ResetOperatorPresses();
            ResetFunctionPresses();
            functionStored = "";
        }

        /// <summary>
        /// Clear and Reset Methods will clear textboxes, reset totals, inputValue, and booleans 
        /// </summary>
        private void ClearAndReset()
        {
            txtBxinputDisplay.Text = btnZero.Text;
            txtBxEquationDisplay.Clear();
            prevTotal = 0.0;
            newTotal = 0.0;
            inputValue = 0.0;
            isEquationStarting = true;
            isInputStarting = true;
            ResetOperatorPresses();
            ResetFunctionPresses();
            functionStored = "";
        }
    
    }
}