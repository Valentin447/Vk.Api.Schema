namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.leave <para/>
    /// Документация: <see href="https://vk.com/dev/groups.leave"/>
    /// </summary>
    public interface IGroupLeaveParameters
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
