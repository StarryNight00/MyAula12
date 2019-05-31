using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerManager4
{
    public class CompareByName : IComparer<Player>
    {
        private bool order;
        public CompareByName(bool order)
        {
            this.order = order;
        }

        public int Compare(Player x, Player y)
        {
            if (x == y) return 0;
            if (x == null) return 1;
            if (y == null) return -1;

            if (order) return x.Name.CompareTo(y.Name);

            return y.Name.CompareTo(x.Name);
        }
    }
}
