using System;
using System.Collections.Generic;
using System.Text;
using ConsoleApp3.Folder;

namespace ConsoleApp3
{
    internal class HeroConstruct
    {
        private CharacterBehavior newCharacter;
        private AbilityBehavior newAbility;

        public HeroConstruct(CharacterBehavior newCharacter, AbilityBehavior newAbility)
        {
            this.newCharacter = newCharacter;
            this.newAbility = newAbility;
        }

        internal void ability()
        {
            newAbility.Ability();
            
        }

        internal void character ()
        {
            newCharacter.Character();
        }

    }
}
