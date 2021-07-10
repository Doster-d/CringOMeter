using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CringOMeter.Wasm.Shared
{
    public sealed class PullRequest
    {
        /// <summary>
        ///     Ссылка на PR.
        /// </summary>
        [JsonPropertyName("html_url")]
        public string Url { get; init; } = string.Empty;
        /// <summary>
        ///     Номер PR.
        /// </summary>
        /// <value></value>
        public int Number { get; init; } = 0;
        /// <summary>
        ///     Тело PR.
        /// </summary>
        public string Body { get; init; } = string.Empty;
        /// <summary>
        ///     Автор PR.
        /// </summary>
        [JsonPropertyName("user")]
        public User Author { get; init; } = new();
        /// <summary>
        ///     Заголовок PR.
        /// </summary>
        public string Title { get; init; } = string.Empty;
        /// <summary>
        ///     Время открытия PR.
        /// </summary>
        /// <value></value>
        [JsonPropertyName("created_at")]
        public DateTime Opened { get; init; } = DateTime.Now;
        /// <summary>
        ///     Время закрытия PR.
        /// </summary>
        /// <value></value>
        [JsonPropertyName("closed_at")]
        public DateTime? Closed { get; init; } = null;
        /// <summary>
        ///     Плашки.
        /// </summary>
        public Label[] Labels { get; init; } = Array.Empty<Label>();
    }
}
