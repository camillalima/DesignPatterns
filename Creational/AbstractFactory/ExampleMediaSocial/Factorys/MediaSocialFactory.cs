using DesignPatterns.Creational.AbstractFactory.ExampleMediaSocial.Enums;
using DesignPatterns.Creational.AbstractFactory.ExampleMediaSocial.Products;

namespace DesignPatterns.Creational.AbstractFactory.ExampleMediaSocial.Factorys;

public class MediaSocialFactory : AbstractFactory
{
    public override MediaSocial CreateMediaSocial(MediaSocialType mediaSocialType)
    {
        switch (mediaSocialType)
        {
            case MediaSocialType.Facebook:
                return new MediaSocialFacebook();

            case MediaSocialType.Twitter:
                return new MediaSocialTwitter();

            default:
                throw new ApplicationException("Media social desconhecida!");
        }
    }
}