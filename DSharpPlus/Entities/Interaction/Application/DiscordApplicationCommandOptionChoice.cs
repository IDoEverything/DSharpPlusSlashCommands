﻿using System;
using Newtonsoft.Json;

namespace DSharpPlus.Entities
{
    /// <summary>
    /// Represents a command parameter choice for a <see cref="DiscordApplicationCommandOption"/>.
    /// </summary>
    public sealed class DiscordApplicationCommandOptionChoice
    {
        /// <summary>
        /// Gets the name of this choice parameter. 
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets the value of this choice parameter. This will either be a type of <see cref="int"/> / <see cref="long"/> or <see cref="string"/>.
        /// </summary>
        [JsonProperty("value")]
        public object Value { get; set; }

        /// <summary>
        /// Creates a new instance of a <see cref="DiscordApplicationCommandOptionChoice"/>.
        /// </summary>
        /// <param name="name">The name of the parameter choice.</param>
        /// <param name="value">The value of the parameter choice.</param>
        public DiscordApplicationCommandOptionChoice(string name, object value)
        {
            if (!(value is string || value is long || value is int))
                throw new InvalidOperationException($"Only {typeof(string)}, {typeof(long)} or {typeof(int)} types may be passed to a command option choice.");

            this.Name = name;
            this.Value = value;
        }
    }
}
