using System.Collections.Generic;
using Vk.Api.Schema.Enums.Wall;

namespace Vk.Api.Schema.Parameters.Wall
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для wall.get <para/>
    /// Документация: <see href="https://vk.com/dev/wall.get"/>
    /// </summary>
    public interface IWallGetParameters
    {
        /// <summary>
        /// Идентификатор пользователя или сообщества, со стены которого необходимо получить записи
        /// </summary>
        /// <remarks>
        /// По умолчанию — текущий пользователь
        /// Идентификатор сообщества в параметре OwnerId необходимо указывать со знаком "-"
        /// </remarks>
        int? OwnerId { get; set; }

        /// <summary>
        /// Короткий адрес пользователя или сообщества
        /// </summary>
        string Domain { get; set; }

        /// <summary>
        /// Смещение, необходимое для выборки определенного подмножества записей
        /// </summary>
        int? Offset { get; set; }

        /// <summary>
        /// Количество записей, которое необходимо получить
        /// </summary>
        /// <remarks>
        /// Максимальное значение: 100
        /// </remarks>
        int? Count { get; set; }

        /// <summary>
        /// Типы записей на стене, которые необходимо получить
        /// </summary>
        TypePostOnWall? Filter { get; set; }

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
