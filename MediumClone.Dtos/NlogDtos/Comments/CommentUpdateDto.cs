﻿using MediumClone.Dtos.Interfaces;
using MediumClone.Entities.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediumClone.Dtos.NlogDtos
{
    public class CommentUpdateDto : IUpdateDto
    {
        public int Id { get; set; }

        public string Content { get; set; }

        public int UserId { get; set; }

        public int BlogId { get; set; }

        public DateTime? UpdatedTime { get; set; }

        public int AppUserId { get; set; }
    }
}
