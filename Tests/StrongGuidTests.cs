using Xunit;


public class StrongGuidTests
{
    [Fact]
    public void CanBeConstructed()
    {
        var _ = new StrongGuid(new UserId(Guid.NewGuid()), new UserId(Guid.NewGuid()));
    }
}
