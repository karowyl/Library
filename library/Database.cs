
using System.Data.SQLite;
using System;
using System.Collections.Generic;
using System.Windows.Forms;



namespace library
{
    class Database
    {
        public SQLiteConnection myConnection { get; set; }


        public Database()
        {
            myConnection = new SQLiteConnection("data source=database.library.db");
        }

        public void OpenConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Open)
                myConnection.Open();
        }

        public void CloseConnection()
        {
            if (myConnection.State != System.Data.ConnectionState.Closed)
                myConnection.Close();
        }

        public void Registration(User user)
        {
            string passwordProtection = Protection.CreateMD5(user.Password);

            // inserting user
            string createUser = "INSERT INTO Users('Login', 'Password', 'FirstName', 'LastName', 'PhoneNumber', 'EmailAddress') VALUES ( @login, @password, @firstName, @lastName, @phoneNumber, @emailAddress)";
           

            try
            {
                OpenConnection();
                // checking user id 
                int userID = CheckId(user);

                // creatining user
                SQLiteCommand cmd = new SQLiteCommand(createUser, myConnection);

                cmd.Parameters.AddWithValue("@login", user.Login);
                cmd.Parameters.AddWithValue("@password", passwordProtection);
                cmd.Parameters.AddWithValue("@firstName", user.FirstName);
                cmd.Parameters.AddWithValue("@lastName", user.LastName);
                cmd.Parameters.AddWithValue("@phoneNumber", user.PhoneNumber);
                cmd.Parameters.AddWithValue("@emailAddress", user.EmailAddress);
                cmd.ExecuteNonQuery();

                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                CloseConnection();
            }
        }

        private int CheckId(User user)
        {
            string checkId = "SELECT * FROM Users WHERE login = @login";
            try
            {
                SQLiteCommand cmd = new SQLiteCommand(checkId, myConnection);
                cmd.Parameters.AddWithValue("@login", user.Login);
                var results = cmd.ExecuteReader();

                while (results.Read())
                {
                    if (results["login"].ToString() == user.Login)
                        return Convert.ToInt32(results["user_id"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                CloseConnection();
            }
            return 0;
        }


        public User Login(string login)
        {
            string loginUserRequest = "SELECT * FROM users WHERE Login = @login";
            try
            {
                OpenConnection();
                SQLiteCommand cmd = new SQLiteCommand(loginUserRequest, myConnection);

                cmd.Parameters.AddWithValue("@login", login);

                var results = cmd.ExecuteReader();
                results.Read();

                string llogin = results["login"].ToString();
                string password = results["password"].ToString();
                string firstName = results["FirstName"].ToString();
                string lastName = results["lastName"].ToString();
                string phoneNumber = results["phoneNumber"].ToString();
                string emailAddress = results["emailAddress"].ToString();
                int id = Convert.ToInt32(results["User_id"].ToString());
                int permi = Convert.ToInt32(results["Permission"].ToString());
                results.Close();
                CloseConnection();
                return new User(llogin, password, firstName, lastName, phoneNumber, emailAddress, id, permi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                CloseConnection();
                return new User();
            }

            
        }

        public List<User> GetUsers()
        {
            OpenConnection();
            string query = "SELECT * FROM users";
            SQLiteDataReader datareader;
            SQLiteCommand cmd = new SQLiteCommand(query, myConnection);
            datareader = cmd.ExecuteReader();
            List<User> users = new List<User>();

            while (datareader.Read())
            {
                try
                {
                    string loginUser = datareader["login"].ToString(); 
                    string passwordUser = datareader["password"].ToString();
                    string firstNameUser = datareader["firstName"].ToString();
                    string lastNameUser = datareader["lastName"].ToString();
                    string phoneNumberUser = datareader["phoneNumber"].ToString();
                    string emailAddressUser = datareader["emailAddress"].ToString();
                    int idUser = Convert.ToInt32(datareader["user_id"].ToString());
                    int permissionUser = Convert.ToInt32(datareader["permission"].ToString());

                    User user = new User(loginUser, passwordUser, firstNameUser, lastNameUser, phoneNumberUser, emailAddressUser, idUser, permissionUser);
                    users.Add(user);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    CloseConnection();
                    return new List<User>();
                }
            }
            CloseConnection();
            return users;
        }

        public void RemoveUser(int Id)
        {
            
            try
            {
                OpenConnection();
                string removeUser = "DELETE FROM Users WHERE User_id = @Id";
                SQLiteCommand cmd = new SQLiteCommand(removeUser, myConnection);
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                CloseConnection();
            }

        }

        public void ModifyUser(int id, string login, string firstName, string lastName, string phoneNumber, string emailAddress, string permission)
        {
            
            try
            {
                OpenConnection();
                string modifyUser = "UPDATE Users SET Login=@login, FirstName=@firstName, LastName=@lastName, PhoneNumber=@phoneNumber, EmailAddress=@emailAddress, Permission=@permission  WHERE User_id ='" + id + "'";
                SQLiteCommand cmd = new SQLiteCommand(modifyUser, myConnection);

                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@firstName", firstName);
                cmd.Parameters.AddWithValue("@lastName", lastName);
                cmd.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                cmd.Parameters.AddWithValue("@emailAddress", emailAddress);
                cmd.Parameters.AddWithValue("@permission", permission);

                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message, "Error");
                CloseConnection();
            }
        }

        public void RemoveBook(int Id)
        {
            string removeBook = "DELETE FROM Books WHERE Book_id = @Id";

            try
            {
                OpenConnection();
                SQLiteCommand cmd = new SQLiteCommand(removeBook, myConnection);
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                CloseConnection();
            }
        }

        public void ModifyBook(int id, string author, string title, string type, string date, int pages)
        {
            string modifyBook = "UPDATE Books SET Author=@author, Title=@title, Type=@type, Date=@date, Pages=@pages  WHERE Book_id = @id";

            try
            {
                OpenConnection();
                SQLiteCommand cmd = new SQLiteCommand(modifyBook, myConnection);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@pages", pages);

                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                CloseConnection();
            }
        }

        public void AddBook(Book book)
        {
            // inserting user
            string createBook = "INSERT INTO Books('Author', 'Title', 'Type', 'Date', 'Pages') VALUES ( @author, @title, @type, @date, @pages)";

            try
            {
                OpenConnection();

                // creatining book
                SQLiteCommand cmd = new SQLiteCommand(createBook, myConnection);

                cmd.Parameters.AddWithValue("@author", book.Author);
                cmd.Parameters.AddWithValue("@title", book.Title);
                cmd.Parameters.AddWithValue("@type", book.Type);
                cmd.Parameters.AddWithValue("@date", book.Date);
                cmd.Parameters.AddWithValue("@pages", book.Pages);
                cmd.ExecuteNonQuery();

                CloseConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                CloseConnection();
            }

        }

        public List<Book> GetBooks(string query)
        {
            OpenConnection();
            SQLiteDataReader datareader;
            SQLiteCommand cmd = new SQLiteCommand(query, myConnection);
            datareader = cmd.ExecuteReader();
            List<Book> books = new List<Book>();

            while (datareader.Read())
            {
                try
                {
                    int book_id = Convert.ToInt32(datareader["book_id"].ToString());
                    string author = datareader["author"].ToString();
                    string title = datareader["title"].ToString();
                    string type = datareader["type"].ToString();
                    string date = datareader["date"].ToString();
                    int pages = Convert.ToInt32(datareader["pages"].ToString());
                    int available = Convert.ToInt32(datareader["available"].ToString());

                    Book book = new Book(book_id, author, title, type, date, pages, available);
                    books.Add(book);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    CloseConnection();
                    return new List<Book>();
                }
            }
            datareader.Close();
            CloseConnection();
            return books;
        }
        public List<Book> GetBorrowedBooks(Client user)
        {
            OpenConnection();
            string query = "SELECT * FROM BorrowedBooks JOIN Books ON BorrowedBooks.IdBook = Books.Book_Id WHERE IdUser = @Id";
            SQLiteDataReader datareader;
            SQLiteCommand cmd = new SQLiteCommand(query, myConnection);
            cmd.Parameters.AddWithValue("@Id", user.User_id);
            datareader = cmd.ExecuteReader();
            List<Book> books = new List<Book>();

            while (datareader.Read())
            {
                try
                {
                    int book_id = Convert.ToInt32(datareader["book_id"].ToString());
                    string author = datareader["author"].ToString();
                    string title = datareader["title"].ToString();
                    string type = datareader["type"].ToString();
                    string date = datareader["date"].ToString();
                    int pages = Convert.ToInt32(datareader["pages"].ToString());
                    int available = Convert.ToInt32(datareader["available"].ToString());

                    Book book = new Book(book_id, author, title, type, date, pages, available);
                    books.Add(book);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                    CloseConnection();
                    return new List<Book>();
                }
            }
            datareader.Close();
            CloseConnection();
            return books;
        }
        public void ReturnBook(int Id)
        {
            try
            {
                OpenConnection();
                string returnBook = "DELETE FROM BorrowedBooks WHERE IdBook = @Id";
                string changeAvailabel = "UPDATE Books SET Available= @One WHERE Book_id = @Id";

                SQLiteCommand cmd = new SQLiteCommand(returnBook, myConnection);
                SQLiteCommand cmd2 = new SQLiteCommand(changeAvailabel, myConnection);

                cmd.Parameters.AddWithValue("@Id", Id);
                cmd2.Parameters.AddWithValue("@One", 1);
                cmd2.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                CloseConnection();
            }
            
        }
        public bool IsBorrowed(int Id)
        {
            try
            {
                OpenConnection();
                string query = "SELECT * FROM Books WHERE Book_id = @Id";
                SQLiteCommand cmd = new SQLiteCommand(query, myConnection);
               
                cmd.Parameters.AddWithValue("@Id", Id);

                var reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    if (reader["Available"].ToString() == "0")
                    {
                        reader.Close();
                        return true;
                    }

                }
                reader.Close();

                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                CloseConnection();
            }
            return false;
        }

        public void BorrowBook(Client client, int Id)
        {
            try
            {
                OpenConnection();
                string borrowBook = "INSERT INTO BorrowedBooks('IdUser', 'IdBook') VALUES ( @c_uid, @Id)";
                string changeAvailabel = "UPDATE Books SET Available= @zero  WHERE Book_id = @Id";

                SQLiteCommand cmd = new SQLiteCommand(borrowBook, myConnection);
                SQLiteCommand cmd2 = new SQLiteCommand(changeAvailabel, myConnection);
                cmd.Parameters.AddWithValue("@c_uid", client.User_id);
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd2.Parameters.AddWithValue("@zero", 0);
                cmd2.Parameters.AddWithValue("@Id", Id);
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                CloseConnection();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                CloseConnection();
            }
        }

        public void AddOpinion(Client client, int Id, string opinion)
        {

            try
            {
                OpenConnection();
                string addOpinion = "INSERT INTO Opinions('IdUser', 'IdBook', 'Opinion') VALUES ( @c_uid, @Id, @Opinion)";

                SQLiteCommand cmd = new SQLiteCommand(addOpinion, myConnection);
                cmd.Parameters.AddWithValue("@c_uid", client.User_id);
                cmd.Parameters.AddWithValue("@Id", Id);
                cmd.Parameters.AddWithValue("@Opinion", opinion);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                CloseConnection();
            }
            

        }

        public List<Opinion> GetOpinions(int Id)
        {
            List<Opinion> opinions = new List<Opinion>();
            try
            {
                OpenConnection();
                string selectOpinions = "SELECT * FROM OPINIONS WHERE IdBook = @Id";

                SQLiteCommand cmd = new SQLiteCommand(selectOpinions, myConnection);
                cmd.Parameters.AddWithValue("@Id", Id);
                var result = cmd.ExecuteReader();

                while (result.Read())
                {
                    string desctription = result["Opinion"].ToString();
                    int userId = Convert.ToInt32(result["IdUser"].ToString());
                    int bookId = Convert.ToInt32(result["IdBook"].ToString());
                    int opinionId = Convert.ToInt32(result["IdOpinion"].ToString());
                    opinions.Add(new Opinion(desctription, opinionId, userId, bookId));
                }
                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                CloseConnection();
            }

            return opinions;
        }

        public string  GetUser(int Id)
        {
            string firstName = "";
            try
            {
                OpenConnection();

                string selectOpinions = "SELECT * FROM Users WHERE User_Id = @Id";

                SQLiteCommand cmd = new SQLiteCommand(selectOpinions, myConnection);
                cmd.Parameters.AddWithValue("@Id", Id);
                var result = cmd.ExecuteReader();

                while (result.Read())
                {
                    firstName = result["FirstName"].ToString();
                }
                result.Close();

                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                CloseConnection();
            }
            return firstName;
        }

        public string GetBook(int Id)
        {
            string title = "";
            try
            {
                OpenConnection();
                string selectOpinions = "SELECT * FROM Books WHERE Book_Id = @Id";

                SQLiteCommand cmd = new SQLiteCommand(selectOpinions, myConnection);
                cmd.Parameters.AddWithValue("@Id", Id);
                var result = cmd.ExecuteReader();

                while (result.Read())
                {
                    title = result["Title"].ToString();
                }

                result.Close();

                CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                CloseConnection();
            }
            
            return title;
        }

       
    }
}
