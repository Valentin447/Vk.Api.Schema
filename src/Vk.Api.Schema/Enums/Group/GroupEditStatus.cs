namespace Vk.Api.Schema.Enums.Group
{
    /// <summary>
    /// Статус доступа элементов сообщества
    /// </summary>
    public enum GroupEditStatus
    {
        /// <summary>
        /// Выключена
        /// </summary>
        Off,

        /// <summary>
        /// Открытая
        /// </summary>
        Open,

        /// <summary>
        /// Ограниченная (доступно только для групп и событий)
        /// </summary>
        Limited,

        /// <summary>
        /// Закрытая (доступно только для групп и событий)
        /// </summary>
        Closed
    }
}