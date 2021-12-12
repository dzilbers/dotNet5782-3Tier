namespace BlApi
{
    public static class BlFactory
    {
        public static IBL GetBl() => BL.BL.Instance;
    }
}
