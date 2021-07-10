using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CringOMeter.Wasm.Shared
{
    /// <summary>
    ///     Пользователь Github.
    /// </summary>
    public sealed class User
    {
        /// <summary>
        ///     Логин пользователя.
        /// </summary>
        public string Login { get; init; } = string.Empty;

        /// <summary>
        ///     Ссылка на аватар пользователя.
        /// </summary>
        [JsonPropertyName("avatar_url")]
        public string Avatar { get; init; } = string.Empty;
    }
}
