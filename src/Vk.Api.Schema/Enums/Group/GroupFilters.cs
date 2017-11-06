using System.ComponentModel;

namespace Vk.Api.Schema.Enums.Group
{
    /// <summary>
    /// Фильтр сообществ
    /// </summary>
    public enum GroupFilters
    {
        /// <summary>
        ///  Будут возвращены сообщества, в которых пользователь является администратором
        /// </summary>
        [Description("admin")]
        Admin,

        /// <summary>
        ///  Будут возвращены сообщества, в которых пользователь является редактором
        /// </summary>
        [Description("editor")]
        Editor,

        /// <summary>
        /// Будут возвращены сообщества, в которых пользователь является модератором
        /// </summary>
        [Description("moder")]
        Moder,

        /// <summary>
        /// Будут возвращены группы
        /// </summary>
        [Description("groups")]
        Groups,

        /// <summary>
        /// Будут возвращены публичные страницы
        /// </summary>
        [Description("publics")]
        Publics,

        /// <summary>
        /// Будут возвращены события
        /// </summary>
        [Description("events")]
        Events
    }
}