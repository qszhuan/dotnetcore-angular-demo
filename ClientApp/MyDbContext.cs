using Microsoft.EntityFrameworkCore;
using System;

namespace coreangular
{
    
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // make sure the connection string makes sense for your machine
        }
    }

    public class Book {
        public string Name{get;set;}
        public string ISBN {get;set;}
        public Author Author{get;set;}
        public Publisher Publisher{get;set;}
        public Category Category{get;set;}
    }

    public class Author {
        public int Id{get;set;}
        public string FirstName{get;set;}
        public string LastName{get;set;}
    }

    public class Publisher{
        public int Id{get;set;}
        public string Name{get;set;}
        public Address Address{get;set;}
    }

    public class Address{
        public string PostalCode{get;set;}
        public string Street{get;set;}
        public string Region{get;set;}
        public string City{get;set;}
        public string Country{get;set;}
    }
    public enum Category{
        Fiction,
        Science,
        History,
    }
}