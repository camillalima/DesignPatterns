namespace DesignPatterns.Creational.AbstractFactory.Products;

public abstract class MediaSocial
{
    public abstract void Post(string title, string body);

    public abstract void Like();
}