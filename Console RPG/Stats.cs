namespace Console_RPG
{
    struct Stats
    {
        public int attack;
        public int magicModifier;
        public int magicResistance;
        public int defense;

        public Stats(int attack, int magicModifier, int magicResistance, int defense)
        {
            this.attack = attack;
            this.magicModifier = magicModifier;
            this.magicResistance = magicResistance;
            this.defense = defense;
        }
    }
}
