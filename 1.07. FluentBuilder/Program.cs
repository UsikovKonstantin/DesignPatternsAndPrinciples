using _07._FluentBuilder;

// Fluent Builder

/*
Паттерн Fluent Builder позволяет упростить процесс создания сложных объектов с помощью методов-цепочек, 
	которые наделяют объект каким-то определенным качеством. 
	Применение данного паттерна делает процесс конструирования объектов более прозрачным, а код более читабельным.

Исторически fluent builder прежде всего позволял решить проблему перегруженных конструкторов.
*/

User tom = new UserBuilder()
	.SetName("Tom")
	.SetCompany("Microsoft")
	.SetAge(23)
	.Build();
Console.WriteLine(tom);

User alice = User.CreateBuilder()
	.SetName("Alice")
	.SetIsMarried(true)
	.SetAge(25);
Console.WriteLine(alice);
