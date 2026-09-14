# 長照媒合平台

## 專題簡介

本系統「長照媒合平台」是一套以長照需求媒合為核心的資訊整合系統，主要協助老人、家屬與照服員之間建立快速且便利的聯繫方式。

## 技術棧

- **框架**：ASP.NET Core MVC
- **.NET 版本**：.NET 8
- **資料庫**：SQL Server
- **ORM**：Entity Framework Core 8.0
- **認證**：ASP.NET Core Identity
- **前端**：Bootstrap 5
- **版本控制**：Git + GitHub

## 系統角色

- **家屬 (Family)**：發布長照需求、媒合照服員、管理被照護者資料
- **照服員 (Caregiver)**：建立檔案、上傳證照、瀏覽案件、申請接案
- **管理員 (Admin)**：審核照服員、管理案件、發布公告、查看統計

## 核心功能

### 帳號安全
- ✅ 使用者註冊與登入
- ✅ ASP.NET Core Identity 管理
- ✅ 角色權限管理
- ✅ 登入失敗鎖定機制
- ✅ OTP 簡訊驗證
- ✅ 忘記密碼重設

### 個人資料
- ✅ 個人資料查看與修改
- ✅ 被照護者資訊管理（病歷、過敏史）

### 照服員管理
- ✅ 照服員檔案建立
- ✅ 證照上傳與驗證
- ✅ 管理員審核流程

### 長照需求與媒合
- ✅ 發布長照需求案件
- ✅ 案件搜尋與篩選
- ✅ 案件申請
- ✅ 媒合管理

### 訂單與服務
- ✅ 服務訂單管理
- ✅ 模擬支付系統
- ✅ 聊天功能

### 通知與收藏
- ✅ 系統通知
- ✅ 案件收藏
- ✅ 照服員收藏

### 後台管理
- ✅ 會員管理
- ✅ 案件管理
- ✅ 審核管理
- ✅ 公告管理
- ✅ 統計分析

## 專案結構

```
LongCareMatchingPlatform/
├── Models/                    # 資料模型
│   ├── Enums/                 # 列舉類型
│   ├── ApplicationUser.cs
│   ├── CaregiverProfile.cs
│   └── ... 其他模型
├── Data/                      # 資料訪問層
│   ├── ApplicationDbContext.cs
│   └── Migrations/
├── Services/                  # 業務邏輯層
│   ├── Interfaces/
│   └── Implementations/
├── Controllers/               # 前台控制器
├── Areas/Admin/               # 後台管理
├── Views/                     # 視圖
├── ViewModels/                # 視圖模型
├── wwwroot/                   # 靜態資源
├── Program.cs                 # 進入點
└── appsettings.json           # 設定檔
```

## 開發階段

- ✅ 第 1 階段：專案建立 + NuGet 套件
- ⏳ 第 2 階段：ApplicationDbContext + Entity 模型
- ⏳ 第 3 階段：ASP.NET Core Identity
- ⏳ 第 4-25 階段：各功能模組開發

## 快速開始

### 前置要求
- Visual Studio 2022
- .NET 8 SDK
- SQL Server (LocalDB 或完整版)

### 安裝步驟

1. Clone 專案
```bash
git clone https://github.com/winter0719/LongCareMatchingPlatform.git
```

2. 在 Visual Studio 中打開專案

3. 恢復 NuGet 套件
```bash
Update-Package
```

4. 執行資料庫遷移
```bash
Add-Migration InitialCreate
Update-Database
```

5. 運行應用程式
```bash
Press F5 or Ctrl+F5
```

## 資料庫連線字串

預設連線字串（appsettings.json）：
```
Server=(localdb)\\mssqllocaldb;Database=LongCareMatchingPlatformDb;Trusted_Connection=true;TrustServerCertificate=true;
```

如需使用其他 SQL Server 實例，請修改連線字串。

## 團隊成員

- 指導教授：黃俊閎 老師
- 專研學生：賴晉宇、孫如泙、鍾承妤、羅書涵、梁芸綺、李冠儀

## 授權

MIT License

## 聯絡方式

如有任何問題或建議，請提交 GitHub Issue。
