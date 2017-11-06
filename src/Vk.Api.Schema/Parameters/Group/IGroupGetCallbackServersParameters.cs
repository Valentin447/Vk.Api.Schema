using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.getCallbackServers <para/>
    /// Документация: <see href="https://vk.com/dev/groups.getCallbackServers"/>
    /// </summary>
    public interface IGroupGetCallbackServersParameters
    {
        /// <summary>
        /// Идентификатор сообщества
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// Идентификаторы серверов, данные о которых нужно получить
        /// </summary>
        /// <remarks>
        /// По умолчанию возвращаются все серверы
        /// </remarks>
        IEnumerable<int> ServerIds { get; set; }
    }
}
