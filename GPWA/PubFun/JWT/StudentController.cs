using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace GpWA.PubFun
{

    [ApiController]
    [Route("[controller]")]
    //[RoutePrefix("api/Student"), ApiAuthorize]
    public class StudentController : ControllerBase
    {
        private static readonly List<Student> StudentList = new List<Student>()
    {
        new Student() {Id = "001", Name = "张三", Sex = "男", Age = 19, Dept = "软件学院"},
        new Student() {Id = "002", Name = "李丽", Sex = "女", Age = 19, Dept = "资环学院"}
    };

        [HttpGet("Plus")]
        public ActionResult Plus(int a, int b)
        {
            int intCount =  a + b;
            return Ok(new { errorId = 0, errorMsg = "", returnInt = intCount });
        }
  
        [HttpGet("GetObjLst")]
        public IEnumerable<Student> GetObjLst()
        {
            return StudentList;
        }
        [HttpGet, Route("GetByDept/{dept}")]
        public IEnumerable<Student> GetByDept(string dept)
        {
            List<Student> tempList = StudentList.Where(p => p.Dept == dept).ToList();
            return tempList;
        }
        [HttpGet("GetId")]
        public Student Get(string id)
        {
            List<Student> tempList = StudentList.Where(p => p.Id == id).ToList();
            return tempList.Count == 1 ? tempList.First() : null;
        }

        [HttpPost("Post")]
        public ActionResult Post([FromBody] Student student)
        {
            if (student == null)              return Ok(new { errorId = 0, errorMsg = "", returnBool = false }); 
            if (StudentList.Where(p => p.Id == student.Id).ToList().Count > 0) return Ok(new { errorId = 0, errorMsg = "", returnBool = false });
            StudentList.Add(student);
            var bolResult = true;
            return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
        }

        [HttpPut("Put")]
        public ActionResult Put(string id, [FromBody] Student student)
        {
            if (student == null) return Ok(new { errorId = 0, errorMsg = "", returnBool = false }); ;
            List<Student> tempList = StudentList.Where(p => p.Id == id).ToList();
            if (tempList.Count == 0) return Ok(new { errorId = 0, errorMsg = "", returnBool = false }); ;
            Student originStudent = tempList[0];
            originStudent.Name = student.Name;
            originStudent.Sex = student.Sex;
            originStudent.Age = student.Age;
            originStudent.Dept = student.Dept;
            var bolResult = true;
            return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
        }

        [HttpDelete("Delete")]
        public ActionResult Delete(string id)
        {
            List<Student> tempList = StudentList.Where(p => p.Id == id).ToList();
            if (tempList.Count == 0) return Ok(new { errorId = 0, errorMsg = "", returnBool = false });
            StudentList.Remove(tempList[0]);
            var bolResult = true;
            return Ok(new { errorId = 0, errorMsg = "", returnBool = bolResult });
        }
    }
    public class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public string Dept { get; set; }
    }
}
