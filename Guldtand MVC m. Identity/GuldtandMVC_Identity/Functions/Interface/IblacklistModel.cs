namespace GuldtandMVC_Identity.Functions
{
    public interface IBlacklistModel
    {
        string[] InsertandgetBlackList(string category, Prj4databaseContext context);
    }
}