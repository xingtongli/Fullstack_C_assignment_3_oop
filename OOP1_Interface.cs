using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop1
{
    public interface IPersonService
    {
        public void PersonService();
    }
    public interface ICourseService
    {
        public void CourseService();
    }
    public interface IStudentService : IPersonService
    {

        public void StudentService();

    }
    public interface IInstructorService : IPersonService
    {
       public void InstrctorService();
    }
    public interface IDepartmentService
    {
        public void PersonService ();
    }
    
}
