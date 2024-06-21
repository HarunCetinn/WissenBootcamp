using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace JsonSerialization
{
    public class Kullanici
    {
        [JsonPropertyName("User ID")]
        public int KullaniciID {  get; set; }
        [JsonPropertyName("User Name")]
        public string KullaniciAdi {  get; set; }
        [JsonPropertyName("Password")]
        public string Parola {  get; set; }
        [JsonPropertyName("State")]
        public bool Durum {  get; set; }

        [JsonIgnore]
        public List<LoginInformation> LoginInfo { get; set; }
    }
}
