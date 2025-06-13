using Rug.Osc;
using System;
using System.Net;
using System.Windows.Forms;

namespace SlashcoSense_VRC_CS_Jpn
{
    internal class OSCTransmitter
    {
        private readonly string ParameterUrl = "/avatar/parameters";        // OSCパラメーターURL
        private IPAddress sendAddress = IPAddress.Parse("127.0.0.1");       // 送信先IP
        private OscSender oscSender;            // OSC送信インスタンス
        private bool enableOsc = false;         //  OSC送信有効フラグ

        private static OSCTransmitter _instance;            // インスタンス
        private GameInfo gameInfo = GameInfo.Instance;      // ゲーム情報クラス

        // プロパティ

        public static OSCTransmitter Instance
        {
            get
            {
                if (_instance == null)
                {                               // インスタンス未生成時
                    _instance = new OSCTransmitter();
                }
                return _instance;
            }
        }                                       // インスタンス (シングルトン)

        public int Port { get; set; }           // 送信先ポート

        public bool EnableOsc
        {
            get
            {
                return enableOsc;
            }
            set
            {
                enableOsc = value;
                SetOscEnabled(value);           // OSC送受信切り替え
            }
        }                                       // OSC送信有効状態

        /// <summary>
        /// OSC送信切り替え
        /// </summary>
        /// <param name="oscFlag"></param>
        public void SetOscEnabled(bool oscFlag)
        {
            if (oscFlag == true)
            {                                   // OSC有効化
                try
                {
                    oscSender = new OscSender(sendAddress, 0, Port);        // 接続先作成
                    oscSender.Connect();        // OSC接続
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());
                }
            }
            else
            {                                   // OSC無効化
                oscSender.Dispose();            // OSC破棄
            }
        }

        /// <summary>
        /// 燃料数送信処理
        /// </summary>
        /// <param name="gNumber"></param>
        /// <param name="generatorType">ジェネレーター更新状態種類</param>
        /// <param name="value">更新後内容</param>
        public void SendFuelNum(int gNumber, int fuel)
        {
            string parameterName = $"GENERATOR{gNumber}_FUEL";      // 燃料パラメータ
            SendOscMessage(parameterName, fuel);                    // OSC送信
        }

        /// <summary>
        /// 燃料数送信処理
        /// </summary>
        /// <param name="gNumber"></param>
        /// <param name="generatorType">ジェネレーター更新状態種類</param>
        /// <param name="value">更新後内容</param>
        public void SendBatteryStatus(int gNumber, bool hadBattery)
        {
            string parameterName = $"GENERATOR{gNumber}_BATTERY";   // バッテリーパラメータ
            SendOscMessage(parameterName, hadBattery);              // OSC送信
        }

        /// <summary>
        /// スラッシャー名送信
        /// </summary>
        public void SendSlasherID()
        {
            int slasherID = 0;                      // スラッシャーID
            slasherID = LogUtils.SlasherNames.IndexOf(gameInfo.SlasherName);  // スラッシャーID取得

            if (slasherID != -1)
            {                                       // 正常
                this.SendOscMessage("SlasherID", slasherID);
            }
        }

        /// <summary>
        /// OSC送信
        /// </summary>
        /// <param name="parameterName"></param>
        /// <param name="value"></param>
        private void SendOscMessage(string parameterName, object sendObj)
        {
            OscMessage oscMessage = new OscMessage($"{ParameterUrl}/{parameterName}", sendObj);
            // OSCメッセージ作成
            oscSender.Send(oscMessage);      // OSC送信
        }

    }
}
