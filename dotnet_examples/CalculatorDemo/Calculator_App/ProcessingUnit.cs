using System;
using System.Linq;

namespace Calculator_App
{
    public class ProcessingUnit
    {
        private int number, op1, op2, assignment, result;
        private char op;
        private const string DIGIT = "0123456789";
        private const string OPERATOR = "+-*/";

        public event EventHandler NewNumberEvent;

        /// <summary>
        /// Constructor
        /// </summary>
        public ProcessingUnit()
        {
            ResetAll();
        }

        public void HandleInput(char ch)
        {
            if(DIGIT.Contains(ch))
            {
                number = BuildNumber(number, ch);
                OnNumber(number);

                switch(assignment)
                {
                    case 1: op1 = number; break;
                    case 2: op2 = number; break;
                }
            }

            if(OPERATOR.Contains(ch))
            {
                switch(assignment)
                {
                    case 1: assignment = 2; break;
                    case 2:
                        op1 = Calculate(op, op1, op2);
                        OnNumber(op1);
                        break;
                }

                number = 0;
                op = ch;
            }

            if(ch == 'r')
            {
                switch (assignment)
                {
                    case 1: OnNumber(op1); break;
                    case 2:
                        op1 = Calculate(op, op1, op2);
                        OnNumber(op1);
                        break;
                }
                number = 0;
                assignment = 1;
            }

            if(ch == 'c')
            {
                ResetAll();
            }
        }

        private static int BuildNumber(int n, char ch)
        {
            return n * 10 + ((int)Convert.ToByte(ch)) - 0x30;
        }

        private int Calculate(char op, int op1, int op2)
        {
            int result = 0;
            switch (op)
            {
                case '+': result = op1 + op2; break;
                case '-': result = op1 - op2; break;
                case '*': result = op1 * op2; break;
                case '/': result = op1 / op2; break;
            }

            return result;
        }

        private void ResetAll()
        {
            number = 0;
            op1 = 0;
            op2 = 0;
            assignment = 1;  //assign to op1
        }

        protected virtual void OnNumber(int number)
        {
            if(NewNumberEvent != null)
            {
                NewNumberEvent(number, null);
            }
        }

    }
}
