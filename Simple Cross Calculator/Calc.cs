using System;
using System.Collections.Generic;

namespace SimpleCrossCalculator
{
    public class Calc
    {
        private Double sum;
        private Operation lastOperation;

        private enum Operation
        {
            ADD, SUBTRACT, MULTIPLY, DIVIDE, EQUAL, NONE
        }
        private Dictionary<string, Operation> operationDictionary = new Dictionary<string, Operation>
        {
            {"+", Operation.ADD },
            {"-", Operation.SUBTRACT },
            {"*", Operation.MULTIPLY },
            {"/", Operation.DIVIDE },
            {"=", Operation.EQUAL }
        };

        public Calc()
        {
            lastOperation = Operation.NONE;
            sum = 0;
        }

        public string DotClickHandler(string screenText)
        {
            if (!(screenText.Contains(".")))
                screenText += ".";
            return screenText;
        }

        public string SignClickHandler(string screenText)
        {
            if (screenText.Contains("-"))
                screenText = (screenText.Replace("-", ""));
            else if (!screenText.Equals("0"))
                screenText = ("-" + screenText);
            return screenText;
        }

        public string ClearClickHandler()
        {
            sum = 0;
            lastOperation = Operation.NONE;
            return "0";
        }

        public string NumberClickHandler(string numberPressed, string screenText) 
        {
            if (screenText != "0")
                screenText += numberPressed;
            else
                screenText = numberPressed;
            return screenText;
        }

        public string OperationClickHandler(string operationPressed, string screenText)
        {
            Operation operation = operationDictionary[operationPressed];


            if (lastOperation == Operation.NONE)
            {//first operation
                sum = Convert.ToDouble(screenText);
                lastOperation = operation;
            }
            else
            {//call with last operation
                performOperation(lastOperation, screenText);
                lastOperation = operation;
            }
            //to set screen to 0 to receive the next number
            screenText = "0";
            //return the sum in case of equal
            //also reset values to handle next operation 
            if (operation == Operation.EQUAL)
            {
                screenText = sum.ToString();
                sum = 0;
                lastOperation = Operation.NONE;
            }

            return screenText;
        }

        private void performOperation(Operation operation, string screenText)
        {
            switch (operation)
            {
                case Operation.ADD:
                        sum += Convert.ToDouble(screenText);
                    break;
                case Operation.SUBTRACT:
                    sum -= Convert.ToDouble(screenText);
                    break;
                case Operation.MULTIPLY:
                    sum *= Convert.ToDouble(screenText);
                    break;
                case Operation.DIVIDE:
                    sum /= Convert.ToDouble(screenText);
                    break;
            }
        }

    }
}
