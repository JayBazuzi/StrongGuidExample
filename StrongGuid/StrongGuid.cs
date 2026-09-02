public readonly record struct UserId(Guid Value);

public class StrongGuid
{
    [Id("UserId")]
    public UserId momUserId;
    [Id("UserId")]
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



