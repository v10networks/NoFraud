using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace V10Networks.FraudDetection
{
    public class NoFraud
    {
        private static HttpClient httpClient = new HttpClient();
        private static string NoFraudEndPoint => "http://api.nofraud.co/";
        public async static Task<double> GetFraudScore(IPAddress address, string ApiKey = "")
        {
            var Response = await httpClient.GetAsync($"{NoFraudEndPoint}ip.php?ip={address.ToString()}");
            Double.TryParse(await Response.Content.ReadAsStringAsync(), out double Score);
            return Score;
        }
    }
}
