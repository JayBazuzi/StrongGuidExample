public readonly record struct UserId(Guid Value);

public class StrongGuid
{
    public UserId momUserId;
    public UserId dadUserId;

    public StrongGuid(UserId momUserId, UserId dadUserId)
    {
        this.momUserId = momUserId;
        this.dadUserId = dadUserId;
    }

    void F()
    {
        momUserId = dadUserId; // warning SIA001: Value with [Id("DadUser")] is assigned to a target with [Id("MomUser")]
    }
}



