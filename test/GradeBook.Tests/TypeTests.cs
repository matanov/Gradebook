using System;
using Xunit;

namespace GradeBook.Tests
{

    
    public delegate string WriteLogDelegate(string logMessage);
    
    public class Typetests
    {
        int count =0;

        [Fact]
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log = ReturnMessage;
            //log = new WriteLogDelegate(ReturnMessage);
            log += ReturnMessage;
            log += IncrementCount;
            
            var result = log("Hello");
            //Assert.Equal(result,"Hello");
            Assert.Equal(3,count);
        }

        string IncrementCount (string message)
        {
            count++;
            return message.ToLower();
        }

        string ReturnMessage (string message)
        {
            count++;
            return message;
        }


        [Fact]
         public void StringsBehaveLikeValueTypes()
        {
            string name = "Scott";
            name = MakeUppercase(name);
            Assert.Equal("SCOTT",name);
        }

         private string MakeUppercase(string parameter)
        {
        return parameter.ToUpper();
        }

    [Fact]
        public void ValueTypesAlsoPassByValue()
        {
            var x = GetInt();
            SetInt(ref x);
            Assert.Equal(x,42);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
             return 3;
        }

        [Fact]
        public void CSharpCanPassByRef()
        {
            var book1 = GetBook("Book 1");      //Can also use keyword out but must assign a word.
            GetBookSetName(ref book1,"New Name");
            Assert.Equal(book1.Name,"New Name");
            
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book =new Book(name);
           // book.Name = name;
        }


        [Fact]
        public void CSharpIsPassedByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1,"New Name");
            Assert.Equal(book1.Name,"Book 1");
            
        }

        private void GetBookSetName(Book book, string name)
        {
            book =new Book(name);
            book.Name = name;
        }

        [Fact]
        public void CanSetNameFromReference()
        {
            var book1 = GetBook("Book 1");
            SetName(book1,"New Name");
            Assert.Equal(book1.Name,"New Name");
            
        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }

        [Fact]
        public void GetBookReturnsDifferentObject()
        {
           var book1 = GetBook("Book 1");
           var book2 = GetBook("Book 2");
             
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);
            Assert.NotSame(book1,book2);
            
        }

        [Fact]
        public void TwovariablesReferceSameObject()
        {
           var book1 = GetBook("Book 1");
           var book2 = book1;
                       //Arrange
             
            //Act
           
            //Assert
            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 1", book2.Name);
            Assert.Same(book1, book2);
            
        }

        Book GetBook(string name)
        {
            return new Book(name);
        }
    }
}
