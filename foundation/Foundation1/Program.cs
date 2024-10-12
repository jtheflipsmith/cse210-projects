using System;

class Program
{
    static void Main(string[] args)
    {
        
        Video video1 = new Video();
        video1._author = "Rhet and Link";
        video1._title = "Perfect Bathroom Trip";
        video1._seconds = 634;
        
        Comment vid1Com1 = new Comment();
        vid1Com1._name = "BoomSmithrines";
        vid1Com1._text = "This video is hilarious! I sing this song every time I use the bathroom";
        
        Comment vid1Com2 = new Comment();
        vid1Com2._name = "ChuckJoe318144265";
        vid1Com2._text = "I don't see what the big deal is anyway";

        Comment vid1Com3 = new Comment();
        vid1Com3._name = "SallyMclaster";
        vid1Com3._text = "I showed this to my family and we all had a laugh";

        video1._comment.Add(vid1Com1);
        video1._comment.Add(vid1Com2);
        video1._comment.Add(vid1Com3);

        video1.VideoDetails();

        Video video2 = new Video();
        video2._author = "Julian Smith";
        video2._title = "Hot Coolaid";
        video2._seconds = 240;

        Comment vid2Com1 = new Comment();
        vid2Com1._name = "CoolaidScheptic";
        vid2Com1._text = "Is coolaid even good?";

        Comment vid2Com2 = new Comment();
        vid2Com2._name = "Scheptic.Blocker";
        vid2Com2._text = "I think this is a fun way to reprisnet differing opinions";

        Comment vid2Com3 = new Comment();
        vid2Com3._name = "ScoreBoater";
        vid2Com3._text = "Rock on! I tried that actually!";

        video2._comment.Add(vid2Com1);
        video2._comment.Add(vid2Com2);
        video2._comment.Add(vid2Com3);

        video2.VideoDetails();
        
        Video video = new Video();
        video._author = "BoomSmitherines";
        video._title = "DNA Origens";
        video._seconds = 3600;

        Comment firstComment = new Comment();
        firstComment._name = "HeckToTheYeah";
        firstComment._text = "This is the single most hyped I have been about something in my entire life!!";

        Comment secondComment = new Comment();
        secondComment._name = "CoolaidScheptic";
        secondComment._text = "I don't know what the big deal is, its just a bunch of animals";

        Comment thirdComment = new Comment();
        thirdComment._name = "AnimalLover9000";
        thirdComment._text = "This is so cool! I gotta tell everyone! There is even a site?! Where do I sign up??? When is the next instalment coming out!?";

        Comment fourthComment = new Comment();
        fourthComment._name = "HolyCowfodder!";
        fourthComment._text = "I heard they were even making a game on this!!";

        video._comment.Add(firstComment);
        video._comment.Add(secondComment);
        video._comment.Add(thirdComment);
        video._comment.Add(fourthComment);

        video.VideoDetails();
        
    }
}