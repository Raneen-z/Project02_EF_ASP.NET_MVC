﻿// <auto-generated />
using EF_MVC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF_MVC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("EF_MVC.Models.BookModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cover")
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "William Golding",
                            Cover = "http://books.google.com/books/content?id=r6eoCwAAQBAJ&printsec=frontcover&img=1&zoom=1&edge=curl&source=gbs_api",
                            Title = "Lord of the Flies"
                        },
                        new
                        {
                            Id = 2,
                            Author = "رضوى عاشور",
                            Cover = "http://books.google.com/books/content?id=ev1KDAAAQBAJ&printsec=frontcover&img=1&zoom=1&edge=curl&source=gbs_api",
                            Title = "ثلاثية غرناطة"
                        },
                        new
                        {
                            Id = 3,
                            Author = "خالد حسيني",
                            Cover = "http://books.google.com/books/content?id=cvPvsgEACAAJ&printsec=frontcover&img=1&zoom=1&source=gbs_api",
                            Title = "و رددت الجبال الصدى"
                        },
                        new
                        {
                            Id = 4,
                            Author = "كيم إكلين",
                            Cover = "http://books.google.com/books/content?id=Of6vDQAAQBAJ&printsec=frontcover&img=1&zoom=1&edge=curl&source=gbs_api",
                            Title = "في ظل الحياة المرئية"
                        },
                        new
                        {
                            Id = 5,
                            Author = "J. K. Rowling",
                            Cover = "http://books.google.com/books/content?id=HksgDQAAQBAJ&printsec=frontcover&img=1&zoom=1&source=gbs_api",
                            Title = "Harry Potter and the Philosopher's Stone"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Antoine de Saint-Exupéry",
                            Cover = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1367545443l/157993.jpg",
                            Title = "The Little Prince"
                        },
                        new
                        {
                            Id = 7,
                            Author = "Matt Haig",
                            Cover = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1602190253l/52578297.jpg",
                            Title = "The Midnight Library"
                        },
                        new
                        {
                            Id = 8,
                            Author = "Emily St. John Mandel",
                            Cover = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1564199892l/45754981.jpg",
                            Title = "The Glass Hotel"
                        },
                        new
                        {
                            Id = 9,
                            Author = "Abi Daré",
                            Cover = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1581128232l/50214741.jpg",
                            Title = "The Girl with the Louding Voice"
                        });
                });

            modelBuilder.Entity("EF_MVC.Models.ProfileModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Avatar")
                        .HasColumnType("text");

                    b.Property<string>("Bio")
                        .HasColumnType("varchar(248)")
                        .HasMaxLength(248);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Profiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Avatar = "https://semantic-ui.com/images/avatar2/large/molly.png",
                            Bio = "“Books are a uniquely portable magic.” – Stephen King",
                            Name = "Raneen Ayman",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            Avatar = "https://semantic-ui.com/images/avatar2/large/kristy.png",
                            Bio = "A good book is an event in my life.",
                            Name = "Haneen Saad",
                            UserId = 2
                        },
                        new
                        {
                            Id = 3,
                            Avatar = "https://semantic-ui.com/images/avatar2/large/elyse.png",
                            Bio = "Reading… a vacation for the mind… ",
                            Name = "Ahmad Salim",
                            UserId = 3
                        },
                        new
                        {
                            Id = 4,
                            Avatar = "https://semantic-ui.com/images/avatar/large/steve.jpg",
                            Bio = "Innovation distinguishes between a leader and a follower.",
                            Name = "Steve Hobes",
                            UserId = 4
                        },
                        new
                        {
                            Id = 5,
                            Avatar = "https://semantic-ui.com/images/avatar/large/jenny.jpg",
                            Bio = "Reading one book is like eating one potato chip",
                            Name = "Joe Nadal",
                            UserId = 5
                        });
                });

            modelBuilder.Entity("EF_MVC.Models.ReviewModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BookId = 6,
                            Content = "So amazing. I can see many rereads of this in the years to come.",
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            BookId = 5,
                            Content = "The BEST of J. K. Rowling",
                            UserId = 2
                        });
                });

            modelBuilder.Entity("EF_MVC.Models.UserModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "raneen.ayman@gmail.com",
                            Password = "1234567"
                        },
                        new
                        {
                            Id = 2,
                            Email = "haneen.Saad@gmail.com",
                            Password = "123456"
                        },
                        new
                        {
                            Id = 3,
                            Email = "Ahmad.Salim@gmail.com",
                            Password = "12345"
                        },
                        new
                        {
                            Id = 4,
                            Email = "Steve.Hobes@gmail.com",
                            Password = "123456"
                        },
                        new
                        {
                            Id = 5,
                            Email = "JoeNadal@gmail.com",
                            Password = "123456"
                        });
                });

            modelBuilder.Entity("EF_MVC.Models.ProfileModel", b =>
                {
                    b.HasOne("EF_MVC.Models.UserModel", "User")
                        .WithOne("Profile")
                        .HasForeignKey("EF_MVC.Models.ProfileModel", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EF_MVC.Models.ReviewModel", b =>
                {
                    b.HasOne("EF_MVC.Models.BookModel", "Book")
                        .WithMany("Reviews")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF_MVC.Models.UserModel", "User")
                        .WithMany("Reviews")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
