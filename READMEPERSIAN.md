# 📈📉📊 کتابخانه بازار بورس اوراق بهادار تهران

![love](https://ci.appveyor.com/api/projects/status/32r7s2skrgm9ubva?svg=true)
[![Made With Love](https://img.shields.io/badge/Made%20With-Love-orange.svg)](https://github.com/chetanraj/awesome-github-badges)
[![License: GPL v2](https://img.shields.io/badge/License-GPL%20v2-blue.svg)](https://github.com/AFP33/TSE/blob/master/LICENSE)


## مقدمه
این کتابخانه برای دریافت تمام اطلاعات از سایت مدیریت فناوری سازمان بورس و اوراق بهادار تهران توسعه داده شده است. همچنین این کتابخانه رایگان و متن باز است و در visual stdio توسعه داده شده است. برای توسعه این کتابخانه از [HtmlAgilityPack](https://html-agility-pack.net/) و [Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json) استفاده شده است. همانطور که احتمالا میدانید برای کار با این کتابخانه نیاز است به اینترنت متصل باشید.

مهمترین مزیت این کتابخانه با سایر کتابخانه های موجود این است که زمانی را برای ذخیره کردن داده نمی گذارد، اطلاعات را به صورت سریع و ساده از سایت دریافت میکند و عملیات ذخیره سازی را بسته به نوع پروژه شما به خودتان واگذار میکند. به همین دلیل کار با این کتابخانه از سرعت بالایی برای دریافت داده ها برخوردار خواهد بود. لازم به ذکر است که عملیات سریالایز کردن داده های دریافتی از سایت اصلی، به ساده ترین و سریع ترین روش صورت گرفته است. پیشنهادات شما به ما در پیشرفت این پروژه کمک خواهد کرد، نحوه دسترسی به بنده در بخش انتهایی و تماس با ما آمده است. ویژگی های دیگری مدنظر است که در آینده توسعه داده خواهد شد.

این کتابخانه به شما دسترسی به تمام سهام موجود در بازارهای بورس، فرابورس، بازارهای پایه، اوراق و ... را میدهد و ویژگی های لیست شده در زیر برای تمام سهام موجود در مارکت های مختلف بازار بورس تهران قابل دریافت است.

## مستندات
مستندات کامل در  بخش [مستندات](https://github.com/AFP33/TSE/wiki) موجود است که امیدوارم کمک کننده باشد.

## نحوه استفاده
برای استفاده از این کتابخانه شما دو راه دارید،
1. دریافت پروژه و Build کردن آن
2. اضافه کردن فایل [*Tse.dll*](https://github.com/AFP33/TSE/releases) به پروژه خودتان

در آینده و پس از تکمیل شدن پروژه این کتابخانه به لیست بسته های Nuget اضافه خواهد شد.


## لیست ویژگی های این کتابخانه

### لیست ویژگی های دسترسی به اطلاعات مارکت
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

### لیست ویژگی های دسترسی به اطلاعات سهام
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
      <tr> <td>Stock Queue</td> <td>تابلو معاملات</td> <td>✔</td> </tr>
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
      <tr> <td>Council Decision</td> <td>تصمیمات مجمع</td><td>✔</td> </tr>
      <tr> <td>Portfo</td> <td>پرتفوی</td><td>✔</td> </tr>
      <tr> <td>Statistics</td> <td>آمار</td><td>✔</td> </tr>
   </tbody>
</table>

## مثال ها
اگر به بخش [مستندات](https://github.com/AFP33/TSE/wiki/7.-Working-with-Stock-Handler) مراجعه کنید برای تمام ویژگی های موجود در کتابخانه مثال هایی در دسترس است.

## کمک به توسعه کتابخانه
در صورتی که مایل به همکاری در توسعه این کتابخانه هستید، کافی است یک Branch جدید بسازید و در نهایت توسعه خودتان را به صورت یک Pull Request ارسال کنید.

## تماس با من
اگر مشکلی در کار با کتابخانه دارید، لطفاً از بخش [`Issue`](https://github.com/AFP33/TSE/issues)، مشکل خودتان را مطرح کنید. در غیر اینصورت، میتوانید از لینک تلگرام به آدرس [@afp33dev](https://telegram.me/afp33dev) با بنده در ارتباط باشید
