using System.ComponentModel;

namespace Vk.Api.Schema.Enums.Group
{
    /// <summary>
    /// Тип создаваемого сообщества
    /// </summary>
    public enum GroupTypeCreate // Единственное отличие от перечисления GroupType, в значении Public
    {
        /// <summary>
        /// Группа
        /// </summary>
        [Description("group")]
        Group,

        /// <summary>
        /// Публичная страница
        /// </summary>
        [Description("public")]
        Public,

        /// <summary>
        /// Мероприятие
        /// </summary>
        [Description("event")]
        Event
    }
}