using _04._TemplateMethod.AbstractClass;

namespace _04._TemplateMethod.ConcreteClasses;

public class School : EducationalInstitution
{
	public override void Enter()
	{
        Console.WriteLine("Иду в первый класс");
    }

	public override void Study()
	{
        Console.WriteLine("Посещаю уроки, делаю домашние задания");
    }

	public override void PassExams()
	{
        Console.WriteLine("Сдаю ОГЭ/ЕГЭ");
    }

	public override void GetGraduationDocument()
	{
        Console.WriteLine("Получаю аттестат о среднем образовании");
    }
}
