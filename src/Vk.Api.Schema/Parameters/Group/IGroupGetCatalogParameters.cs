namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.getCatalog <para/>
    /// Документация: <see href="https://vk.com/dev/groups.getCatalog"/>
    /// </summary>
    public interface IGroupGetCatalogParameters
    {
        /// <summary>
        /// Идентификатор категории, полученный в методе groups.getCatalogInfo
        /// </summary>
        int? CategoryId { get; set; }

        /// <summary>
        /// Идентификатор подкатегории, полученный в методе groups.getCatalogInfo
        /// </summary>
        /// <remarks>
        /// Максимальное значение 99
        /// </remarks>
        int? SubcategoryId { get; set; }
    }
}
