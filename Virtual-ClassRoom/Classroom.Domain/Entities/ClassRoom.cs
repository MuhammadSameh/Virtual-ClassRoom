using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Domain.Entities
{
    public class ClassRoom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }

        public User Teacher{ get; set; }
        public List<AsssignedQuiz> AssignedQuizzes { get; set; }

    }
}
