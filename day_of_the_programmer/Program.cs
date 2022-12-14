
Console.WriteLine(dayOfProgrammer(2000));

string dayOfProgrammer(int year)
{
    var isLeapYear = ClarifyIfyearIsLeap(year);

    Console.WriteLine(isLeapYear);

    int Jan = isYear1918(year) ? 32 : 31;
    int Feb = (isLeapYear && !isYear1918(year)) ? 29 : (!isLeapYear && !isYear1918(year)) ? 28 :
     (isLeapYear && isYear1918(year)) ? 15 : (!isLeapYear && isYear1918(year)) ? 14 : 0;


    Console.WriteLine(Feb);
    Console.WriteLine(Jan);
    int March = 31;
    int April = 30;
    int May = 31;
    int June = 30;
    int July = 31;
    int Aug = 31;


    var totolDay = Jan + Feb + March + April + May + June + July + Aug;

    Console.WriteLine(totolDay);
    var remain = 256 - totolDay;


    return $"{remain}.09.{year}";

}

Calendar ClarifyTheCalendar(int year)
    => year < 1918 ? Calendar.Julian : Calendar.Gregorian;

bool isYear1918(int year)
{
    return year == 1918;
}

bool ClarifyIfyearIsLeap(int year)
{

    var calendarType = ClarifyTheCalendar(year);
    if (calendarType == Calendar.Julian)
    {
        return year % 4 == 0;
    }
    return (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
}


enum Calendar
{
    Julian,
    Gregorian
}