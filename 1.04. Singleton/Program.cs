using _04._Singleton;

// Одиночка (Singleton)

/*
Одиночка (Singleton) - порождающий паттерн, который гарантирует, 
	что для определенного класса будет создан только один объект, 
	а также предоставит к этому объекту точку доступа.

Когда надо использовать Синглтон? 
	Когда необходимо, чтобы для класса существовал только один экземпляр.
*/

Logger logger = Logger.GetInstance();
logger.Log("Hello world");

DateStorage dateStorage = DateStorage.GetInstance(DateTime.UtcNow);
Console.WriteLine(dateStorage.Date);
