public interface IAuditService
{
    void LogCommandExecution(string commandName);
}

public class AuditService : IAuditService
{
    public void LogCommandExecution(string commandName)
    {
        // Generate a timestamp and log the command execution details to a file or database
        string logEntry = $"{DateTime.UtcNow:yyyy-MM-dd HH:mm:ss} - Executed command: {commandName}";
        
        // Write the logEntry to a file on disk
        File.AppendAllText("audit.log", logEntry + Environment.NewLine);
    }
}
