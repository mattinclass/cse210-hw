using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoList = new List<Video>();
        
        Video myFirstVideo = new Video();
        Video mySecondVideo = new Video();
        Video myThirdVideo = new Video();
        Video myFourthVideo = new Video();

        myFirstVideo.SetTitle("This is my First Video!");
        myFirstVideo.SetAuthor("Tony");
        myFirstVideo.SetLength(30);
        myFirstVideo.CreateComment("Lebron James", "Dude this video is good!");
        myFirstVideo.CreateComment("Lizzy McGuire", "Way to Go!");
        myFirstVideo.CreateComment("John the Beloved", "Repent ye of thy words at 10 seconds in!");

        mySecondVideo.SetTitle("This is my Second Video!");
        mySecondVideo.SetAuthor("Ricky");
        mySecondVideo.SetLength(44);
        mySecondVideo.CreateComment("Tony Parker", "You double dribbled my man");
        mySecondVideo.CreateComment("Mickey Mouse", "Great second video!");
        mySecondVideo.CreateComment("Bill Jenkins", "nice ");


        myThirdVideo.SetTitle("I Almost Died in my Third Video!");
        myThirdVideo.SetAuthor("Bart");
        myThirdVideo.SetLength(430);
        myThirdVideo.CreateComment("brody", "skippadee doop boobadee doop");
        myThirdVideo.CreateComment("The melting man", "Guys he didn't actually almost die, check the top left corner at 45 seconds. There's a string!");
        myThirdVideo.CreateComment("Joey Dean", "@themeltingman No way you're right. What a fraud!");
        

        myFourthVideo.SetTitle("sorry. i did not almost die.");
        myFourthVideo.SetAuthor("Johnny");
        myFourthVideo.SetLength(10042);
        myFourthVideo.CreateComment("Brick Jones", "Dude smh you've lied too many times");
        myFourthVideo.CreateComment("Brick Jones", "seriously");
        myFourthVideo.CreateComment("Gabby", "hi you didnt respnod to my last comment");
        myFourthVideo.CreateComment("Gabby", "pls repsond");

        videoList.Add(myFirstVideo);
        videoList.Add(mySecondVideo);
        videoList.Add(myThirdVideo);
        videoList.Add(myFourthVideo);

        foreach (Video vid in videoList)
        {
            vid.ShowInfo();
            foreach (Comment com in vid.commentList)
            {
                Console.WriteLine($"{com.GetName()}\n   {com.GetText()}");
            }
        }
    }
}