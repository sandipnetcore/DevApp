namespace ExternalAPIConfigurations.EndPointConfigurations
{
    public class APISettings: EndPointConfiguration
    {
        /// <summary>
        /// User Id for the API
        /// </summary>
        public String UserId { get; set; }

        /// <summary>
        /// Password For the API
        /// </summary>
        public String Password { get; set; }

        /// <summary>
        /// Additional Configurations
        /// </summary>
        public Dictionary<String, String> Configurations { get; set; }
    }
}
