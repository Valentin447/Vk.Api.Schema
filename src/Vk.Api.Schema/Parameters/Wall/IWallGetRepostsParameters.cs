namespace Vk.Api.Schema.Parameters.Wall
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для wall.getReposts <para/>
    /// Документация: <see href="https://vk.com/dev/wall.getReposts"/>
    /// </summary>
    public interface IWallGetRepostsParameters
    {
        /// <summary>
        /// Идентификатор пользователя или сообщества, со стены которого необходимо получить записи
        /// </summary>
        /// <remarks>
        /// По умолчанию идентификатор текущего пользователя
        /// Идентификатор сообщества в параметре OwnerId необходимо указывать со знаком "-"
        /// </remarks>
        int? OwnerId { get; set; }

        /// <summary>
        /// Идентификатор записи на стене
        /// </summary>
        int? PostId { get; set; }

        /// <summary>
        /// Смещение, необходимое для выборки определенного подмножества записей
        /// </summary>
        int? Offset { get; set; }

        /// <summary>
        /// Количество записей, которое необходимо получить
        /// </summary>
        /// <remarks>
        /// По умолчанию 20, максимальное значение 1000
        /// </remarks>
        int? Count { get; set; }
    }
}
