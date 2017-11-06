using System.Collections.Generic;
using Vk.Api.Schema.Enums.Filters;

namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.getRequests <para/>
    /// Документация: <see href="https://vk.com/dev/groups.getRequests"/>
    /// </summary>
    public interface IGroupGetRequestsParameters
    {
        /// <summary>
        /// Идентификатор сообщества (указывается без знака «минус»)
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// Смещение, необходимое для выборки определенного подмножества результатов
        /// </summary>
        /// <remarks>
        /// По умолчанию — 0
        /// </remarks>
        int? Offset { get; set; }

        /// <summary>
        /// Число результатов, которые необходимо вернуть
        /// </summary>
        /// <remarks>
        /// По умолчанию 20, максимальное значение 200
        /// </remarks>
        int? Count { get; set; }

        /// <summary>
        /// Список дополнительных полей профилей, которые необходимо вернуть
        /// </summary>
        IEnumerable<UserField> Fields { get; set; }
    }
}
