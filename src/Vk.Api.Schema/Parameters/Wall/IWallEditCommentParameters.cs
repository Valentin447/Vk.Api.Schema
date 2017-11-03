using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Wall
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для wall.editComment <para/>
    /// Документация: <see href="https://vk.com/dev/wall.editComment"/>
    /// </summary>
    public interface IWallEditCommentParameters
    {
        /// <summary>
        /// Идентификатор владельца стены
        /// </summary>
        /// <remarks>
        /// Идентификатор сообщества нужно указывать со знаком «минус» 
        /// По умолчанию идентификатор текущего пользователя
        /// </remarks>
        int? OwnerId { get; set; }

        /// <summary>
        /// Идентификатор комментария, который необходимо отредактировать
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int CommentId { get; set; }

        /// <summary>
        /// Новый текст комментария
        /// </summary>
        /// <remarks>
        /// Обязательный параметр, если не передан параметр attachments
        /// </remarks>
        string Message { get; set; }

        /// <summary>
        /// Список объектов, приложенных к комментарию
        /// </summary>
        /// <remarks>
        /// Параметр является обязательным, если не задан параметр Message
        /// </remarks>
        IEnumerable<string> Attachments { get; set; } // TODO: Возможно стоит сделать отдельный тип
    }
}
