using System;

namespace DnD
{
    public class Campaign
    {
        public Campaign(string name)
        {
            this.Name = name;
        }

        public object Name { get; }
    }
}
