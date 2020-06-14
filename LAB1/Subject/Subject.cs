using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace LAB1
{
    class Subject
    {
        protected string _level;
        protected string _field;
        protected string _name;

        public Subject(string level, string field, string name)
        {
            _level = level;
            _field = field;
            _name = name;
        }
        public string Level { get { return _level; } set { _level = value; } }
        public string Field { get { return _field; } set { _field = value; } }
        public string Name { get { return _name; } set { _name = value; } }

        /*public static Subject[] CreateBeta()
        {
            List<Subject> result_list = new List<Subject>();
            string content = File.ReadAllText(@"..\..\..\Subject\SubjectConfigure.json");
            SubjectConfigure config = JsonSerializer.Deserialize<SubjectConfigure>(content);
            //get level list
            string content_level = File.ReadAllText(@"..\..\..\Level\LevelConfigure.json");
            LevelConfigure config_level = JsonSerializer.Deserialize<LevelConfigure>(content_level);
            //get levels
            string[] levels = config_level.LevelNameConfig.level_name_set;
            //get field list
            string content_field = File.ReadAllText(@"..\..\..\Field\FieldConfigure.json");
            FieldConfigure config_field = JsonSerializer.Deserialize<FieldConfigure>(content_field);
            //get fields
            string[] fields = config_field.FieldNameConfig.field_name_set;
            string name;
            for (uint i = 0; i < levels.Length; i++)
            {
                string level = levels[i];
                for (int j = 0; j < fields.Length; j++)
                {
                    string field = fields[j];
                    switch (fields[j])
                    {
                        case "Toán":
                            name = config.SubjectNameConfig.math_subject_name_set[i];
                            result_list.Add(new Subject(levels[i], fields[j], name));
                            break;
                        case "Vật Lý":
                            name = config.SubjectNameConfig.physics_subject_name_set[i];
                            result_list.Add(new Subject(levels[i], fields[j], name));
                            break;
                        case "Hóa Học":
                            name = config.SubjectNameConfig.chemistry_subject_name_set[i];
                            result_list.Add(new Subject(levels[i], fields[j], name));
                            break;
                        case "Sinh Học":
                            name = config.SubjectNameConfig.biology_subject_name_set[i];
                            result_list.Add(new Subject(levels[i], fields[j], name));
                            break;
                        case "Ngữ Văn":
                            name = config.SubjectNameConfig.literature_subject_name_set[i];
                            result_list.Add(new Subject(levels[i], fields[j], name));
                            break;
                        case "Tiếng Anh":
                            name = config.SubjectNameConfig.english_subject_name_set[i];
                            result_list.Add(new Subject(levels[i], fields[j], name));
                            break;
                        case "Tin Học":
                            name = config.SubjectNameConfig.it_subject_name_set[i];
                            result_list.Add(new Subject(levels[i], fields[j], name));
                            break;
                        case "Lịch Sử":
                            name = config.SubjectNameConfig.history_subject_name_set[i];
                            result_list.Add(new Subject(levels[i], fields[j], name));
                            break;
                        case "Địa Lý":
                            name = config.SubjectNameConfig.geography_subject_name_set[i];
                            result_list.Add(new Subject(levels[i], fields[j], name));
                            break;
                        case "Giáo Dục Công Dân":
                            name = config.SubjectNameConfig.civicedu_subject_name_set[i];
                            result_list.Add(new Subject(levels[i], fields[j], name));
                            break;
                        case "Giáo Dục Quốc Phòng":
                            name = config.SubjectNameConfig.defenseedu_subject_name_set[i];
                            result_list.Add(new Subject(levels[i], fields[j], name));
                            break;
                        case "Thể Dục":
                            name = config.SubjectNameConfig.physicaledu_subject_name_set[i];
                            result_list.Add(new Subject(levels[i], fields[j], name));
                            break;
                        case "Công Nghệ":
                            name = config.SubjectNameConfig.technology_subject_name_set[i];
                            result_list.Add(new Subject(levels[i], fields[j], name));
                            break;
                        case "Tiếng Đức":
                            name = config.SubjectNameConfig.german_subject_name_set[i];
                            result_list.Add(new Subject(levels[i], fields[j], name));
                            break;
                        default:
                            break;
                    }
                }
            }
            //generate subject list
            Subject[] result = result_list.ToArray();
            return result;
        }*/

        public static Subject[] Create()
        {
            List<Subject> result_list = new List<Subject>();
            string content = File.ReadAllText(@"..\..\..\Subject\SubjectConfigure.json");
            SubjectConfigure config = JsonSerializer.Deserialize<SubjectConfigure>(content);
            //get level list
            string content_level = File.ReadAllText(@"..\..\..\Whatever\Levels.json");
            List<Level> levels = JsonConvert.DeserializeObject<List<Level>>(content_level);
            Level[] level_list = levels.ToArray();
            //get field list
            string content_field = File.ReadAllText(@"..\..\..\Whatever\Fields.json");
            List<Field> fields = JsonConvert.DeserializeObject<List<Field>>(content_field);
            //get fields
            Field[] field_list = fields.ToArray();
            string name;
            for(int i = 0; i < level_list.Length; i++)
            {
                string level = level_list[i].UUID;
                for (int j = 0; j < field_list.Length; j++)
                {
                    switch (field_list[j].Name)
                    {
                        case "Toán":
                            name = config.SubjectNameConfig.math_subject_name_set[i];
                            result_list.Add(new Subject(level, field_list[j].UUID, name));
                            break;
                        case "Vật Lý":
                            name = config.SubjectNameConfig.physics_subject_name_set[i];
                            result_list.Add(new Subject(level, field_list[j].UUID, name));
                            break;
                        case "Hóa Học":
                            name = config.SubjectNameConfig.chemistry_subject_name_set[i];
                            result_list.Add(new Subject(level, field_list[j].UUID, name));
                            break;
                        case "Sinh Học":
                            name = config.SubjectNameConfig.biology_subject_name_set[i];
                            result_list.Add(new Subject(level, field_list[j].UUID, name));
                            break;
                        case "Ngữ Văn":
                            name = config.SubjectNameConfig.literature_subject_name_set[i];
                            result_list.Add(new Subject(level, field_list[j].UUID, name));
                            break;
                        case "Tiếng Anh":
                            name = config.SubjectNameConfig.english_subject_name_set[i];
                            result_list.Add(new Subject(level, field_list[j].UUID, name));
                            break;
                        case "Tin Học":
                            name = config.SubjectNameConfig.it_subject_name_set[i];
                            result_list.Add(new Subject(level, field_list[j].UUID, name));
                            break;
                        case "Lịch Sử":
                            name = config.SubjectNameConfig.history_subject_name_set[i];
                            result_list.Add(new Subject(level, field_list[j].UUID, name));
                            break;
                        case "Địa Lý":
                            name = config.SubjectNameConfig.geography_subject_name_set[i];
                            result_list.Add(new Subject(level, field_list[j].UUID, name));
                            break;
                        case "Giáo Dục Công Dân":
                            name = config.SubjectNameConfig.civicedu_subject_name_set[i];
                            result_list.Add(new Subject(level, field_list[j].UUID, name));
                            break;
                        case "Giáo Dục Quốc Phòng":
                            name = config.SubjectNameConfig.defenseedu_subject_name_set[i];
                            result_list.Add(new Subject(level, field_list[j].UUID, name));
                            break;
                        case "Thể Dục":
                            name = config.SubjectNameConfig.physicaledu_subject_name_set[i];
                            result_list.Add(new Subject(level, field_list[j].UUID, name));
                            break;
                        case "Công Nghệ":
                            name = config.SubjectNameConfig.technology_subject_name_set[i];
                            result_list.Add(new Subject(level, field_list[j].UUID, name));
                            break;
                        case "Tiếng Đức":
                            name = config.SubjectNameConfig.german_subject_name_set[i];
                            result_list.Add(new Subject(level, field_list[j].UUID, name));
                            break;
                        default:
                            break;
                    }
                }
            }
            //generate subject list
            Subject[] result = result_list.ToArray();
            return result;
        }
        public void print()
        {
            Console.WriteLine(_level + " | " + _field + " | " + _name);
        }
    }
}
