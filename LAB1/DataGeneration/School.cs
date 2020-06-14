using LAB1.DataGeneration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;

/// <summary>
/// The School class
/// Contains method to create School and its getter/setter/ctor.
/// Contains lists of others objects to manage and write to the file.
/// </summary>
class School
{

    private List<Student> _student_list;
    private List<Room> _room_list;
    private List<Level> _level_list;
    private List<Classes> _classes_list;
    private List<Field> _field_list;
    /// <summary>
    /// The ctor of School 
    /// Has one blank ctor
    /// </summary>
    /// <param name="student_list">An array of Student</param>
    /// <param name="room_list">An array of Room</param>
    /// <param name="level_list">An array of Level</param>
    /// <param name="classes_list">An array of Classes</param>
    public School() { }
    public School(Student[] student_list, Room[] room_list, Level[] level_list, Classes[] classes_list, Field[] field_list)
    {
        _student_list = new List<Student>(student_list);
        _room_list = new List<Room>(room_list);
        _level_list = new List<Level>(level_list);
        _classes_list = new List<Classes>(classes_list);
        _field_list = new List<Field>(field_list);
    }
    public List<Student> GetStudents()
    {
        return _student_list;
    }
    public void SetStudents(Student[] students)
    {
        _student_list = new List<Student>(students);
    }
    //getter setter for Student
    public List<Room> GetRooms()
    {
        return _room_list;
    }
    public void SetRooms(Room[] rooms)
    {
        _room_list = new List<Room>(rooms);
    }
    //getter setter for Room
    public List<Level> GetLevels()
    {
        return _level_list;
    }
    public void SetLevels(Level[] levels)
    {
        _level_list = new List<Level>(levels);
    }
    //getter setter for Level
    public List<Classes> GetClasses()
    {
        return _classes_list;
    }
    public void SetClasses(Classes[] classes)
    {
        _classes_list = new List<Classes>(classes);
    }
    public List<Field> GetField()
    {
        return _field_list;
    }
    public void setField(Field[] fields)
    {
        _field_list = new List<Field>(fields);
    }
    public void saveStudent(string filename)
    {
        string content = "";
        if (Path.GetExtension(filename) == ".csv")
        {
            content = "ID, Name, DOB, Gender, Class\n";
            try
            {
                if (_student_list == null)
                {
                    _student_list = new List<Student>();
                }
                foreach (Student student in _student_list)
                {
                    content += student.Uuid + ", ";
                    content += student.Name + ", ";
                    content += student.Birthday.ToString("d") + ", ";
                    content += student.Gender + ", ";
                    content += student.Class + "\n";
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Error in saveStudent: " + ex.Message);
            }
        }
        if (Path.GetExtension(filename) == ".json")
        {
            content = JsonConvert.SerializeObject(_student_list, Formatting.Indented);
        }
        File.WriteAllText(filename, content);
    }


    public void saveRoom(string filename)
    {
        string content = "";
        if (Path.GetExtension(filename) == ".csv")
        {
            content = "ID, Class, No\n";
            try
            {
                if (_room_list == null)
                {
                    _room_list = new List<Room>();
                }
                foreach (Room room in _room_list)
                {
                    content += room.Uuid + ", ";
                    content += room.Class_info + ", ";
                    content += room.No + "\n";
                }   
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Error in saveRoom: " + ex.Message);
            }
        }
        if (Path.GetExtension(filename) == ".json")
        {
            content = JsonConvert.SerializeObject(_room_list, Formatting.Indented);
        }
        File.WriteAllText(filename, content);
    }
    public void saveLevel(string filename)
    {
        string content = "";
        if (Path.GetExtension(filename) == ".csv") 
        {
            content = "ID, Name\n";
            try
            {
                if (_level_list == null)
                {
                    _level_list = new List<Level>();
                }
                foreach (Level level in _level_list)
                {
                    content += level.Uuid + ", ";
                    content += level.Name + "\n";
                }  
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Error in saveLevel:" + ex.Message);
            }
        }
        if (Path.GetExtension(filename) == ".json")
        {
            content = JsonConvert.SerializeObject(_level_list, Formatting.Indented);
        }
        File.WriteAllText(filename, content);
    }
    public void saveClasses(string filename)
    {
        string content = "";
        if (Path.GetExtension(filename) == ".csv")
        {
            content = "ID, Level, Room, Name\n";
            try
            {
                if (_classes_list == null)
                    _classes_list = new List<Classes>();
                foreach (Classes classs in _classes_list)
                {
                    content += classs.Uuid + ", ";
                    content += classs.Level + ", ";
                    content += classs.Room + ", ";
                    content += classs.Name + "\n";
                }
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Error in saveClasses: " + ex.Message);
            }
        }
        if (Path.GetExtension(filename) == ".json")
        {
            content = JsonConvert.SerializeObject(_classes_list, Formatting.Indented);
        }
        File.WriteAllText(filename, content);
    }
    public void saveField(string filename)
    {
        string content = "";
        if (Path.GetExtension(filename) == ".csv")
        {
            content = "ID, Name\n";
            try
            {
                if (_field_list == null)
                    _field_list = new List<Field>();
                    foreach (Field field in _field_list)
                    {
                        content += field.Uuid + ", ";
                        content += field.Name + "\n";
                    }   
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Error in saveField: " + ex.Message);
            }
        }
        if (Path.GetExtension(filename) == ".json")
        {
            content = JsonConvert.SerializeObject(_field_list, Formatting.Indented);
        }
        File.WriteAllText(filename, content);
    }
    public void saveSubject(string filename)
    {
        string content = "";
        if (Path.GetExtension(filename) == ".csv")
        {
           
        }
    }
}

