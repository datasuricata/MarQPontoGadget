using Newtonsoft.Json;
using System;

namespace MarqPontoExtension.Entities
{
    public class UserPointJson
    {
        [JsonProperty("ImageUri")]
        public string ImageUri { get; set; }

        [JsonProperty("Company")]
        public object Company { get; set; }

        [JsonProperty("CompanyId")]
        public string CompanyId { get; set; }

        [JsonProperty("User")]
        public object User { get; set; }

        [JsonProperty("UserId")]
        public string UserId { get; set; }

        [JsonProperty("Hour")]
        public DateTimeOffset Hour { get; set; }

        [JsonProperty("Date")]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("UserPointType")]
        public long UserPointType { get; set; }

        [JsonProperty("DeviceType")]
        public long DeviceType { get; set; }

        [JsonProperty("PointNumber")]
        public long PointNumber { get; set; }

        [JsonProperty("DeviceId")]
        public string DeviceId { get; set; }

        [JsonProperty("Version")]
        public string Version { get; set; }

        [JsonProperty("Latitude")]
        public string Latitude { get; set; }

        [JsonProperty("Longitude")]
        public string Longitude { get; set; }

        [JsonProperty("PointReference")]
        public long PointReference { get; set; }

        [JsonProperty("CodeType")]
        public object CodeType { get; set; }

        [JsonProperty("Id")]
        public string Id { get; set; }

        [JsonProperty("CreatedAt")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("Deleted")]
        public bool Deleted { get; set; }

        [JsonProperty("UpdatedAt")]
        public object UpdatedAt { get; set; }
    }
}
