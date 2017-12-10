# Mobile-Project-Year4
> Module: Mobile Applications Development 2 / 4th Year  
> Lecturer: Damien Costello  
> Mobile Project 2017 : MenuApp.

> Student : Weichen Wang

This application project was developed based on [MVVM](https://msdn.microsoft.com/en-us/library/hh848246.aspx) design patterns.

## What is MVVM?
#### The MVVM pattern includes three key parts:
1. `Model` (Business rule, data access, model classed).
2. `View` (User interface (XAML)).
3. `ViewModel` (Agent or middle man between view and model).

The `ViewModel` acts as an interface between `Model` and `View`. It provides data binding between `View` and `model` data as well as handles all UI actions by using command.

The `View` binds its control value to properties on a `ViewModel`, which, in turn, exposes data contained in `Model` objects.

## Why use MVVM?
In traditional UI development - developer used to create a View using window or user control or page and then write all logical code (Event handling, initialization and data model, etc.) in the code behind and hence they were basically making code as a part of view definition class itself. This approach increased the size of the View class and created a very strong dependency between my UI and data binding logic and business operations. In this situation, no two developers can work simultaneously on the same view and also one developer's changes might break the other code. So everything is in one place is always a bad idea for maintainability, extendibility and testability prospective. So if you look at the big picture, you can feel that all these problems exist because there is a very tight coupling between the following items.

```
1. View (UI)
2. Model (Data displayed in UI)
3. Glue code (Event handling, binding, business logic)
```
In MVVM the Glue code is View Model. So it basically focuses on separation of concerns to make the implementation of an application structure a lot more simpler to create as well as maintain.

If property values in the ViewModel change, those new values automatically propagate to the view via data binding and via notification. When the user performs some action in the view for example clicking on save button, a command on the ViewModel executes to perform the requested action. In this process, it’s the ViewModel which modifies model data, View never modifies it. The view classes have no idea that the model classes exist, while the ViewModel and model are unaware of the view. In fact, the model doesn’t have any idea about ViewModel and view exists.

## MVVM Architecture:

![image](https://github.com/w326004741/Mobile-Project-Year4/blob/master/imges/1661512922301_.pic.jpg)

#### Structure:

![image](https://github.com/w326004741/Mobile-Project-Year4/blob/master/imges/Menu3.png)


## Reference:
[SplitView](https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls.splitview)

[ICommand Interface](https://www.codeproject.com/Tips/813345/Basic-MVVM-and-ICommand-Usage-Example)
