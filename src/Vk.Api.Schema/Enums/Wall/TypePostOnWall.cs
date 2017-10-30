using System.ComponentModel;

namespace Vk.Api.Schema.Enums.Wall
{
    /// <summary>
    /// Типы записей на стене
    /// </summary>
    public enum TypePostOnWall
    {
        /// <summary>
        /// Предложенные записи на стене сообщества (доступно только при вызове с передачей AccessToken)
        /// </summary>
        [Description("suggests")]
        Suggests,

        /// <summary>
        /// Отложенные записи (доступно только при вызове с передачей AccessToken)
        /// </summary>
        [Description("postponed")]
        Postponed,

        /// <summary>
        /// Записи владельца стены
        /// </summary>
        [Description("owner")]
        Owner,

        /// <summary>
        /// Записи не от владельца стены
        /// </summary>
        [Description("others")]
        Others,

        /// <summary>
        /// Все записи на стене (owner + others)
        /// </summary>
        [Description("all")]
        All
    }
}