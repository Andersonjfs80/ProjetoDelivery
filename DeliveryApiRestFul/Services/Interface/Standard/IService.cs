using Application.Domain;
using Application.Domain.Services.Domain;
using Application.Model;
using System.Collections.Generic;

namespace Application.Services.Interface.Standard
{
    public interface IService
    {
        /// <summary>
        /// Retorna o token do ifood
        /// </summary>
        /// <param name="UserAPI"></param>
        /// <returns>IReturnEvent<Token></returns>
        IReturnEvent<Token> GetAccessOauthToken(UserAPI userAPI);

        /// <summary>
        /// Obtém todos os eventos ainda não recebidos.
        /// </summary>
        /// <param name="Token"></param>
        /// <returns>IReturnEvent<List<PoolingEvent>></returns>
        IReturnEvent<List<PoolingEvent>> GetEventPolling(Token token);

        /// <summary>        
        /// o App deve enviar uma requisição confirmando o recebimento dos eventos.                
        /// O IFood processará as notificações e remover da fila de eventos.
        /// Na próxima requisição que o App consultar por novos eventos, os eventos 
        /// não serão enviados novamente
        /// </summary>
        /// <param name="token"></param>
        /// <param name="eventAcknowledgment"></param>
        /// <returns>IGenericReturn</returns>
        IGenericReturn SendEventAcknowledgmentPolling(Token token, List<EventAcknowledgment> eventAcknowledgment);

        /// <summary>
        /// Informa ao IFood que o pedido foi integrado pelo PDV.
        /// Integração significa que o PDV foi capaz de realizar o parse do pedido e integrar em seu sistema.
        /// </summary>
        /// <param name="token"></param>
        /// <param name="reference"></param>
        /// <returns></returns>
        IReturnEvent<Order> GetPendingOrder(Token token, string reference);

        /// <summary>        
        /// o App deve enviar um status do eventos.                
        /// O IFood processará as notificações e devolve um polling do evento enviado.
        /// Na próxima requisição que o App consultar por novos eventos, os que tem retorno no polling serão 
        /// devolvidos processados
        /// </summary>
        /// <param name="token"></param>
        /// <param name="orderstatus"></param>
        /// <returns>IGenericReturn</returns>
        IGenericReturn SendOrdersStatus(Token token, OrderStatus orderstatus);
    }
}
