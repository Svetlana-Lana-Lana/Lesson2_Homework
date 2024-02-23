int n = 568;
int num = n;
int number = n;
int count = 0;
int tens = 1;
int result = 0;




while (num > 0)
{
    num = num / 10;
    count++;
    if (num > 0)
    {
        tens = tens * 10;
    }
}
while (count > 0)
{
    result = number / tens;
    number = number % tens;
    tens = tens / 10;
    count = count - 1;
    Console.Write(result + ", ");
}





