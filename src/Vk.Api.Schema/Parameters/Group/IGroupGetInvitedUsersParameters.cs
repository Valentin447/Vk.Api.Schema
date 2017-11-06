using System.Collections.Generic;
using Vk.Api.Schema.Enums.Filters;
using Vk.Api.Schema.Enums.User;

namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.getInvitedUsers <para/>
    /// Документация: <see href="https://vk.com/dev/groups.getInvitedUsers"/>
    /// </summary>
    public interface IGroupGetInvitedUsersParameters
    {
        /// <summary>
        /// Идентификатор группы, список приглашенных в которую пользователей нужно вернуть
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// Смещение, необходимое для выборки определённого подмножества пользователей
        /// </summary>
        int? Offset { get; set; }

        /// <summary>
        /// Количество пользователей, информацию о которых нужно вернуть
        /// </summary>
        /// <remarks>
        /// По умолчанию 20
        /// </remarks>
        int? Count { get; set; }

        /// <summary>
        /// Список дополнительных полей, которые необходимо вернуть
        /// </summary>
        IEnumerable<UserField> Fields { get; set; } // TODO: Количество значений в перечислении, больше чем допустимых значений этого параметра

        /// <summary>
        /// Падеж для склонения имени и фамилии пользователя
        /// </summary>
        /// <remarks>
        /// По умолчанию: nom
        /// </remarks>
        NameCaseType? NameCase { get; set; }
    }
}
