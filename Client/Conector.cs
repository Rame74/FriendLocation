using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    static class Conector
    {
        public static T GetApiResult<T>(Uri uri)
        {
            string token = "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJpZCI6ImY1ZmU4YThjLTdiYmEtNGE5MS04MzliLT" +
                           "NhOTdjMmM2NTY0NCIsIm5hbWUiOiJSYWZhZWwgTWVsbyIsImV4cCI6MTUzODM2Mjc5OX0.s4youOwsV" +
                           "2bT553iJFtkkpIj0Mmv2H3_srrD5jdXTCtgc_SgZPf7tRwXeEkERv7QDnQxh4PGAJDLQpTpKnVBLw";

            using (var httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", token);

                var response = httpClient.GetStringAsync(uri).Result;

                var friends = JsonConvert.DeserializeObject<T>(response);

                return friends;
            }
        }

        public static void PostToApi(Uri uri, string value)
        {
            using (var httpClient = new HttpClient())
            {
                string token = "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJpZCI6ImY1ZmU4YThjLTdiYmEtNGE5MS04MzliLT" +
                               "NhOTdjMmM2NTY0NCIsIm5hbWUiOiJSYWZhZWwgTWVsbyIsImV4cCI6MTUzODM2Mjc5OX0.s4youOwsV" +
                               "2bT553iJFtkkpIj0Mmv2H3_srrD5jdXTCtgc_SgZPf7tRwXeEkERv7QDnQxh4PGAJDLQpTpKnVBLw";

                httpClient.DefaultRequestHeaders.Add("Authorization", token);

                var content = new StringContent(value, Encoding.UTF8, "application/json");

                var result = httpClient.PostAsync(uri, content).Result;
            }
        }
    }
}
