using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.DTOs.PostDTOs
{
    public class PostCommentAddDto
    {

        public int Id { get; set; }

        public string Content { get; set; }

        public int PostId { get; set; }

        public int UserId { get; set; }
    }
}
