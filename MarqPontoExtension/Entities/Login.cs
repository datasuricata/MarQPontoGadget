namespace MarqPontoExtension.Entities
{
    public class Login
    {
        public Login(string username, string password, string grant_type)
        {
            this.username = username;
            this.password = password;
            this.grant_type = grant_type;
        }

        public string username { get; set; }
        public string password { get; set; }
        public string grant_type { get; set; }
    }
}
