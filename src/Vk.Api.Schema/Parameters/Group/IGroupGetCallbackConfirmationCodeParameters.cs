namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.getCallbackConfirmationCode <para/>
    /// Документация: <see href="https://vk.com/dev/groups.getCallbackConfirmationCode"/>
    /// </summary>
    public interface IGroupGetCallbackConfirmationCodeParameters
    {
        /// <summary>
        /// Идентификатор сообщества
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }
    }
}
