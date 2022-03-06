namespace RPG.src.entities
{
    public class Wizard : Hero
    {

        public Wizard(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }

        public string Attack(int bonus){

            if (bonus  > 6 ){
                return this.Name + " Lançou magia super efetiva com bonus de ataque de " + bonus;
            } else 
            {
                return this.Name + " Lançou magia fraca com bonus de " + bonus;
            }
        }

        
    }
}