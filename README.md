# Vendor and Order Tracker

#### An MVC Application for a Bakery

#### By Helen Lehrer

## Description

 An MVC application for a bakery that tracks vendors and purchased baked good belonging to those vendors. This application includes:

* A splash pages with a welcome message linking to a Vendors page
* A Vendors page that contains a link to a page with a form to create a new `Vendor` and clickable `Vendor` names that go to new page displaying the selected `Vendor` information and orders.
* On the selected `Vendor` page, there is a link to page with a form to create a new `Order` and a list of clickable `Order`s that display `Order` details.

Features:

* A splash page
* `Order` objects are nested within `Vendor` objects
* Multiple controllers 
* Throughly tested Models
* GET and POST requests
* MVC routes follow RESTful conventions

## Technologies Used

* .NET 5.0.401
* C#
* Git Bash
* MSTest

All functionality for the models are tested. The code uses custom classes, namespaces, autoimplemented properties, and class methods.

## Setup/Installation Requirements

Enter this command into your terminal to clone the project: 
```bash
$ git clone https://github.com/helen-lehrer/VendorTracker.Solution
```

Navigate from the root directory of the repo into the folder `VendorTracker`:
```bash
$ cd VendorTracker
```

Compile the code: 
```bash
$ dotnet build
```

---

#### Follow these instructions in your command line to set up **MSTest**:

Navigate from the root directory of the repo to folder `VendorTracker.Tests`: 
```bash
$ cd VendorTracker.Tests
```

Download & install **MSTest**: 
```bash
$ dotnet restore
```

To run **MSTest**, type this into your command line while you are inside of the VendorTracker.Tests folder: 
```bash
$ dotnet test
```

---

#### To run the application: 

Navigate from the root directory of the repo into the folder `VendorTracker`:
```bash
$ cd VendorTracker
```

Run the application:
```bash
$ dotnet run
```

## Known Bugs

*none

## License
[![License](https://img.shields.io/badge/License-BSD_3--Clause-blue.svg)](https://opensource.org/licenses/BSD-3-Clause)

&copy; _Copyright 2022 Helen Lehrer_
