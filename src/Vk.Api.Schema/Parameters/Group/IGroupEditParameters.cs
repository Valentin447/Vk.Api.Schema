using System;
using System.Collections.Generic;
using Vk.Api.Schema.Enums.Group;

namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.edit <para/>
    /// Документация: <see href="https://vk.com/dev/groups.edit"/>
    /// </summary>
    public interface IGroupEditParameters
    {
        /// <summary>
        /// Идентификатор сообщества, ссылки которого нужно удалить
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// Название сообщества
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Описание сообщества
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Короткое имя сообщества
        /// </summary>
        string ScreenName { get; set; }

        /// <summary>
        /// Тип группы
        /// </summary>
        GroupClosedType? Access { get; set; }

        /// <summary>
        /// Адрес сайта, который будет указан в информации о группе
        /// </summary>
        string Website { get; set; }

        /// <summary>
        /// Тематика сообщества
        /// </summary>
        CommunitySubjects? Subject { get; set; }

        /// <summary>
        /// Электронный адрес организатора (для мероприятий)
        /// </summary>
        string Email { get; set; }

        /// <summary>
        /// Номер телефона организатора (для мероприятий)
        /// </summary>
        string Phone { get; set; }

        /// <summary>
        /// Адрес rss для импорта новостей
        /// </summary>
        /// <remarks>
        /// доступен только группам, получившим соответствующее разрешение, 
        /// обратитесь в http://vk.com/support для получения разрешения
        /// </remarks>
        string Rss { get; set; }

        /// <summary>
        /// Дата начала события
        /// </summary>
        DateTime? EventStartDate { get; set; }

        /// <summary>
        /// Дата окончания события
        /// </summary>
        DateTime? EventFinishDate { get; set; }

        /// <summary>
        /// Идентификатор группы, которая является организатором события (только для событий)
        /// </summary>
        int? EventGroupId { get; set; }

        /// <summary>
        /// Категория публичной страницы
        /// </summary>
        int? PublicCategory { get; set; }

        /// <summary>
        /// Подкатегория публичной станицы
        /// </summary>
        /// <remarks>
        /// Список подкатегорий можно получить методом groups.getSettings
        /// </remarks>
        int? PublicSubcategory { get; set; }

        /// <summary>
        /// Дата основания компании, организации, которой посвящена публичная страница
        /// </summary>
        /// <remarks>
        /// Строка формата "dd.mm.YYYY".
        /// </remarks>
        string PublicDate { get; set; }

        /// <summary>
        /// Статус доступа стены
        /// </summary>
        GroupEditStatus? Wall { get; set; }

        /// <summary>
        /// Статус доступа обсуждения
        /// </summary>
        GroupEditStatus? Topics { get; set; } // TODO: Не может принимать значение "закрыт", нужно отдельное перечисление?

        /// <summary>
        /// Статус доступа фотографии
        /// </summary>
        GroupEditStatus? Photos { get; set; } // TODO: Не может принимать значение "закрыт", нужно отдельное перечисление?

        /// <summary>
        /// Статус доступа видеозаписи
        /// </summary>
        GroupEditStatus? Video { get; set; } // TODO: Не может принимать значение "закрыт", нужно отдельное перечисление?

        /// <summary>
        /// Статус доступа аудиозаписи
        /// </summary>
        GroupEditStatus? Audio { get; set; } // TODO: Не может принимать значение "закрыт", нужно отдельное перечисление?

        /// <summary>
        /// Ссылки - включены (доступно только для публичных страниц) 
        /// (0 — выключены)
        /// </summary>
        bool? LinksIsActive { get; set; }

        /// <summary>
        /// События - включены (доступно только для публичных страниц)
        /// (0 — выключены)
        /// </summary>
        bool? EventsIsActive { get; set; }

        /// <summary>
        /// Места - включены (доступно только для публичных страниц)
        /// (0 — выключены)
        /// </summary>
        bool? PlacesIsActive { get; set; }

        /// <summary>
        /// Контакты - включены (доступно только для публичных страниц)
        /// (0 — выключены)
        /// </summary>
        bool? ContactsIsActive { get; set; }

        /// <summary>
        /// Статус доступа документов сообщества
        /// </summary>
        GroupEditStatus? Docs { get; set; } // TODO: Не может принимать значение "закрыт", нужно отдельное перечисление?

        /// <summary>
        /// Статус доступа wiki-материалов сообщества
        /// </summary>
        GroupEditStatus? Wiki { get; set; } // TODO: Не может принимать значение "закрыт", нужно отдельное перечисление?

        /// <summary>
        /// Сообщения сообщества - включены (0 — выключены)
        /// </summary>
        bool? MessagesIsActive { get; set; }

        /// <summary>
        /// Возрастное ограничение для сообщества
        /// </summary>
        /// <remarks>
        /// По умолчанию: 1 — нет ограничений
        /// </remarks>
        AgeLimits? AgeLimitsGroup { get; set; }

        /// <summary>
        /// Товары - включены (0 — выключены)
        /// </summary>
        bool? MarketIsActive { get; set; }

        /// <summary>
        /// Комментарии к товарам - включены (0 — выключены)
        /// </summary>
        bool? MarketCommentsIsActive { get; set; }

        /// <summary>
        /// Регионы доставки товаров
        /// </summary>
        IEnumerable<int> MarketCountry { get; set; }

        /// <summary>
        /// Города доставки товаров (в случае если указана одна страна)
        /// </summary>
        IEnumerable<int> MarketCity { get; set; }

        /// <summary>
        /// Идентификатор валюты магазина
        /// </summary>
        CurrencyIdentifier? MarketCurrency { get; set; }

        /// <summary>
        /// Контакт для связи с продавцом
        /// </summary>
        /// <remarks>
        /// Для использования сообщений сообщества следует включить их и передать значение 0
        /// </remarks>
        int? MarketContact { get; set; }

        /// <summary>
        /// Идентификатор wiki-страницы с описанием магазина
        /// </summary>
        int? MarketWiki { get; set; }

        /// <summary>
        /// Фильтр нецензурных выражений в комментариях - включен (0 — выключен)
        /// </summary>
        bool? ObsceneFilterIsActive { get; set; }

        /// <summary>
        /// Фильтр по ключевым словам в комментариях - включен (0 — выключен)
        /// </summary>
        bool? ObsceneStopwordsIsActive { get; set; }

        /// <summary>
        /// Ключевые слова для фильтра комментариев
        /// </summary>
        IEnumerable<string> ObsceneWords { get; set; }
    }
}
