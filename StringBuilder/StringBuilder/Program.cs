// See https://aka.ms/new-console-template for more information

using StringBuilderPosts.Entities;

Comment firstComment = new Comment("Have a nice trip");
Comment secondComment = new Comment("Wow that's awesome!");
Post firstPost = new Post(
    DateTime.Parse("25/08/2022 20:20:25"),
    "Traveling to New Zealand",
    "I'm going to visit this wonderful country!",
    12
    );
firstPost.AddComment(firstComment);
firstPost.AddComment(secondComment);

Comment thirdComment = new Comment("Good night");
Comment fourthComment = new Comment("May the Force be with you");
Post secondPost = new Post(
    DateTime.Parse("25/08/2022 20:40:45"),
    "Good night guys",
    "See you tomorrow",
    5
    );
firstPost.AddComment(thirdComment);
firstPost.AddComment(fourthComment);

Console.WriteLine(firstPost);
Console.WriteLine(secondPost);