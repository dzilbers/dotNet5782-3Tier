using System;
using DalApi;

namespace Dal
{
    sealed class DalObject : IDal
    {
        static readonly IDal instance = new DalObject();
        public static IDal Instance { get => instance; }
        DalObject() { }
    }
}
