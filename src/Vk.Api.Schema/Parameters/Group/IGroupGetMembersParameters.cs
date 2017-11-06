using System.Collections.Generic;
using Vk.Api.Schema.Enums.Filters;
using Vk.Api.Schema.Enums.Group;

namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.getMembers <para/>
    /// Документация: <see href="https://vk.com/dev/groups.getMembers"/>
    /// </summary>
    public interface IGroupGetMembersParameters
    {
        /// <summary>
        /// Идентификатор или короткое имя сообщества
        /// </summary>
        string GroupId { get; set; }

        /// <summary>
        /// Сортировка, с которой необходимо вернуть список участников
        /// </summary>
        /// <remarks>
        /// Сортировка по time_asc и time_desc возможна только при вызове от модератора сообщества 
        /// По умолчанию id_asc
        /// </remarks>
        SortMembers? Sort { get; set; }

        /// <summary>
        /// Смещение, необходимое для выборки определенного подмножества участников
        /// </summary>
        /// <remarks>
        /// По умолчанию: 0
        /// </remarks>
        int? Offset { get; set; }

        /// <summary>
        /// Количество участников сообщества, информацию о которых необходимо получить
        /// </summary>
        /// <remarks>
        /// По умолчанию 1000, максимальное значение 1000
        /// </remarks>
        int? Count { get; set; }

        /// <summary>
        /// Список дополнительных полей, которые необходимо вернуть
        /// </summary>
        IEnumerable<UserField> Fields { get; set; }

        /// <summary>
        /// Фильтр списка участников сообщества
        /// </summary>
        GroupMembersFilter? Filter { get; set; }
    }
}
