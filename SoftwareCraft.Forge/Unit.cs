namespace SoftwareCraft.Functional
{
    public sealed class Unit
    {
        private static Unit? instance;

        private Unit()
        {
        }

        public static Unit Instance => instance ??= new Unit();
    }
}