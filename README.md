# Csharp-webApp


ASP.NET Core Webアプリ(Model-View-Controller)
3.1で生成

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

### Utils
DBの接続など

### Views
HTMLテンプレートファイル

### wwwroot
publicフォルダと同じ扱い。webから直接アクセスされる個所




### プロジェクト名.csproj
プロジェクトファイル。おもにライブラリ管理の情報が書き込まれていく

### プロジェクト名.csproj.user
自動生成されるレベルで、あまり意識しなくてもよい

### App.config
DBの設定ファイル(予定)

## dotnet toolのインストール
dotnet tool install --global dotnet-ef