using SlashcoSense_VRC_CS_Jpn.Utils;
using System;

namespace SlashcoSense_VRC_CS_Jpn
{
    internal class GameInfo
    {
        private static GameInfo _instance;              // インスタンス (シングルトン)

        // コンストラクター
        public GameInfo()
        {
            Reset();            // ゲーム情報初期化
        }

        // プロパティ

        public static GameInfo Instance
        {
            get
            {
                if (_instance == null)
                {               // インスタンス未生成
                    _instance = new GameInfo();     // インスタンス作成
                }
                return _instance;
            }
        }                       // インスタンス

        public bool InGame { get; set; }            // ゲーム中

        public string SlasherName { get; set; }     // スラッシャー名

        public GeneratorInfo[] Generators { get; private set; }         // 燃料情報

        /// <summary>
        /// ゲーム情報に初期値代入
        /// </summary>
        public void Reset()
        {
            int genCnt = 0;                 // ループカウンタ

            InGame = false;                 // ゲーム外フラグ
            SlasherName = string.Empty;     // スラッシャー名

            Generators = new GeneratorInfo[GameUtils.GenNum];       // ジェネレーター情報配列

            for (genCnt = 0; genCnt < GameUtils.GenNum; genCnt++)
            {                               // ジェネレーター情報を初期化
                Generators[genCnt] = new GeneratorInfo();           // ジェネレータインスタンス生成
            }
        }

    }
}
