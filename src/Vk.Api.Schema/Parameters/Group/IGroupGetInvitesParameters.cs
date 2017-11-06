namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.getInvites <para/>
    /// Документация: <see href="https://vk.com/dev/groups.getInvites"/>
    /// </summary>
    public interface IGroupGetInvitesParameters
    {
        /// <summary>
        /// Смещение, необходимое для выборки определённого подмножества приглашений
        /// </summary>
        int? Offset { get; set; }

        /// <summary>
        /// Количество приглашений, которое необходимо вернуть
        /// </summary>
        /// <remarks>
        /// По умолчанию 20
        /// </remarks>
        int? Count { get; set; }

        /// <summary>
        /// Вернуть дополнительную информацию о пользователях, отправлявших приглашения
        /// </summary>
        /// <remarks>
        /// По умолчанию — 0
        /// </remarks>
        bool? IsExtended { get; set; }
    }
}
