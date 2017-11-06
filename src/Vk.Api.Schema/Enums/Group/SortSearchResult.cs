namespace Vk.Api.Schema.Enums.Group
{
    /// <summary>
    /// Сортировка результата поиска сообществ
    /// </summary>
    public enum SortSearchResult
    {
        /// <summary>
        /// Сортировать по умолчанию (аналогично результатам поиска в полной версии сайта)
        /// </summary>
        ByDefault,

        /// <summary>
        /// Сортировать по скорости роста
        /// </summary>
        GrowthRate,

        /// <summary>
        /// Сортировать по отношению дневной посещаемости к количеству пользователей
        /// </summary>
        AttendanceUsers,

        /// <summary>
        /// Сортировать по отношению количества лайков к количеству пользователей
        /// </summary>
        LikesUsers,

        /// <summary>
        /// Сортировать по отношению количества комментариев к количеству пользователей
        /// </summary>
        CommentsUsers,

        /// <summary>
        /// Сортировать по отношению количества записей в обсуждениях к количеству пользователей
        /// </summary>
        EntriesUsers
    }
}