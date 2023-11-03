using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Business.DTOs.PostDTOs
{
    public class PostImageAddDto
    {
        public int Id { get; set; }

        public int PostId { get; set; }

        public string ImageUrl { get; set; }
    }
}
