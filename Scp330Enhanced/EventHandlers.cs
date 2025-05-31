using Exiled.API.Features;
using Exiled.Events.EventArgs.Scp330;

namespace Scp330Enhanced
{
    public class EventHandlers
    {
        RandomCandySelector RandomCandySelector { get; } = new RandomCandySelector();

        public void InteractingScp330(InteractingScp330EventArgs ev)
        {
            if (Scp330Enhanced.Instance.Config.AllowedCandies.Count == 0)
            {
                ev.IsAllowed = false;
                return;
            }

            ev.Candy = RandomCandySelector.GetRandomCandy(Scp330Enhanced.Instance.Config.AllowedCandies);

            Log.Debug($"Selected candy: {ev.Candy} with weight {Scp330Enhanced.Instance.Config.AllowedCandies.Find(c => c.Candy == ev.Candy).Weight}");
        }
    }
}
