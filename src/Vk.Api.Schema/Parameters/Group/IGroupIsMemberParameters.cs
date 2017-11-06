using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.isMember <para/>
    /// Документация: <see href="https://vk.com/dev/groups.isMember"/>
    /// </summary>
    public interface IGroupIsMemberParameters
    {
        /// <summary>
        /// Идентификатор или короткое имя сообщества
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        string GroupId { get; set; }

        /// <summary>
        /// Идентификатор пользователя
        /// </summary>
        int? UserId { get; set; }

        /// <summary>
        /// Идентификаторы пользователей
        /// </summary>
        /// <remarks>
        /// Не более 500
        /// </remarks>
        IEnumerable<int> UserIds { get; set; }

        /// <summary>
        /// Вернуть ответ в расширенной форме
        /// </summary>
        /// <remarks>
        /// По умолчанию — 0
        /// </remarks>
        bool? IsExtended { get; set; }
    }
}
