using System;

namespace BookMainPage
{
	class Book
	{
		public string author;
		public string title;
		public int pages;
		
		public Book(string aTitle, string aAuthor, int aPages)
		{
			title = aTitle;
			author = aAuthor;
            pages = aPages;
            // Console.WriteLine(name);
        }
	}
}