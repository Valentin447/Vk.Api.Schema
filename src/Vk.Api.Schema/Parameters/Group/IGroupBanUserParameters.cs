using Vk.Api.Schema.Enums.Group;

namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.banUser <para/>
    /// Документация: <see href="https://vk.com/dev/groups.banUser"/>
    /// </summary>
    public interface IGroupBanUserParameters
    {
        /// <summary>
        /// Идентификатор сообщества
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// Идентификатор пользователя, которого нужно добавить в черный список
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int UserId { get; set; }

        /// <summary>
        /// Дата завершения срока действия бана в формате unixtime
        /// </summary>
        /// <remarks>
        /// Максимальный возможный срок окончания бана, который можно указать, — один год с его начала.
        /// Если параметр не указан, пользователь будет заблокирован навсегда
        /// </remarks>
        int? EndDate { get; set; } // TODO: DateTime?

        /// <summary>
        /// Причина бана
        /// </summary>
        ReasonForBan Reason { get; set; }

        /// <summary>
        /// Текст комментария к бану
        /// </summary>
        string Comment { get; set; }

        /// <summary>
        /// Текст комментария будет отображаться пользователю
        /// </summary>
        /// <remarks>
        /// 0 – текст комментария не доступен пользователю
        /// По умолчанию: 0
        /// </remarks>
        bool? CommentIsVisible { get; set; }
    }
}
