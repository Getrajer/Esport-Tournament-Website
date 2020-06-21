using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace EzsatBlazor.Pages
{
    public class CommentBase : ComponentBase
    {
        //Declaring comment class
        public class Comment
        {
            public string Name { get; set; }
            public string Text { get; set; }
            public string Posted { get; set; }
            public string IconPath { get; set; }
        }

        //Declaring variables connected to post Page
        protected string name_input;
        protected string text_input;
        protected string iconPath_input;
        protected string RadioValue = "../icons/lolicon_1.png";
        protected List<Comment> comments = new List<Comment>();

        protected List<string> icons_paths = new List<string> { "../icons/lolicon_1.png", "../icons/lolicon_2.png" };

        //Creating coment method
        public async void CreateComment()
        {
            Comment comment = new Comment();
            comment.Name = name_input;
            comment.Text = text_input;
            comment.IconPath = RadioValue;
            comment.Posted = DateTime.Now.ToString("MM/dd/yyyy h:mm tt");

            comments.Add(comment);
            name_input = "";
            text_input = "";
            iconPath_input = "";
        }

        public void RadioSelection(ChangeEventArgs args)
        {
            RadioValue = args.Value.ToString();
        }



    }

}
