using SlashcoSense_VRC_CS_Jpn.Utils;
using System.Text.RegularExpressions;

namespace SlashcoSense_VRC_CS_Jpn
{
    /// <summary>
    /// ログの内容の取得などを行う関数
    /// </summary>
    internal class LogParser
    {

        private OSCTransmitter osc = OSCTransmitter.Instance;       // OSCクラス
        private GameInfo gameData = GameInfo.Instance;              // ゲーム情報クラス
        private GameStateUpdateEvent gameEvent = GameStateUpdateEvent.Instance;     // ゲーム情報変更イベントクラス

        /// <summary>
        /// ログの内容からゲーム情報を取得する
        /// </summary>
        /// <param name="line">ログの1行の内容</param>
        public void ParseLog(string line)
        {
            if (gameData.InGame == false)
            {               // ゲーム外フラグ
                if (TryParseFuelReduction(line) == true)
                {           // 調節された燃料数抽出
                    return;
                }
                if (TryParseMapName(line) == true)
                {           // マップ名抽出
                    gameData.InGame = true;             // ゲーム中フラグ
                    return;
                }
            }

            if (line.EndsWith(LogUtils.GameEndStr) == true)
            {               // ゲーム終了フラグ有効化
                gameData.Reset();   // ゲーム情報リセット
                gameEvent.RaiseGameStateUpdated();      // ゲーム情報更新イベント
                return;
            }

            if (TryParseSlasherName(line) == true)
            {               // スラッシャー名抽出
                return;
            }
            TryParseGeneratorStatus(line);      // ジェネ更新抽出
        }

        /// <summary>
        /// 調節された燃料数抽出
        /// </summary>
        /// <param name="line">ログ内容</param>
        /// <returns></returns>
        private bool TryParseFuelReduction(string line)
        {
            Match match = LogUtils.FuelReductionRegex.Match(line);
            // 調節された燃料数抽出
            if (match.Success == false)
            {       // 調節された燃料抽出失敗
                return false;
            }

            int filledFuel = int.Parse(match.Groups[1].Value);              // 燃料数
            int genNum = int.Parse(match.Groups[2].Value);                  // ジェネ番号
            gameData.Generators[genNum - 1].FilledFuel += filledFuel;       // 燃料数格納

            return true;
        }

        /// <summary>
        /// マップID抽出
        /// </summary>
        /// <param name="line">ログ内容</param>
        /// <returns></returns>
        private bool TryParseMapName(string line)
        {
            Match match = LogUtils.MapNameRegex.Match(line);
            if (match.Success == false)
            {           // 抽出失敗
                return false;
            }

            int mapId = int.Parse(match.Groups[1].Value);
            gameData.MapName = LogUtils.MapNames[mapId];

            for (int genNum = 1; genNum <= GameUtils.GenNum; genNum++)
            {           // 全ジェネ
                int fuel = gameData.Generators[genNum - 1].FilledFuel;      // 投入済燃料数
                osc.SendFuelNum(genNum, fuel);          // 投入済燃料数送信
                osc.SendBatteryStatus(genNum, false);   // バッテリー未投入状態送信
            }

            gameEvent.RaiseGameStateUpdated();          // ジェネ更新抽出  

            return true;
        }

        /// <summary>
        /// スラッシャー名抽出
        /// </summary>
        /// <param name="line">ログ内容</param>
        /// <returns></returns>
        private bool TryParseSlasherName(string line)
        {
            Match match = LogUtils.GeneratorUpdateRegex.Match(line);
            if (match.Success == false)
            {           // スラッシャー名抽出失敗
                return false;
            }

            gameData.SlasherName = match.Groups[1].Value;       // スラッシャー名格納
            osc.SendSlasherID();                        // スラッシャーID送信
            gameEvent.RaiseGameStateUpdated();          // ゲーム情報更新イベント

            return true;
        }

        /// <summary>
        /// ジュネ更新種類抽出
        /// </summary>
        /// <param name="line">ログ内容</param>
        private void TryParseGeneratorStatus(string line)
        {
            int genNum = 0;             // ジェネID
            int filledFuel = 0;         // 燃料数

            Match fuelMatch = LogUtils.FueledRegex.Match(line);     // 燃料投入抽出
            Match batteryMatch = LogUtils.batteryRegex.Match(line); // バッテリー投入抽出 

            if (fuelMatch.Success == true)
            {           // 燃料投入抽出失敗
                genNum = int.Parse(fuelMatch.Groups[1].Value);
                filledFuel = (++gameData.Generators[genNum - 1].FilledFuel);
                osc.SendFuelNum(genNum, filledFuel);                // 燃料数送信
            }
            else if (batteryMatch.Success == true)
            {           // バッテリー投入抽出失敗
                genNum = int.Parse(batteryMatch.Groups[1].Value);   // ジェネ番号
                gameData.Generators[genNum - 1].HasBattery = true;  // バッテリー投入
                osc.SendBatteryStatus(genNum, true);                // バッテリー投入送信
            }
            else
            {
                return;
            }

            gameEvent.RaiseGameStateUpdated();                      // ゲーム情報更新イベント
        }
    }
}
