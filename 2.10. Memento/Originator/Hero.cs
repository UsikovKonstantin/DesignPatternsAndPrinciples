using _10._Memento.Memento;

namespace _10._Memento.Originator;

public class Hero
{
    public int Health { get; private set; } = 100;
    public int Armor { get; private set; } = 0;
    public int Ammo { get; private set; } = 50;

    public Hero()
    {
        
    }

    public void Shoot()
    {
        if (Ammo > 0)
        {
            Ammo--;
            Console.WriteLine($"Выстрелил. Осталось патронов: {Ammo}");
        }
        else
        {
            Console.WriteLine("Патронов нет.");
        }
    }

    public HeroMemento GetCurrentState()
    {
        return new HeroMemento(Health, Armor, Ammo);
    }

    public void RestoreState(HeroMemento memento)
    {
        Health = memento.Health;
		Armor = memento.Armor;
		Ammo = memento.Ammo;
	}

	public override string ToString()
	{
		return $"Health: {Health}, Armor: {Armor}, Ammo: {Ammo}";
	}
}
