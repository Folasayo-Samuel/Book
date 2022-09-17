// using System;
using BookMainPage;

namespace BookEntry
{
	class BookClass
	{
		static void Main(string[]args)
		{

			
			try
			{
			var book1 = new Book("Harry Potter", "JK Rowling", 500);
			var book2 = new Book("Lord Of The Rings", "Tolkein", 800);
			// var book3 = new Book("Lord Of The Rings", "Tolkein", 800);

			// book1.title = ;
			// book1.author = ;
			// book1.pages = 500;
			
			// book2.title = ;
			// book2.author = ;
			// book2.pages = 800;

			// string[,] books = { 
			// 	{
			// 		book1, book2 
			// 	}};
			Console.WriteLine(book1.title);
			Console.WriteLine(book2.title);

			// Console.Write( book2.author);
				
			}
			catch (Exception e)
			{

				Console.WriteLine(e.Message);
			}
			
			Console.ReadLine();
		}
	}
}