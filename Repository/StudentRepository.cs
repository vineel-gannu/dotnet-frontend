using FirstAPI.Model;
using System.Collections.Generic;
using System.Linq;

namespace FirstAPI.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly DataContext db;

        public StudentRepository(DataContext db)
        {
            this.db = db;
        }
        public int AddStudent(Student student)
        {
            this.db.Students.Add(student);
            return db.SaveChanges();
        }

        public int DeleteStudent(int studentId)
        {
            var stu = db.Students.Where(item => item.StudentId == studentId).FirstOrDefault(); 
            db.Students.Remove(stu);
            return db.SaveChanges();
        }

        public List<Student> GetStudents()
        {
            return db.Students.ToList();
        }

        public Student GetStudent(int id)
        {
            return db.Students.Where(item => item.StudentId == id).FirstOrDefault();
        }

        public int UpdateStudent(int id, Student student)
        {
            var stu = db.Students.Where(item => item.StudentId == id).FirstOrDefault();
            stu.Name = student.Name;
            stu.Email = student.Email;
            db.Entry<Student>(stu).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            return db.SaveChanges();
        }
    }
}
