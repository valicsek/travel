using System;
using System.Collections.Generic;
using Travel.Model;

namespace Travel.ViewModel
{
    public class HistoryViewModel : ViewModelBase
    {
        private List<Post> posts;
        public List<Post> Posts
        {
            get => posts;
            set => SetField(ref posts, value);
        }
        private Post selectedPost;
        public Post SelectedPost
        {
            get => selectedPost;
            set => SetField(ref selectedPost, value);
        }

        public HistoryViewModel()
        {
            this.posts = new List<Post>();
        }
    }
}
