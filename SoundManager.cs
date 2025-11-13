using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Media;

namespace ToanCongTruNhanChia
{
    public static class SoundManager
    {
        private static readonly SoundPlayer _player = new SoundPlayer();

        private static string BasePath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sound", "en");

        // Mapping: MENU NAME → FILE NAME
        private static readonly Dictionary<string, string> MenuSoundMap =
            new Dictionary<string, string>
            {
                { "menuMath",             "Math.wav" },
                { "menuPrimarySchool",    "Primary school.wav" },
                { "menuAddition",         "Addition Plus.wav" },
                { "menuSubtraction",      "Subtraction Minus.wav" },
                { "menuMultiplication",   "Multiplication Times.wav" },
                { "menuDivision",         "Division.wav" },
                { "menuSettings",         "Settings.wav" }
            };

        private static readonly Dictionary<string, string> SettingsSoundMap =
            new Dictionary<string, string>
            {
        // FORM
        //{ "settingsForm",            "Settings.wav" },

        // BUTTONS
        { "btnSave",                 "Save Settings.wav" },
        { "btnCancel",               "Cancel.wav" },

        // GROUP BOXES
        { "grpAdd",                  "Addition Settings.wav" },
        { "grpSub",                  "Subtraction Settings.wav" },
        { "grpMul",                  "Multiplication Settings.wav" },
        { "grpDiv",                  "Division Settings.wav" },

        //////////////////////////////////////////////////
        // ADDITION (+)
        //////////////////////////////////////////////////

        // Operand 1
        { "lblAddOpe1",              "Operand One.wav" },
        { "chkAddOpe1Enable",        "Enable.wav" },
        { "lblAddOpe1Min",           "Minimum Value.wav" },
        { "numAddOpe1Min",           "Minimum Value.wav" },
        { "lblAddOpe1Max",           "Maximum Value.wav" },
        { "numAddOpe1Max",           "Maximum Value.wav" },

        // Operand 2
        { "lblAddOpe2",              "Operand Two.wav" },
        { "chkAddOpe2Enable",        "Enable.wav" },
        { "lblAddOpe2Min",           "Minimum Value.wav" },
        { "numAddOpe2Min",           "Minimum Value.wav" },
        { "lblAddOpe2Max",           "Maximum Value.wav" },
        { "numAddOpe2Max",           "Maximum Value.wav" },

        // Result
        { "lblAddResult",            "Result.wav" },
        { "chkAddResultEnable",      "Enable.wav" },
        { "lblAddResultMin",         "Minimum Value.wav" },
        { "numAddResultMin",         "Minimum Value.wav" },
        { "lblAddResultMax",         "Maximum Value.wav" },
        { "numAddResultMax",         "Maximum Value.wav" },

        //////////////////////////////////////////////////
        // SUBTRACTION (-)
        //////////////////////////////////////////////////

        // Operand 1
        { "lblSubOpe1",              "Operand One.wav" },
        { "chkSubOpe1Enable",        "Enable.wav" },
        { "lblSubOpe1Min",           "Minimum Value.wav" },
        { "numSubOpe1Min",           "Minimum Value.wav" },
        { "lblSubOpe1Max",           "Maximum Value.wav" },
        { "numSubOpe1Max",           "Maximum Value.wav" },

        // Operand 2
        { "lblSubOpe2",              "Operand Two.wav" },
        { "chkSubOpe2Enable",        "Enable.wav" },
        { "lblSubOpe2Min",           "Minimum Value.wav" },
        { "numSubOpe2Min",           "Minimum Value.wav" },
        { "lblSubOpe2Max",           "Maximum Value.wav" },
        { "numSubOpe2Max",           "Maximum Value.wav" },

        // Result
        { "lblSubResult",            "Result.wav" },
        { "chkSubResultEnable",      "Enable.wav" },
        { "lblSubResultMin",         "Minimum Value.wav" },
        { "numSubResultMin",         "Minimum Value.wav" },
        { "lblSubResultMax",         "Maximum Value.wav" },
        { "numSubResultMax",         "Maximum Value.wav" },

        //////////////////////////////////////////////////
        // MULTIPLICATION (×)
        //////////////////////////////////////////////////

        // Operand 1
        { "lblMulOpe1",              "Operand One.wav" },
        { "chkMulOpe1Enable",        "Enable.wav" },
        { "lblMulOpe1Min",           "Minimum Value.wav" },
        { "numMulOpe1Min",           "Minimum Value.wav" },
        { "lblMulOpe1Max",           "Maximum Value.wav" },
        { "numMulOpe1Max",           "Maximum Value.wav" },

        // Operand 2
        { "lblMulOpe2",              "Operand Two.wav" },
        { "chkMulOpe2Enable",        "Enable.wav" },
        { "lblMulOpe2Min",           "Minimum Value.wav" },
        { "numMulOpe2Min",           "Minimum Value.wav" },
        { "lblMulOpe2Max",           "Maximum Value.wav" },
        { "numMulOpe2Max",           "Maximum Value.wav" },

        // Result
        { "lblMulResult",            "Result.wav" },
        { "chkMulResultEnable",      "Enable.wav" },
        { "lblMulResultMin",         "Minimum Value.wav" },
        { "numMulResultMin",         "Minimum Value.wav" },
        { "lblMulResultMax",         "Maximum Value.wav" },
        { "numMulResultMax",         "Maximum Value.wav" },

        //////////////////////////////////////////////////
        // DIVISION (÷)
        //////////////////////////////////////////////////

        // Operand 1
        { "lblDivOpe1",              "Operand One.wav" },
        { "chkDivOpe1Enable",        "Enable.wav" },
        { "lblDivOpe1Min",           "Minimum Value.wav" },
        { "numDivOOpe1Min",          "Minimum Value.wav" },
        { "lblDivOpe1Max",           "Maximum Value.wav" },
        { "numDivOpe1Max",           "Maximum Value.wav" },

        // Operand 2
        { "lblDivOpe2",              "Operand Two.wav" },
        { "chkDivOpe2Enable",        "Enable.wav" },
        { "lblDivOpe2Min",           "Minimum Value.wav" },
        { "numDivOpe2Min",           "Minimum Value.wav" },
        { "lblDivOpe2Max",           "Maximum Value.wav" },
        { "numDivOpe2Max",           "Maximum Value.wav" },

        // Result
        { "lblDivResult",            "Result.wav" },
        { "chkDivResultEnable",      "Enable.wav" },
        { "lblDivResultMin",         "Minimum Value.wav" },
        { "numDivResultMin",         "Minimum Value.wav" },
        { "lblDivResultMax",         "Maximum Value.wav" },
        { "numDivResultMax",         "Maximum Value.wav" }
            };


        /// <summary>
        /// Gọi khi rê chuột vào menu item.
        /// Nhận vào tên menu: menuAddition.Name
        /// </summary>
        public static void PlayMenu(string menuName)
        {
            if (!MenuSoundMap.TryGetValue(menuName, out string file))
                return;

            string fullPath = Path.Combine(BasePath, file);
            Play(fullPath);
        }

        private static void Play(string path)
        {
            try
            {
                if (!File.Exists(path))
                    return;

                _player.SoundLocation = path;
                _player.Load();
                _player.Play();
            }
            catch
            {
                // Không để app bị crash nếu không phát được âm thanh
            }
        }

        public static void PlaySettingsHover(string controlName)
        {
            if (!SettingsSoundMap.TryGetValue(controlName, out string file))
                return;

            string fullPath = Path.Combine(BasePath, file);
            Play(fullPath);
        }
    }
}
