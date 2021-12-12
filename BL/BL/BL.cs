using System;
using BlApi;
using DalApi;

namespace BL
{
    sealed class BL : IBL
    {
        static readonly IBL instance = new BL();
        public static IBL Instance { get => instance; }

        internal IDal dal = DalFactory.GetDal();
        BL() { }

    }
}
