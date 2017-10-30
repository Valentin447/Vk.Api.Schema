using Vk.Api.Schema.Enums;

namespace Vk.Api.Schema.Parameters.Wall
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для wall.reportComment <para/>
    /// Документация: <see href="https://vk.com/dev/wall.reportComment"/>
    /// </summary>
    public interface IWallReportCommentParameters
    {
        /// <summary>
        /// Идентификатор пользователя или сообщества, которому принадлежит комментарий
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// Идентификатор сообщества в параметре OwnerId необходимо указывать со знаком "-"
        /// </remarks>
        int OwnerId { get; set; }

        /// <summary>
        /// Идентификатор комментария
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int CommentId { get; set; }

        /// <summary>
        /// Причина жалобы
        /// </summary>
        ReportContentType Reason { get; set; }
    }
}
