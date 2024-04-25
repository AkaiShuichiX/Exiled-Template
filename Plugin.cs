using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;

namespace Exiled_Template
{
    public class Plugin : Plugin<Config>
    {
        public override string Name { get; } = "Template";
        public override string Prefix { get; } = "Template";
        public override string Author { get; } = "Wave";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(8, 0, 0);
        public override bool IgnoreRequiredVersionCheck { get; } = true;

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.Verified += OnVerified;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Verified -= OnVerified;
            base.OnDisabled();
        }
        
        private void OnVerified(VerifiedEventArgs ev)
        {
            ev.Player.Broadcast(5, "Welcome to the server!");
        }
    }
}