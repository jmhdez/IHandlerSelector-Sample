using System;

namespace HSSample
{
    public class Report
    {
        private readonly string title;
        private readonly string content;

        public Report(string title, string content)
        {
            this.title = title;
            this.content = content;
        }

        public string Title
        {
            get { return title; }
        }

        public string Content
        {
            get { return content; }
        }

        public override string ToString()
        {
            return string.Format("{0}{1}----------{1}{2}", Title, Environment.NewLine, Content);
        }
    }
}