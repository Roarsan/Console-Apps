using System;

namespace ConsoleAppProject.App04
{
    ///<summary>
    /// This class stores information about a post in a social network. 
    /// The main part of the post consists of a photo and a caption. 
    /// Other data, such as author and time, are also stored.
    ///</summary>
    /// <author>
    /// Michael Kölling and David J. Barnes
    /// @version 0.1
    /// Modified by : Roshan Gauchan 07/06/2022 
    /// </author>
    public class PhotoPost : Post
    {
        // the name of the image file
        public String Filename { get; set; }

        // a one line image caption
        public String Caption { get; set; }

        ///<summary>
        /// Constructor for objects of class PhotoPost.
        ///</summary>
        /// <param name="author">
        /// The username of the author of this post.
        /// </param>
        /// <param name="caption">
        /// A caption for the image.
        /// </param>
        /// <param name="filename">
        /// The filename of the image in this post.
        /// </param>
        public PhotoPost(String author, String filename, String caption) : base(author)
        {
            this.Filename = filename;
            this.Caption = caption;
        }
        /// <summary>
        /// Display the new photo posted 
        /// </summary>
        public override void Display()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("===================================================");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\t\t Photo Post Display");
            Console.WriteLine($"\t\tFilename: [{Filename}]");
            Console.WriteLine($"\t\tCaption: [{Caption}]");
            base.Display();
        }
    }
}