

using OOP3;

HousingCreditManager housingCreditManager = new HousingCreditManager(new DatabaseLoggerManager());
housingCreditManager.Calculate();

FarmCreditManager farmCreditManager = new FarmCreditManager(new FileLoggerManager());
farmCreditManager.Calculate();

StudentCreditManager studentCreditManager = new StudentCreditManager(new DatabaseLoggerManager());
studentCreditManager.Calculate();