using System.IO;

namespace SlashcoSense_VRC_CS_Jpn
{
    /// <summary>
    /// ファイルのイベントを取得を取得して監視を行うクラス
    /// </summary>
    internal class LogWatcher
    {
        private string logPath = string.Empty;  // 監視中のログファイルのパス
        private long readPosition = 0;          // 最終読み取り位置

        private readonly LogParser logParser = new LogParser();   // スラシュコのログを管理するクラス

        /// <summary>
        /// ファイル内容のイベントハンドラ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnChanged(object sender, FileSystemEventArgs e)
        {
            string filePath = e.FullPath;       // イベントのファイルのパス

            if (logPath != filePath)
            {                                   // ログファイルが変わった
                logPath = filePath;             // ログファイルパス代入
                readPosition = 0;               // 最終読み取り位置リセット
            }

            ReadNewLines();                      // ログを読み込む
        }


        /// <summary>
        /// ログファイルの変更分を一行ずつ読み込んで解析
        /// </summary>
        private void ReadNewLines()
        {
            FileStream fs = null;           // ファイルストリーム
            StreamReader sr = null;         // 内容を読み込むストリーム
            string line = "";               // 1行の内容

            try
            {
                fs = new FileStream(logPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                // ファイルストリーム
                sr = new StreamReader(fs);         // 内容を読み込むストリーム

                if (readPosition == 0)
                {                                   // 初回読み込み時
                    fs.Seek(0, SeekOrigin.End);     // 末尾から開始
                }
                else
                {
                    fs.Seek(readPosition, SeekOrigin.Begin);
                }

                while ((line = sr.ReadLine()) != null)
                {                                   // 1行ずつ末尾まで内容を読み込む
                    logParser.ParseLog(line);       // スラシュコのログか内容を確認する関数
                }

                readPosition = fs.Position;         // 読み込み済の位置を保存
            }
            catch (IOException)
            {
                // ファイルがロック中などで読み取れなかった場合の対策
                // 必要であればログ出力などを追加
            }
            finally
            {
                if (sr != null)
                {           // ファイルストリーム
                    sr.Dispose();
                }
                if (fs != null)
                {           // 内容を読み込むストリーム
                    fs.Dispose();
                }
            }
        }

    }
}
