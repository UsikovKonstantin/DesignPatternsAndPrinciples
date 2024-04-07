using _4._01._SingleResponsibility.Good.PhoneLogger;
using _4._01._SingleResponsibility.Good.PhoneReader;
using _4._01._SingleResponsibility.Good.PhoneValidator;
using PhoneStoreBad = _4._01._SingleResponsibility.Bad.PhoneStore;
using PhoneStoreGood = _4._01._SingleResponsibility.Good.PhoneStore;

// S - Single-responsibility principle (принцип единственной ответственности)
/*
	Каждый компонент должен иметь одну и только одну причину для изменения.
*/

// Bad
PhoneStoreBad phoneStoreBad = new PhoneStoreBad();
phoneStoreBad.Process();
Console.WriteLine();

// Good
IPhoneReader reader = new ConsolePhoneReader();
IPhoneValidator validator = new StandartPhoneValidator();
IPhoneLogger logger = new FilePhoneLogger("store2.txt");
PhoneStoreGood phoneStoreGood = new PhoneStoreGood(reader, validator, logger);
phoneStoreGood.Process();
Console.WriteLine();
