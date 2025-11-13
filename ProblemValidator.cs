using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToanCongTruNhanChia
{
    public static class ProblemValidator
    {
        public static bool IsValid(string opKey, int a, int b, AppConfig cfg, out string error)
        {
            error = "";
            if (!cfg.Operations.TryGetValue(opKey, out var op))
            {
                error = "Operation not found";
                return false;
            }

            if (op.Operand1Range.Enabled)
            {
                if (a < op.Operand1Range.Min || a > op.Operand1Range.Max)
                {
                    error = "Operand1 out of range";
                    return false;
                }
            }

            if (op.Operand2Range.Enabled) {
                if (b < op.Operand2Range.Min || b > op.Operand2Range.Max)
                {
                    error = "Operand2 out of range";
                    return false;
                }
            }

            if (op.Constraints.Operand1Greater && a < b)
            {
                error = "Operand1 must be ≥ Operand2";
                return false;
            }

            double result;

            switch (opKey)
            {
                case "add":
                    result = a + b;
                    break;

                case "subtract":
                    result = a - b;
                    break;

                case "multiply":
                    result = a * b;
                    break;

                case "divide":
                    result = (b == 0) ? double.NaN : (double)a / b;
                    break;

                default:
                    result = double.NaN;
                    break;
            }


            if (double.IsNaN(result))
            {
                error = "Invalid operation";
                return false;
            }

            if (op.Constraints.NonNegativeResult && result < 0)
            {
                error = "Negative result not allowed";
                return false;
            }

            if (op.Constraints.IntegerResult && result % 1 != 0)
            {
                error = "Result must be integer";
                return false;
            }

            if (op.Constraints.DivisibleOnly && (b == 0 || a % b != 0))
            {
                error = "a must be divisible by b";
                return false;
            }

            int r = (int)Math.Round(result);

            if (op.ResultRange.Enabled)
            {
                if (r < op.ResultRange.Min || r > op.ResultRange.Max)
                {
                    error = "Result out of range";
                    return false;
                }
            }

            return true;
        }
    }
}
