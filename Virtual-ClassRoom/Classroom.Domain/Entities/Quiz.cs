using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Domain.Entities
{
    public class Quiz
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<Question> Questions { get; set; }
        public int TeacherId { get; set;}
        public User Teacher { get; set; }
        public List<AsssignedQuiz> AssignedQuizzes { get; set; }
    }
}
