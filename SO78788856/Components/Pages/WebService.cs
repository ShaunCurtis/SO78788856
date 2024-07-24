namespace SO78788856.Components;

public record StatusData(string Name, string Status, DateTimeOffset Timestamp);

public class StatusService
{
    private List<StatusData> statusData = new List<StatusData>()
    {
        new("France", "Loaded", DateTimeOffset.Now.AddDays(-3)),
        new("Spain", "Loaded", DateTimeOffset.Now.AddDays(-2)),
        new("Portugal", "Loaded", DateTimeOffset.Now.AddDays(-1)),
    };

    public async ValueTask<IEnumerable<StatusData>> GetStatus()
    {
        statusData.Add(new("Me", "Loading", DateTimeOffset.Now));
        await Task.Yield();
        return statusData.AsEnumerable();
    }
}
