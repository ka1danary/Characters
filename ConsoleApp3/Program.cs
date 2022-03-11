using System;
using ConsoleApp3.Folder;
namespace ConsoleApp3

{

    
    class Program
    {

        internal static void DoCharacter(HeroConstruct hero)
        {
            hero.character();
            hero.ability();
        }

        static void Main(string[] args)
        {
            HeroConstruct Pers1 = new HeroConstruct(new King(), new Power());
            HeroConstruct Pers2 = new HeroConstruct(new Queen(), new Magic());
            HeroConstruct Pers3 = new HeroConstruct(new Knight(), new Dxterity());

            Program.DoCharacter(Pers1);

        }
    }
}
