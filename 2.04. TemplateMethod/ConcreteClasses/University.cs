using _04._TemplateMethod.AbstractClass;

namespace _04._TemplateMethod.ConcreteClasses;

public class University : EducationalInstitution
{
	public override void Enter()
	{
		Console.WriteLine("Поступаю в университет");
	}

	public override void Study()
	{
		Console.WriteLine("Посещаю лекции");
		Console.WriteLine("Прохожу практики");
	}

	public override void PassExams()
	{
		Console.WriteLine("Сдаю экзамены по специальности");
	}

	public override void GetGraduationDocument()
	{
		Console.WriteLine("Получаю диплом о высшем образовании");
	}
}
