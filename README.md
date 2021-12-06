# sample-csharp

Mac で C# 開発するためのサンプル。

## 準備

下記をMac(ローカル)に導入

- [.NET SDK](https://docs.microsoft.com/ja-jp/dotnet/core/install/macos) (.NET 5で試している)
- VSCode
- VSCodeのMS製C#拡張
  - [C# - Visual Studio Marketplace](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)

## 開発

コンソールで下記の手順で実行。

```sh
cd HelloWorld
dotnet run --framework net5.0 # 実行(ビルドも走る)
dotnet build # Debug版が生成される
dotnet publish -c Release -o out # outディレクトリにRelease版成果物を生成
dotnet ./out/HelloWorld.dll # 成果物を実行
```

VSCodeのタスクからでも実行可能。(キーバインドはデフォルトから変更しているので注意)

- `cmd`+`shift`+`G` : 「ビルドタスクの実行」 ※ よく使う`dotnet run`を割り当てている
- `cmd`+`shift`+`T` : 「タスクの実行」 ※ `build`や`publis`を選択実行

その他よく使うコマンドをメモ。

```sh
dotnet new console -o HelloWorld # プロジェクト生成
```

## Debug

`F5`で実行。

- ブレークポイント等が効く
- デバッグ実行設定は、`.vscode/launch.json`に書いてある

## Lint

`StyleCop`を使う。

- 下記サイトのとおりに設定
  - [VSCodeでもStyleCopを使いたい【C#】 | neputa note](https://www.neputa-note.net/2020/10/vscode-stylecop.html#VSCode%E3%81%A7.editorconfig%E3%82%92%E4%BD%BF%E3%81%88%E3%82%8B%E3%82%88%E3%81%86%E3%81%AB%E3%81%99%E3%82%8B%E6%89%8B%E9%A0%86)

## UnitTest

- まだ途中
- [mozkzki/memo](https://github.com/mozkzki/memo)を見ること

## DevContainer

- 途中
- Omnisharpが動かないのでコーディングは厳しい
- 動作確認には使える

## TargetFramework

複数バージョン生成している[(参考)](https://kazuhira-r.hatenablog.com/entry/2021/04/02/013829)。記載できる名前は[MSのページ](https://docs.microsoft.com/ja-jp/dotnet/standard/frameworks)を参照。

```xml
        <TargetFrameworks>net6.0;net5.0;netcoreapp3.1</TargetFrameworks>
```

### 注意

- タグ名の変更が必要なので注意: `TargetFramework`→`TargetFrameworks`
- 当然だが`net6.0`をビルドするには .NET SDK 6が必要 (5だけだとエラーになった)
- TargetFrameworkを3.1にしたら、runtimeも3.1が必要 (なので結局Macに複数バージョン入れた)
  - 下記で導入バージョンを確認出来る

    ```sh
    dotnet --list-sdks
    dotnet --list-runtimes
    ```
