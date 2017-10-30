namespace Vk.Api.Schema.Parameters.Wall
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для wall.restore <para/>
    /// Документация: <see href="https://vk.com/dev/wall.restore"/>
    /// </summary>
    public interface IWallRestoreParameters
    {
        /// <summary>
        /// Идентификатор пользователя или сообщества, на стене которого находилась удаленная запись
        /// </summary>
        /// <remarks>
        /// Идентификатор сообщества в параметре OwnerId необходимо указывать со знаком "-"
        /// </remarks>
        int? OwnerId { get; set; }

        /// <summary>
        /// Идентификатор записи
        /// </summary>
        int? PostId { get; set; }
    }
}
