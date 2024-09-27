using DesignPatterns.Creational.AbstractFactory.ExampleMediaSocial.Enums;
using DesignPatterns.Creational.AbstractFactory.ExampleMediaSocial.Products;

namespace DesignPatterns.Creational.AbstractFactory.ExampleMediaSocial.Factorys;

public abstract class AbstractFactory
{
    public abstract MediaSocial CreateMediaSocial(MediaSocialType mediaSocialType);
}