/*
 * Swagger Appointment managment - RTM - OpenAPI 3.1
 *
 * This is the OpenAPI 3.0 specification of Appointment managment - RTM.
 *
 * The version of the OpenAPI document: 0.1
 * Contact: mehmet-ali.asar@protonmail.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Newtonsoft.Json;

namespace AppointmentManagement.Client.Client.Auth
{
    class TokenResponse
    {
        [JsonProperty("token_type")]
        public string TokenType { get; set; }
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
    }
}