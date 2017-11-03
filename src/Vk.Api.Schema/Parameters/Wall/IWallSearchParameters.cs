using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Wall
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для wall.search <para/>
    /// Документация: <see href="https://vk.com/dev/wall.search"/>
    /// </summary>
    public interface IWallSearchParameters
    {
        /// <summary>
        /// Идентификатор пользователя или сообщества
        /// </summary>
        /// <remarks>
        /// Идентификатор сообщества в параметре OwnerId необходимо указывать со знаком "-"
        /// </remarks>
        int? OwnerId { get; set; }

        /// <summary>
        /// Короткий адрес пользователя или сообщества
        /// </summary>
        string Domain { get; set; }

        /// <summary>
        /// Поисковой запрос
        /// </summary>
        string Query { get; set; }

        /// <summary>
        /// 1 — возвращать только записи от имени владельца стены
        /// </summary>
        bool? IsOwnersOnly { get; set; }

        /// <summary>
        /// Количество записей, которые необходимо вернуть
        /// </summary>
        /// <remarks>
        /// По умолчанию 20, максимальное значение 100
        /// </remarks>
        int? Count { get; set; }

        /// <summary>
        /// Смещение, необходимо для получения определенного подмножества результатов
        /// </summary>
        /// <remarks>
        /// По умолчанию 0
        /// </remarks>
        int? Offset { get; set; }

        /// <summary>
        /// 1 - Возвращать в ответе дополнительные поля profiles и groups, 
        /// содержащие информацию о пользователях и сообществах
        /// </summary>
        /// <remarks>
        /// По умолчанию: 0
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
