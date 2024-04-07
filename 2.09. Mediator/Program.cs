using _09._Mediator.AbstractColleague;
using _09._Mediator.ConcreteColleagues;
using _09._Mediator.ConcreteMediator;

// Посредник (Mediator)

/*
Паттерн Посредник (Mediator) представляет такой шаблон проектирования, который обеспечивает 
	взаимодействие множества объектов без необходимости ссылаться друг на друга. 
	Тем самым достигается слабосвязанность взаимодействующих объектов.

Когда используется паттерн Посредник?
	Когда имеется множество взаимосвязаных объектов, связи между которыми сложны и запутаны.
	Когда необходимо повторно использовать объект, однако повторное использование затруднено 
		в силу сильных связей с другими объектами.
*/

ManagerMediator mediator = new ManagerMediator();
Colleague customer = new CustomerColleague(mediator);
Colleague programmer = new ProgrammerColleague(mediator);
Colleague tester = new TesterColleague(mediator);
mediator.Customer = customer;
mediator.Programmer = programmer;
mediator.Tester = tester;

customer.Send("Есть заказ, надо сделать программу");
programmer.Send("Программа готова, надо протестировать");
tester.Send("Программа протестирована и готова к продаже");
