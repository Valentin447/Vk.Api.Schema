using Vk.Api.Schema.Enums.Group;

namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.search <para/>
    /// Документация: <see href="https://vk.com/dev/groups.search"/>
    /// </summary>
    public interface IGroupSearchParameters
    {
        /// <summary>
        /// Текст поискового запроса
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        string QueryText { get; set; }

        /// <summary>
        /// Тип сообщества
        /// </summary>
        GroupType? Type { get; set; }

        /// <summary>
        /// Идентификатор страны
        /// </summary>
        int? CountryId { get; set; }

        /// <summary>
        /// Идентификатор города
        /// </summary>
        /// <remarks>
        /// При передаче этого параметра, поле CountryId игнорируется
        /// </remarks>
        int? CityId { get; set; }

        /// <summary>
        /// Будут выведены предстоящие события
        /// </summary>
        /// <remarks>
        /// Учитывается только при передаче в качестве Type значения event
        /// </remarks>
        bool? IsFuture { get; set; }

        /// <summary>
        /// Будут выведены сообщества с включенными товарами
        /// </summary>
        bool? MarketIsActive { get; set; }

        /// <summary>
        /// Сортировка результата поиска сообществ
        /// </summary>
        SortSearchResult? Sort { get; set; }

        /// <summary>
        /// Смещение, необходимое для выборки определённого подмножества результатов поиска
        /// </summary>
        /// <remarks>
        /// По умолчанию — 0
        /// </remarks>
        int? Offset { get; set; }

        /// <summary>
        /// Количество результатов поиска, которое необходимо вернуть
        /// </summary>
        /// <remarks>
        /// По умолчанию 20, максимальное значение 1000
        /// </remarks>
        int? Count { get; set; }
    }
}
