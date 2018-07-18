namespace MarqPontoExtension.Commands
{
    public class SecurityCommand
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string expires_in { get; set; }
    }

    public static class Security
    {
        public static string Token { get; set; }
    }
}
