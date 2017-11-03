using System.Collections.Generic;
using Vk.Api.Schema.Enums.Board;

namespace Vk.Api.Schema.Parameters.Wall
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для wall.getComments <para/>
    /// Документация: <see href="https://vk.com/dev/wall.getComments"/>
    /// </summary>
    public interface IWallGetCommentsParameters
    {
        /// <summary>
        /// Идентификатор владельца страницы (пользователь или сообщество)
        /// </summary>
        /// <remarks>
        /// По умолчанию — текущий пользователь
        /// Идентификатор сообщества в параметре OwnerId необходимо указывать со знаком "-"
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
        /// 1 — возвращать информацию о лайках
        /// </summary>
        bool? NeedLikes { get; set; }

        /// <summary>
        /// Идентификатор комментария, начиная с которого нужно вернуть список
        /// </summary>
        /// <remarks>
        /// Доступен начиная с версии 5.33
        /// </remarks>
        int? StartCommentId { get; set; }

        /// <summary>
        /// Смещение, необходимый для получения конкретной выборки результатов
        /// </summary>
        int? Offset { get; set; }

        /// <summary>
        /// Число комментариев, которые необходимо получить
        /// </summary>
        /// <remarks>
        /// По умолчанию: 10, максимальное значение: 100
        /// </remarks>
        int? Count { get; set; }

        /// <summary>
        /// Порядок сортировки комментариев
        /// </summary>
        SortChronological? Sort { get; set; }

        /// <summary>
        /// Количество символов, по которому нужно обрезать текст комментария
        /// </summary>
        /// <remarks>
        /// 0 - если не нужно обрезать текст
        /// </remarks>
        int? PreviewLength { get; set; }

        /// <summary>
        /// 1 - Возвращать в ответе дополнительные поля profiles и groups, 
        /// содержащие информацию о пользователях и сообществах
        /// </summary>
        /// <remarks>
        /// По умолчанию: 0
        /// Доступен начиная с версии 5.0
        /// </remarks>
        bool? IsExtended { get; set; }

        /// <summary>
        /// Список дополнительных полей для профилей и групп, которые необходимо вернуть
        /// </summary>
        /// <remarks>
        /// Этот параметр учитывается только при IsExtended = 1
        /// </remarks>
        IEnumerable<string> Fields { get; set; } // TODO: Возможно стоит сделать отдельный тип
    }
}
