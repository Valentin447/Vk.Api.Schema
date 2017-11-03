namespace Vk.Api.Schema.Enums.Group
{
    /// <summary>
    /// Причина бана
    /// </summary>
    public enum ReasonForBan
    {
        /// <summary>
        /// Другое (по умолчанию)
        /// </summary>
        Other,

        /// <summary>
        /// Спам
        /// </summary>
        Spam,

        /// <summary>
        /// Оскорбление участников
        /// </summary>
        Insult,

        /// <summary>
        /// Нецензурные выражения
        /// </summary>
        Obscene,

        /// <summary>
        /// Сообщения не по теме
        /// </summary>
        OffTopic
    }
}