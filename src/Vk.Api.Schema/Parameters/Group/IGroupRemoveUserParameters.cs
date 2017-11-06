namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.removeUser <para/>
    /// Документация: <see href="https://vk.com/dev/groups.removeUser"/>
    /// </summary>
    public interface IGroupRemoveUserParameters
    {
        /// <summary>
        /// Идентификатор группы, из которой необходимо исключить пользователя
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// Идентификатор пользователя, которого нужно исключить
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int UserId { get; set; }
    }
}
