using Vk.Api.Schema.Enums;

namespace Vk.Api.Schema.Parameters.Wall
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для wall.reportPost <para/>
    /// Документация: <see href="https://vk.com/dev/wall.reportPost"/>
    /// </summary>
    public interface IWallReportPostParameters
    {
        /// <summary>
        /// Идентификатор пользователя или сообщества, которому принадлежит запись
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// Идентификатор сообщества в параметре OwnerId необходимо указывать со знаком "-"
        /// </remarks>
        int OwnerId { get; set; }

        /// <summary>
        /// Идентификатор записи
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int PostId { get; set; }

        /// <summary>
        /// Причина жалобы
        /// </summary>
        ReportContentType Reason { get; set; }
    }
}
