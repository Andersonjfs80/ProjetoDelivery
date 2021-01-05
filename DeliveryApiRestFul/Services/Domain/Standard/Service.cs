using Application.Constant;
using Application.Domain;
using Application.Domain.Services.Domain;
using Application.Model;
using Application.Services.Interface.Standard;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Application.Services.Domain.Standard
{
    public class Service : IService
    {
        HttpClient _httpClient = new HttpClient();
        private IReturnEvent<Token> GetGenericReturnToken(string jsonContent, string message, bool sucess, Token token = null)
        {
            return new ReturnEvent<Token>()
            {
                Json = jsonContent,
                Message = message,
                Success = sucess,
                Result = token
            };
        }
        public IReturnEvent<Token> GetAccessOauthToken(UserAPI userAPI)
        {
            Uri accessAuthorizationTokenURL = new Uri(Endpoints.URL_BASE + Endpoints.URL_TOKEN);

            ////limpa o header
            _httpClient.DefaultRequestHeaders.Accept.Clear();

            ////incluir o cabeçalho Accept que será envia na requisição             
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var form = new Dictionary<string, string>
                {
                    {"client_id", userAPI.ClientId},
                    {"client_secret", userAPI.ClientSecret},
                    {"grant_type", userAPI.GrantType},
                    {"username", userAPI.UserName},
                    {"password", userAPI.Password}
                };

            HttpResponseMessage tokenResponse = _httpClient.PostAsync(accessAuthorizationTokenURL, new FormUrlEncodedContent(form)).Result;
           
            var jsonContent = tokenResponse.Content.ReadAsStringAsync().Result;           
            if (tokenResponse.StatusCode == HttpStatusCode.OK)
            {
                //deserializa o token e data de expiração para o objeto Token
                Token token = JsonSerializer.Deserialize<Token>(jsonContent);

                return GetGenericReturnToken(
                    jsonContent,
                    tokenResponse.RequestMessage.ToString(),
                    true,
                    token);
            }

            return GetGenericReturnToken(
                jsonContent,
                tokenResponse.RequestMessage.ToString(),
                true);
        }
        public IReturnEvent<List<PoolingEvent>> GetEventPolling(Token token)
        {
            Uri eventPollingURL = new Uri(string.Format("{0}{1}/{2}", Endpoints.URL_BASE, Endpoints.VERSION_1, Endpoints.URL_EVENT_POOLING));

            ////limpa o header
            _httpClient.DefaultRequestHeaders.Accept.Clear();

            ////incluir o cabeçalho Accept que será enviado na requisição             
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //Associando o token aos headers do objeto do tipo HttpClient
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);

            HttpResponseMessage tokenResponse = _httpClient.GetAsync(eventPollingURL).Result;

            var jsonContent = tokenResponse.Content.ReadAsStringAsync().Result;
            if (tokenResponse.StatusCode == HttpStatusCode.OK)
            {                
                List<PoolingEvent> poolingEventList = JsonSerializer.Deserialize<List<PoolingEvent>>(jsonContent);

                return new ReturnEvent<List<PoolingEvent>>()
                {
                    Json = jsonContent,
                    Message = tokenResponse.RequestMessage.ToString(),
                    Success = true,
                    Result = poolingEventList
                };
            }

            return new ReturnEvent<List<PoolingEvent>>()
            {
                Json = jsonContent,
                Message = tokenResponse.RequestMessage.ToString(),
                Success = false
            };
        }
        public IReturnEvent<Order> GetPendingOrder(Token token, string reference)
        {
            Uri orderURL = new Uri(string.Format("{0}{1}/{2}/{3}", Endpoints.URL_BASE, Endpoints.VERSION_3, Endpoints.URL_ORDER, reference));

            ////limpa o header
            _httpClient.DefaultRequestHeaders.Accept.Clear();

            ////incluir o cabeçalho Accept que será enviado na requisição             
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //Associando o token aos headers do objeto do tipo HttpClient
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);

            HttpResponseMessage tokenResponse = _httpClient.GetAsync(orderURL).Result;

            var jsonContent = tokenResponse.Content.ReadAsStringAsync().Result;
            if (tokenResponse.StatusCode == HttpStatusCode.OK)
            {
                Order order = JsonSerializer.Deserialize<Order>(jsonContent);

                return new ReturnEvent<Order>()
                {
                    Json = jsonContent,
                    Message = tokenResponse.RequestMessage.ToString(),
                    Success = true,
                    Result = order
                };
            }

            return new ReturnEvent<Order>()
            {
                Json = jsonContent,
                Message = tokenResponse.RequestMessage.ToString(),
                Success = false
            };
        }
        public IGenericReturn SendEventAcknowledgmentPolling(Token token, List<EventAcknowledgment> eventAcknowledgment)
        {
            Uri eventAcknowledgmentPollingURL = new Uri(string.Format("{0}{1}/{2}", Endpoints.URL_BASE, Endpoints.VERSION_1, Endpoints.URL_EVENT_ACNOWLEDGMENT));

            ////limpa o header
            _httpClient.DefaultRequestHeaders.Accept.Clear();

            ////incluir o cabeçalho Accept que será enviado na requisição             
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            //Associando o token aos headers do objeto do tipo HttpClient
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);

            string jsonContent = JsonSerializer.Serialize<List<EventAcknowledgment>>(eventAcknowledgment);
            HttpContent httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            HttpResponseMessage tokenResponse =  _httpClient.PostAsync(eventAcknowledgmentPollingURL, httpContent).Result;


            var jsonContentResponse = tokenResponse.Content.ReadAsStringAsync().Result;
            if (tokenResponse.StatusCode == HttpStatusCode.OK)
            {               

                return new GenericReturn()
                {
                    Json = jsonContentResponse,
                    Message = tokenResponse.RequestMessage.ToString(),
                    Success = true
                };
            }

            return new GenericReturn()
            {
                Json = jsonContent,
                Message = tokenResponse.RequestMessage.ToString(),
                Success = false
            };
        }
        public IGenericReturn SendOrdersStatus(Token token, OrderStatus orderstatus)
        {
            Uri endPointUrl = GerURLOrderStatus(orderstatus.EventOrderCode, orderstatus.);

            //faltando criar o json da rejection e cancelamento

            ////limpa o header
            _httpClient.DefaultRequestHeaders.Accept.Clear();

            ////incluir o cabeçalho Accept que será enviado na requisição             
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //Associando o token aos headers do objeto do tipo HttpClient
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token.AccessToken);

            HttpRequestMessage requestHttp = new HttpRequestMessage(HttpMethod.Post, endPointUrl);

            if (orderstatus.EventOrderCode == PoolingEventStatusCode.REJECTED)
            {
                var eventCancellation = new Dictionary<string, string>
                {              
                    {"details", orderstatus.RejectionMotive}
                };

                string jsonContent = JsonSerializer.Serialize(eventCancellation);
                requestHttp.Content = new StringContent(jsonContent, Encoding.UTF8, "application/json"); 
            }

            if (orderstatus.EventOrderCode == PoolingEventStatusCode.CANCELLATION_REQUESTED)
            {
                var eventCancellation = new Dictionary<string, string>
                {
                    {"cancellationCode", orderstatus.RejectionCode},
                    {"details", orderstatus.RejectionMotive}
                };

                string jsonContent = JsonSerializer.Serialize(eventCancellation);
                requestHttp.Content = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            }

            HttpResponseMessage responseHttp = _httpClient.SendAsync(requestHttp).Result;

            var jsonContentResponse = responseHttp.Content.ReadAsStringAsync().Result;
            if (responseHttp.StatusCode == HttpStatusCode.OK)
            {

                return new GenericReturn()
                {
                    Json = jsonContentResponse,
                    Message = responseHttp.RequestMessage.ToString(),
                    Success = true
                };
            }

            return new GenericReturn()
            {
                Json = jsonContentResponse,
                Message = responseHttp.RequestMessage.ToString(),
                Success = false
            };
        }
        private static Uri GerURLOrderStatus(string orderstatus, string correlationId)
        {
            Uri endPointUrl = null;

            switch (orderstatus)
            {
                case PoolingEventStatusCode.CONFIRMED:
                    endPointUrl = new Uri(string.Format("{0}{1}/{2}/{3}", Endpoints.URL_BASE, Endpoints.VERSION_1, reference, Endpoints.URL_ORDER_CONFIRMATION));
                    break;
                case PoolingEventStatusCode.DELIVERED:
                    endPointUrl = new Uri(string.Format("{0}{1}/{2}/{3}", Endpoints.URL_BASE, Endpoints.VERSION_1, reference, Endpoints.URL_ORDER_DELIVERED));
                    break;
                case PoolingEventStatusCode.DISPATCHED:
                    endPointUrl = new Uri(string.Format("{0}{1}/{2}/{3}", Endpoints.URL_BASE, Endpoints.VERSION_1, reference, Endpoints.URL_ORDER_DISPATCHED));
                    break;
                case PoolingEventStatusCode.INTEGRATED:
                    endPointUrl = new Uri(string.Format("{0}{1}/{2}/{3}", Endpoints.URL_BASE, Endpoints.VERSION_1, reference, Endpoints.URL_ORDER_INTEGRATED));
                    break;
                case PoolingEventStatusCode.REJECTED:
                    endPointUrl = new Uri(string.Format("{0}{1}/{2}/{3}", Endpoints.URL_BASE, Endpoints.VERSION_1, reference, Endpoints.URL_ORDER_REJECTED));
                    break;
                case PoolingEventStatusCode.READY_TO_DELIVER:
                    endPointUrl = new Uri(string.Format("{0}{1}/{2}/{3}", Endpoints.URL_BASE, Endpoints.VERSION_1, reference, Endpoints.URL_ORDER_READY_TO_DELIVER));
                    break;
                case PoolingEventStatusCode.CANCELLATION_REQUESTED:
                    endPointUrl = new Uri(string.Format("{0}{1}/{2}/{3}", Endpoints.URL_BASE, Endpoints.VERSION_3, reference, Endpoints.URL_ORDER_CANCELLATION_REQUESTED));
                    break;
                case PoolingEventStatusCode.CONSUMER_CANCELLATION_ACCEPTED:
                    endPointUrl = new Uri(string.Format("{0}{1}/{2}/{3}", Endpoints.URL_BASE, Endpoints.VERSION_2, reference, Endpoints.URL_ORDER_CONSUMER_CANCELLATION_ACCEPTED));
                    break;
                case PoolingEventStatusCode.CONSUMER_CANCELLATION_DENIED:
                    endPointUrl = new Uri(string.Format("{0}{1}/{2}/{3}", Endpoints.URL_BASE, Endpoints.VERSION_2, reference, Endpoints.URL_ORDER_CONSUMER_CANCELLATION_DENIED));
                    break;
            }

            return endPointUrl;
        }
    }
}
