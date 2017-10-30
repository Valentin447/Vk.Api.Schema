using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Wall
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для wall.postAdsStealth <para/>
    /// Документация: <see href="https://vk.com/dev/wall.postAdsStealth"/>
    /// </summary>
    public interface IWallPostAdsStealthParameters
    {
        /// <summary>
        /// Идентификатор владельца стены пользователя или сообщества
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// Идентификатор сообщества в параметре OwnerId необходимо указывать со знаком "-"
        /// </remarks>
        int OwnerId { get; set; }

        /// <summary>
        /// Текст записи
        /// </summary>
        string Message { get; set; }

        /// <summary>
        /// Список объектов, приложенных к записи
        /// </summary>
        /// <remarks>
        /// Параметр является обязательным, если не задан параметр Message
        /// </remarks>
        IEnumerable<string> Attachments { get; set; } // TODO: Возможно стоит сделать отдельный тип

        /// <summary>
        /// 1 — у записи, размещенной от имени сообщества, будет добавлена подпись (имя пользователя, разместившего запись)
        /// </summary>
        /// <remarks>
        /// 0 — подписи добавлено не будет
        /// </remarks>
        bool? IsSigned { get; set; }

        /// <summary>
        /// Географическая широта отметки, заданная в градусах (от -90 до 90)
        /// </summary>
        double? Latitude { get; set; }

        /// <summary>
        /// Географическая долгота отметки, заданная в градусах (от -180 до 180)
        /// </summary>
        double? Longitude { get; set; }

        /// <summary>
        /// Идентификатор места, в котором отмечен пользователь
        /// </summary>
        int? PlaceId { get; set; }

        /// <summary>
        /// уникальный идентификатор, предназначенный для предотвращения повторной отправки одинаковой записи
        /// </summary>
        string Guid { get; set; }

        /// <summary>
        /// Идентификатор кнопки, которую необходимо добавить к сниппету для ссылки
        /// </summary>
        string LinkButton { get; set; } // TODO: enum или отдельный тип?

        /// <summary>
        /// Заголовок, который должен быть использован для сниппета
        /// </summary>
        /// <remarks>
        /// Если не указан, будет автоматически получен с целевой ссылки. 
        /// Обязательно указывать в случае, если ссылка является номером телефона
        /// </remarks>
        string LinkTitle { get; set; }

        /// <summary>
        /// Ссылка на изображение, которое должно быть использовано для сниппета
        /// </summary>
        /// <remarks>
        /// Минимальное разрешение: 537x240. 
        /// Если не указана, будет автоматически загружена с целевой ссылки. 
        /// Обязательно указывать в случае, если ссылка является номером телефона
        /// </remarks>
        string LinkImage { get; set; }
    }
}
