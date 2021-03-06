﻿using System;

namespace Shoko.Models.Metro
{
    public class Metro_Comment
    {
        public string Source { get; set; } // trakt, anidb
        public int CommentType { get; set; } // trakt - Comment, anidb (for fans, must see, Recommended)
        public string CommentText { get; set; }
        public bool IsSpoiler { get; set; }
        public DateTime? CommentDate { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string ImageURL { get; set; }
    }
}