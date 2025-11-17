using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


        // Folder chứa file khen
        private static readonly string PraiseFolder =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sound", "en", "praise");

        // Danh sách file praise đã load (tự động lấy từ thư mục)
        private static string[] _praiseFiles = null;

        // Vị trí file hiện tại trong danh sách (round-robin)
        private static int _praiseIndex = 0;

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

        /// <summary>
        /// Phát âm thanh theo thư mục và tên file.
        /// Ví dụ: PlayFromFolder("en", "Settings saved")
        /// sẽ phát sound/en/Settings saved.wav
        /// </summary>
        public static void PlayFromFolder(string folder, string fileNameWithoutExt)
        {
            try
            {
                string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sound");
                string fullPath = Path.Combine(basePath, folder, fileNameWithoutExt + ".wav");

                if (!File.Exists(fullPath))
                    return;

                _player.SoundLocation = fullPath;
                _player.Load();
                _player.Play();
            }
            catch
            {
                // không để app crash
            }
        }

        private static void LoadPraiseFiles()
        {
            if (!Directory.Exists(PraiseFolder))
                return;

            // Lấy toàn bộ wav trong thư mục
            _praiseFiles = Directory.GetFiles(PraiseFolder, "*.wav");

            // Nếu thư mục rỗng thì _praiseFiles = null
            if (_praiseFiles.Length == 0)
                _praiseFiles = null;
        }

        public static bool PlayPraise(out string praiseText)
        {
            praiseText = string.Empty;

            try
            {
                if (_praiseFiles == null)
                    LoadPraiseFiles();

                if (_praiseFiles == null || _praiseFiles.Length == 0)
                    return false;

                // Lấy file theo index
                string fileToPlay = _praiseFiles[_praiseIndex];

                // Tăng index theo kiểu xoay vòng
                _praiseIndex++;
                if (_praiseIndex >= _praiseFiles.Length)
                    _praiseIndex = 0;

                // Phát âm thanh
                Play(fileToPlay);

                // Lấy text (bỏ đuôi .wav)
                praiseText = Path.GetFileNameWithoutExtension(fileToPlay);

                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void PlayPraise()
        {
            string _;
            PlayPraise(out _);   // gọi bản 2 nhưng bỏ text
        }

        //////////////////////////////////////////////////////////////////////
        // TRY AGAIN (âm thanh khi làm sai)
        //////////////////////////////////////////////////////////////////////

        // Thư mục chứa file tryagain
        private static readonly string TryAgainFolder =
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sound", "en", "tryagain");

        // Danh sách file tryagain (load lần đầu)
        private static string[] _tryAgainFiles = null;

        // Vị trí hiện tại (xoay vòng)
        private static int _tryAgainIndex = 0;


        // Load danh sách file trong thư mục tryagain
        private static void LoadTryAgainFiles()
        {
            if (!Directory.Exists(TryAgainFolder))
                return;

            _tryAgainFiles = Directory.GetFiles(TryAgainFolder, "*.wav");

            if (_tryAgainFiles.Length == 0)
                _tryAgainFiles = null;
        }


        // Hàm phát âm thanh + trả text
        public static bool PlayTryAgain(out string text)
        {
            text = string.Empty;

            try
            {
                if (_tryAgainFiles == null)
                    LoadTryAgainFiles();

                if (_tryAgainFiles == null || _tryAgainFiles.Length == 0)
                    return false;

                // Lấy file theo index xoay vòng
                string fileToPlay = _tryAgainFiles[_tryAgainIndex];

                _tryAgainIndex++;
                if (_tryAgainIndex >= _tryAgainFiles.Length)
                    _tryAgainIndex = 0;

                // Phát âm
                Play(fileToPlay);

                // Lấy text (bỏ .wav)
                text = Path.GetFileNameWithoutExtension(fileToPlay);

                return true;
            }
            catch
            {
                return false;
            }
        }


        // Bản gọi không cần trả text
        public static void PlayTryAgain()
        {
            string _;
            PlayTryAgain(out _);
        }



    }
}
