namespace Vk.Api.Schema.Parameters.Wall
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для wall.unpin <para/>
    /// Документация: <see href="https://vk.com/dev/wall.unpin"/>
    /// </summary>
    public interface IWallUnpinParameters
    {
        /// <summary>
        /// Идентификатор пользователя или сообщества, на стене которого находится запись
        /// </summary>
        /// <remarks>
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
    }
}
