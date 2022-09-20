using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NoSqlProvider.Shared.Classes
{
    public class FirestoreSettings
    {
        [JsonPropertyName("project_id")]
        public string? ProjectId { get; set; }

        [JsonPropertyName("private_key_id")]
        public string? PrivateKeyId { get; set; }
    }
}
