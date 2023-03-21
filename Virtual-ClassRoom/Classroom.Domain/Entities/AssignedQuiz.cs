using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Domain.Entities
{
    public class AsssignedQuiz
    {
        public int Id { get; set; }
        public int QuizId { get; set; }
        public Quiz Quiz { get; set; }
        public int StudentId { get; set; }
        public User Student { get; set; }
        public int ClassRoomId { get; set; }

        public ClassRoom Classroom { get; set; }
        public List<AnsweredQuestion> Answeres { get; set; }
        public DateTime SubmissionDate { get; set; }
        public DateTime DueDate { get; set; }
    }
}
