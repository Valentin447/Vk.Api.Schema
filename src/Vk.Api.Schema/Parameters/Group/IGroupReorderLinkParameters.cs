namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.reorderLink <para/>
    /// Документация: <see href="https://vk.com/dev/groups.reorderLink"/>
    /// </summary>
    public interface IGroupReorderLinkParameters
    {
        /// <summary>
        /// Идентификатор группы, внутри которой перемещается ссылка
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// Идентификатор ссылки, которую необходимо переместить
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int LinkId { get; set; }

        /// <summary>
        /// Идентификатор ссылки после которой необходимо разместить перемещаемую ссылку
        /// </summary>
        /// <remarks>
        /// 0 – если ссылку нужно разместить в начале списка
        /// </remarks>
        int? After { get; set; }
    }
}
