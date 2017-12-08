# Mobile-Project-Year4
> Module: Mobile Application Development 2 / 4th Year  
> Lecturer: Damien Costello  
> Mobile Project 2017 : MenuApp

> Student : Weichen Wang

This application project was developed based on [MVVM](https://msdn.microsoft.com/en-us/library/hh848246.aspx) design patterns.

## What is MVVM?
#### The MVVM pattern includes three key parts:
1. `Model` (Business rule, data access, model classes).
2. `View` (User interface (XAML)).
3. `ViewModel` (Agent or middle man between view and model).
 

The `ViewModel` acts as an interface between `Model` and `View`. It provides data binding between `View` and `model` data as well as handles all UI actions by using command.

The `View` binds its control value to properties on a `ViewModel`, which, in turn, exposes data contained in `Model` objects.

