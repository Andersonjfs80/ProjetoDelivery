using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Constant
{
    public static class Endpoints
    {
        public const string URL_BASE = "https://pos-api.ifood.com.br/";
        public const string VERSION_1 = "v1.0";
        public const string VERSION_2 = "v2.0";
        public const string VERSION_3 = "v3.0";

        public const string URL_TOKEN = "oauth/token";
        public const string URL_EVENT_POOLING = "events:polling";
        public const string URL_EVENT_ACNOWLEDGMENT = "events/acknowledgment";
        public const string URL_ORDER = "orders";
        public const string URL_ORDER_INTEGRATION = "statuses/integration";
        public const string URL_ORDER_CONFIRMATION = "statuses/confirmation";
        public const string URL_ORDER_DISPATCH = "statuses/dispatch";
        public const string URL_ORDER_REJECTION = "statuses/rejection";
        public const string URL_ORDER_CANCELLATION_REQUESTED = "statuses/cancellationRequested";
        public const string URL_ORDER_CONSUMER_CANCELLATION_ACCEPTED = "statuses/consumerCancellationAccepted";
        public const string URL_ORDER_CONSUMER_CANCELLATION_DENIED = "statuses/consumerCancellationDenied";
        public const string URL_ORDER_READY_TO_DELIVER = "statuses/readyToDeliver";
        public const string URL_ORDER_DELIVERED = "statuses/delivery";
        public const string URL_ORDER_DISPATCHED = "statuses/dispatch";
        public const string URL_ORDER_INTEGRATED = "statuses/integration";
        public const string URL_ORDER_REJECTED = "statuses/rejection";
    }
}
