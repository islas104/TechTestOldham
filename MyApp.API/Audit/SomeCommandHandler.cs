public class SomeCommandHandler
{
    private readonly IAuditService _auditService;

    public SomeCommandHandler(IAuditService auditService)
    {
        _auditService = auditService;
    }

    public void Handle(SomeCommand command)
    {
        // Handle the command logic
        
        // Log the command execution
        _auditService.LogCommandExecution("SomeCommand");
    }
}
