namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.deleteCallbackServer <para/>
    /// Документация: <see href="https://vk.com/dev/groups.deleteCallbackServer"/>
    /// </summary>
    public interface IGroupDeleteCallbackServerParameters
    {
        /// <summary>
        /// Идентификатор сообщества
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// Идентификатор сервера, который нужно удалить
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int ServerId { get; set; }
    }
}