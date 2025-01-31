﻿using _01._SimpleFactory.AbstractCoffee;
using _01._FactoryMethod.Factory;
using _01._FactoryMethod.CoffeeEnum;

// Фабричный метод (Factory Method)

/*
Фабричный метод (Factory Method) - это шаблон проектирования, который помогает решить проблему 
	создания различных объектов в зависимости от некоторых условий.
 
Когда надо применять паттерн:
	Когда заранее неизвестно, объекты каких типов необходимо создавать
	Когда система должна быть независимой от процесса создания новых объектов и расширяемой: 
		в нее можно легко вводить новые классы, объекты которых система должна создавать.
	Когда создание новых объектов необходимо делегировать из базового класса классам наследникам
*/

CoffeeFactory coffeeFactory = new CoffeeFactory();
Coffee coffee = coffeeFactory.CreateCoffee(CoffeeType.Americano);

Console.WriteLine(coffee.Name);
coffee.GrindCoffee();
coffee.MakeCoffee();
coffee.PourIntoCup();
Console.WriteLine("Вот ваш кофе! Спасибо, приходите еще!");

/*
Если в будущем нам потребуется создавать кофе другого типа, то нам надо:
	1) добавить значение в перечисление CoffeeType
	2) Создать класс, унаследованный от Coffee
	3) Добавить обработчик в фабрику
 */
