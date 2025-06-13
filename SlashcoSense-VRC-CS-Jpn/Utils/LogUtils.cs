using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace SlashcoSense_VRC_CS_Jpn
{
    /// <summary>
    /// ログ抽出用
    /// </summary>
    internal class LogUtils
    {
        
        public static readonly string LogFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "Low", "VRChat", "VRChat");
        // VRCのログのフォルダパス

        public static readonly Regex FuelReductionRegex = new Regex(@"subtracted (\d) can for free from: SC_generator(\d)", RegexOptions.Compiled);
        /* 燃料調節の正規表現
         * Groups[1].Value = 調節された燃料数
         * Groups[2].Value = ジェネ番号 */

        public static readonly Regex MapNameRegex = new Regex(@"Played Map:\s*([^,]+)", RegexOptions.Compiled);
        // マップ名の正規表現
        public static readonly Regex GeneratorUpdateRegex = new Regex(@"Initialized the Slasher as (\w+)", RegexOptions.Compiled);
        // スラッシャー名の正規表現
        public static readonly Regex FueledRegex = new Regex(@"Gas fueled to SC_generator(\d)", RegexOptions.Compiled);
        // 燃料投入正規表現 (Groups[1].Value = ジェネID)
        public static readonly Regex batteryRegex = new Regex(@"SC_generator(\d) had battery", RegexOptions.Compiled);
        // バッテリー投入正規表現

        public static readonly string GameSetupStr = "SLASHCO Game setup.";
        // ゲーム開始テキスト
        public static readonly string GameEndStr = "Generators reset again.";
        // ゲーム終了テキスト

        public static readonly List<string> MapNames = new List<string>()
        {
            "SlashCoHQ",
            "MalonesFarmyard",
            "PhilipsWestwoodHighSchool",
            "EastwoodGeneralHospital",
            "ResearchFacilityDelta"
        };                      // マップリスト

        public static readonly List<string> SlasherNames = new List<string>()
        {
            "Bababooey",
            "Sid",
            "Trollge",
            "Borgmire", 
            "Abomignat", 
            "Thirsty",
            "Elmo",
            "Watcher",
            "Beast",
            "Dolphinman", 
            "Igor",
            "Grouch", 
            "Princess", 
            "Speedrunner"
        };                  // スラッシャーリスト
    }
}
