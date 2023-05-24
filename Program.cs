void consoleWrite(string strline, bool eol = true) {
    Console.Write(strline);
    if (eol) Console.WriteLine();
}

int consoleReadInt() {
    return Convert.ToInt32(Console.ReadLine());
}

void task10(){
    // Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
    consoleWrite("Задача №10");
    consoleWrite("Введите трехзначное число - ", false);
    int number = consoleReadInt();
    if (number < 0) number = Math.Abs(number);

    while((number < 100)||(number > 999)) {
        consoleWrite("Введенное число не трехзначное. Введите трехзначное число - ", false);
        number = Convert.ToInt32(Console.ReadLine());
    }

    consoleWrite($"Вторая цифра введенного числа - { Convert.ToString(number % 100 / 10) }");
}

void task13(){
    // Напишите программу, которая с помощью деления выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
    
}

void task15(){
    // Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
    
}

consoleWrite("Домашнее задание №2");
consoleWrite("Введите номер задачи: ", false);
int tasknum = consoleReadInt();

switch(tasknum){
    case 1: 
        task10(); 
        break;
    case 2: 
        task13(); 
        break;
    case 3: 
        task15(); 
        break;
    default:
        consoleWrite("Такой задачи не существует");
        break;
}