using Exiled.API.Interfaces;
using InventorySystem.Items.Usables.Scp330;
using Scp330Enhanced.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace Scp330Enhanced
{
    public class Config : IConfig
    {
        /// <summary>
        /// Gets or sets a value indicating whether the plugin is enabled or not.
        /// </summary>
        [Description("Whether or not this plugin is enabled.")]
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether debug messages should be displayed in the console or not.
        /// </summary>
        [Description("Whether or not debug messages should be shown in the console.")]
        public bool Debug { get; set; } = false;

        /// <summary>
        /// Gets or sets the list of allowed candies with their weights.
        /// </summary>
        [Description("List of allowed candies with their weights.")]
        public List<ConfigCandyitem> AllowedCandies { get; set; } = new List<ConfigCandyitem>
        {
            new ConfigCandyitem { Candy = CandyKindID.Rainbow, Weight = 16 },
            new ConfigCandyitem { Candy = CandyKindID.Yellow, Weight = 16 },
            new ConfigCandyitem { Candy = CandyKindID.Purple, Weight = 16 },
            new ConfigCandyitem { Candy = CandyKindID.Red, Weight = 16 },
            new ConfigCandyitem { Candy = CandyKindID.Green, Weight = 16 },
            new ConfigCandyitem { Candy = CandyKindID.Blue, Weight = 16 },
            new ConfigCandyitem { Candy = CandyKindID.Pink, Weight = 4 }
        };
    }
}
