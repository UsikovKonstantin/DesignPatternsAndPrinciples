using _02._AbstractFactory.AbstractWeapon;

namespace _03._AbstractFactory.ConcreteWeapons;

public class SwordWeapon : Weapon
{
	public SwordWeapon() : base(50, true)
	{

	}

	public override void Attack()
    {
        Console.WriteLine($"Бью мечом, наношу {Damage} единиц урона, {(!CanBreakArmor ? "не " : "")}могу ломать броню");
    }
}
