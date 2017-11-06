namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.approveRequest <para/>
    /// Документация: <see href="https://vk.com/dev/groups.approveRequest"/>
    /// </summary>
    public interface IGroupApproveRequestParameters
    {
        /// <summary>
        /// Идентификатор сообщества, заявку в которую необходимо одобрить
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// Идентификатор пользователя, заявку которого необходимо одобрить
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int UserId { get; set; }
    }
}
