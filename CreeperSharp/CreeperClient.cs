using System;
using System.Security.Authentication;
using CreeperSharp.responses;
using CreeperSharp.responses.server;
using RestSharp;

namespace CreeperSharp
{
    public class CreeperClient
    {

        public ConnectionCredentials Credentials { get; set; }

        /// <summary>
        /// Should the client throw an exception if a network error happens
        /// These will be transport or non http exceptions
        /// </summary>
        public bool ThrowExceptionsForErrors { get; set; } = false;

        public CreeperClient() { }

        public CreeperClient(ConnectionCredentials credentials)
        {
            this.Credentials = credentials;
        }

        private void CanRequest()
        {
            if (Credentials == null)
                throw new AuthenticationException("Client requires credentials to connect to the api");
        }

        public CPU GetCPU()
        {
            CanRequest();

            return Execute<CPU>("os/getcpu");
        }

        public HDD GetHDD()
        {
            CanRequest();

            return Execute<HDD>("os/gethdd");
        }

        public Net GetNet()
        {
            CanRequest();

            return Execute<Net>("os/getNet");
        }

        public RAM GetRAM()
        {
            CanRequest();

            return Execute<RAM>("os/getram");
        }

        /*public IRestResponse<T> Execute<T>(String endpoint) where T : Response, new()
        {

            var client = new RestClient("https://api.creeper.host");

            var request = new RestRequest(endpoint, Method.GET);
            request.AddHeader("Content-Type", "application/json");

            request.AddHeader("key", Credentials.Key);
            request.AddHeader("secret", Credentials.Secret);

            return client.Execute<T>(request);
        }*/

        private T Execute<T>(String endpoint) where T : Response, new()
        {

            var client = new RestClient("https://api.creeper.host");
            client.AddHandler("application/json", new JsonDeserializer());

            var request = new RestRequest(endpoint, Method.GET);
            request.AddHeader("Content-Type", "application/json");
            request.JsonSerializer = new JsonSerializer();

            request.AddHeader("key", Credentials.Key);
            request.AddHeader("secret", Credentials.Secret);

            var response = client.Execute<T>(request);

            var data = response.Data;
            data.StatusCode = response.StatusCode;

            if (response.ErrorException != null
                && ThrowExceptionsForErrors)
            {
                const string message = "Error retrieving response.  Check inner details for more info.";
                var creeperException = new ApplicationException(message, response.ErrorException);
                throw creeperException;
            }

            data.Exception = response.ErrorException;

            return data;
        }

    }
}
