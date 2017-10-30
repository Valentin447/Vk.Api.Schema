namespace Vk.Api.Schema.Parameters.Wall
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для wall.restoreComment <para/>
    /// Документация: <see href="https://vk.com/dev/wall.restoreComment"/>
    /// </summary>
    public interface IWallRestoreCommentParameters
    {
        /// <summary>
        /// Идентификатор пользователя или сообщества, на стене которого находится комментарий к записи
        /// </summary>
        /// <remarks>
        /// По умолчанию идентификатор текущего пользователя
        /// Идентификатор сообщества в параметре OwnerId необходимо указывать со знаком "-"
        /// </remarks>
        int? OwnerId { get; set; }

        /// <summary>
        /// Идентификатор комментария
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int CommentId { get; set; }
    }
}
