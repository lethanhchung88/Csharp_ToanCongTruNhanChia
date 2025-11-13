using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToanCongTruNhanChia
{
    public class AppConfig
    {
        public int TotalScore { get; set; }
        public Dictionary<string, OperationConfig> Operations { get; set; } 
            = new Dictionary<string, OperationConfig>();
    }

    public class OperationConfig
    {
        public int Score { get; set; }
        public string OperatorName { get; set; }
        public string OperatorSymbol { get; set; }
        public RangeConfig Operand1Range { get; set; } = new RangeConfig();
        public RangeConfig Operand2Range { get; set; } = new RangeConfig();
        public RangeConfig ResultRange { get; set; } = new RangeConfig();
        public ConstraintConfig Constraints { get; set; } = new ConstraintConfig();
    }

    public class RangeConfig
    {
        public bool Enabled { get; set; } = true;
        public int Min { get; set; }
        public int Max { get; set; }
    }

    public class ConstraintConfig
    {
        public bool Operand1Greater { get; set; }
        public bool IntegerResult { get; set; }
        public bool NonNegativeResult { get; set; }
        public bool DivisibleOnly { get; set; }
    }
}
