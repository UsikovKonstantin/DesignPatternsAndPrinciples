using _02._AbstractFactory.Movements;
using _02._AbstractFactory.Weapons;

namespace _02._AbstractFactory.HeroFactories;

public class ElfFactory : HeroFactory
{
	public override Movement CreateMovement()
	{
		return new FlyMovement();
	}

	public override Weapon CreateWeapon()
	{
		return new ArbaletWeapon();
	}
}
