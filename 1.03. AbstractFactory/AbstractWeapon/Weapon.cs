namespace _02._AbstractFactory.AbstractWeapon;

public abstract class Weapon
{
    public int Damage { get; protected set; }
    public bool CanBreakArmor { get; protected set; }

    protected Weapon(int damage, bool canBreakArmor)
    {
        Damage = damage;
        CanBreakArmor = canBreakArmor;
    }

    public abstract void Attack();
}
