﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizeSystemWindowsForms.Models
{
    public class UserChoice
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public QuestionModel Question { get; set; } 
        public UserChoice(string text)
        {
            this.Text = text;
        }
    }
}