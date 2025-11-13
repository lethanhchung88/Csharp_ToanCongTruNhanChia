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
        private static string ConfigPath => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.json");

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
                        OperatorName = "Cộng",
                        OperatorSymbol = "+",
                        Operand1Range = new RangeConfig { Min = 0, Max = 20 },
                        Operand2Range = new RangeConfig { Min = 0, Max = 20 },
                        ResultRange = new RangeConfig { Min = 0, Max = 40 },
                        Constraints = new ConstraintConfig { Operand1Greater = false, IntegerResult = true, NonNegativeResult = true, DivisibleOnly = false }
                    },
                    ["subtract"] = new OperationConfig
                    {
                        Score = 0,
                        OperatorName = "Trừ",
                        OperatorSymbol = "-",
                        Operand1Range = new RangeConfig { Min = 0, Max = 20 },
                        Operand2Range = new RangeConfig { Min = 0, Max = 20 },
                        ResultRange = new RangeConfig { Min = 0, Max = 20 },
                        Constraints = new ConstraintConfig { Operand1Greater = true, IntegerResult = true, NonNegativeResult = true, DivisibleOnly = false }
                    },
                    ["multiply"] = new OperationConfig
                    {
                        Score = 0,
                        OperatorName = "Nhân",
                        OperatorSymbol = "×",
                        Operand1Range = new RangeConfig { Min = 0, Max = 10 },
                        Operand2Range = new RangeConfig { Min = 0, Max = 10 },
                        ResultRange = new RangeConfig { Min = 0, Max = 100 },
                        Constraints = new ConstraintConfig { Operand1Greater = false, IntegerResult = true, NonNegativeResult = true, DivisibleOnly = false }
                    },
                    ["divide"] = new OperationConfig
                    {
                        Score = 0,
                        OperatorName = "Chia",
                        OperatorSymbol = "÷",
                        Operand1Range = new RangeConfig { Min = 1, Max = 100 },
                        Operand2Range = new RangeConfig { Min = 1, Max = 10 },
                        ResultRange = new RangeConfig { Min = 0, Max = 100 },
                        Constraints = new ConstraintConfig { Operand1Greater = true, IntegerResult = true, NonNegativeResult = true, DivisibleOnly = true }
                    }
                }
            };
        }
    }
}
