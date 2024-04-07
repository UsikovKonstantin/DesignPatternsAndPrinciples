namespace _04._TemplateMethod.AbstractClass;

public abstract class EducationalInstitution
{
	public void Learn()
	{
		Enter();
		Study();
		PassExams();
		GetGraduationDocument();
	}
	public abstract void Enter();
	public abstract void Study();
	public abstract void PassExams();
	public abstract void GetGraduationDocument();
}
