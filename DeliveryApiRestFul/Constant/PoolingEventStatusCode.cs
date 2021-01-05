namespace Application.Constant
{
    public static class PoolingEventStatusCode
    {
        //Pedido adicionado no sistema.
        public const string PLACED = "PLACED";
        //Pedido foi recebido pelo PDV.
        public const string INTEGRATED = "INTEGRATED";
        //Pedido foi confirmado.
        public const string CONFIRMED = "CONFIRMED";
        //Pedido foi cancelado.
        public const string CANCELLED = "CANCELLED";
        //Falha no cancelamento.
        public const string CANCELLATION_REQUEST_FAILED = "CANCELLATION_REQUEST_FAILED ";
        //Pedido foi recusado.
        public const string REJECTED = "REJECTED"; 
        //Pedido está pronto para entregar.
        public const string READY_TO_DELIVER = "READY_TO_DELIVER"; 
        //Pedido está requesitando cancelamento.
        public const string CANCELLATION_REQUESTED = "CANCELLATION_REQUESTED"; 
        //Pedido de cancelamento aceito.
        public const string CONSUMER_CANCELLATION_ACCEPTED = "CONSUMER_CANCELLATION_ACCEPTED";
        //Pedido de cancelamento negado.
        public const string CONSUMER_CANCELLATION_DENIED = "CONSUMER_CANCELLATION_DENIED";
        //Pedido foi despachado ao cliente.
        public const string DISPATCHED = "DISPATCHED";
        //Pedido foi entregue.
        public const string DELIVERED = "DELIVERED";
        //Pedido foi concluído (Em até duas horas do fluxo normal)*.
        public const string CONCLUDED = "CONCLUDED";
    }
}
