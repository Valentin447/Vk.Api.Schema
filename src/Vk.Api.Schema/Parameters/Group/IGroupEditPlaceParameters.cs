namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.editPlace <para/>
    /// Документация: <see href="https://vk.com/dev/groups.editPlace"/>
    /// </summary>
    public interface IGroupEditPlaceParameters
    {
        /// <summary>
        /// Идентификатор группы, информацию о месте которой нужно отредактировать
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// Название места
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Строковой адрес места
        /// </summary>
        string Address { get; set; }

        /// <summary>
        /// Идентификатор страны
        /// </summary>
        /// <remarks>
        /// Список доступных стран можно получить методом database.getCountries
        /// </remarks>
        int? CountryId { get; set; }

        /// <summary>
        /// Идентификатор города
        /// </summary>
        /// <remarks>
        /// Список доступных городов можно получить методом database.getCities
        /// </remarks>
        int? CityId { get; set; }

        /// <summary>
        /// Географическая широта отметки, заданная в градусах (от -90 до 90)
        /// </summary>
        double? Latitude { get; set; }

        /// <summary>
        /// Географическая долгота отметки, заданная в градусах (от -180 до 180)
        /// </summary>
        double? Longitude { get; set; }
    }
}
