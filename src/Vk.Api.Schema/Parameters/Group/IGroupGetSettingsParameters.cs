namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.getSettings <para/>
    /// Документация: <see href="https://vk.com/dev/groups.getSettings"/>
    /// </summary>
    public interface IGroupGetSettingsParameters
    {
        /// <summary>
        /// Идентификатор сообщества, данные которого необходимо получить
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }
    }
}
