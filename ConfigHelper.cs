using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace ToanCongTruNhanChia
{
    public static class ConfigHelper
    {
        private static string ConfigPath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.json");

        public static void SaveConfig(AppConfig config)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(ConfigPath, JsonSerializer.Serialize(config, options));
        }

        public static AppConfig LoadConfig()
        {
            if (!File.Exists(ConfigPath))
                return CreateDefault();

            return JsonSerializer.Deserialize<AppConfig>(File.ReadAllText(ConfigPath)) ?? CreateDefault();
        }

        private static AppConfig CreateDefault()
        {
            return new AppConfig
            {
                TotalScore = 0,
                Operations = new Dictionary<string, OperationConfig>
                {
                    ["add"] = new OperationConfig
                    {
                        Score = 0,
                        OperatorName = "Addition",
                        OperatorSymbol = "+",
                        Operand1Range = new RangeConfig { Enabled = true, Min = 0, Max = 10 },
                        Operand2Range = new RangeConfig { Enabled = true, Min = 0, Max = 10 },
                        ResultRange = new RangeConfig { Enabled = true, Min = 0, Max = 10 },
                        Constraints = new ConstraintConfig { Operand1Greater = false, IntegerResult = true, NonNegativeResult = true, DivisibleOnly = false }
                    },
                    ["sub"] = new OperationConfig
                    {
                        Score = 0,
                        OperatorName = "Subtraction",
                        OperatorSymbol = "-",
                        Operand1Range = new RangeConfig { Enabled = true, Min = 0, Max = 10 },
                        Operand2Range = new RangeConfig { Enabled = true, Min = 0, Max = 10 },
                        ResultRange = new RangeConfig { Enabled = true, Min = 0, Max = 10 },
                        Constraints = new ConstraintConfig { Operand1Greater = true, IntegerResult = true, NonNegativeResult = true, DivisibleOnly = false }
                    },
                    ["mul"] = new OperationConfig
                    {
                        Score = 0,
                        OperatorName = "Multiplication",
                        OperatorSymbol = "×",
                        Operand1Range = new RangeConfig { Enabled = true, Min = 0, Max = 10 },
                        Operand2Range = new RangeConfig { Enabled = true, Min = 0, Max = 10 },
                        ResultRange = new RangeConfig { Enabled = true, Min = 0, Max = 100 },
                        Constraints = new ConstraintConfig { Operand1Greater = false, IntegerResult = true, NonNegativeResult = true, DivisibleOnly = false }
                    },
                    ["div"] = new OperationConfig
                    {
                        Score = 0,
                        OperatorName = "Division",
                        OperatorSymbol = ":",
                        Operand1Range = new RangeConfig { Enabled = true, Min = 1, Max = 99 },
                        Operand2Range = new RangeConfig { Enabled = true, Min = 1, Max = 9 },
                        ResultRange = new RangeConfig { Enabled = true, Min = 0, Max = 99 },
                        Constraints = new ConstraintConfig { Operand1Greater = true, IntegerResult = true, NonNegativeResult = true, DivisibleOnly = true }
                    }
                }
            };
        }
    }
}
