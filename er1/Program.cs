int months = 12, bounus = 5000;
double ratePerHour = 12.34;
int numberOfHoursWorked = 10;

double currentMonthWage = ratePerHour * numberOfHoursWorked + bounus;

Console.WriteLine(currentMonthWage);

ratePerHour += 2;
Console.WriteLine(ratePerHour);
