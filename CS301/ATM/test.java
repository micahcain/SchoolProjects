   import java.net.URL;
   import java.net.MalformedURLException;
   import java.sql.SQLException;

    public class test {
   
       public static void main(String[] args) {
      
         Connection c;
         Statement s;
         ResultSet r;
      
         try {
            SQL sql = new SQL();
            String url = "http://www.boehnecamp.com/phpMyAdmin/razorsql_mysql_bridge.php?database=ATM&tablename=accountInformation";
            c = sql.getConnection(url);
            s = c.createStatement(url);
            r = s.executeQuery("SELECT * FROM accountInformation");
            s.executeUpdate("UPDATE accountInformation SET balanceAmount = 1000.00 WHERE accountNumber = '12548693'");
         }
             catch (SQLException e) {
               System.out.println("EEEERRRRRRRROOORRR");
            }
      }
   
   }