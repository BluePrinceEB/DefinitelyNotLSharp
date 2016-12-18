// --------------------------------------------------------------------------------------------------------------------  
// <summary>
//   The Load.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Jayce
{
    #region

    using System;

    using LeagueSharp;
    using LeagueSharp.SDK;

    using Events = LeagueSharp.SDK.Events;

    #endregion

    /// <summary>
    ///     The Load.
    /// </summary>
    internal class Load
    {
        #region Methods

        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            Bootstrap.Init(args);
            Events.OnLoad += OnLoad;
        }

        /// <summary>
        /// The on load.
        /// </summary>
        /// <param name="sender">
        /// The sender.
        /// </param>
        /// <param name="eventArgs">
        /// The event args.
        /// </param>
        private static void OnLoad(object sender, EventArgs eventArgs)
        {
            if (ObjectManager.Player.ChampionName == "Jayce")
            {
                Extensions.Events.Initialize();
                Extensions.Spells.Initialize();
                Extensions.Config.Initialize();
            }
        }

        #endregion
    }
}