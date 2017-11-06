namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.unbanUser <para/>
    /// Документация: <see href="https://vk.com/dev/groups.unbanUser"/>
    /// </summary>
    public interface IGroupUnbanUserParameters
    {
        /// <summary>
        /// Идентификатор сообщества
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// Идентификатор пользователя, которого нужно убрать из черного списка
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int UserId { get; set; }
    }
}
