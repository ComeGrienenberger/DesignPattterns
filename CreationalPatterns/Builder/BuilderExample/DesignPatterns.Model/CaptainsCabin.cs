namespace DesignPatterns.Model
{
    public class CaptainsCabin : Room
    {
        public CaptainsCabin() : base(2)
        {
        }

        public override bool HasDesk()
        {
            return true;
        }

        public override bool HasShower()
        {
            return false;
        }
    }
}
