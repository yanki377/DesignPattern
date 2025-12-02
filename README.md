1. Factory Pattern

-File modified: Factory/DatabaseFactory.cs
-Implemented the CreateDatabase method.
-Added logic to return the correct database object (SqlServerDatabase or OracleDatabase) depending on the enum input.


2. Adapter Pattern

-File modified: Adapter/EmployeeAdapter.cs
-Implemented the ProcessCompanySalary method.
-Converted the HR string[,] data into a List<Employee> collection.
-Passed the converted list to the third-party BillingSystem so it could process salaries.
-All other adapter files were kept as provided.

3. Observer Pattern

-File modified: Observer/Observer.cs
-Completed the ConcreteObserver class.
-Added methods to subscribe and unsubscribe from a Subject.
-Implemented Update to show notifications when product availability changes.
-Subject and interface files were left untouched.
