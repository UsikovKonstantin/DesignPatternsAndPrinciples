using _10._Memento.Memento;

namespace _10._Memento.Caretaker;

public class GameHistory
{
	private List<HeroMemento> _history = new List<HeroMemento>();

	public int AddSave(HeroMemento save)
	{
		_history.Add(save);
		return _history.Count - 1;
	}

	public HeroMemento GetSave(int index)
	{
		return _history[index];
	}
}
