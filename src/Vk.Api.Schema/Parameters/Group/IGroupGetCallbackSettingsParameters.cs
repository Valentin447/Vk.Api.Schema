namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.getCallbackSettings <para/>
    /// Документация: <see href="https://vk.com/dev/groups.getCallbackSettings"/>
    /// </summary>
    public interface IGroupGetCallbackSettingsParameters
    {
        /// <summary>
        /// Идентификатор сообщества
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// Идентификатор сервера
        /// </summary>
        int ServerId { get; set; }
    }
}
