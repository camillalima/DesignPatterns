namespace DesignPatterns.Creational.AbstractFactory.ExampleMediaSocial.Products;

public class MediaSocialTwitter : MediaSocial
{
    public override void Like()
    {
        Console.WriteLine("Curtida no Twitter!");
    }

    public override void Post(string title, string body)
    {
        Console.WriteLine("Post criado no Twitter!");
        Console.WriteLine($"Título: {title}");
        Console.WriteLine($"Conteúdo: {body}");
    }
}