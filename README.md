# ClubRegistration
A performance task in Computer Programming where I have to create a program that connects to the database. 
Tasks to accomplish the PT:
- Designing the UI layout of the Registration and the Updating layout
- Create a table named ClumMembers with the following coluums: ID,StudentID,FIRSTNAME,MIDDLENAME,LASTNAME,AGE,GENDER, and PROGRAM.
- Create a a class named ClubRegistrationQuery and import inside the class with "import System.Data.SqlClient,System Data, and System.Windows.Forms.
- Go to the constructor of the class ClubRegistrationQuery. Perform the following:
a. Initialize connectionString with the value of ClubDB's connection string.
NOTE: The connection string is located at the properties once you right-click the database file in the server
explorer.
b. Initialize your previously created SqlConnection object with connectionString as the
argument. Syntax: new SqlConnection(myConnectionString);
c. Instantiate your previously created DataTable and BindingSource objects.
  Declare a method named DisplayList() that returns a Boolean value true.
a. Declare a string variable named ViewClubMembers and set its value using a Select query
statement . Use only the StudentId , FirstName , MiddleName , LastName , Age, Gender , and
Program in the ClubMembers table.
b. Initialize your previously created SqlAdapter
ViewClubMembers and sqlConnect.
c. Add the following code:
i. dataTable.Clear();
object with two (2) arguments,
13 Task Performance 1
IT1907
*Property of STI
Page 4 of 6
ii. sqlAdapter.Fill(dataTable);
iii. bindingSource.DataSource = dataTable;
- Analyze and copy the given code below.
public bool RegisterStudent(int ID,long StudentID, string FirstName, string
MiddleName, string LastName, int Age, string Gender, string Program)
{
 sqlCommand = new SqlCommand("INSERT INTO ClubMembers VALUES(@ID, @StudentID,
@FirstName, @MiddleName, @LastName, @Age, @Gender, @Program)", sqlConnect);
 sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
 sqlCommand.Parameters.Add("@RegistrationID", SqlDbType.BigInt).Value = StudentID;
 sqlCommand.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = StudentID;
 sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
 sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
 sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
 sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
 sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
 sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;
 sqlConnect.Open();
 sqlCommand.ExecuteNonQuery();
 sqlConnect.Close();
 return true;
}
  - Go to FrmClubRegistration and declare the following. See Table 3.
Access Modifier Class / Data type Variable Name
Private ClubRegistrationQuery clubRegistrationQuery
int ID, Age, count
string FirstName, MiddleName,
LastName, Gender, Program
long StudentId
Table 3. Class and data type in FrmClubRegistration
- Create a method named RefreshListOfClubMembers and add the following code:
a. clubRegistrationQuery.DisplayList();
b. dataGridView.DataSource = clubRegistrationQuery.bindingSource;
11. Double click on the form of FrmClubRegistration to generate a Load event. Initialize the
ClubRegistrationQuery class and call the RefreshListOfClubMembers method.
- Create a method named RegistrationID that returns an integer value. This method will increment by
one (1) in each transaction. Use the count variable in Table 3.
- To add data to the database table, call the RegisterStudent() method of ClubRegistrationQuery
class to the Register button once it is clicked. This method contains parameters and calls all the inputs
by assigning in each variable given in Table 3. The ID variable will call the RegistrationID() method.
- Call the RefreshListOfClubMembers method for the Refresh button to display the added data
  
