using MarqPontoExtension.Utils;

namespace MarqPontoExtension.Endpoints.Base
{
    public static class Endpoint
    {
        public static readonly string user = XmlUtilities.GetString("Server") + "api/v1/user/";

        public static readonly string security = XmlUtilities.GetString("Server") + "api/security/";
    }
}
