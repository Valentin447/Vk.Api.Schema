using System;

namespace Vk.Api.Schema.Parameters.Group
{
    /// <summary>
    /// Интерфейс для представления параметров запроса для groups.editCallbackServer <para/>
    /// Документация: <see href="https://vk.com/dev/groups.editCallbackServer"/>
    /// </summary>
    public interface IGroupEditCallbackServerParameters
    {
        /// <summary>
        /// Идентификатор сообщества
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int GroupId { get; set; }

        /// <summary>
        /// Идентификатор сервера, данные которого нужно отредактировать
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        int ServerId { get; set; }

        /// <summary>
        /// Новый URL сервера
        /// </summary>
        /// <remarks>
        /// Обязательный параметр
        /// </remarks>
        Uri Url { get; set; }

        /// <summary>
        /// Новое название сервера
        /// </summary>
        /// <remarks>
        /// Обязательный параметр, максимальная длина 14
        /// </remarks>
        string Title { get; set; }

        /// <summary>
        /// Новый секретный ключ сервера
        /// </summary>
        /// <remarks>
        /// Максимальная длина 1024
        /// </remarks>
        string SecretKey { get; set; }
    }
}
