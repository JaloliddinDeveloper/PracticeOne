using SoftExam.Classes;

//double g = -6;

//double j=Mathe.Pow(4,-1);
//Console.WriteLine(j);

//Console.WriteLine(Mathe.PI);

var post = new Post("Exam", "Simple Exam");
post.Publish();
post.Like();
post.Like();
post.Like();
post.Like();

post.Comment("Very good");
post.Comment("Very good");
post.Comment("Very good");
post.Comment("Very good");
post.Comment("Very good");

post.GetInfo();
