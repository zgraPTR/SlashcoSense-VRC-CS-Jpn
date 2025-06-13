using SlashcoSense_VRC_CS_Jpn.Utils;
using System;
using System.IO;
using System.Windows.Forms;

namespace SlashcoSense_VRC_CS_Jpn
{
    public partial class FormMain : Form
    {
        private LogWatcher logWatcher;
        private GameInfo gameData;                      // ゲーム情報クラス
        private GameStateUpdateEvent gameEvent;         // ゲーム情報変更イベントクラス
        private OSCTransmitter oscTransmitter;

        private readonly string fuelStr = "燃料";         // 燃料表示

        public FormMain()
        {                               // コンストラクター
            InitializeComponent();
            
            logWatcher = new LogWatcher();              // ファイル監視クラス
            InitFileSystemWatcher();                    // ログの監視を開始

            oscTransmitter = OSCTransmitter.Instance;   // OSC送信クラス

            gameData = GameInfo.Instance;               // ゲーム情報インスタンス
            gameEvent = GameStateUpdateEvent.Instance;  // ゲーム情報更新イベントクラス
            gameEvent.Changed += OnGe;                  // ゲーム情報更新イベント
        }

        /// <summary>
        /// フォームロード時のイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            OnGe(null, null);                           // 表示内容初期化
        }

        /// <summary>
        /// ゲーム情報更新イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnGe(object sender, EventArgs e)
        {
            labelMap.Text = gameData.MapName;               // マップ名
            labelSlasher.Text = gameData.SlasherName;       // スラッシャー名

            labelG1Fuel.Text = $"{fuelStr} {gameData.Generators[0].FilledFuel} / {GameUtils.TotalFuel}";    // 燃料
            progressBarG1Fuel.Value = gameData.Generators[0].FilledFuel;   // 燃料バー
            checkBoxG1Battery.Checked = gameData.Generators[0].HasBattery; // バッテリー

            labelG2Fuel.Text = $"{fuelStr} {gameData.Generators[1].FilledFuel} / {GameUtils.TotalFuel}";    // 燃料
            progressBarG2Fuel.Value = gameData.Generators[1].FilledFuel;   // 燃料バー
            checkBoxG2Battery.Checked = gameData.Generators[1].HasBattery; // バッテリー
        }

        /// <summary>
        /// OSC有効化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckBoxOSC_CheckedChanged(object sender, EventArgs e)
        {
            oscTransmitter.Port = (int)numericUpDownPort.Value;     // ポート取得
            oscTransmitter.EnableOsc = checkBoxOSC.Checked;            // OSC有効化
        }

        /// <summary>
        /// Port番号変更イベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NumericUpDownPort_ValueChanged(object sender, EventArgs e)
        {
            oscTransmitter.Port = (int)numericUpDownPort.Value;     // ポート取得
        }

        /// <summary>
        /// ログ監視イベント開始
        /// </summary>
        private void InitFileSystemWatcher()
        {
            fileSystemWatcherLog.Path = LogUtils.LogFolderPath;     // 監視フォルダパス
            fileSystemWatcherLog.NotifyFilter = NotifyFilters.Attributes
                                 | NotifyFilters.CreationTime
                                 | NotifyFilters.DirectoryName
                                 | NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite
                                 | NotifyFilters.Security
                                 | NotifyFilters.Size;              // 通知のフィルターを設定

            fileSystemWatcherLog.Filter = "output_*.txt";           // 監視ファイル
            fileSystemWatcherLog.IncludeSubdirectories = false;     // サブディレクトリ除外
            fileSystemWatcherLog.Changed += logWatcher.OnChanged;   // ファイル生成時のイベントハンドラ   
            fileSystemWatcherLog.EnableRaisingEvents = true;        // ログ監視イベント有効化
        }

    }
}
