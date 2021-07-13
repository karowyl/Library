using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library
{
    public class Opinion
    {
        public string Description { get; set; }
        public int OpinionId { get; set; }
        public int UserId { get; set; }
        public int BookId { get; set; }


        public Opinion(string description, int opinionId, int userId, int bookId)
        {
            Description = description;
            OpinionId = opinionId;
            UserId = userId;
            BookId = bookId;
        }

        public Opinion()
        {
            Description = "";
            OpinionId = 0;
            UserId = 0;
            BookId = 0;
        }

        public string GetUser(int Id)
        {
            Database database = new Database();
            return database.GetUser(Id);

        }
        public string GetBook(int Id)
        {
            Database database = new Database();
            return database.GetBook(Id);

        }
    }
}
