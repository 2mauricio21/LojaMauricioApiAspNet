namespace LojaMauricio.WebAPI.Dal
{
    public class User
    {
        public static Model.User Get(string username, string password) 
        {
            var users = new List<Model.User>();
            users.Add(new Model.User { Id = 1, UserName = "admin", Password = "admin", Role = "manager" });
            users.Add(new Model.User { Id = 2, UserName = "empregado", Password = "empregado", Role = "employee" });
            return users.FirstOrDefault(x => x.UserName == username && x.Password == password)!;
        }
    }
}
