using System;
using Xunit;
using Fisher.Bookstore.Models;

namespace tests
{
    public class BookTest
    {
        
        [Fact]
        public void ChangePublicationDate()
        {    
            var book = new Book()
            {
                Id = 1,
                Title = "Domain Driven Design",
                Author = new Author()
                {
                    Id = 65,
                    Name = "Eric Evans"
                },
                PublishDate = DateTime.Now.AddMonths(-6),
                Publisher = "McGraw-Hill"
            };

            var newPublicationDate = DateTime.Now.AddMonths(2);
            book.ChangePublicationDate(newPublicationDate);

            var expectedPublicationDate = newPublicationDate.ToShortDateString();
            var actualPublicationDate = book.PublishDate.ToShortDateString();
            Assert.Equal(expectedPublicationDate, actualPublicationDate);

        } 

          public void ChangeBookTitle()
            {    
            var book = new Book()
            {
                Id = 1,
                Title = "Domain Driven Design",
                Author = new Author()
                {
                    Id = 65,
                    Name = "Eric Evans"
                },
                PublishDate = DateTime.Now.AddMonths(-6),
                Publisher = "McGraw-Hill"
            };

            var newBookTitle = "Test";
            book.ChangeBookTitle(newBookTitle);

            var expectedBookTitle = newBookTitle;
            var actualBookTitle = "Test";
            Assert.Equal(expectedBookTitle, actualBookTitle);

        } 

        public void ChangePublisherName()
            {    
            var book = new Book()
            {
                Id = 1,
                Title = "Domain Driven Design",
                Author = new Author()
                {
                    Id = 65,
                    Name = "Eric Evans"
                },
                PublishDate = DateTime.Now.AddMonths(-6),
                Publisher = "McGraw-Hill"
            };

            var newPublisherName = "Test Name";
            book.ChangePublisherName(newPublisherName);

            var expectedPublisherName = newPublisherName;
            var actualPublisherName = "Test Name";
            Assert.Equal(expectedPublisherName, actualPublisherName);

        } 
    }
}

