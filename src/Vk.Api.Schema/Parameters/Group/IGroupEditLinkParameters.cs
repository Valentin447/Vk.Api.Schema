namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.editLink <para/>
    /// Документация: <see href="https://vk.com/dev/groups.editLink"/>
    /// </summary>
    public interface IGroupEditLinkParameters
    {
        /// <summary>
        /// Идентификатор сообщества, в которое добавляется ссылка
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// Идентификатор ссылки
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int LinkId { get; set; }

        /// <summary>
        /// Новый текст описания для ссылки
        /// </summary>
        string Text { get; set; }
    }
}
