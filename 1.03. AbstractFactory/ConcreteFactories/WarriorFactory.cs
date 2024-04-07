using _02._AbstractFactory.AbstractFactory;
using _02._AbstractFactory.AbstractMovement;
using _02._AbstractFactory.AbstractWeapon;
using _03._AbstractFactory.ConcreteMovements;
using _03._AbstractFactory.ConcreteWeapons;

namespace _03._AbstractFactory.ConcreteFactories;

public class WarriorFactory : HeroFactory
{
    public override Movement CreateMovement()
    {
        return new RunMovement();
    }

    public override Weapon CreateWeapon()
    {
        return new SwordWeapon();
    }
}
