using System;

namespace DesignPattern.Factory
{
    //ref:
    // https://refactoring.guru/design-patterns/factory-method/csharp/example

    public static class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType type)  // Returns an IDatabase implementation depending on which database type is requested.

        {
            return type switch
            {
                DatabaseType.SqlServer => new SqlServerDatabase(), // Create SQL Server DB
                DatabaseType.Oracle => new OracleDatabase(),// Create Oracle DB
                _ => throw new ArgumentException("Unsupported database type")
            };
        }
    }
}
