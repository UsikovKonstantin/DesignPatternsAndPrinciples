using _02._AbstractFactory.AbstractMovement;
using _02._AbstractFactory.AbstractWeapon;

namespace _02._AbstractFactory.AbstractFactory;

public abstract class HeroFactory
{
    public abstract Movement CreateMovement();
    public abstract Weapon CreateWeapon();
}
