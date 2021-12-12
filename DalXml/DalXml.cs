using System;
using DalApi;

namespace Dal
{
    sealed class DalXml : IDal
    {
        static readonly IDal instance = new DalXml();
        public static IDal Instance { get => instance; }
        DalXml() { }
    }
}
