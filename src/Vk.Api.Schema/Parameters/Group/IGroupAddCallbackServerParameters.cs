using System;

namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.addCallbackServer <para/>
    /// Документация: <see href="https://vk.com/dev/groups.addCallbackServer"/>
    /// </summary>
    public interface IGroupAddCallbackServerParameters
    {
        /// <summary>
        /// Идентификатор сообщества
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// URL сервера
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        Uri Url { get; set; }

        /// <summary>
        /// Название сервера
        /// </summary>
        /// <remarks>
        /// Обязательный параметр, максимальная длина 14
        /// </remarks>
        string Title { get; set; }

        /// <summary>
        /// Секретный ключ
        /// </summary>
        /// <remarks>
        /// Максимальная длина 50
        /// </remarks>
        string SecretKey { get; set; }
    }
}
