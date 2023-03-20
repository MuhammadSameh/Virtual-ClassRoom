using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Domain.Entities
{
    public class AnsweredQuestion
    {
        public int Id { get; set; }
        public int QuestionId { get; set; }
        public int StudentId { get; set; }
        public List<string> Answers { get; set; }

    }
}
