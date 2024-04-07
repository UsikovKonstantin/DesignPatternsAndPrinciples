using _02._AbstractFactory.AbstractWeapon;

namespace _03._AbstractFactory.ConcreteWeapons;

public class ArbaletWeapon : Weapon
{
	public ArbaletWeapon() : base(15, false)
	{

	}

	public override void Attack()
    {
        Console.WriteLine($"Стреляю из арбалета, наношу {Damage} единиц урона, {(!CanBreakArmor ? "не" : "")} могу ломать броню");
    }
}
