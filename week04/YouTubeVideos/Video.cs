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

   //add videos to the allVideos list
   //create an instance of built-in List<T> where we'll store data of type Video
   public List<Video> _allVideos = new List<Video>();

   // ++++++++ methods ++++++++++ 

   public void AddComment(Comment newComment)
   {
      _comments.Add(newComment);
   }

   public void AddCommentsToVideo(Video comments)
   {
      _allVideos.Add(comments);
   }
   //returns the list of comments
   public List<Comment> GetComments()
   {
      return _comments;
   }

   // returns the number of comments
   public int NumberOfComments()
   {
      
      return GetComments().Count();
   }

   public void AddNewVideo(Video video)
   {
      _allVideos.Add(video);
   }
   public void AllVideosDisplay()
   {
        
      foreach (Video video in _allVideos)
      {
         Console.WriteLine($"Title: {video._title}  Author: {video._author}  Lenght: {video._length}");
         
          
        
         Console.WriteLine($"{video.NumberOfComments()} Comments");

         foreach (Comment comment in _comments)
         {
            video.GetComments();
            comment.Display();
         }

      }
   }
}
