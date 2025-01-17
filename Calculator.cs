using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Calculator
{
    internal class Calculator
    {
        private double _actualResult;
        
        public Calculator(double initialResult)
        {
            _actualResult = initialResult;
        }

        public double SumUp(double value)
        {
            return _actualResult += value;
        }
        public double Subtract(double value)
        {
            return _actualResult -= value;
        }
        public double Multiply(double value)
        {
            return _actualResult *= value;
        }
        public double Divide(double divisor)
        {
            if (divisor == 0)
            {
                throw new DivideByZeroException("Nemůžeš dělit 0.");
            }
            return _actualResult /= divisor;
        }
        public double Power(int exponent)
        {

            if (exponent == 0)
            {
                return 1;
            }

            if (_actualResult == 0 && exponent < 0)
            {
                throw new DivideByZeroException("Cannot raise zero to a negative exponent.");
            }

            double result = 1;
            int absExponent = Math.Abs(exponent);

            for (int i = 0; i < absExponent; i++)
            {
                result *= _actualResult;
            }

            _actualResult = exponent > 0 ? result : (1 / result);
            return _actualResult;
        }

        public double GetCurrentResult()
        {
            return _actualResult;
        }

        public void SetCurrentResult(double value)
        {
             _actualResult = value;
        }
    }
}
