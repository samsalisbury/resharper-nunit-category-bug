resharper-nunit-category-bug
============================

Issues with ReSharper recognising NUnit test fixture categories

# Issue 1: Run all tests - erroneous `Uncategorized` category

To Reproduce:

1. Open the solution in Visual Studio 2013 with ReSharper 8.1.
2. Open MyTestFixture.cs
3. Right click in the code editor, and select 'Run Unit Tests'.
4. Observe the output in 'Unit Test Sessions' window.

### Expected output in 'Unit Test Sessions':
* 2 categories are shown, `Cat1` and `Cat2`, one passing and one failing.

### Actual output in 'Unit Test Sessions':
* There are 3 categories shown, `Cat1`, `Cat2`, and `Uncategorized`
* All 3 categories are shown to have failed
* One individual test has passed (the one in 'Cat1'). Being the only test in that category, the category should also have passed.


# Issue #2: Run one passing test in one category - all categories said to have passed

To Reproduce:

1. Open the solution in Visual Studio 2013 with ReSharper 8.1.
2. Open MyTestFixture.cs
3. In the left-hand gutter on line 17, click the 'NUnit Test' icon, and select `MyTestFixture(True).MyTest` -> `Run`
4. Observe the output in 'Unit Test Sessions' window.

### Expected output in 'Unit Test Sessions':
* 1 Category shown `Cat1`, with 1 passing test

### Actual output in 'Unit Test Sessions':
* 3 Categories shown: `Cat1`, `Cat2`, and `Uncategorized`
* All 3 categories shown to have passed