using _02._AbstractFactory.HeroFactories;
using _02._AbstractFactory.Movements;
using _02._AbstractFactory.Weapons;

namespace _02._AbstractFactory;

public class Hero
{
    public Movement Movement { get; private set; }
	public Weapon Weapon { get; private set; }

	public Hero(HeroFactory factory)
	{
		Movement = factory.CreateMovement();
		Weapon = factory.CreateWeapon();
	}

	public void Move()
	{
		Movement.Move();
	}

	public void Attack()
	{
		Weapon.Attack();
	}
}
