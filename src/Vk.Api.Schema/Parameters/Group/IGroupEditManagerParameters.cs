using Vk.Api.Schema.Enums.Group;

namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.editManager <para/>
    /// Документация: <see href="https://vk.com/dev/groups.editManager"/>
    /// </summary>
    public interface IGroupEditManagerParameters
    {
        /// <summary>
        /// Идентификатор сообщества
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// Идентификатор пользователя, чьи полномочия в сообществе нужно изменить
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int UserId { get; set; }

        /// <summary>
        /// Уровень полномочий
        /// </summary>
        /// <remarks>
        /// Если параметр не задан, с пользователя UserId снимаются полномочия руководителя
        /// </remarks>
        AdminLevel? Role { get; set; }

        /// <summary>
        /// Отображать пользователя в блоке контактов сообщества
        /// </summary>
        bool? IsContact { get; set; }

        /// <summary>
        /// Должность пользователя, отображаемая в блоке контактов
        /// </summary>
        string ContactPosition { get; set; }

        /// <summary>
        /// Телефон пользователя, отображаемый в блоке контактов
        /// </summary>
        string ContactPhone { get; set; }

        /// <summary>
        /// Email пользователя, отображаемый в блоке контактов
        /// </summary>
        string ContactEmail { get; set; }
    }
}
