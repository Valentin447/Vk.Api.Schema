using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Wall
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для wall.getById <para/>
    /// Документация: <see href="https://vk.com/dev/wall.getById"/>
    /// </summary>
    public interface IWallGetByIdParameters
    {
        /// <summary>
        /// Идентификаторы владельцев стен и самих записей на стене
        /// </summary>
        /// <remarks>
        /// Перечисленные через запятую идентификаторы, 
        /// которые представляют собой идущие через знак подчеркивания 
        /// id владельцев стен и id самих записей на стене
        /// Обязательный параметр
        /// </remarks>
        IEnumerable<string> Posts { get; set; }

        /// <summary>
        /// 1 - Возвращать в ответе дополнительные поля profiles и groups, 
        /// содержащие информацию о пользователях и сообществах
        /// </summary>
        /// <remarks>
        /// По умолчанию: 0
        /// </remarks>
        bool? IsExtended { get; set; }

        /// <summary>
        /// Определяет размер массива copy_history, возвращаемого в ответе, 
        /// если запись является репостом записи с другой стены
        /// </summary>
        /// <remarks>
        /// По умолчанию: 2
        /// </remarks>
        int? CopyHistoryDepth { get; set; }

        /// <summary>
        /// Список дополнительных полей для профилей и групп, которые необходимо вернуть
        /// </summary>
        /// <remarks>
        /// Этот параметр учитывается только при IsExtended = 1
        /// </remarks>
        IEnumerable<string> Fields { get; set; } // TODO: Возможно стоит сделать отдельный тип
    }
}
