using _4._04._InterfaceSegregation.Bad;

// I - Interface segregation principle (принцип разделения интерфейсов)
/*
	Объекты не должны зависеть от интерфейсов, которые они не используют.
*/

// Bad
IAnimal animal = new Cat();
animal.Fly();
