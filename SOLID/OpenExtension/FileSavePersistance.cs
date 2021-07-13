
//If one class was tehre to save, we could have add two seperate methods to save data in DB and flat file. 
// By introducing the interface, we are extending the interface by seperate two class
public class FileSavePersistance : ISavePersistance{
    public void Save(){
        // Code to save the data in flat file
    }
}