using _04._TemplateMethod.ConcreteClasses;

// Шаблонный метод (Template Method)

/*
Шаблонный метод (Template Method) определяет общий алгоритм поведения подклассов, 
	позволяя им переопределить отдельные шаги этого алгоритма без изменения его структуры.

Когда использовать шаблонный метод?
	Когда планируется, что в будущем подклассы должны будут переопределять 
		различные этапы алгоритма без изменения его структуры
	Когда в классах, реализующим схожий алгоритм, происходит дублирование кода. 
		Вынесение общего кода в шаблонный метод уменьшит его дублирование в подклассах.
*/

School school = new School();
College college = new College();
University university = new University();

school.Learn();
Console.WriteLine();

college.Learn();
Console.WriteLine();

university.Learn();
Console.WriteLine();
