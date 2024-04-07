using _04._TemplateMethod.AbstractClass;

namespace _04._TemplateMethod.ConcreteClasses;

public class College : EducationalInstitution
{
	public override void Enter()
	{
		Console.WriteLine("Сдаю вступительные экзамены и поступаю в колледж");
	}

	public override void Study()
	{
		Console.WriteLine("Учусь в колледже");
	}

	public override void PassExams()
	{
		Console.WriteLine("Сдаю экзамены по специальности");
	}

	public override void GetGraduationDocument()
	{
		Console.WriteLine("Получаю диплом о среднем профессиональном образовании");
	}
}
