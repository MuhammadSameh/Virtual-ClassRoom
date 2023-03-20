using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Domain.Entities
{
    public class AssignedQuiz
    {
        public int Id { get; set; }
        public int QuizId { get; set; }
        public int ClassRoomId { get; set; }
        public DateTime DueDate { get; set; }

    }
}
