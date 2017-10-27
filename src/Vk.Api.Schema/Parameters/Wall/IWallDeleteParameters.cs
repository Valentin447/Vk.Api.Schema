namespace Vk.Api.Schema.Parameters.Wall
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для wall.delete <para/>
    /// Документация: <see href="https://vk.com/dev/wall.delete"/>
    /// </summary>
    public interface IWallDeleteParameters
    {
        /// <summary>
        /// Идентификатор пользователя или сообщества, на стене которого находится запись
        /// </summary>
        /// <remarks>
        ///  идентификатор сообщества в параметре OwnerId необходимо указывать со знаком "-"
        ///  — например, OwnerId=-1 
        /// По умолчанию идентификатор текущего пользователя
        /// </remarks>
        int? OwnerId { get; set; }

        /// <summary>
        /// Идентификатор записи на стене
        /// </summary>
        int? PostId { get; set; }
    }
}
