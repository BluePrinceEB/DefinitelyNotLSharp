namespace Brand
{
    using System;
    using LeagueSharp.SDK;

    using static Extensions.Config;

    class Load
    {
        static void Main(string[] args)
        {
            Bootstrap.Init(args);
            Events.OnLoad += OnLoad;
        }

        private static void OnLoad(object sender, EventArgs eventArgs)
        {
            if (MyHero.ChampionName == "Brand")
            {
                Extensions.Events.Initialize();
                Extensions.Config.Initialize();
                Extensions.Spells.Initialize();
            }
        }
    }
}
