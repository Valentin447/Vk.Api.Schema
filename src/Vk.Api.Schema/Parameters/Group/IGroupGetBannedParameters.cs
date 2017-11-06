using System.Collections.Generic;
using Vk.Api.Schema.Enums.Filters;

namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.getBanned <para/>
    /// Документация: <see href="https://vk.com/dev/groups.getBanned"/>
    /// </summary>
    public interface IGroupGetBannedParameters
    {
        /// <summary>
        /// Идентификатор сообщества
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// Смещение, необходимое для выборки определенного подмножества черного списка
        /// </summary>
        int? Offset { get; set; }

        /// <summary>
        /// Количество пользователей, которое необходимо вернуть
        /// </summary>
        /// <remarks>
        /// По умолчанию 20, максимальное значение 200
        /// </remarks>
        int? Count { get; set; }

        /// <summary>
        /// Список дополнительных полей, которые необходимо вернуть
        /// </summary>
        IEnumerable <UserField> Fields { get; set; }

        /// <summary>
        /// Идентификатор владельца стены
        /// </summary>
        int? OwnerId { get; set; }
    }
}
