using _02._AbstractFactory.Movements;
using _02._AbstractFactory.Weapons;

namespace _02._AbstractFactory.HeroFactories;

public abstract class HeroFactory
{
	public abstract Movement CreateMovement();
	public abstract Weapon CreateWeapon();
}
