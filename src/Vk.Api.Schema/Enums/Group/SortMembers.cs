using System.ComponentModel;

namespace Vk.Api.Schema.Enums.Group
{
    /// <summary>
    /// Сортировка списка участников сообщества
    /// </summary>
    public enum SortMembers
    {
        /// <summary>
        /// Сортировать в порядке возрастания id
        /// </summary>
        [Description("id_asc")]
        IdAsc,

        /// <summary>
        /// Сортировать в порядке убывания id
        /// </summary>
        [Description("id_desc")]
        IdDesc,

        /// <summary>
        /// Сортировать в хронологическом порядке по вступлению в сообщество
        /// </summary>
        [Description("time_asc")]
        TimeAsc,

        /// <summary>
        /// Сортировать в антихронологическом порядке по вступлению в сообщество
        /// </summary>
        [Description("time_desc")]
        TimeDesc
    }
}