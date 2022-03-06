namespace RPG.src.entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

        public string Attack(int bonus){

            if (bonus  > 6 ){
                return this.Name + " Lançou ataque super efetivo com sua espada com bonus de ataque de " + bonus;
            } else 
            {
                return this.Name + " Lançou ataque fraco com sua espada bonus de " + bonus;
            }
        }


    }
}