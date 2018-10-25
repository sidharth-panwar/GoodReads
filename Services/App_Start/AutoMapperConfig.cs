using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Core.DomainModels;
using DataAccess.Entities;

namespace Services.App_Start
{
    internal static class AutoMapperConfig
    {
        public static void Run()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<Book, BookEntity>();
                config.CreateMap<BookEntity, Book>();

                config.CreateMap<Author, AuthorEntity>();
                config.CreateMap<AuthorEntity, Author>();

                config.CreateMap<BookEdition, BookEditionEntity>();
                config.CreateMap<BookEditionEntity, BookEdition>();

                config.CreateMap<Comment, CommentEntity>();
                config.CreateMap<CommentEntity, Comment>();

                config.CreateMap<Publisher, PublisherEntity>();
                config.CreateMap<PublisherEntity, Publisher>();

                config.CreateMap<Review, ReviewEntity>();
                config.CreateMap<ReviewEntity, Review>();

                config.CreateMap<Tag, TagEntity>();
                config.CreateMap<TagEntity, Tag>();

                config.CreateMap<User, UserEntity>();
                config.CreateMap<UserEntity, User>();
            });
        }
    }
}