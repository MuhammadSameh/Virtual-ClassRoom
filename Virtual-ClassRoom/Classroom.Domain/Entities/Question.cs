﻿using Classroom.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Domain.Entities
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }
        public List<string> ModelAnswers { get; set; }
        public QuestionType QuestionType { get; set; }
        public int TotalMark { get; set;}

    }
}
