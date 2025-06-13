using System;

namespace SlashcoSense_VRC_CS_Jpn
{
    public class GameStateUpdateEvent
    {
        private static GameStateUpdateEvent _instance;     // インスタンス

        public event EventHandler Changed;      // ゲーム情報発生イベント


        // プロパティ

        public static GameStateUpdateEvent Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new GameStateUpdateEvent();
                }
                return _instance;
            }
        }                       // インスタンス

        /// <summary>
        /// ゲーム情報更新イベント発生
        /// </summary>
        public void RaiseGameStateUpdated()
        {
            Changed?.Invoke(this, new EventArgs());
        }
    }
}
