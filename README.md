# Inventory Management System
## Introduction
Program designed to manage items and categorize them. It has a simple description of the item: name, manufacturer, serial number, model, quantity, dimensions, weight and description. It makes it easy to review and collect information about stored items. For a large amount of data, a search engine is placed above the tables, searching every tuple of data. The application contains two tables: category and items (listed in category). Databases are files placed in the folder "/ims-data", and named the same as the category name with the extension ".imsdata". Databases as well as individual items contained in them can be freely created, edited and deleted. Tables dynamically adjust their width to the typed text, so that the whole is visible. In case of very long text, a scrollbar appears automatically in the tables.
## App screenshot
![image](https://user-images.githubusercontent.com/101213292/222105464-f142b474-5336-46ff-8aa1-f64901a76f41.png)
## Data in the database
These are the previously mentioned files with the extension ".imsdata" in the folder "/ims-data". The application creates them automatically in the absence of it (folder and files). They contain data lines separated by the character ";". If the item information is missing, an empty ellipse is entered: ";;". Each line corresponds to one saved item. For example, for an empty item, the line in the file looks like this:
```txt
;;;;;;;;
```
On the other hand, for the completed subject:
```txt
Pen;Pen-producer;123;456-456;Describe the pen... ;1000;13.5 x 0.5;0.36;
```
It is important that there is always a new line mark at the end. In texarea item description new line environment enter is char '0160' is automated conventer in to side.
## Description of technologies used
The application was developed using the C# programming language along with the main Windows.Forms library. It was programmed under Microsoft.NET Framework version 4.0.30319 with default libraries.
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
