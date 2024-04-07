using _04._Composite.AbstractComponent;
using Directory = _04._Composite.ConcreteComponent.Directory;
using File = _04._Composite.Leaf.File;

// Компоновщик (Composite)

/*
Паттерн Компоновщик (Composite) объединяет группы объектов в древовидную 
	структуру по принципу "часть-целое" и позволяет клиенту одинаково 
	работать как с отдельными объектами, так и с группой объектов.

Когда использовать компоновщик?
	Когда объекты должны быть реализованы в виде иерархической древовидной структуры.
	Когда клиенты единообразно должны управлять как целыми объектами, так и их составными 
		частями. То есть целое и его части должны реализовать один и тот же интерфейс.
*/

Component fileSystem = new Directory("Файловая система");
Component diskC = new Directory("Диск С");
Component pngFile = new File("12345.png");
Component docxFile = new File("Document.docx");
diskC.Add(pngFile);
diskC.Add(docxFile);
fileSystem.Add(diskC);
Console.WriteLine(fileSystem.GetString());
Console.WriteLine();

diskC.Remove(pngFile);
Component docsFolder = new Directory("Мои Документы");
Component txtFile = new File("readme.txt");
Component csFile = new File("Program.cs");
docsFolder.Add(txtFile);
docsFolder.Add(csFile);
diskC.Add(docsFolder);
Console.WriteLine(fileSystem.GetString());
