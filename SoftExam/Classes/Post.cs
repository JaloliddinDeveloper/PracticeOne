namespace SoftExam.Classes
{
    public class Post
    {
        private string Title { get; set; }
        private string Describtion { get; set; }
        private int LikeCount;
        private string[] Comments;
        private int commentCount;
        private bool IsPublish;

        public Post(string title, string describtion)
        {
            Title = title;
            Describtion = describtion;
            LikeCount = 0;
            Comments = new string[5];
            commentCount = 0;
            IsPublish = false;
        }

        public bool Publish()=>
            IsPublish = true;
        
        public void Like()=>
            LikeCount++;
        
        public void Comment(string comment)=>
            Comments[commentCount++] = comment;

        public void GetInfo()
        {
            if (IsPublish)
            {
                Console.WriteLine(
               $"""
                Title: {Title}
                Describtion: {Describtion}
                Likes: {LikeCount}
                """
               );
                Console.WriteLine("Comments ");
                foreach (var comment in Comments)
                {
                    Console.WriteLine(comment);
                }
            }

            else
            {
                Console.WriteLine("not publish");
            }
        }
    }
}
