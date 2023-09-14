using DbUp;
using System;
using System.Reflection;

public static class DatabaseMigration
{
    public static void MigrateDatabase(string connectionString)
    {
        string scriptsLocation = Assembly.GetExecutingAssembly().Location.Replace("YourApp.dll", "DbScripts");

        EnsureDatabase.For.SqlDatabase(connectionString);

        var upgrader =
            DeployChanges.To
                .SqlDatabase(connectionString)
                .WithScriptsFromFileSystem(scriptsLocation)
                .LogToConsole()
                .Build();

        var result = upgrader.PerformUpgrade();

        if (!result.Successful)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(result.Error);
            Console.ResetColor();
            return;
        }

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Database migration successful!");
        Console.ResetColor();
    }
}
