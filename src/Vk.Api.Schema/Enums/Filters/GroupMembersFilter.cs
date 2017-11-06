using System.ComponentModel;

namespace Vk.Api.Schema.Enums.Filters
{
    /// <summary>
    /// Фильтр списка участников сообщества
    /// </summary>
    public enum GroupMembersFilter
    {
        /// <summary>
        /// Будут возвращены только друзья в этом сообществе
        /// </summary>
        [Description("friends")]
        Friends,

        /// <summary>
        /// Будут возвращены пользователи, которые выбрали «Возможно пойду» (если сообщество относится к мероприятиям)
        /// </summary>
        [Description("unsure")]
        Unsure,

        /// <summary>
        /// будут возвращены только руководители сообщества (доступно при запросе с передачей access_token от имени администратора сообщества)
        /// </summary>
        [Description("managers")]
        Managers
    }
}