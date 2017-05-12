
using System;

namespace Post
{
    public class Post
    {
        private string _title { get; }
        private string _description { get; }
        private DateTime _creationTime { get; }
        private static int _votes { get; set; }

        public Post(string title, string description, DateTime creationTime)
        {
            this._title = title;
            this._description = description;
            this._creationTime = creationTime;
        }

        public void UpVote()
        {
            _votes += 1;
        }

        public void DownVote()
        {
            _votes -= 1;
        }

        public override string ToString()
        {
            var formattedDateTime = _creationTime.ToLongDateString();
            return ("Title: " + _title + "\nDescription: " + _description +
                    "\nDate: " + formattedDateTime + "\nVote Value: " + _votes);

        }
    }
}