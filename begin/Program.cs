using System.ComponentModel.Design;

void CheckPass(string pass)
{
    string v_pass = "qwerty111";
    if (pass == v_pass) {  
        Console.WriteLine("Верный пароль!\nУстановка RTX4090 начинается...");
        for (int i = 10; i <= 100; i+=10)
        {
            Thread.Sleep(1250);
            Console.WriteLine($"{i}%");    
        }
        Thread.Sleep(750);
        Console.WriteLine("RTX4090 успешно установлена!");
    }
    else {  
        Console.WriteLine("Неверный пароль!");
    }
}
string u_pass;
Console.WriteLine("Введите пароль:");
u_pass = Console.ReadLine();
CheckPass(u_pass);