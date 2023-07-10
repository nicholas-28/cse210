using System;
using System.Collections.Generic;
public class Program
{
    static void Main(string[] args)
    {
        // Create Video Objects
        Video video1 = new Video("Ólafur Arnalds live from Hafursey, in Iceland for Cercle", "Cercle",  "1:27:22");
        Video video2 = new Video("Hans Zimmer - Interstellar (Space Sounds)", "dhe Perissann", "2:01:37");
        Video video3 = new Video("MANHATTAN EVENING, 5th Avenue Walking Tour 4K", "WALKS and the CITY", "3:37:01");

        // Add Comments to Videos
        video1.AddComment(new Comment("@JBCreatuve",  "very nice music,and stunning landscape views 👍👍👍👍👍👍👍"));
        video1.AddComment(new Comment("@daniros1422", "This performance was like a journey through all the feelings a human can have... masterpiece...."));
        video1.AddComment(new Comment("@frutosergio", "I have no words for what I've experienced during this performance. If magic was ever real, this is a proof of it."));
        video1.AddComment(new Comment("@PlannBmann", "This performance made me feel as if I was discovering a long lost secret that many had already stopped searching for. Truly beautiful music and landscape. Thank you Cercle and thank you Ólafur"));

        video2.AddComment(new Comment("@palricard7545", "I am in tears! Its touched the heart and soul so deep . Thank you :)"));
        video2.AddComment(new Comment("@cynthiahenderson450", "Absolutely lovely. Thank you!"));
        video2.AddComment(new Comment("@adrianzamora1426", "Wow , what a vibe!"));
        video2.AddComment(new Comment("@romanticguitar.no1", "The piano music on this channel is like a warm embrace, comforting and supportive."));

        video3.AddComment(new Comment("@HighPlainsWalker", "Great walk, enjoyed the views of Manhattan at night. Thanks for taking us along! 😍😍👍"));
        video3.AddComment(new Comment("@sanphearak9904", "Nice walk tour man I just love it"));
        video3.AddComment(new Comment("@simplyliving_withrenee", "Very calming."));

        // Create a list of videos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Display each video details and comments
        foreach (var video in videos)
        {
            Console.WriteLine($"Video title: {video.GetTitle()}, Author: {video.GetAuthor()}, Length: {video.GetLength()}, Comments: {video.GetNumberOfComments()}");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"Comment by {comment.GetCommenterName()}: {comment.GetText()}");
            }
        }
    }
}