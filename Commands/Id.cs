using Rocket.API;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Logger = Rocket.Core.Logging.Logger;

namespace BTShowID.Commands
{
    public class Id : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;
        public string Name => "Id";

        public string Help => "Shows the ID of a Item in Hand";

        public string Syntax => "ID";

        public List<string> Aliases => new List<string>();

        public List<string> Permissions => new List<string>() { "BTShowID.Id" };

        public void Execute(IRocketPlayer caller, string[] command)
        {
            UnturnedPlayer player = (UnturnedPlayer)caller;
            if (player.Player.equipment.isBusy || !player.Player.equipment.isEquipped) return;
            if (player.Player.equipment.isEquipped)
            {
                ChatManager.say(player.CSteamID, Main.Instance.Translate("ShowID", player.Player.equipment.itemID).Replace("{", "<").Replace("}", ">"), Color.red, true);
            }
        }
    }
}
