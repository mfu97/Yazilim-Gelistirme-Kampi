namespace OOP3;

public class KonutKrediManager:IKrediManager
{
    public void Hesapla()
    {
        Console.WriteLine("Konut kredisi ödeme planı hesaplandı");
    }

    public void BirseyYap()
    {
        throw new NotImplementedException();
    }
}