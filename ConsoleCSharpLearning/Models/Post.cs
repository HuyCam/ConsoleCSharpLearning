using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCSharpLearning.Models
{
    class Post
    {
        private int userId;
        private int id;
        private string title;
        private string completed;

        public Post(int userId, string title, string completed)
        {
            this.userId = userId;
            this.title = title;
            this.completed = completed;
        }

        public int UserId { get => userId; set => userId = value; }
        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Completed { get => completed; set => completed = value; }
    }
}
