//Create class Calculator for object for the Form Simple Calculator

namespace prjMultiConverter
{
    class Calculator
    {//Private fields for class
        private decimal currentValue;
        private decimal operand1;
        private decimal operand2;
        private string op;
        public Calculator()
        {
            //defaut constructor
            operand1 = 0;
            operand2 = 0;
            op = "";
        }
        public decimal CurrentValue
        {// Public properties 
            get { return currentValue; }
            set { currentValue = value; }
        }
        public decimal Operand1
        {// Public properties
            get { return operand1; }
            set { operand1 = value; }
        }
        public decimal Operand2
        {// Public properties
            get { return operand2; }
            set { operand2 = value; }
        }
        public string Op
        {// Public properties
            get { return op; }
            set { op = value; }
        }
        public void Add(decimal displayValue)
        {// Public methods Add: Sets the operand1 and currentValue fields to the value that’s passed to it,
         // and sets the op field to "+".
            Operand1 = displayValue;
            CurrentValue = displayValue;
            Op = "+";
        }
        public void Subtract(decimal displayValue)
        {//Public methods Subtract: Sets the operand1 and currentValue fields to the value that’s passed to it,
         //and sets the op field to "-".
            Operand1 = displayValue;
            CurrentValue = displayValue;
            Op = "-";
        }
        public void Multiply(decimal displayValue)
        {//Public methods Multiply: Sets the operand1 and currentValue fields to the value that’s passed to it,
         //and sets the op field to "*".
            Operand1 = displayValue;
            CurrentValue = displayValue;
            Op = "*";
        }
        public void Divide(decimal displayValue)
        {//Public methods Divide: Sets the operand1 and currentValue fields to the value that’s passed to it,
         //and sets the op field to "/".
            Operand1 = displayValue;
            CurrentValue = displayValue;
            Op = "/";
        }
        public void Equals()
        {//Public methods Equals: Performs the operation specified by the op field on the operand1 and operand2 fields,
         //and stores the result in the operand1 field.
            switch (Op)
            {
                case "+": Operand1 = Operand1 + Operand2; CurrentValue = Operand1; break;
                case "-": Operand1 = Operand1 - Operand2; CurrentValue = Operand1; break;
                case "*": Operand1 = Operand1 * Operand2; CurrentValue = Operand1; break;
                case "/": Operand1 = Operand1 / Operand2; CurrentValue = Operand1; break;

            }
        }
        public void Equals(decimal displayValue)
        {//Public methods Equals(displayValue): Sets the operand2 field to the value that’s passed to it.
         //Then, performs the operation specified by the op field on the operand1 and operand2 fields,
         //and stores the result in the operand1 field.
            Operand2 = displayValue;
            switch (Op)
            {
                case "+": Operand1 = CurrentValue + Operand2; CurrentValue = Operand1; break;
                case "-": Operand1 = CurrentValue - Operand2; CurrentValue = Operand1; break;
                case "*": Operand1 = CurrentValue * Operand2; CurrentValue = Operand1; break;
                case "/": Operand1 = CurrentValue / Operand2; CurrentValue = Operand1; break;
            }
        }
        public void Clear()
        {//Public methods
            Operand1 = 0;
            Operand2 = 0;
            currentValue = 0;
            Op = "";
        }
    }
}
