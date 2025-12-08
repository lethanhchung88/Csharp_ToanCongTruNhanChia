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
        public StickerConfig Sticker { get; set; } = new StickerConfig();

        /// <summary>
        /// Password to unlock edit mode in Settings.
        /// Stored as plain text in settings.json.
        /// Default: "Lisa&Helen"
        /// </summary>
        public string AdminPassword { get; set; } = "Lisa&Helen";

        // ✅ mới thêm:
        public PracticeStateConfig PracticeState { get; set; }
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

    public class EarnedStickerInfo
    {
        public int Level { get; set; }

        // STT (1-based) trong danh sách file .png sắp xếp theo ABC
        public int Index { get; set; }

        // Giữ lại để tương thích ngược (có thể dùng hoặc bỏ)
        public string FileName { get; set; }
    }



    public class StickerConfig
    {
        /// <summary>
        /// Số điểm cần để lên 1 level (10, 20, ...).
        /// Dùng chung cho cả vòng 10 level.
        /// </summary>
        public int PointStep { get; set; } = 10;

        /// <summary>
        /// Danh sách sticker đã được tặng, để khi mở app lại thì vẽ ra đúng.
        /// </summary>
        public List<EarnedStickerInfo> EarnedStickers { get; set; } = new List<EarnedStickerInfo>();
    }

    public class StickerColumnColorConfig
    {
        public int Level { get; set; }        // 1..10
        public int BackColorArgb { get; set; } // Color.ToArgb()
    }

    public class PracticeStateConfig
    {
        // Trạng thái check các phép toán
        public bool ChkAdd { get; set; }
        public bool ChkSub { get; set; }
        public bool ChkMul { get; set; }
        public bool ChkDiv { get; set; }

        // Chế độ đổi phép toán: "Manual", "Sequential", "Random"
        public string Mode { get; set; }

        // Màu nền từng cột sticker
        public List<StickerColumnColorConfig> StickerColumns { get; set; }
    }

}
