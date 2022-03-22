using FirstAPI.Model;
using System.Collections.Generic;

namespace FirstAPI.Repository
{
    public interface IStudentRepository
    {
        List<Student> GetStudents();
        Student GetStudent(int id);
        int AddStudent(Student student);
        int UpdateStudent(int id, Student student);
        int DeleteStudent(int studentId);
    }
}
