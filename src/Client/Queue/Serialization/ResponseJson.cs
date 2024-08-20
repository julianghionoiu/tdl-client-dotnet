using Newtonsoft.Json;
using TDL.Client.Queue.Abstractions.Response;

namespace TDL.Client.Queue.Serialization
{
    public class ResponseJson
    {
        [JsonProperty("result")]
        public required object Result { get; set; }

        [JsonProperty("error")]
        public string? Error { get; set; }

        [JsonProperty("id")]
        public required string Id { get; set; }

        public static string Serialize(IResponse response) =>
            JsonConvert.SerializeObject(From(response));

        private static ResponseJson From(IResponse response) =>
            new()
            {
                Result = response.Result,
                Error = null,
                Id = response.Id
            };
    }
}
