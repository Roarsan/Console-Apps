using System;
using System.Collections.Generic;

namespace ConsoleAppProject.App04
{   /// <summary>
    /// The post class is the the super/base class or parent
    /// has as sub child Massagepost and PhotoPost
    /// </summary>
    /// <author>
    /// Roshan Gauchan
    /// Date : 07/06/2022
    /// </author>
    public class Post
    {
        // username of the post's author

        public int PostId { get; }
        public String Username { get; set; }

        public DateTime Timestamp { get; }

        public static int instances = 0;

        private int likes;
        // private int unlikes;

        private readonly List<String> comments;

        /// <summary>
        /// The constructor of the class post
        /// </summary>
        public Post(String author)
        {
            instances++;
            PostId = instances;

            this.Username = author;
            Timestamp = DateTime.Now;

            likes = 0;
            comments = new List<String>();
        }

        ///<summary>
        /// Record one more 'Like' indication from a user.
        ///</summary>
        public void Like()
        {
            likes++;
        }

        ///<summary>
        /// Record that a user has withdrawn his/her 'Like' vote.
        ///</summary>
        public void Unlike()
        {
            if (likes > 0)
            {
                likes--;
            }
        }

        ///<summary>
        /// Add a comment to this post.
        /// The new comment to add.
        /// </summary>
        public void AddComment(String text)
        {
            comments.Add(text);
        }

        ///<summary>
        /// Display the details of this post.
        /// (Currently: Print to the text terminal. This is simulating display 
        /// in a web browser for now.)
        ///</summary>
        public virtual void Display()
        {
            Console.WriteLine();
            Console.WriteLine($"\tPost ID:\t {PostId}");
            Console.WriteLine($"\tAuthor:\t\t {Username}");
            Console.WriteLine($"\tTime Elpased:\t {FormatElapsedTime(Timestamp)}");
            Console.WriteLine($"\tDate Posted:\t {Timestamp.ToLongDateString()}");
            Console.WriteLine($"\tTime Posted:\t {Timestamp.ToLongTimeString()}");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("===================================================");
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine();

            if (likes > 0)
            {
                Console.WriteLine($"    Likes: -  {likes}  people like this.");
            }
            else
            {
                Console.WriteLine();
            }
            //if (unlikes > 0)
            //{
            //    Console.WriteLine($"    Unlikes: -  {unlikes}  people like this.");
            //}
            //else
            //{
            //    Console.WriteLine();
            //}

            if (comments.Count == 0)
            {
                Console.WriteLine("    No comments.");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("===================================================");
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.WriteLine($"    Comment(s): {comments.Count}  Click here to view.");
                foreach (string comments in comments)
                {
                    Console.WriteLine($"\tComment: {comments}\n");
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("===================================================");
                    Console.ForegroundColor = ConsoleColor.Black;

                }


            }
        }

        /// <summary>
        /// count the number of the posts
        /// </summary>
        public static int GetNumberOfPosts()
        {
            return instances;
        }

        /// <summary>
        /// Create a string describing a time point in the past in terms 
        /// relative to current time, such as "30 seconds ago" or "7 minutes ago".
        /// Currently, only seconds and minutes are used for the string.
        /// </summary>
        /// <param name="time">
        /// The time value to convert (in system milliseconds)
        /// </param> 
        /// <returns>
        /// A relative time string for the given time
        /// </returns>  
        private String FormatElapsedTime(DateTime time)
        {
            DateTime current = DateTime.Now;
            TimeSpan timePast = current - time;

            long seconds = (long)timePast.TotalSeconds;
            long minutes = seconds / 60;

            if (minutes > 0)
            {
                return minutes + " minutes ago";
            }
            else
            {
                return seconds + " seconds ago";
            }
        }

    }


}
