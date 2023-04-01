using Newtonsoft.Json;
using RestSharp;
using System.Text.Json.Serialization;

namespace POFrontEnd.Helpers
{
    public class ReqAPI
    {
        public APIResponse GetAPIResponse(string url, Method method, object reqBody)
        {
            var client = new RestClient();
            var request = new RestRequest(url, method);

            request.AddParameter("application/json", JsonConvert.SerializeObject(reqBody), ParameterType.RequestBody);
            var response = client.Execute(request);
            var dataResponse = JsonConvert.DeserializeObject<APIResponse>(response.Content.ToString());

            return dataResponse;
        }

        public async Task<APIResponse> GetAPIResponseAsync(string url, Method method)
        {
            var client = new RestClient();
            var request = new RestRequest(url, method);
            var response = await client.ExecuteAsync(request);
            var dataResponse = JsonConvert.DeserializeObject<APIResponse>(response.Content.ToString());

            return dataResponse;
        }
    }
}
