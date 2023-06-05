using SOLID_O_Open_Close_Princeple;

Student student1 = new Student
{
  firstName  = "Dmytro",
  lastname = "Levchenko",
  age = 25,
  faculty = "Logistick"
};

Person student2 = new Student
{
  firstName = "Jena",
  lastname = "Charikov",
  age = 25,
  faculty = "Biohemick"
};

Teacher teacher = new Teacher
{
  firstName =  "Anatoliy",
  lastname = "Chebercov",
  age = 34,
  department = "Matematicks"
};

student1.Print();
student2.Print();
teacher.Print();