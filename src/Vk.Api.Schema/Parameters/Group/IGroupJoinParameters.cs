namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.join <para/>
    /// Документация: <see href="https://vk.com/dev/groups.join"/>
    /// </summary>
    public interface IGroupJoinParameters
    {
        /// <summary>
        /// Идентификатор сообщества
        /// </summary>
        int? GroupId { get; set; }

        /// <summary>
        /// Опциональный параметр, учитываемый, если GroupId принадлежит встрече
        /// </summary>
        /// <remarks>
        /// 1 — Возможно пойду. 0 — Точно пойду. По умолчанию 0
        /// </remarks>
        string NotSure { get; set; } // TODO: По документации - строка, по логике - булл или перечисление. проверить
    }
}
