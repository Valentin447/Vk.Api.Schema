namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.setCallbackSettings <para/>
    /// Документация: <see href="https://vk.com/dev/groups.setCallbackSettings"/>
    /// </summary>
    public interface IGroupSetCallbackSettingsParameters
    {
        /// <summary>
        /// Идентификатор сообщества
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// Идентификатор сервера
        /// </summary>
        int? ServerId { get; set; }

        /// <summary>
        /// Уведомления о новых сообщениях (0 — выключить, 1 — включить)
        /// </summary>
        bool? MessageNew { get; set; }

        /// <summary>
        /// Уведомления об ответе на сообщение (0 — выключить, 1 — включить)
        /// </summary>
        bool? MessageReply { get; set; }

        /// <summary>
        /// Уведомления о подписке на сообщения (0 — выключить, 1 — включить)
        /// </summary>
        bool? MessageAllow { get; set; }

        /// <summary>
        /// Уведомления о запрете на сообщения (0 — выключить, 1 — включить)
        /// </summary>
        bool? MessageDeny { get; set; }

        /// <summary>
        /// Уведомления о добавлении новой фотографии (0 — выключить, 1 — включить)
        /// </summary>
        bool? PhotoNew { get; set; }

        /// <summary>
        /// Уведомления о добавлении новой аудиозаписи (0 — выключить, 1 — включить)
        /// </summary>
        bool? AudioNew { get; set; }

        /// <summary>
        /// Уведомления о добавлении новой видеозаписи (0 — выключить, 1 — включить)
        /// </summary>
        bool? VideoNew { get; set; }

        /// <summary>
        /// Уведомления о добавлении нового комментария на стене (0 — выключить, 1 — включить)
        /// </summary>
        bool? WallReplyNew { get; set; }

        /// <summary>
        /// Уведомления о редактировании комментария на стене (0 — выключить, 1 — включить)
        /// </summary>
        bool? WallReplyEdit { get; set; }

        /// <summary>
        /// Уведомления об удалении комментария на стене (0 — выключить, 1 — включить)
        /// </summary>
        bool? WallReplyDelete { get; set; }

        /// <summary>
        /// Уведомления о восстановлении комментария на стене (0 — выключить, 1 — включить)
        /// </summary>
        bool? WallReplyRestore { get; set; }

        /// <summary>
        /// Уведомления о новой записи на стене (0 — выключить, 1 — включить)
        /// </summary>
        bool? WallPostNew { get; set; }

        /// <summary>
        /// Уведомления о репосте записи (0 — выключить, 1 — включить)
        /// </summary>
        bool? WallRepost { get; set; }

        /// <summary>
        /// Уведомления о создании комментария в обсуждении (0 — выключить, 1 — включить)
        /// </summary>
        bool? BoardPostNew { get; set; }

        /// <summary>
        /// Уведомления о редактировании комментария в обсуждении (0 — выключить, 1 — включить)
        /// </summary>
        bool? BoardPostEdit { get; set; }

        /// <summary>
        /// Уведомление о восстановлении комментария в обсуждении (0 — выключить, 1 — включить)
        /// </summary>
        bool? BoardPostRestore { get; set; }

        /// <summary>
        /// Уведомления об удалении комментария в обсуждении (0 — выключить, 1 — включить)
        /// </summary>
        bool? BoardPostDelete { get; set; }

        /// <summary>
        /// Уведомления о добавлении нового комментария к фото (0 — выключить, 1 — включить)
        /// </summary>
        bool? PhotoCommentNew { get; set; }

        /// <summary>
        /// Уведомления о редактировании комментария к фото (0 — выключить, 1 — включить)
        /// </summary>
        bool? PhotoCommentEdit { get; set; }

        /// <summary>
        /// Уведомления об удалении комментария к фото (0 — выключить, 1 — включить)
        /// </summary>
        bool? PhotoCommentDelete { get; set; }

        /// <summary>
        /// Уведомления о восстановлении комментария к фото (0 — выключить, 1 — включить)
        /// </summary>
        bool? PhotoCommentRestore { get; set; }

        /// <summary>
        /// Уведомления о добавлении нового комментария к видео (0 — выключить, 1 — включить
        /// </summary>
        bool? VideoCommentNew { get; set; }

        /// <summary>
        /// Уведомления о редактировании комментария к видео (0 — выключить, 1 — включить)
        /// </summary>
        bool? VideoCommentEdit { get; set; }

        /// <summary>
        /// Уведомления об удалении комментария к видео (0 — выключить, 1 — включить)
        /// </summary>
        bool? VideoCommentDelete { get; set; }

        /// <summary>
        /// Уведомления о восстановлении комментария к видео (0 — выключить, 1 — включить)
        /// </summary>
        bool? VideoCommentRestore { get; set; }

        /// <summary>
        /// Уведомления о добавлении нового комментария к товару (0 — выключить, 1 — включить)
        /// </summary>
        bool? MarketCommentNew { get; set; }

        /// <summary>
        /// Уведомления о редактировании комментария к товару (0 — выключить, 1 — включить)
        /// </summary>
        bool? MarketCommentEdit { get; set; }

        /// <summary>
        /// Уведомления об удалении комментария к товару (0 — выключить, 1 — включить)
        /// </summary>
        bool? MarketCommentDelete { get; set; }

        /// <summary>
        /// Уведомления о восстановлении комментария к товару (0 — выключить, 1 — включить)
        /// </summary>
        bool? MarketCommentRestore { get; set; }

        /// <summary>
        /// Уведомления о новом голосе в публичных опросах (0 — выключить, 1 — включить)
        /// </summary>
        bool? PollVoteNew { get; set; }

        /// <summary>
        /// Уведомления о вступлении в сообщество (0 — выключить, 1 — включить)
        /// </summary>
        bool? GroupJoin { get; set; }

        /// <summary>
        /// Уведомления о выходе из сообщества (0 — выключить, 1 — включить)
        /// </summary>
        bool? GroupLeave { get; set; }

        /// <summary>
        /// Уведомления об изменении настроек (0 — выключить, 1 — включить)
        /// </summary>
        bool? GroupChangeSettings { get; set; }

        /// <summary>
        /// Уведомления об изменении главной фотографии (0 — выключить, 1 — включить)
        /// </summary>
        bool? GroupChangePhoto { get; set; }

        /// <summary>
        /// Уведомления об изменении руководства (0 — выключить, 1 — включить)
        /// </summary>
        bool? GroupOfficersEdit { get; set; }

        /// <summary>
        /// Уведомления об внесении пользователя в чёрный список (0 — выключить, 1 — включить)
        /// </summary>
        bool? UserBlock { get; set; }

        /// <summary>
        /// Уведомления об исключении пользователя из чёрного списка (0 — выключить, 1 — включить)
        /// </summary>
        bool? UserUnblock { get; set; }
    }
}
