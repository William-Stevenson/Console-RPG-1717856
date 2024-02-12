namespace Console_RPG
{
    struct Stats
    {
        public int attack;
        public int defense;
        public int magicModifier;
        public int magicResistance;

        public Stats(int attack, int defense, int magicModifier, int magicResistance)
        {
            this.attack = attack;
            this.defense = defense;
            this.magicModifier = magicModifier;
            this.magicResistance = magicResistance;
        }
    }
}
