public readonly record struct UserId(Guid Value);

public class StrongGuid
{
    public UserId momUserId;
    public UserId dadUserId;
    private UserId _childUserId;


    public StrongGuid(UserId momUserId, UserId dadUserId, UserId childUserId)
    {
        this.momUserId = momUserId;
        this.dadUserId = dadUserId;

        this._childUserId = childUserId;

    }

    void F()
    {
        momUserId = dadUserId; // warning SIA001: Value with [Id("DadUser")] is assigned to a target with [Id("MomUser")]
    }
}



