namespace _10._Memento.Memento;

public class HeroMemento
{
	public int Health { get; private set; }
	public int Armor { get; private set; }
	public int Ammo { get; private set; }

    public HeroMemento(int health, int armor, int ammo)
    {
		Health = health;
		Armor = armor;
		Ammo = ammo;
	}
}
