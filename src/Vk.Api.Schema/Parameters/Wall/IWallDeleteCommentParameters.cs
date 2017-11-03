namespace Vk.Api.Schema.Parameters.Wall
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для wall.deleteComment <para/>
    /// Документация: <see href="https://vk.com/dev/wall.deleteComment"/>
    /// </summary>
    public interface IWallDeleteCommentParameters
    {
        /// <summary>
        /// Идентификатор пользователя, на чьей стене находится комментарий к записи
        /// </summary>
        /// <remarks>
        ///  идентификатор сообщества в параметре OwnerId необходимо указывать со знаком "-"
        ///  — например, OwnerId=-1 
        /// По умолчанию идентификатор текущего пользователя
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
