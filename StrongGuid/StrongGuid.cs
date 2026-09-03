public readonly record struct UserId(Guid Value);

public class StrongGuid
{
    [Id("User")]
    public UserId momUserId;
    [Id("User")]
    public UserId dadUserId;

    public StrongGuid(UserId momUserId, UserId dadUserId)
    {
        this.momUserId = momUserId;
        this.dadUserId = dadUserId;
    }

    void F()
    {
        momUserId = dadUserId;
    }
}



