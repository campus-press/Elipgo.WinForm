using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Examen.Elipgo.BusinessLogic.Services
{
    public class RequestApi : IRequestApi
    {
        private readonly string _urlBase;

        public RequestApi(string urlBase)
        {
            _urlBase = urlBase;
        }

        public async Task<string> SendURIAsync(string endPoint, HttpMethod method, HttpContent httpContent = null)
        {
            string result = "";
            using (var client = new HttpClient())
            {
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (method.Method == "GET")
                    {
                        HttpRequestMessage httpRequest = new HttpRequestMessage
                        {
                            Method = method,
                            RequestUri = new Uri(_urlBase + endPoint),
                        };
                        httpRequest.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        httpResponse = await client.SendAsync(httpRequest);
                    }
                    else
                    {
                        HttpRequestMessage httpRequest = new HttpRequestMessage
                        {
                            Method = method,
                            RequestUri = new Uri(_urlBase + endPoint),
                            Content = httpContent,
                        };
                        httpRequest.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        httpResponse = await client.SendAsync(httpRequest);
                    }

                    result = await httpResponse.Content.ReadAsStringAsync();
                }
                catch (Exception e)
                {
                    return "Servicio no disponible";
                }
            }

            return result;
        }

        public async Task<string> SendURIAsync(string endPoint, HttpMethod method, string Token, HttpContent httpContent = null)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage httpResponse = null;
                try
                {
                    if (method.Method == "GET")
                    {
                        HttpRequestMessage httpRequest = new HttpRequestMessage
                        {
                            Method = method,
                            RequestUri = new Uri(_urlBase + endPoint),
                        };
                        httpRequest.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        httpRequest.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Token);
                        httpResponse = await client.SendAsync(httpRequest);
                    }
                    else
                    {
                        HttpRequestMessage httpRequest = new HttpRequestMessage
                        {
                            Method = method,
                            RequestUri = new Uri(_urlBase + endPoint),
                            Content = httpContent,
                        };
                        httpRequest.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                        httpRequest.Headers.Authorization = new AuthenticationHeaderValue("Bearer", Token);
                        httpResponse = await client.SendAsync(httpRequest);
                    }

                    switch (httpResponse.StatusCode)
                    {
                        case System.Net.HttpStatusCode.OK:
                            var result = await httpResponse.Content.ReadAsStringAsync();
                            break;
                    }
                    //var response = await httpResponse.Content.ReadAsStringAsync();

                    
                }
                catch (Exception e)
                {
                    return "Servicio no disponible";
                }
            }

            return "";
        }
    }
}
