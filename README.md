# Csharp-webApp


ASP.NET Core Webアプリ(Model-View-Controller)
3.1で生成

DBはentityframework core 5(SQLServer)を採用


## ファイル説明
### Startup.cs
エントリーポイントかつルーティングの記載(後ほど分解する必要があるかも・・・)

### log4net.confg
log4の設定

### logs
logファイル

### Controller
Controller

### Entity
Entity

### Service
Service

### Migrations
マイグレーションファイル作成

### Data
DataContext(DBの接続窓口)

### Views
HTMLテンプレートファイル

### wwwroot
publicフォルダと同じ扱い。webから直接アクセスされる個所

### プロジェクト名.csproj
プロジェクトファイル。おもにライブラリ管理の情報が書き込まれていく

### プロジェクト名.csproj.user
自動生成されるレベルで、あまり意識しなくてもよい


### appsettings.json
ASP.NET Core ではweb.configがなく、代わりにappsettings.jsonから読み込む

### Migrationsについて
コマンドはすべてアプリケーションディレクトリで実行

### dotnet toolのインストール
dotnet tool install --global dotnet-ef

#### エラー見るとき
dotnet build

```
C:\Users\matsumoto\source\repos\Ecbeing.Sample.DbMigration\Startup.cs(23,25): error CS1061: 'DbContextOptionsBuilder' に 'UseSqlServer' の定義が含まれておらず、型 'DbContextOptionsBuilder' の最初の引数を受け付けるアクセス可能な拡張メソッド 'UseSqlServer' が見つかりませんでした。using ディレクティブまたはアセンブリ参照が不足していないことを確認してください [C:\Users\matsumoto\source\repos\Ecbeing.Sample.DbMigration\Ecbeing.Sample.DbMigration.csproj]

ビルドに失敗しました。
```
リビルドなどで解決

#### migraionファイル作成
dotnet ef migrations add InitialCreate
```
Build started...
Build succeeded.
Done. To undo this action, use 'ef migrations remove'
```
Migrations以下にMigrationsファイル作成

#### migrations実行

dotnet ef database update

成功時のメッセージ
```
Build started...
Build succeeded.
Applying migration '20220122132233_CustomCreate'.
Done.
```

#### migrationsの詳細なコマンド
https://docs.microsoft.com/ja-jp/ef/core/cli/dotnet