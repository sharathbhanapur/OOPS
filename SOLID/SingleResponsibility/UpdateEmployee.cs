
public class UpdateEmployee{

DbConnection dbConnection ;
ErrorLogging errorLogging ;
    public bool UpdateAddress(){
        try{
            /* Here database connection code is moved into different class instead of having logic over here.
                Update Address will have only responsibilty to update employee details */
                dbConnection.connectOracleDb();
        }
        catch{
            /* Here Error logging code is moved into different class instead of having logic over here.
             */
            errorLogging.log();
        }
    }
}
