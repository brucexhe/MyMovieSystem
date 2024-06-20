using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMovieSystem.Entity.ViewModel
{

    public class PostViewModel
    { 
        public int ID { get; set; }
        private string _Title;
        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                _Title = value;
            }
        }
        public string Content { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
