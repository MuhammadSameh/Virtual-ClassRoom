using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Domain.Entities
{
    public class User: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Quiz> TeacherQuizzes { get; set; }
        public List<ClassRoom> Classrooms { get; set; }
        public List<AsssignedQuiz> StudentAssignedQuizzes { get; set; }
        
    }
}
