using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Xunit;

namespace XUnitTests
{
    public class TesteAPI
    {
        [Fact]
        public void InvalidToken()
        {
            var ex = Record.Exception(() => {

                HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create("http://localhost:60474/api/friends");
                httpReq.Headers.Add("Authorization", "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJpZCI6ImY1ZmU4YThjLTdiYmEtNGE5MS04MzliLTNhOTdjMmM2NTY0NCIsIm5hbWUiOiJSYWZhZWwgTWVsbyIsImV4cCI6MTUzODM2Mjc5OX0.s4youOwsV2bT553iJFtkkpIj0Mmv2H3_srrD5jdXTCtgc_SgZPf7tRwXlJhe547QDnQxh4PGAJDLQpTpKnVBL0");

                HttpWebResponse httpRes = (HttpWebResponse)httpReq.GetResponse();

            });

            Assert.Equal(HttpStatusCode.Unauthorized, ((HttpWebResponse)((WebException)ex).Response).StatusCode);
        }

        [Fact]
        public void ValidToken()
        {
            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create("http://localhost:60474/api/friends");
            httpReq.Headers.Add("Authorization", "eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJpZCI6ImY1ZmU4YThjLTdiYmEtNGE5MS04MzliLTNhOTdjMmM2NTY0NCIsIm5hbWUiOiJSYWZhZWwgTWVsbyIsImV4cCI6MTUzODM2Mjc5OX0.s4youOwsV2bT553iJFtkkpIj0Mmv2H3_srrD5jdXTCtgc_SgZPf7tRwXeEkERv7QDnQxh4PGAJDLQpTpKnVBL0");

            HttpWebResponse httpRes = (HttpWebResponse)httpReq.GetResponse();

            Assert.Equal(HttpStatusCode.OK, httpRes.StatusCode);
        }
    }
}
