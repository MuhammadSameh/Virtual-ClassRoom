using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Domain.Entities
{
    public class SubmittedQuiz
    {
        public int Id { get; set; }
        public int QuizId { get; set; }
        public int StudentId { get; set; }
        public List<AnsweredQuestion> Answeres { get; set; }
        public DateTime SubmissionDate { get; set; }
    }
}
