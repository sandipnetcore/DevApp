using ExternalAPIConfigurations.EndPointConfigurations;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic.FileIO;
using System.Globalization;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace ExternalAPIConfigurations.APIResponses
{
    public class APIResponses : IAPIResponse
    {
        private APISettings mAPISettings;

        public APIResponses(IOptions<APISettings> apiSettings)
        {
            mAPISettings = apiSettings.Value;
        }

        private HttpClient httpClient
        {
            get;set;
        }

        private void CreateClient()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(mAPISettings.APIUrl);
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public Task AddHeaders(Dictionary<string, string> headerParameters)
        {
            throw new NotImplementedException();
        }

        public async Task<HttpResponseMessage> GetAsyncResponseWithNoParameters(String actionName)
        {
            CreateClient();
            var response = await httpClient.GetAsync(actionName).ConfigureAwait(false);
             return response;
        }

        public async Task<HttpResponseMessage> GetAsyncResponseMessageWithQueryParameters(String actionName, Dictionary<String, String> parameters)
        {
            CreateClient();
            StringBuilder queryStringParametersBuilder = new StringBuilder();

            foreach (var parameter in parameters)
            {
                queryStringParametersBuilder.AppendFormat(String.Format(CultureInfo.CurrentCulture, "/{0}?{1}{2}{3}{4}"),actionName, parameter.Key, "=", parameter.Value, "&");
            }

            Uri uri = new Uri(queryStringParametersBuilder.ToString().TrimEnd('&'));

            var response = await httpClient.GetAsync(uri).ConfigureAwait(false);

            return response;
        }

        public async Task<HttpResponseMessage> GetAsyncResponseMessageWithParameters(String actionName, Dictionary<string, string> parameters)
        {
            CreateClient();
            StringBuilder queryStringParametersBuilder = new StringBuilder();

            queryStringParametersBuilder.Append(actionName);

            foreach (var parameter in parameters)
            {
                queryStringParametersBuilder.AppendFormat(String.Format(CultureInfo.CurrentCulture, "/{0}/{1}", parameter.Key, parameter.Value));
            }

            //httpClient.BaseAddress = new Uri(String.Concat(httpClient.BaseAddress, queryStringParametersBuilder.ToString()));
            var response = await httpClient.GetAsync(queryStringParametersBuilder.ToString()).ConfigureAwait(false);

            return response;
        }

        public async Task<HttpResponseMessage> GetAsyncResponseMessageWithValues(String actionName, List<string> parameters)
        {
            CreateClient();
            StringBuilder queryStringParametersBuilder = new StringBuilder();
            queryStringParametersBuilder.Append(actionName);

            foreach (var parameter in parameters)
            {
                queryStringParametersBuilder.AppendFormat(String.Format(CultureInfo.CurrentCulture, "{0}"), parameter);
            }
            
            var response = await httpClient.GetAsync(queryStringParametersBuilder.ToString()).ConfigureAwait(false);

            return response;
        }
    }
}
