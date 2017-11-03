namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.deleteLink <para/>
    /// Документация: <see href="https://vk.com/dev/groups.deleteLink"/>
    /// </summary>
    public interface IGroupDeleteLinkParameters
    {
        /// <summary>
        /// Идентификатор сообщества, ссылки которого нужно удалить
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// Идентификатор ссылки, которую необходимо удалить
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int LinkId { get; set; }
    }
}
