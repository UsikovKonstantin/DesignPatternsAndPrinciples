using _11._Visitor.ConcreteVisitors;
using _11._Visitor;
using _11._Visitor.ConcreteProducts;

// Посетитель (Visitor)

/*
Паттерн Посетитель (Visitor) позволяет определить операцию для объектов других классов без изменения этих классов.
	При использовании паттерна Посетитель определяются две иерархии классов: одна для элементов, 
	для которых надо определить новую операцию, и вторая иерархия для посетителей, описывающих данную операцию.

Когда использовать данный паттерн?
	Когда имеется много объектов разнородных классов с разными интерфейсами, и требуется выполнить 
		ряд операций над каждым из этих объектов.
	Когда классам необходимо добавить одинаковый набор операций без изменения этих классов.
	Когда часто добавляются новые операции к классам, при этом общая структура классов стабильна и 
		практически не изменяется.
*/

Store store = new Store();
store.AddProduct(new Bread("Хлеб", 30, DateTime.Now));
store.AddProduct(new Pen("Ручка", 10, 1.5));
store.AddProduct(new SoccerBall("Мяч", 575, 5));
store.AddProduct(new SoccerBall("Мяч2", 999, 6));

PriceVisitor priceVisitor = new PriceVisitor();
store.AcceptVisitor(priceVisitor);
Console.WriteLine($"TotalPrice: {priceVisitor.TotalPrice}");
Console.WriteLine();

InventoryVisitor inventoryVisitor = new InventoryVisitor();
store.AcceptVisitor(inventoryVisitor);
foreach (var kv in inventoryVisitor.Inventory)
    Console.WriteLine($"{kv.Key}: {kv.Value}");
Console.WriteLine();
