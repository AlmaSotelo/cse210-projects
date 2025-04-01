using System;
using System.Collections.Generic;
using System.ComponentModel;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.\n");

        //creates 3 videos:

        //Video1 - comments        
        //1.Instantiate an object of class Comment for each comment,
        Comment v1Comment1 = new Comment();
        Comment v1Comment2 = new Comment();
        Comment v1Comment3 = new Comment();

        // initialize a list class Comment to hold comments of class Comment for that video
        List<Comment> v1Comments = new List<Comment>();
                
        //2.Set the appropiate values for member variables for each comment and add them to the list of comments of that video
        v1Comment1._name = "@mahnoor8043";
        v1Comment1._text = "I just was seeking to learn c# but everyone was teaching I a boring way but you were energized to help us learn I appreciate your hard work."; 
        //add Comment objects to the Video List    
        v1Comments.Add(v1Comment1);

        v1Comment2._name = "@Rita_lifes";
        v1Comment2._text = "I'm Russian-speaker user, but our lessons is the most understand and the most don't boring  everything! Thanks❤";
        v1Comments.Add(v1Comment2);

        v1Comment3._name = "@itCODE";
        v1Comment3._text = "Thanks for the video, good presentation of the material.";
        v1Comments.Add(v1Comment3);
        
        //Video1 - info
        //1.Instantiate an object of class Video for video1,
        Video video1 = new Video();
        //2.Set the appropiate values for member variables for video1.        
        video1._title = "C# tutorial for beginners";
        video1._author = "Bro Code";
        video1._length = 360;
        video1._comments.AddRange(v1Comments);       
        
        v1Comments.Add(v1Comment1);


        //Video2 - comments        
        //1.Instantiate an object of class Comment for each comment,
        Comment v2Comment1 = new Comment();
        Comment v2Comment2 = new Comment();
        Comment v2Comment3 = new Comment();
        Comment v2Comment4 = new Comment();

        // initialize a list class Comment to hold comments of class Comment for that video
        List<Comment> v2Comments = new List<Comment>();

        //2.Set the appropiate values for member variables for each comment.
        v2Comment1._name = "@6tt.8";
        v2Comment1._text = "The most place I like to come to study.";
        v2Comments.Add(v2Comment1);
        v2Comment2._name = "@khangtran6683";        
        v2Comment2._text = "I like your video";
        v2Comments.Add(v2Comment2);
        v2Comment3._name = "@frankroxtar";
        v2Comment3._text = "Christmas music always brightens the mind and soul <3";
        v2Comments.Add(v2Comment3);
        v2Comment4._name = "@kanikagarg25";
        v2Comment4._text = "Just love it dude.....its like......";
        v2Comments.Add(v2Comment4);
        //Video2 - info
        //1.Instantiate an object of class Video for video2,
        Video video2 = new Video();
        //2.Set the appropiate values for member variables for video2.        
        video2._title = "2-HOUR STUDY WITH ME | Calm Piano🎹, Rain sounds🌧️ | Pomodoro 50/10 | Late night";
        video2._author = "Carrot TD";
        video2._length = 6720;
        video2._comments.AddRange(v2Comments);


        //Video3 - comments        
        //1.Instantiate an object of class Comment for each comment,
        Comment v3Comment1 = new Comment();
        Comment v3Comment2 = new Comment();
        Comment v3Comment3 = new Comment();

        // initialize a list class Comment to hold comments of class Comment for that video
        List<Comment> v3Comments = new List<Comment>();

        //2.Set the appropiate values for member variables for each comment.
        v3Comment1._name = "@ayodejioloja6852";
        v3Comment1._text = "This is great sir!";
        v3Comments.Add(v3Comment1);
        v3Comment2._name = "@asad6715";
        v3Comment2._text = "Very nice!";
        v3Comments.Add(v3Comment2);
        v3Comment3._name = "@dhruvkaith3160";
        v3Comment3._text = "Great yo see new series, actually has C# in next semester. Thanks bro!";
        v3Comments.Add(v3Comment3);
        
        //Video3 - info
        //1.Instantiate an object of class Video for video3,
        Video video3 = new Video();
        //2.Set the appropiate values for member variables for video3.        
        video3._title = "String To List Conversion in C#";
        video3._author = "Samakosh";
        video3._length = 385;
        video3._comments.AddRange(v3Comments);

        //Add each video to a list of videos
        Video allVideos = new Video(); 

        allVideos._allVideos.Add(video1);       
        allVideos._allVideos.Add(video2);
        allVideos._allVideos.Add(video3);  

        allVideos.AllVideosDisplay();              
        
    }
}