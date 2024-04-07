using _10._Memento.Caretaker;
using _10._Memento.Originator;

// Хранитель (Memento)

/*
Паттерн Хранитель (Memento) позволяет выносить внутреннее состояние объекта за его пределы 
	для последующего возможного восстановления объекта без нарушения принципа инкапсуляции.

Когда использовать Memento?
	Когда нужно сохранить состояние объекта для возможного последующего восстановления.
	Когда сохранение состояния должно проходить без нарушения принципа инкапсуляции.
*/

Hero hero = new Hero();
Console.WriteLine(hero);
hero.Shoot();
hero.Shoot();
hero.Shoot();

GameHistory gameHistory = new GameHistory();
Console.WriteLine("Сохраняем игру");
int index = gameHistory.AddSave(hero.GetCurrentState());

hero.Shoot();
hero.Shoot();
hero.Shoot();

Console.WriteLine("Загружаем сейв");
hero.RestoreState(gameHistory.GetSave(index));

hero.Shoot();
hero.Shoot();
