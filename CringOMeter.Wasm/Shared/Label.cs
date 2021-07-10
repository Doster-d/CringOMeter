using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CringOMeter.Wasm.Shared
{
    /// <summary>
    ///     Github Label.
    /// </summary>
    public sealed class Label
    {
        /// <summary>
        ///     Название плашки.
        /// </summary>
        public string Name { get; init; } = string.Empty;
        /// <summary>
        ///     Описание плашки.
        /// </summary>
        public string Description { get; init; } = string.Empty;
        /// <summary>
        ///     Цвет плашки.
        /// </summary>
        public string Color { get; init; } = string.Empty;
    }
}
