
//using Oxide.Core;
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
//using WebSocketSharp;
//using Oxide.Plugins.TODEH;

namespace Oxide.Plugins
{
    [Info("Grumbo'z BigBen tester", "Grumbo", "1.0")]
    [Description("Tests examples of default Event Hooks")]

    public class BigBentester : RustPlugin
	{
        #region Oxide Hooks

        private void OnDawn(string msg, bool service)
        {
            PrintWarning(msg + ":" + TOD_Sky.Instance.Cycle.DateTime.ToString("HH:mm"));
        }
        private void OnNoon(string msg, bool service)
		{
            PrintWarning(msg + ":" + TOD_Sky.Instance.Cycle.DateTime.ToString("HH:mm"));
        }
        private void OnDusk(string msg, bool service)
        {
            PrintWarning(msg + ":" + TOD_Sky.Instance.Cycle.DateTime.ToString("HH:mm"));
        }
        private void OnMidnight(string msg, bool service)
        {
            PrintWarning(msg + ":" + TOD_Sky.Instance.Cycle.DateTime.ToString("HH:mm"));
        }
        private void OnTest(string msg, bool service)
        {
            PrintWarning(msg + ":" + TOD_Sky.Instance.Cycle.DateTime.ToString("HH:mm"));
        }
        #endregion
    }
}
