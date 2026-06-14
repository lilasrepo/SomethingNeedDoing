# Something Need Doing（繁中移植版 · TC12） / Traditional-Chinese Port

> Work work.（埋頭苦幹。）<br>
> Work work.

**繁體中文**：這是 **[Something Need Doing](https://github.com/Jaksuhn/SomethingNeedDoing)** 的繁體中文客戶端移植版，對應 **FFXIV 7.1 / yanmucorp Dalamud API12（.NET 9）**。本專案僅做相容性移植，**非官方、非原作維護**；所有原始功能與設計著作權歸原作者 **daemitus、croizat**。

**English**: A Traditional-Chinese-client port of **[Something Need Doing](https://github.com/Jaksuhn/SomethingNeedDoing)** targeting **FFXIV 7.1 / yanmucorp Dalamud API12 (.NET 9)**. Compatibility port only — **unofficial and not maintained by the original author**. All original work © **daemitus, croizat**.

---

## 這是什麼 / About

儲存無數巨集並撰寫 Lua 腳本來自動化遊戲操作；如今用途已不只製作。可串接其他插件打造複雜的自動化流程。

Store unlimited macros and write Lua scripts to automate the game — now for far more than crafting. Chains with other plugins to build complex automation.

## 安裝 / Installation

**繁體中文**
1. 使用 **XIVTCLauncher** 啟動繁體中文客戶端。
2. 遊戲內輸入 `/xlsettings` → 切到 **Experimental** 分頁 → **Custom Plugin Repositories（自訂插件庫）**。
3. 貼上下列網址並按 **+** 儲存：
   ```
   https://raw.githubusercontent.com/lilasrepo/DalamudPlugins/main/pluginmaster.json
   ```
4. 輸入 `/xlplugins`，搜尋 **Something Need Doing (TC12)** → 安裝 → 啟用。

**English**
1. Launch the Traditional-Chinese client with **XIVTCLauncher**.
2. In-game, type `/xlsettings` → **Experimental** tab → **Custom Plugin Repositories**.
3. Add this URL and save with **+**:
   ```
   https://raw.githubusercontent.com/lilasrepo/DalamudPlugins/main/pluginmaster.json
   ```
4. Type `/xlplugins`, search **Something Need Doing (TC12)** → Install → Enable.

## 對應版本 / Compatibility

| 項目 / Item | 版本 / Version |
|---|---|
| 遊戲 / Game | FFXIV 7.1（繁中客戶端 / TC client） |
| Dalamud | yanmucorp API12（.NET 9） |
| 移植自上游 / Ported from upstream | v15.2 |

## 原作與授權 / Credits & License

本專案 fork 自 **[Jaksuhn/SomethingNeedDoing](https://github.com/Jaksuhn/SomethingNeedDoing)**，授權沿用上游；所有原始功能著作權歸 **daemitus、croizat**。<br>
Forked from **[Jaksuhn/SomethingNeedDoing](https://github.com/Jaksuhn/SomethingNeedDoing)**. License follows upstream; all original work © **daemitus, croizat**.

## 免責聲明 / Disclaimer

第三方插件，使用風險自負。**移植相關問題請回報到本 repo 的 Issues，請勿打擾上游原作者。**<br>
Third-party plugin — use at your own risk. **For port-specific issues please open an Issue here; do not contact the upstream author.**
