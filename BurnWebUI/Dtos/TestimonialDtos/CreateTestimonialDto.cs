﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurnWebUI.Dtos.TestimonialDtos
{
	public class CreateTestimonialDto
    {
        public string Name { get; set; }
        public string Tittle { get; set; }
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }
    }
}
