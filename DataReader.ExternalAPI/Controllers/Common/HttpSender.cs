using System.Net.Http.Headers;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Text;


namespace DataReader.ExternalAPI.Controllers.Common
{
  public static class HttpSender
  {
    public static async Task<string> GetFromAzure(string query, string pat)
    {
      string result = "";

      string link = $"https://analytics.dev.azure.com/KAPPASTAR-IT/_odata/v3.0/" + query;

      using (HttpClient client = new HttpClient())
      {
        client.DefaultRequestHeaders.Accept.Add(
           new MediaTypeWithQualityHeaderValue("application/json"));

        client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic",
        Convert.ToBase64String(
                ASCIIEncoding.ASCII.GetBytes(
                    string.Format("{0}:{1}", "", pat))));

        using (HttpResponseMessage response = client.GetAsync(link).Result)
        {
          response.EnsureSuccessStatusCode();
          string responseBody = await response.Content.ReadAsStringAsync();
          result = JToken.Parse(responseBody).ToString(Formatting.Indented);
        }
      }

      return result;
    }
  }
}
