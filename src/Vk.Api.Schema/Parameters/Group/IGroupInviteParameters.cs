namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.invite <para/>
    /// Документация: <see href="https://vk.com/dev/groups.invite"/>
    /// </summary>
    public interface IGroupInviteParameters
    {
        /// <summary>
        /// Идентификатор группы, в которую необходимо выслать приглашение
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// Идентификатор пользователя, которому необходимо выслать приглашение
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int UserId { get; set; }
    }
}
