namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.addLink <para/>
    /// Документация: <see href="https://vk.com/dev/groups.addLink"/>
    /// </summary>
    public interface IGroupAddLinkParameters
    {
        /// <summary>
        /// Идентификатор сообщества, в которое добавляется ссылка
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// Адрес ссылки 
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        string Link { get; set; }

        /// <summary>
        /// Текст ссылки
        /// </summary>
        string Text { get; set; }
    }
}
