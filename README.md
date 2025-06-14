# SlashcoSense-VRC-CS-Jpn 🎮⚡

[![Python 3.8+](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/)
[![OSC Protocol](https://img.shields.io/badge/OSC-Rug.OSC-brightgreen)](https://www.nuget.org/packages/Rug.Osc)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)


[SlashcoSense-VRC](https://github.com/arcxingye/SlashcoSense-VRC) を元に作成されています。

Slashco VRゲームのログを読み込んで実行中の情報を出力します。ゲームがアップデートされたら動作しない可能性があります。


## 機能

1.ゲームが開始後にマップ、スラッシャー、生成アイテム情報が分かります

2.発電機に必要なガソリンとバッテリーの量をリアルタイムで更新（ゲーム中のみ）

3.MAをサポートし、OSCを介してゲーム内で表示可能

4.デスクトップ、PCVRどちらにも対応しています


## SlashcoSense-VRC との違い

1.アプリ、MAプレハブの日本語化

2.ジェネレーター状態更新時のバグ修正



## スクリーンショット
ゲーム内UIの説明：最初の4つはオイルの量を表し、最後はバッテリーが投入済みかを表しています
![image](https://github.com/user-attachments/assets/85a33ff6-2aa8-40d1-8595-b324f456f972)
PCVR
![image](https://github.com/user-attachments/assets/15b90e73-3fc4-4116-aeec-bc866341ecf4)
デスクトップ
![image](https://github.com/user-attachments/assets/f8def42e-3877-40aa-9df3-12fe3a715030)


プレファブの取付方法: モデルのルートに配置して実行する。調整不要です。

OSC送信パラメータ
```
SlasherID (Int 0-13)
GENERATOR1_FUEL (Int 0-4)
GENERATOR2_FUEL (Int 0-4)
GENERATOR1_BATTERY (Bool 0-1)
GENERATOR2_BATTERY (Bool 0-1)
```
