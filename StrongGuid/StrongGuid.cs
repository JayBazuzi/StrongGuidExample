

public class StrongGuid
{
    public string? _entraObjectId;

    public void G(Microsoft.Graph.Models.User entraUser)
    {
        if (entraUser.Id == null)
        {
            throw new ArgumentNullException(nameof(entraUser));
        }
        _entraObjectId = entraUser.Id; // warning SIA001: Value with [Id("User/DirectoryObject")] is assigned to a target with [Id("EntraObject")]
    }
}



