namespace DesignPatterns.Model
{
    public class StakeholderCabin : Room
    {
        public StakeholderCabin() : base(1)
        {
        }

        public override bool HasDesk()
        {
            return true;
        }

        public override bool HasShower()
        {
            return true;
        }
    }
}
