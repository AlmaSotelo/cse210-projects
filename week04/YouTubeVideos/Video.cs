using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;
//Has the responsibility to track the title, author, and length of the video.
//Also has the responsibility to store a list of comments.
class Video
{
   //+++++++ member variables ++++++++

   public string _title;
   public string _author;
   public int _length;
   public List<Comment> _comments = new List<Comment>();

   //create an instance of built-in List<T> where we'll store data of type Video
   public List<Video> _allVideos = new List<Video>();
   
   // ++++++++ methods ++++++++++    

   // returns the number of comments
   public int NumberOfComments()
   {      
      return _comments.Count();
   }
   
   public void AllVideosDisplay()
   {
        
      foreach (Video video in _allVideos)
      {
         Console.WriteLine($"Title: {video._title}  Author: {video._author}  Lenght: {video._length}");          
        
         Console.WriteLine($"                 {video.NumberOfComments()} Comments:");

         foreach (Comment comment in video._comments)
         {            
            comment.Display();
         }
         
         Console.WriteLine();
      }
   }
}
