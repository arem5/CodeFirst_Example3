using CodeFirst_Example3.Models.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst_Example3.Models
{
    public class StudentDataAccessLayer
    {
        StudentContext projectContext = new StudentContext();

        public List<Student> GetAll()
        {
            
            var users = projectContext.Students.Where(x => x.IsDeleted == false).ToList();
            return users;
        }

        public Student GetData(int id)
        {
            var getUser = projectContext.Students.Where(p => p.Id == id).FirstOrDefault();
            return getUser;

        }

        public void UpdateData(Student student)
        {

            var user = projectContext.Students.Where(p => p.Id == student.Id).FirstOrDefault();
            user.Name = student.Name;
            user.Surname = student.Surname;
            user.NumberOfClass = student.NumberOfClass;
            user.Department = student.Department;
            user.GradeAvg = student.GradeAvg;           
            user.IsDeleted = student.IsDeleted;
            user.ImgUrl = student.ImgUrl;

            projectContext.SaveChanges();

        }

        public void CreateData(Student student)
        {

            Student user = new Student();
            user.Name = student.Name;
            user.Surname = student.Surname;
            user.NumberOfClass = student.NumberOfClass;
            user.Department = student.Department;
            user.GradeAvg = student.GradeAvg;
            user.IsDeleted = student.IsDeleted;
            user.ImgUrl = student.ImgUrl;

            projectContext.Students.Add(user);
            projectContext.SaveChanges();
        }

        public void DeleteData(int id)
        {
            Student getUser = projectContext.Students.Where(p => p.Id == id).FirstOrDefault();
            getUser.IsDeleted = true;
            projectContext.SaveChanges();

        }
    }
}
