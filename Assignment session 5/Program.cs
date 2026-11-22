namespace Assignment_session_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Book b=new Book();
            //Console.WriteLine(b.password);


            // Compile error: 'password' is private, so it cannot be accessed outside the Book class.
            #endregion

            #region Q2
            //Console.WriteLine(b.copiesInStock);


            // it will  be compiled because 'copiesInStock' is internal , so it can be accessed inside its project.

            #endregion

            #region Q3
            //b.Title = "c#";
            //Console.WriteLine(b.Title);

            #endregion

            #region Q4
            //b.Genre = Genre.Science;
            //Console.WriteLine(b.Genre);
            #endregion

            #region Q5
            //Console.WriteLine((int)Genre.Fiction);
            //Console.WriteLine((int)Genre.NonFiction);
            //Console.WriteLine((int)Genre.Science);
            #endregion

            #region Q6
            //int genreNumber = 1;
            //Console.WriteLine((Genre)genreNumber);
            #endregion

            #region Q7
            //Genre genre = Genre.Fiction;
            //Console.WriteLine(genre.ToString());
            #endregion

            #region Q8
            //string genreText = "Science";
            //Console.WriteLine(Enum.Parse(typeof(Genre), genreText));
            #endregion

            #region Q9
            //string genreText = "Mystery";
            //if(Enum.TryParse(genreText, out Genre parsedGenre))
            //    Console.WriteLine(parsedGenre);
            //else
            //    Console.WriteLine("Unknown genre");
            
            #endregion


        }
    }
}
