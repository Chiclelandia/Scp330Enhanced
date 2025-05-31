using Exiled.API.Features;
using System;

namespace Scp330Enhanced
{
    public class Scp330Enhanced : Plugin<Config>
    {
        public override string Name => "Scp330Enhanced";
        public override string Prefix => "Scp330Enhanced";
        public override string Author => "Chicle (chiclelandia.com) <hola@chicle.dev>";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(9, 6, 0);

        public static Scp330Enhanced Instance { get; set; }
        private EventHandlers _eventHandlers;

        public override void OnEnabled()
        {
            Instance = this;
            _eventHandlers = new EventHandlers();
            SubscribeEvents();
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;
            UnsubscribeEvents();
            base.OnDisabled();
        }

        public override void OnReloaded()
        {
            base.OnReloaded();
        }

        private void SubscribeEvents()
        {
            Exiled.Events.Handlers.Scp330.InteractingScp330 += _eventHandlers.InteractingScp330;
        }

        private void UnsubscribeEvents()
        {
            Exiled.Events.Handlers.Scp330.InteractingScp330 -= _eventHandlers.InteractingScp330;
        }
    }
}
