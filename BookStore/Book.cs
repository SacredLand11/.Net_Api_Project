﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookStore
{
    public class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Sonradan girilen book id'lerini bir bir arttırır.
        public int Id { get; set; }

        public string Title { get; set; }

        public int GenreId { get; set; }

        public int PageCount { get; set; }

        public DateTime PublishDate { get; set; }
    }
}