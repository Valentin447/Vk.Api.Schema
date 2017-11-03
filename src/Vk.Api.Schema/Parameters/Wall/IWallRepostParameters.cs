namespace Vk.Api.Schema.Parameters.Wall
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для wall.repost <para/>
    /// Документация: <see href="https://vk.com/dev/wall.repost"/>
    /// </summary>
    public interface IWallRepostParameters
    {
        /// <summary>
        /// Строковый идентификатор объекта, который необходимо разместить на стене
        /// </summary>
        /// <remarks>
        /// Формируется из типа объекта (wall, photo, video и т.п.), 
        /// идентификатора владельца объекта и идентификатора самого объекта
        /// Обязательный параметр
        /// </remarks>
        string ObjectId { get; set; }

        /// <summary>
        /// Сопроводительный текст, который будет добавлен к записи с объектом
        /// </summary>
        string Message { get; set; }

        /// <summary>
        /// Идентификатор сообщества, на стене которого будет размещена запись с объектом
        /// </summary>
        /// <remarks>
        /// Если не указан, запись будет размещена на стене текущего пользователя
        /// </remarks>
        int? GroupId { get; set; }

        /// <summary>
        /// К записи, размещенной от имени сообщества, будет добавлена метка "это реклама", 
        /// 0 — метки добавлено не будет/снять установленную метку
        /// </summary>
        bool? MarkAsAds { get; set; }
    }
}
