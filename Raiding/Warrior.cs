﻿namespace Raiding
{
    public class Warrior : BaseHero
    {
        public Warrior(string name) : base(name, 100) { }
        public override string CastAbility()
        {
            return $"{GetType()} – {Name} healed for {Power}";
        }
    }
}
