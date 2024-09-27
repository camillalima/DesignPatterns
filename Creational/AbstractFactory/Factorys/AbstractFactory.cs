using DesignPatterns.Creational.AbstractFactory.Enums;
using DesignPatterns.Creational.AbstractFactory.Products;

namespace DesignPatterns.Creational.AbstractFactory.Factorys;

public abstract class AbstractFactory
{
    public abstract MediaSocial CreateMediaSocial(MediaSocialType mediaSocialType);
}