using LAB1.DataGeneration;
using System;
using System.Collections.Generic;
using System.IO;

class School
{
    private List<Student> _student_list;
    private List<Room> _room_list; 
    public School()
    {
        _student_list = new List<Student>();
        _room_list = new List<Room>();
    }
    public School(Student[] student_list, Room[] room_list)
    {
        _student_list = new List<Student>(student_list);
        _room_list = new List<Room>(room_list);
    }
    public List<Student> GetStudents()
    {
        return _student_list;
    }
    public void setStudents(Student[] students)
    {
        _student_list = new List<Student>(students);
    }
    public List<Room> getRooms()
    {
        return _room_list;
    }
    public void setRoom(Room[] rooms)
    {
        _room_list = new List<Room>(rooms);
    }
    public void saveStudent(string filename)
    {
        String content = "ID, Name, DOB, Gender, Class\n";
        foreach (Student student in _student_list)
        {
            content += student.Uuid + ", ";
            content += student.Name + ", ";
            content += student.Birthday.ToString("d") + ", ";
            content += student.Gender + ", ";
            content += student.Class + "\n";
        }
        File.WriteAllText(filename, content);
    }

    public void saveRoom(string filename)
    {
        string content = "ID, Class, No\n";
        foreach (Room room in _room_list)
        {
            content += room.Uuid + ", ";
            content += room.Class_info + ", ";
            content += room.No +"\n";     
        }
        File.WriteAllText(filename, content);
    }

}

