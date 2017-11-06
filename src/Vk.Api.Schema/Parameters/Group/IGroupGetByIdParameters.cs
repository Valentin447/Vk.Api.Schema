using System.Collections.Generic;
using Vk.Api.Schema.Enums.Filters;

namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.getById <para/>
    /// Документация: <see href="https://vk.com/dev/groups.getById"/>
    /// </summary>
    public interface IGroupGetByIdParameters
    {
        /// <summary>
        /// Идентификаторы или короткие имена сообществ
        /// </summary>
        /// <remarks>
        /// Максимальное число идентификаторов - 500
        /// </remarks>
        IEnumerable<string> GroupIds { get; set; }

        /// <summary>
        /// Идентификатор или короткое имя сообщества
        /// </summary>
        string GroupId { get; set; }

        /// <summary>
        /// Список дополнительных полей, которые необходимо вернуть
        /// </summary>
        IEnumerable<UserField> Fields { get; set; } // TODO: нужен тип описывающий дополнительные поля группы https://vk.com/dev/objects/group
    }
}
