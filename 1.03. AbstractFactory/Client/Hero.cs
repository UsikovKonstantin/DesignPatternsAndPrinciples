using _02._AbstractFactory.AbstractFactory;
using _02._AbstractFactory.AbstractMovement;
using _02._AbstractFactory.AbstractWeapon;

namespace _03._AbstractFactory.Client;

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
