namespace Task01.Models
{
    public static class UserDb
    {
        public static List<User> Users {  get; set; } 
        
        static UserDb()
        {
            Users = new List<User>()
            {
                new User(1, "Jhonny", 21),
                new User(2, "Eva", 24),
                new User(3, "Petko", 23),
                new User(4, "Cvetko", 31),
                new User(5, "Mishko", 33),
            };
        }

        public static List<User> Search(int? id = null, string name = null, int? age = null)
        {
            return SearchHelper.Search(Users, id, name, age);
        }

    }
}
