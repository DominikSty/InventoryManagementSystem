# InventoryManagementSystem
## Introduction
Program designed to manage items and categorize them. It has a simple description of the item: name, manufacturer, serial number, model, quantity, dimensions, weight and description. It makes it easy to review and collect information about stored items. For a large amount of data, a search engine is placed above the tables, searching every tuple of data. The application contains two tables: category and items (listed in category). Databases are files placed in the folder "/ims-data", and named the same as the category name with the extension ".imsdata". Databases as well as individual items contained in them can be freely created, edited and deleted. Tables dynamically adjust their width to the typed text, so that the whole is visible. In case of very long text, a scrollbar appears automatically in the tables.
## App screenshot
![Alt text](https://v1.padlet.pics/1/image.webp?t=c_limit%2Cdpr_1%2Ch_539%2Cw_958&url=https%3A%2F%2Fstorage.googleapis.com%2Fpadlet-uploads%2F109007466%2F93288c897ee1f873ea78af4b64d0333c%2Fimage.png%3FExpires%3D1677684641%26GoogleAccessId%3D778043051564-q79bsd8mc40b0bl82ikkrtc3jdofe4dg%2540developer.gserviceaccount.com%26Signature%3DewwxsPwVBz2u2nIpVOieZHUB98lzXRCVUnxaD%252F9RWrt%252FNU36qdBh%252BqAKmaOsz2gQIjRDCsVtOeaZjpNqCu20g%252Bo4x4ycW4InvBXaE0yvumJgbIGOLa09AaRjszqO3KSPrxQnvCbcf%252F0ZjQYA42gXSeOK%252FMFTYW2DWMdbNzjK6N4%253D%26original-url%3Dhttps%253A%252F%252Fpadlet-uploads.storage.googleapis.com%252F109007466%252F93288c897ee1f873ea78af4b64d0333c%252Fimage.png "Inventory Management System")
## Description of technologies used
The application was developed using the C# programming language along with the main Windows library. Forms. It was programmed under Microsoft. NET Framework version 4.0.30319 with default libraries.
## Compilation
An example way to compile an application is to use CMD command line commands:
Application without console
```bat
csc.exe /t:winexe /out:"Inventory Management System.exe" main.cs
```
Application with console in the background
```bat
csc.exe /t:exe /out:"Inventory Management System.exe" main.cs
```
