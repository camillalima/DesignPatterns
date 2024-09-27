namespace DesignPatterns.Creational.AbstractFactory.Product;

public class MediaSocialFacebook : MediaSocial
{
    public override void Like()
    {
        Console.WriteLine("Curtida no Facebook!");
    }

    public override void Post(string title, string body)
    {
        Console.WriteLine("Post criado no Facebook!");
        Console.WriteLine($"Título: {title}");
        Console.WriteLine($"Conteúdo: {body}");
    }
}