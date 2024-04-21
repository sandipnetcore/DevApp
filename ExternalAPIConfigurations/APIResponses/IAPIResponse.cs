namespace ExternalAPIConfigurations.APIResponses
{
    /// <summary>
    /// This interface should be used to connect with External API and get the responses.
    /// The interface should responsible for Getting the HTTPResponse Message for the REST Methods. 
    /// </summary>
    public interface IAPIResponse
    {
        /// <summary>
        /// Add headers to the http client
        /// </summary>
        /// <param name="HeaderParameters">Dictionary<String,String></param>
        /// <returns></returns>
        public Task AddHeaders(Dictionary<String, String> headerParameters);

        /// <summary>
        /// Use with [HTTPGET] Method only.Get async response from the base HTTP Client. With no query string or body parameters.
        /// </summary>
        /// <param name="ActionName">String</param>
        /// <returns>HttpResponseMessage</returns>
        public Task<HttpResponseMessage> GetAsyncResponseWithNoParameters(String ActionName);

        /// <summary>
        /// Use with [HTTPGET] Method only. Get async response from the base HTTP Client. The method is specific to only query strings.
        /// Example :- "https://sometest.com/?{Parameter1.Key=Parameter1.Value}&{Parameter2.Key=Parameter2.Value}"
        /// </summary>
        /// <param name="ActionName">String</param>
        /// <param name="parameters">Dictionary<String, String></param>
        /// <returns>HttpResponseMessage</returns>
        public Task<HttpResponseMessage> GetAsyncResponseMessageWithQueryParameters(String ActionName, Dictionary<String, String> parameters);

        /// <summary>
        /// Use with [HTTPGET] Method only. Get async response from the base HTTP Client.
        /// Example :- "https://sometest.com/Action/Parameter1.Key/{Parameter1.Value}/Parameter2.Key/{Parameter2.Value}"
        /// </summary>
        /// <param name="ActionName">String</param>
        /// <param name="parameters">Dictionary<String, String></param>
        /// <returns>HttpResponseMessage</returns>
        public Task<HttpResponseMessage> GetAsyncResponseMessageWithParameters(String ActionName, Dictionary<String, String> parameters);

        /// <summary>
        /// Use with [HTTPGET] Method only. Get async response from the base HTTP Client.
        /// Example :- "https://sometest.com/Action/{Parameter1}/{Parameter2}"
        /// </summary>
        /// <param name="ActionName">String</param>
        /// <param name="parameters">Dictionary<String, String></param>
        /// <returns>HttpResponseMessage</returns>
        public Task<HttpResponseMessage> GetAsyncResponseMessageWithValues(String ActionName, List<String> parameters);
    }
}
