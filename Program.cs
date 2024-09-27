using DesignPatterns.Creational.AbstractFactory.ExampleMediaSocial.Enums;
using DesignPatterns.Creational.AbstractFactory.ExampleMediaSocial.Factorys;

var factory = new MediaSocialFactory();

var twitter = factory.CreateMediaSocial(MediaSocialType.Twitter);

twitter.Post("Minha primeira postagem", "Conteúdo da minha postagem");
twitter.Like();

var facebook = factory.CreateMediaSocial(MediaSocialType.Facebook);

facebook.Post("Minha primeira postagem", "Conteúdo da minha postagem");
facebook.Like();