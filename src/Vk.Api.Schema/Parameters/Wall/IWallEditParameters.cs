﻿using System.Collections.Generic;

namespace Vk.Api.Schema.Parameters.Wall
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для wall.edit <para/>
    /// Документация: <see href="https://vk.com/dev/wall.edit"/>
    /// </summary>
    public interface IWallEditParameters
    {
        /// <summary>
        /// Идентификатор пользователя или сообщества, на стене которого находится запись
        /// </summary>
        /// <remarks>
        ///  идентификатор сообщества в параметре OwnerId необходимо указывать со знаком "-"
        ///  — например, OwnerId=-1 
        /// По умолчанию идентификатор текущего пользователя
        /// </remarks>
        int? OwnerId { get; set; }

        /// <summary>
        /// Идентификатор записи на стене
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int PostId { get; set; }

        /// <summary>
        /// Запись будет доступна только друзьям. (0 — доступна всем пользователям)
        /// </summary>
        /// <remarks>
        /// Параметр учитывается только при редактировании отложенной записи
        /// </remarks>
        bool? IsFriendsOnly { get; set; }

        /// <summary>
        /// Текст сообщения
        /// </summary>
        /// <remarks>
        /// Является обязательным, если не задан параметр Attachments
        /// </remarks>
        string Message { get; set; }

        /// <summary>
        /// Список объектов, приложенных к записи
        /// </summary>
        /// <remarks>
        /// Параметр является обязательным, если не задан параметр Message
        /// </remarks>
        IEnumerable<string> Attachments { get; set; } // TODO: Возможно стоит сделать отдельный тип

        /// <summary>
        /// Список сервисов или сайтов, на которые необходимо экспортировать запись, 
        /// в случае если пользователь настроил соответствующую опцию
        /// </summary>
        /// <remarks>
        /// Параметр учитывается только при редактировании отложенной записи
        /// </remarks>
        string Services { get; set; }

        /// <summary>
        /// К записи, размещенной от имени сообщества будет добавлена подпись (имя пользователя, разместившего запись)
        /// </summary>
        /// <remarks>
        /// 0 — подписи добавлено не будет 
        /// Параметр учитывается только при редактировании записи на стене сообщества, 
        /// опубликованной от имени группы
        /// </remarks>
        bool? IsSigned { get; set; }

        /// <summary>
        /// Дата публикации записи в формате unixtime. 
        /// </summary>
        /// <remarks>
        /// Если параметр не указан, отложенная запись будет опубликована 
        /// Параметр учитывается только при редактировании отложенной записи
        /// </remarks>
        int? PublishDate { get; set; }

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
        /// К записи, размещенной от имени сообщества, будет добавлена метка "это реклама", 
        /// 0 — метки добавлено не будет/снять установленную метку
        /// </summary>
        /// <remarks>
        /// Метка может быть снята в течение пяти минут после её установки
        /// В сутки может быть опубликовано не более пяти рекламных записей, 
        /// из которых не более трёх — вне Биржи ВКонтакте
        /// </remarks>
        bool? MarkAsAds { get; set; }
    }
}