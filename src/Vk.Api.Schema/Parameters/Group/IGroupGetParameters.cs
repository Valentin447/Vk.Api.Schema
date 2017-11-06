using System.Collections.Generic;
using Vk.Api.Schema.Enums.Filters;
using Vk.Api.Schema.Enums.Group;

namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.get <para/>
    /// Документация: <see href="https://vk.com/dev/groups.get"/>
    /// </summary>
    public interface IGroupGetParameters
    {
        /// <summary>
        /// Идентификатор пользователя, информацию о сообществах которого требуется получить
        /// </summary>
        /// <remarks>
        /// По умолчанию идентификатор текущего пользователя
        /// </remarks>
        int? UserId { get; set; }

        /// <summary>
        /// Будет возвращена полная информация о группах пользователя
        /// </summary>
        /// <remarks>
        /// По умолчанию 0
        /// </remarks>
        bool? IsExtended { get; set; }

        /// <summary>
        /// Список фильтров сообществ
        /// </summary>
        IEnumerable<GroupFilters> Filter { get; set; }

        /// <summary>
        /// Список дополнительных полей, которые необходимо вернуть
        /// </summary>
        /// <remarks>
        /// Этот параметр учитывается только при IsExtended = 1
        /// </remarks>
        IEnumerable<UserField> Fields { get; set; } // TODO: нужен тип описывающий дополнительные поля группы https://vk.com/dev/objects/group

        /// <summary>
        /// Смещение, необходимое для выборки определённого подмножества сообществ
        /// </summary>
        int? Offset { get; set; }

        /// <summary>
        /// Количество сообществ, информацию о которых нужно вернуть
        /// </summary>
        /// <remarks>
        /// Максимальное значение 1000
        /// </remarks>
        int? Count { get; set; }
    }
}
