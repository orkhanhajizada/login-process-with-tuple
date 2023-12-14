(string username, string password) user = ("admin", "123");

while (true)
{
    Console.Write("İstifadəçi adını daxil edin: ");
    var inputUsername = Console.ReadLine();

    Console.Write("Şifrənizi daxil edin: ");
    var inputPassword = Console.ReadLine();

    if (inputUsername == user.username && inputPassword == user.password)
    {
        Console.WriteLine("Giriş uğurla tamamlandı!");
        break;
    }

    Console.WriteLine("İstifadəçi adı və ya şifrə yanlışdır!. Yenidən cəhd edin!");
}

