using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Wall
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для wall.createComment <para/>
    /// Документация: <see href="https://vk.com/dev/wall.createComment"/>
    /// </summary>
    public interface IWallCreateCommentParameters
    {
        /// <summary>
        /// Идентификатор пользователя или сообщества, на чьей стене находится запись, 
        /// к которой необходимо добавить комментарий
        /// </summary>
        /// <remarks>
        /// Идентификатор сообщества в параметре OwnerId необходимо указывать со знаком "-"
        /// — например, OwnerId=-1
        /// </remarks>
        int? OwnerId { get; set; }

        /// <summary>
        /// Идентификатор записи на стене
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int PostId { get; set; }

        /// <summary>
        /// Идентификатор сообщества, от имени которого публикуется комментарий
        /// </summary>
        /// <remarks>
        /// По умолчанию: 0
        /// </remarks>
        int? FromGroup { get; set; }

        /// <summary>
        /// Текст комментария
        /// </summary>
        /// <remarks>
        /// Обязательный параметр, если не передан параметр attachments
        /// </remarks>
        string Message { get; set; }

        /// <summary>
        /// Идентификатор комментария, в ответ на который должен быть добавлен новый комментарий
        /// </summary>
        int? ReplyToComment { get; set; }

        /// <summary>
        /// Список объектов, приложенных к комментарию
        /// </summary>
        /// <remarks>
        /// Параметр является обязательным, если не задан параметр Message
        /// </remarks>
        IEnumerable<string> Attachments { get; set; } // TODO: Возможно стоит сделать отдельный тип

        /// <summary>
        /// Идентификатор стикера
        /// </summary>
        int? StickerId { get; set; }

        /// <summary>
        /// Уникальный идентификатор, предназначенный для предотвращения повторной отправки одинакового комментария
        /// </summary>
        string Guid { get; set; }
    }
}
