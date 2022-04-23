using Rocket.API.Collections;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTShowID
{
    public class Main : RocketPlugin
    {
        public static Main Instance;
        protected override void Load()
        {
            Instance = this;
            Logger.Log("#############################################", ConsoleColor.Yellow);
            Logger.Log("###           BTShowID Loaded             ###", ConsoleColor.Yellow);
            Logger.Log("###   Plugin Created By blazethrower320   ###", ConsoleColor.Yellow);
            Logger.Log("###            Join my Discord:           ###", ConsoleColor.Yellow);
            Logger.Log("###     https://discord.gg/YsaXwBSTSm     ###", ConsoleColor.Yellow);
            Logger.Log("#############################################", ConsoleColor.Yellow);
        }
        protected override void Unload()
        {
            Logger.Log("BTShowID Unloaded");
        }
        public override TranslationList DefaultTranslations => new TranslationList
        {
            { "ShowID", "{{color=#FF0000}}[BTShowID] {{/color}}{{color=#F3F3F3}}Your Currently held Item has the ID of:{{/color}} {{color=#3E65FF}}{0}{{/color}}" },
        };
    }
}
