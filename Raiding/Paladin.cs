﻿namespace Raiding
{
    public class Paladin : BaseHero
    {
        public Paladin(string name) : base(name, 100) { }
        public override string CastAbility()
        {
            return $"{GetType()} – {Name} healed for {Power}";
        }
    }
}