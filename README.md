# 📈📉📊 Tehran Securities Exchange (TSE) Library

![love](https://ci.appveyor.com/api/projects/status/32r7s2skrgm9ubva?svg=true)
[![Made With Love](https://img.shields.io/badge/Made%20With-Love-orange.svg)](https://github.com/chetanraj/awesome-github-badges)
[![License: GPL v2](https://img.shields.io/badge/License-GPL%20v2-blue.svg)](https://github.com/AFP33/TSE/blob/master/LICENSE)

### کتابخانه بازار بورس اوراق بهادار تهران (نسخه فارسی را از [اینجا](/READMEPERSIAN.md) بخوانید)

## 📌 Introduction
This library developed for fetch all data from [tsetmc.com](http://www.tsetmc.com/) as Tehran Securities Exchange Technology Management Co. It's free and open-source and developed in visual studio C# library. we using [HtmlAgilityPack](https://html-agility-pack.net/) and [Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json) as library helper. As you probably know, for using this library you need to connect to internet, for accessing tsetmc site.

**The most important advantage of this library is not to store information and leave it to you.** Because of this you will get the highest data speed. The data serialization operation is developed in the simplest way to achieve fast response. Other parts are also planned for development which will be done in the future. Your suggestions can help us improve the project.

This library gives you access to all the stocks available in the market, such as the stock exchange(بورس), Farabourse(فرابورس), base market(بازارهای پایه), bonds (اوراق) and etc..., and the features mentioned below can be used for all stocks in all different markets.

## 📝 Documentation 
The full documentation access in [wiki](https://github.com/AFP33/TSE/wiki). hope it's useful.

## 📌 How to Use
you have two option for use the library:
1. Get the project and build it by youself. [*how to?*](https://github.com/AFP33/TSE/wiki/2.-How-to-build-Project)
2. Download [*Tse.dll*](https://github.com/AFP33/TSE/releases) in Relase page and reference it in your project. [*how to?*](https://github.com/AFP33/TSE/wiki/3.-How-to-add-the-Tse.dll-to-project)

## 📌 Features List

### Market Feature List
<table>
   <thead>
      <tr>
         <th>Feature name</th>
         <th>tsetmc name</th>
         <th>status</th>
      </tr>
   </thead>
   <tbody>
      <tr> <td>Bourse at Glance</td> <td>بورس اوراق بهادار تهران</td> <td>✔</td> </tr>
      <tr> <td>Farabourse at Glance</td> <td>فرابورس ایران</td> <td>✔</td> </tr>
      <tr> <td>Search Stock</td> <td>جستجوی سهام</td> <td>✔</td> </tr>
      <tr> <td>All Stocks</td> <td>همه نمادهای مارکت</td> <td>✔</td> </tr>
      <tr> <td>Chosen Indexes</td> <td>شاخص های منتخب بورس</td> <td>✔</td> </tr>
      <tr> <td>Effective on Index</td> <td>تاثیر در شاخص بورس</td> <td>✔</td> </tr>
      <tr> <td>Effective on Index</td> <td>تاثیر در شاخص فرا بورس</td> <td>✔</td> </tr>
      <tr> <td>Top Transaction Symbol</td> <td>نماد های پر تراکنش بورس</td> <td>✔</td> </tr>
      <tr> <td>Top Transaction Symbol</td> <td>نماد های پر تراکنش فرا بورس</td> <td>✔</td> </tr>
   </tbody>
</table>

### Stock Feature List

<table>
   <thead>
      <tr>
         <th>Feature name</th>
         <th>tsetmc name</th>
         <th>status</th>
      </tr>
   </thead>
   <tbody>
      <tr> <td>Brief Information</td> <td>در یک نگاه</td> <td>✔</td> </tr>
      <tr> <td>Stock Transaction History</td> <td>سابقه</td> <td>✔</td> </tr>
      <tr> <td>Announcements</td> <td>اطلاعیه ها</td><td>✔</td> </tr>
      <tr> <td>Company Identity</td> <td>شناسه</td><td>✔</td> </tr>
      <tr> <td>Balance Sheet</td> <td>ترازنامه</td><td>✔</td> </tr>
      <tr> <td>Council Announcement</td> <td>آگهی مجمع</td><td>✔</td> </tr>
      <tr> <td>Status Change</td> <td>تغییر وضعیت</td><td>✔</td> </tr>
      <tr> <td>Board of Director</td> <td>هئیت مدیره</td><td>✔</td> </tr>
      <tr> <td>Real Legal</td> <td>حقیقی و حقوقی</td><td>✔</td> </tr>
      <tr> <td>Stockholder</td> <td>سهامداران</td><td>✔</td> </tr>
      <tr> <td>EPS</td> <td>EPS</td><td>✔</td> </tr>
      <tr> <td>DPS</td> <td>DPS</td><td>✔</td> </tr>
      <tr> <td>Company Info</td> <td>معرفی شرکت</td><td>✔</td> </tr>
      <tr> <td>Cost Benefit</td> <td>سود و زیان</td><td>✔</td> </tr>
      <tr> <td>Supervisor Message</td> <td>پیام های ناظر</td><td>✔</td> </tr>
      <tr> <td>Produce and Sales</td> <td>تولید و فروش</td><td>❌ No, in develop</td> </tr>
      <tr> <td>Council Decision</td> <td>تصمیمات مجمع</td><td>❌ No, in develop</td> </tr>
      <tr> <td>Portfo</td> <td>پرتفوی</td><td>❌ No, in develop</td> </tr>
      <tr> <td>Statistics</td> <td>آمار</td><td>❌ No, in develop</td> </tr>
   </tbody>
</table>

## 📌 Examples
   See the [wiki](https://github.com/AFP33/TSE/wiki) page.

## 📌 Develop
if you want to help in develop, create `branch` and finally send the `pull requests`.

## 📌 Contact me
if you have a problem in working with the library you can send [`ISSUE`](https://github.com/AFP33/TSE/issues) in issues page.
otherwise you can reach me with this Telegram ID: [@afp33dev](https://telegram.me/afp33dev)
