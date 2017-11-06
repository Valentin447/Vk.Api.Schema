namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.getCatalogInfo <para/>
    /// Документация: <see href="https://vk.com/dev/groups.getCatalogInfo"/>
    /// </summary>
    public interface IGroupGetCatalogInfoParameters
    {
        /// <summary>
        /// Вернуть информацию о количестве сообществ в категории и три сообщества для предпросмотра
        /// </summary>
        /// <remarks>
        /// По умолчанию 0, доступен начиная с версии 5.37
        /// </remarks>
        bool? IsExtended { get; set; }

        /// <summary>
        /// Вернуть информацию об подкатегориях
        /// </summary>
        /// <remarks>
        /// По умолчанию 0, доступен начиная с версии 5.37
        /// </remarks>
        bool? GetSubcategories { get; set; }
    }
}
