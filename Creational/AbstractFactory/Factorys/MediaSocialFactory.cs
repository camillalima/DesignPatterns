using DesignPatterns.Creational.AbstractFactory.Enums;
using DesignPatterns.Creational.AbstractFactory.Products;

namespace DesignPatterns.Creational.AbstractFactory.Factorys;

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