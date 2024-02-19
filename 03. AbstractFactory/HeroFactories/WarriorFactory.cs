using _02._AbstractFactory.Movements;
using _02._AbstractFactory.Weapons;

namespace _02._AbstractFactory.HeroFactories;

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
