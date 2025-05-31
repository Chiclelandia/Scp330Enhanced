using InventorySystem.Items.Usables.Scp330;

namespace Scp330Enhanced.Models
{
    public class ConfigCandyitem
    {
        public CandyKindID Candy { get; set; }
        public double Weight { get; set; }

        public ConfigCandyitem() { }

        public ConfigCandyitem(CandyKindID candy, double weight) {
            Candy = candy;
            Weight = weight;
        }
    }
}
