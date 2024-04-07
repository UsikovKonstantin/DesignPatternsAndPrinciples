using _09._Mediator.AbstractColleague;
using _09._Mediator.AbstractMediator;

namespace _09._Mediator.ConcreteMediator;

public class ManagerMediator : Mediator
{
    public Colleague? Customer { get; set; }
	public Colleague? Programmer { get; set; }
	public Colleague? Tester { get; set; }

    public ManagerMediator()
    {

	}

    public override void Send(string message, Colleague sender)
	{
        Console.WriteLine($"Менеджер получил сообщение: \"{message}\" от {sender.GetType().Name}");

        // Если отправитель - заказчик, значит есть новый заказ
        // отправляем сообщение программисту - выполнить заказ
        if (sender == Customer)
			Programmer?.Notify(message);

		// Если отправитель - программист, то можно приступать к тестированию
		// отправляем сообщение тестировщику
		else if (sender == Programmer)
			Tester?.Notify(message);

		// Если отправитель - тестировщик, значит продукт готов
		// отправляем сообщение заказчику
		else if (sender == Tester)
			Customer?.Notify(message);
	}
}
