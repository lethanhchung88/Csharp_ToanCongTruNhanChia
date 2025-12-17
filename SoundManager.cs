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

        // 👇 THÊM 2 DÒNG NÀY
        private static readonly SoundPlayer _stickerPlayer = new SoundPlayer();
        private static readonly object _stickerLock = new object();

        // ===== MUSIC LOOP (sticker "play music") =====
        private static readonly SoundPlayer _musicPlayer = new SoundPlayer();
        private static readonly object _musicLock = new object();
        private static volatile bool _musicPlaying = false;

        // Chỉ mute đúng/sai (praise/tryagain) khi nhạc đang chạy
        private static volatile bool _answerFeedbackEnabled = true;

        public static bool IsMusicPlaying => _musicPlaying;

        public static void SetAnswerFeedbackEnabled(bool enabled)
        {
            _answerFeedbackEnabled = enabled;
        }

        public static void StartStickerMusicLoop(int level, string fileNameWithoutExt)
        {
            try
            {
                string levelFolderName = $"level{level:00}";
                string levelFolderPath = Directory
                    .GetDirectories(StickersBasePath, levelFolderName + "*")
                    .FirstOrDefault();

                if (string.IsNullOrEmpty(levelFolderPath))
                    return;

                string wavPath = Path.Combine(levelFolderPath, fileNameWithoutExt + ".wav");
                if (!File.Exists(wavPath))
                    return;

                lock (_musicLock)
                {
                    _musicPlayer.Stop();
                    _musicPlayer.SoundLocation = wavPath;
                    _musicPlayer.Load();
                    _musicPlayer.PlayLooping();

                    _musicPlaying = true;
                    SetAnswerFeedbackEnabled(false); // đang phát nhạc -> tắt âm đúng/sai
                }
            }
            catch { }
        }

        public static void StopStickerMusicLoop()
        {
            try
            {
                lock (_musicLock)
                {
                    _musicPlayer.Stop();
                    _musicPlaying = false;
                    SetAnswerFeedbackEnabled(true); // dừng nhạc -> bật lại âm đúng/sai
                }
            }
            catch { }
        }



        private static string BasePath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sound", "en");


        private static string StickersBasePath =>
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sound", "stickers");


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
        { "lblAddRes",               "Result.wav" },
        { "chkAddResEnable",         "Enable.wav" },
        { "lblAddResMin",            "Minimum Value.wav" },
        { "numAddResMin",            "Minimum Value.wav" },
        { "lblAddResMax",            "Maximum Value.wav" },
        { "numAddResMax",            "Maximum Value.wav" },

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
        { "lblSubRes",               "Result.wav" },
        { "chkSubResEnable",         "Enable.wav" },
        { "lblSubResMin",            "Minimum Value.wav" },
        { "numSubResMin",            "Minimum Value.wav" },
        { "lblSubResMax",            "Maximum Value.wav" },
        { "numSubResMax",            "Maximum Value.wav" },

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
        { "lblMulRes",               "Result.wav" },
        { "chkMulResEnable",         "Enable.wav" },
        { "lblMulResMin",            "Minimum Value.wav" },
        { "numMulResMin",            "Minimum Value.wav" },
        { "lblMulResMax",            "Maximum Value.wav" },
        { "numMulResMax",            "Maximum Value.wav" },

        //////////////////////////////////////////////////
        // DIVISION (÷)
        //////////////////////////////////////////////////

        // Operand 1 (Dividend)
        { "lblDivOpe1",              "Dividend.wav" },
        { "chkDivOpe1Enable",        "Enable.wav" },
        { "lblDivOpe1Min",           "Minimum Value.wav" },
        { "numDivOpe1Min",           "Minimum Value.wav" },
        { "lblDivOpe1Max",           "Maximum Value.wav" },
        { "numDivOpe1Max",           "Maximum Value.wav" },

        // Operand 2 (Divisor)
        { "lblDivOpe2",              "Divisor.wav" },
        { "chkDivOpe2Enable",        "Enable.wav" },
        { "lblDivOpe2Min",           "Minimum Value.wav" },
        { "numDivOpe2Min",           "Minimum Value.wav" },
        { "lblDivOpe2Max",           "Maximum Value.wav" },
        { "numDivOpe2Max",           "Maximum Value.wav" },

        // Result (Quotient)
        { "lblDivRes",               "Quotient.wav" },
        { "chkDivResEnable",         "Enable.wav" },
        { "lblDivResMin",            "Minimum Value.wav" },
        { "numDivResMin",            "Minimum Value.wav" },
        { "lblDivResMax",            "Maximum Value.wav" },
        { "numDivResMax",            "Maximum Value.wav" },

        //////////////////////////////////////////////////
        // CONSTRAINTS
        //////////////////////////////////////////////////
        { "chkSubNonNegative",       "Non Negative Result.wav" },
        { "chkDivExact",             "Exact Division.wav" },
            };

        private static readonly Dictionary<string, string> PracticeFormSoundMap =
            new Dictionary<string, string>
            {
                // Add các mapping cho PracticeForm1 nếu cần
            };

        public static void PlayMenuHover(string menuName)
        {
            if (!MenuSoundMap.TryGetValue(menuName, out string file))
                return;

            string fullPath = Path.Combine(BasePath, file);
            Play(fullPath);
        }

        public static void PlaySettingsHover(string controlName)
        {
            if (!SettingsSoundMap.TryGetValue(controlName, out string file))
                return;

            string fullPath = Path.Combine(BasePath,
                Path.Combine("settings", file));

            Play(fullPath);
        }

        public static void PlayPracticeHover(string controlName)
        {
            if (!PracticeFormSoundMap.TryGetValue(controlName, out string file))
                return;

            string fullPath = Path.Combine(BasePath,
                Path.Combine("practice", file));

            Play(fullPath);
        }

        public static void PlayFile(string relativePath)
        {
            string fullPath = Path.Combine(BasePath, relativePath);
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

        private static void PlaySyncSafe(string path)
        {
            try
            {
                if (!File.Exists(path))
                    return;

                using (var player = new SoundPlayer(path))
                {
                    player.Load();
                    player.PlaySync();
                }
            }
            catch
            {
                // Không để app bị crash nếu không phát được âm thanh
            }
        }

        //////////////////////////////////////////////////
        // PRAISE (sound/en/praise)
        //////////////////////////////////////////////////

        private static string PraiseFolder =>
            Path.Combine(BasePath, "praise");

        // Danh sách file khen thưởng
        private static string[] _praiseFiles = null;

        // Index hiện tại để phát (theo kiểu xoay vòng)
        private static int _praiseIndex = 0;

        // Load danh sách file trong thư mục praise
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
            if (!_answerFeedbackEnabled) { praiseText = ""; return false; }

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
            PlayPraise(out _);
        }


        //////////////////////////////////////////////////
        // TRY AGAIN (sound/en/tryagain)
        //////////////////////////////////////////////////

        private static string TryAgainFolder =>
            Path.Combine(BasePath, "tryagain");

        private static string[] _tryAgainFiles = null;
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

        public static bool PlayTryAgain(out string tryAgainText)
        {
            if (!_answerFeedbackEnabled) { tryAgainText = ""; return false; }

            tryAgainText = string.Empty;

            try
            {
                if (_tryAgainFiles == null)
                    LoadTryAgainFiles();

                if (_tryAgainFiles == null || _tryAgainFiles.Length == 0)
                    return false;

                // Lấy file theo index
                string fileToPlay = _tryAgainFiles[_tryAgainIndex];

                // Tăng index theo kiểu xoay vòng
                _tryAgainIndex++;
                if (_tryAgainIndex >= _tryAgainFiles.Length)
                    _tryAgainIndex = 0;

                // Phát âm thanh
                Play(fileToPlay);

                // Lấy text (bỏ đuôi .wav)
                tryAgainText = Path.GetFileNameWithoutExtension(fileToPlay);

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

        //////////////////////////////////////////////////
        // STICKERS (Level up & click)
        //////////////////////////////////////////////////

        public static void PlayStickerLevelUpSequence(int level)
        {
            // 1) Nhạc hiệu level up chung
            string music = Path.Combine(StickersBasePath, "level-up-music.wav");
            PlaySyncSafe(music);

            // 2) Congratulations...
            string congrats = Path.Combine(StickersBasePath, "Congratulations Level Up.wav");
            PlaySyncSafe(congrats);

            // 3) Tìm thư mục levelXX*
            string levelFolderName = $"level{level:00}";
            string levelFolderPath = Directory
                .GetDirectories(StickersBasePath, levelFolderName + "*")
                .FirstOrDefault();

            if (string.IsNullOrEmpty(levelFolderPath))
                return;

            // 4) levelXX.wav (file chính)
            string levelWav = Path.Combine(levelFolderPath, $"level{level:00}.wav");
            PlaySyncSafe(levelWav);

            // 5) Tìm tất cả file có chữ "intro" trong tên (.wav)
            //   - không cần chứa levelXX
            //   - chỉ cần có "intro" (không phân biệt hoa/thường)
            //   - sort theo ABC rồi lấy file đầu tiên
            var introCandidates = Directory.GetFiles(levelFolderPath, "*.wav")
                .Where(p => Path.GetFileName(p)
                    .IndexOf("intro", StringComparison.OrdinalIgnoreCase) >= 0)
                .OrderBy(p => Path.GetFileName(p), StringComparer.CurrentCultureIgnoreCase)
                .ToArray();

            if (introCandidates.Length > 0)
            {
                // Lấy file đầu tiên sau khi sort
                string introFile = introCandidates[0];
                PlaySyncSafe(introFile);
            }

        }

        public static void PlayLevelPin(int level)
        {
            string levelFolderName = $"level{level:00}";
            string levelFolderPath = Directory
                .GetDirectories(StickersBasePath, levelFolderName + "*")
                .FirstOrDefault();

            if (string.IsNullOrEmpty(levelFolderPath))
                return;

            string wavPath = Path.Combine(levelFolderPath, $"level{level:00}.wav");
            Play(wavPath);
        }

        public static void PlayStickerSound(int level, string fileNameWithoutExt)
        {
            //string levelFolderName = $"level{level:00}";
            //string levelFolderPath = Directory
            //    .GetDirectories(StickersBasePath, levelFolderName + "*")
            //    .FirstOrDefault();

            //if (string.IsNullOrEmpty(levelFolderPath))
            //    return;

            //string wavPath = Path.Combine(levelFolderPath, fileNameWithoutExt + ".wav");
            //Play(wavPath);

            // chuyển sang kênh sticker riêng để không bị _player (đúng/sai) đè
            PlayStickerSoundAsync(level, fileNameWithoutExt);

        }

        public static string PlayStickerSoundAndReturnText(int level, string fileNameWithoutExt)
        {
            string stickersRoot = StickersBasePath;
            string levelFolderName = $"level{level:00}";
            string levelFolderPath = Directory
                .GetDirectories(stickersRoot, levelFolderName + "*")
                .FirstOrDefault();

            if (string.IsNullOrEmpty(levelFolderPath))
                return "";

            string wavPath = Path.Combine(levelFolderPath, fileNameWithoutExt + ".wav");

            // Phát âm thanh như bình thường
            PlaySyncSafe(wavPath);

            // Trả về text để hiển thị
            return fileNameWithoutExt;
        }


        /// <summary>
        /// Gọi khi rê chuột vào menu item.
        /// Nhận vào tên menu, ví dụ: menuAddition.Name
        /// </summary>
        public static void PlayMenu(string menuName)
        {
            if (!MenuSoundMap.TryGetValue(menuName, out string file))
                return;

            string fullPath = Path.Combine(BasePath, file);
            Play(fullPath);
        }

        /// <summary>
        /// Phát âm thanh theo thư mục và tên file (không cần .wav).
        /// Ví dụ:
        ///   PlayFromFolder("en", "Settings saved")
        /// sẽ phát: sound/en/Settings saved.wav
        /// </summary>
        public static void PlayFromFolder(string folder, string fileNameWithoutExt)
        {
            try
            {
                string basePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "sound");
                string fullPath = Path.Combine(basePath, folder, fileNameWithoutExt + ".wav");

                if (!File.Exists(fullPath))
                    return;

                // dùng hàm Play chung để phát
                Play(fullPath);
            }
            catch
            {
                // Không để app bị crash nếu lỗi
            }
        }

        public static void PlayStickerSoundAsync(int level, string fileNameWithoutExt)
        {
            try
            {
                string stickersRoot = StickersBasePath;
                string levelFolderName = $"level{level:00}";
                string levelFolderPath = Directory
                    .GetDirectories(stickersRoot, levelFolderName + "*")
                    .FirstOrDefault();

                if (string.IsNullOrEmpty(levelFolderPath))
                    return;

                string wavPath = Path.Combine(levelFolderPath, fileNameWithoutExt + ".wav");
                if (!File.Exists(wavPath))
                    return;

                // 🔑 Chỉ dùng 1 player cho sticker và luôn dừng tiếng cũ trước khi phát lại
                lock (_stickerLock)
                {
                    _stickerPlayer.Stop();                // dừng tiếng đang phát (nếu có)
                    _stickerPlayer.SoundLocation = wavPath;
                    _stickerPlayer.Load();
                    _stickerPlayer.Play();               // Play() là async, không block UI
                }
            }
            catch
            {
                // nuốt lỗi, tránh crash app
            }
        }


    }
}
