using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classroom.Domain.Entities
{
    public class ClassRoomStudent
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ClassRoomId { get; set; }
    }
}
