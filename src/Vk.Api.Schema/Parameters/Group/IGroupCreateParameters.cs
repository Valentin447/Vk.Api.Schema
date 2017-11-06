using Vk.Api.Schema.Enums.Group;

namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.create <para/>
    /// Документация: <see href="https://vk.com/dev/groups.create"/>
    /// </summary>
    public interface IGroupCreateParameters
    {
        /// <summary>
        /// Название сообщества
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        string Title { get; set; }

        /// <summary>
        /// Описание сообщества
        /// </summary>
        /// <remarks>
        /// Не учитывается при Type = public
        /// </remarks>
        string Description { get; set; }

        /// <summary>
        /// Тип создаваемого сообщества
        /// </summary>
        /// <remarks>
        /// По умолчанию: group
        /// </remarks>
        GroupTypeCreate? Type { get; set; }

        /// <summary>
        /// Категория публичной страницы
        /// </summary>
        /// <remarks>
        /// Только для Type = public
        /// </remarks>
        int? PublicCategory { get; set; }

        /// <summary>
        /// Вид публичной страницы
        /// </summary>
        /// <remarks>
        /// Только при Type = public
        /// </remarks>
        TypePublicPage? Subtype { get; set; }
    }
}
