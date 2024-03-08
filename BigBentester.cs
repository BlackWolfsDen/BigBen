using Oxide.Core.Libraries;
using Oxide.Core.Libraries.Covalence;
using Oxide.Core.Plugins;
using Oxide.Game.Rust.Cui;
using Oxide.Game.Rust.Libraries;

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Oxide.Plugins
{
    [Info("Grumbo'z BigBen tester", "Grumbo", "1.0")]
    [Description("Tests examples of default Event Hooks")]
/*
	Below are example of how to subscribe your method to event hooks triggered by Big Ben using  
*/
    public class BigBentester : RustPlugin
	{
        #region Oxide Hooks

        private void OnDawn(string msg, bool service)
        {
		PrintWarning(msg);
        }
        private void OnNoon(string msg, bool service)
	{
		PrintWarning(msg);
	}
        private void OnDusk(string msg, bool service)
        {
		PrintWarning(msg);
        }
        private void OnMidnight(string msg, bool service)
        {
		PrintWarning(msg);
        }
        #endregion
    }
}
