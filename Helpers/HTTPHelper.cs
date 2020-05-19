using Newtonsoft.Json;
using webapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using HttpClientExtensions.Patch;
using System.Text;
using Xero.Api.Core.Model;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Threading;
using webapi.Helpers;
using webapi.Data;

namespace webapi.Helpers
{
    public static class HttpClientExtensions
    {
      
        public static Task<HttpResponseMessage> PatchAsync(this HttpClient client, string requestUri, HttpContent content)
        {
            return client.PatchAsync(CreateUri(requestUri), content);
        }

      
        public static Task<HttpResponseMessage> PatchAsync(this HttpClient client, Uri requestUri, HttpContent content)
        {
            return client.PatchAsync(requestUri, content, CancellationToken.None);
        }
      
        public static Task<HttpResponseMessage> PatchAsync(this HttpClient client, string requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return client.PatchAsync(CreateUri(requestUri), content, cancellationToken);
        }

      
        public static Task<HttpResponseMessage> PatchAsync(this HttpClient client, Uri requestUri, HttpContent content, CancellationToken cancellationToken)
        {
            return client.SendAsync(new HttpRequestMessage(new HttpMethod("PATCH"), requestUri)
            {
                Content = content
            }, cancellationToken);
        }

        private static Uri CreateUri(string uri)
        {
            return string.IsNullOrEmpty(uri) ? null : new Uri(uri, UriKind.RelativeOrAbsolute);
        }
    }
}
class HTTPHelper
    {
        public HTTPHelper ()
        { }
       
        public static HttpClient gethttpclient()

        {
            var dict = new Dictionary<string, string> {
                    { "X-Auth-App-Key", "bbHcbh/RoTkZlEoEIfJ9wnaPuTKg2H2byO1alOd1OAeaElN/kwa/wQ1UP/m/8WIS"}
                
                };
            var client = new HttpClient
            {
                BaseAddress = new Uri("https://orionuk.unmsapp.com/api/v1.0/"),
                DefaultRequestHeaders = { UserAgent = { new ProductInfoHeaderValue("ApiExample", "1.0") }
                    }
            };

            foreach (var key in dict.Keys)
            {
                client.DefaultRequestHeaders.Add(key, dict[key]);
            }
            return client;
        }
    public static HttpClient gethttpclientforunms()

    {
        var dict = new Dictionary<string, string> {
                    { "X-Auth-Token", "f9547870-cbb3-40e6-815a-0818f79a0844"}

                };
        var client = new HttpClient
        {
            BaseAddress = new Uri("https://orionuk.unmsapp.com/nms/api/v2.1/"),
            DefaultRequestHeaders = { UserAgent = { new ProductInfoHeaderValue("ApiExample", "1.0") }
                    }
        };

        foreach (var key in dict.Keys)
        {
            client.DefaultRequestHeaders.Add(key, dict[key]);
        }
        return client;
    }

    public static string httpGet(string entity)
        {
            var client = gethttpclient();
            var response = client.GetAsync(entity).Result;
            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content;
                return responseContent.ReadAsStringAsync().Result;
            }
            return null;
        }
    public static string httpGetforunms(string entity)
    {
        var client = gethttpclientforunms();
        var response = client.GetAsync(entity).Result;
        if (response.IsSuccessStatusCode)
        {
            var responseContent = response.Content;
            return responseContent.ReadAsStringAsync().Result;
        }
        return null;
    }
    public static bool httpPost(string entity, object entityObj)
        {
            var client = gethttpclient();

            var postdataJson = JsonConvert.SerializeObject(entityObj);
            var postdataString = new StringContent(postdataJson, new UTF8Encoding(), "application/json");
            var responseMessage = client.PostAsync(entity, postdataString).Result;
            var responseString = responseMessage.Content.ReadAsStringAsync().Result;
            if (responseMessage.IsSuccessStatusCode) { return true; }
        else
        {
            OrionAdminEntities db = new OrionAdminEntities();
            WebHookLog dbwl = new WebHookLog();
            dbwl.body = "err "+responseString;
            dbwl.Date = DateTime.Now;
            db.WebHookLogs.Add(dbwl);
            db.SaveChanges(); 
            return false; };
        }

      
        public static bool httpDelete(string entity)
        {
            var client = gethttpclient();

            var responseMessage = client.DeleteAsync(entity).Result;
            var responseString = responseMessage.Content.ReadAsStringAsync().Result;
            if (responseMessage.IsSuccessStatusCode) { return true; } else { return false; };
        }

        public static bool httpPatch(string entity, object entityObj)
        {
            var client = gethttpclient();
            var postdataJson = JsonConvert.SerializeObject(entityObj);
            var postdataString = new StringContent(postdataJson, new UTF8Encoding(), "application/json");
            var responseMessage = client.PatchAsync(entity, postdataString).Result;
            var responseString = responseMessage.Content.ReadAsStringAsync().Result;
            if (responseMessage.IsSuccessStatusCode) { return true; } else { return false; };
        }
}
