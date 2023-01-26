# Tehran Securities Exchange (TSE) Library

[![License: GPL v2](https://img.shields.io/badge/License-GPL%20v2-blue.svg)](https://github.com/AFP33/TSE/blob/master/LICENSE)

## کتابخانه بازار بورس اوراق بهادار تهران

### Introduction
This library developed for fetch all data from [tsetmc.com](http://www.tsetmc.com/) as Tehran Securities Exchange Technology Management Co. It's free and open-source and developed in visual studio C# library.

### How to Use
you have two option for use the library:
1. Get the project and build it by youself.
2. Download <span style="color:orange;">*Tse.dll*</span> in Relase page and reference it in your project

### Features List

#### Market Feature List
| Feature name  | tsetmc name | status |
| ------------- | ------------- | ------------- |
| Bourse at Glance  | بورس اوراق بهادار تهران  | :heavy_check_mark: |
| Farabourse at Glance  | فرابورس ایران  | :heavy_check_mark: |
| Search Stock  | جستجوی سهام  | :heavy_check_mark: |
| All Stock  | همه نماد های بازار  | :heavy_check_mark: |
| Chosen Indexes | شاخص های منتخب بورس | :heavy_check_mark: |
| Effective on Index | تاثیر در شاخص بورس | :heavy_check_mark: |
| Effective on Index | تاثیر در شاخص فرا بورس | :heavy_check_mark: |
| Top Transaction Symbol | نماد های پر تراکنش بورس | :heavy_check_mark:
| Top Transaction Symbol | نماد های پر تراکنش فرا بورس | :heavy_check_mark:

#### Stock Feature List
| Feature name  | tsetmc name | status |
| ------------- | ------------- | ------------- |
| Brief Information  | در یک نگاه  | :heavy_check_mark: |
| Stock Transaction History  | سابقه  | :heavy_check_mark: |
| Announcements  | اطلاعیه ها  | :heavy_check_mark: |
| Company Identity  | شناسه  | :heavy_check_mark: |
| Balance Sheet  | ترازنامه  | :heavy_check_mark: |
| Council Announcement  | آگهی مجمع  | :heavy_check_mark: |
| Status Change  | تغییر وضعیت  | :heavy_check_mark: |
| Board of Director  | هئیت مدیره | :heavy_check_mark: |
| Real Legal  | حقیقی و حقوقی  | :heavy_check_mark: |
| Stockholder  | سهامداران  | :heavy_check_mark: |
| EPS  | EPS  | :heavy_check_mark: |
| DPS  | DPS  | :heavy_check_mark: |
| Company Info  | معرفی شرکت  | :heavy_check_mark: |
| Cost Benefit  | سود و زیان  | :heavy_check_mark: |
| Supervisor Message  | پیام های ناظر  | :heavy_check_mark: |
| Produce and Sales  | تولید و فروش  | ❌ No, in develop |
| Council Decision  | تصمیمات مجمع  | ❌ No, in develop |
| Portfo  | پرتفوی  | ❌ No, in develop |
| Statistics  | آمار  | ❌ No, in develop |


#### Examples

##### Market Information
```cs
using Tse;

            var tse = new TSE();
            var marketHandler = tse.GetMarketHandler();

            // دریافت اطلاعات بورس و اوراق بهادار تهران
            var BourseAtGlance = marketHandler.BourseAtGlance;

            // شاخص های منتخب
            var chosenIndexes = BourseAtGlance.ChosenIndexes;
            foreach (var item in chosenIndexes)
            {
                Console.WriteLine(item.Index + " " + item.Publish + " " + item.Hight + " " );
            }

            // نماد های موثر بر شاخص
            var effectiveOnIndex = BourseAtGlance.EffectiveOnIndex;
            foreach (var item in effectiveOnIndex)
            {
                Console.WriteLine(item.Symbol + " " + item.Efficacy + " " + item.FinalPrice + " ");
            }
            // لیست همه سهام موجود در بازار
            var Stocks = marketHandler.Stocks;

            // جستجوی سهام
            var stocks = marketHandler.FindStock("فخاس");
```

##### Stock Information
```cs
using Tse;

            var tse = new TSE();

            var marketHandler = tse.GetMarketHandler();
            // جستجوی سهام
            var stocks = marketHandler.FindStock("فخاس");

            var stock = tse.GetStockHandler(stocks[0]);
            
            // دریافت سابقه معاملات - روزهای معامله شده
            var th = stock.GetTransactionHistory();

            // دریافت سابقه معاملات -  همه روزها
            var th2 = stock.GetTransactionHistory(Tse.Entities.TransactionHistoryType.AllDay);

            // دریافت مجامع
            var Announcements = stock.Announcements;

            // دریافت ترازنامه ها
            var BalanceSheets = stock.BalanceSheets;

            // دریافت اطلاعات بخش هیئت مدیره
            var BoardOfDirectors = stock.BoardOfDirectors;

            // دریافت اطلاعات اولیه نماد
            var BriefInformations = stock.BriefInformations;

            // دریافت اطلاعات بخش شناسه نماد
            var CompanyIdentities = stock.CompanyIdentities;

            // دریافت اطلاعات بخش معرفی شرکت
            var CompanyInfos = stock.CompanyInfos;

            // دریافت اطلاعات بخش سود و زیان
            var CostBenefits = stock.CostBenefits;

            // دریافت اطلاعات بخش آگهی مجمع
            var CouncilAnnouncements = stock.CouncilAnnouncements;

            // دریافت اطلاعات بخش DPS
            var dps = stock.DPSs;

            // دریافت اطلاعات بخش EPS
            var eps = stock.EPSs;

            // دریافت اطلاعات بخش تغییر وضعیت
            var StatusChanges = stock.StatusChanges;

            // دریافت اطلاعات بخش سهامداران
            var Stockholders = stock.Stockholders;

            // دریافت اطلاعات بخش پیام های ناظر
            var SupervisorMessages = stock.SupervisorMessages;

```

#### Develop
if you want to help in develop, create `branch` and finally send the pull requests.

#### Contact me
if you have a problem in working with library you can send [`ISSUE']() in issues page.
otherwise you can reach me with this Telegram ID: [@AFP33](https://telegram.me/afp33dev)
