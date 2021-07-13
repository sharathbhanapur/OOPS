public class SaveManager
{
    ISavePersistance savePersistance;

    // SavePersistance parameter type  can be of DBSavePersistance or FileSavePersistance
    public SaveManager(ISavePersistance savePersistance)
    {
        this.savePersistance = savePersistance;
    }
}

public class Client
{
    FileSavePersistance fileSavePersistance = new FileSavePersistance();
    DBSavePersistance dBSavePersistance = new DBSavePersistance();
    SaveManager saveManager = new SaveManager(FileSavePersistance);
    SaveManager saveManager = new SaveManager(DBSavePersistance);

}