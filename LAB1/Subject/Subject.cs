using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

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

        public static Subject[] Create()
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
            for (uint i = 0; i < levels.Length; i++)
            {
                string level = levels[i];
                for (int j = 0; j < fields.Length; j++)
                {
                    string field = fields[j];
                    switch (fields[j])
                    {
                        case "Khoa Học Tự Nhiên":
                            for (int k = 0; k < config.SubjectNameConfig.experimentalscience_subject_name_set.Length; k++)
                            {
                                string name = config.SubjectNameConfig.experimentalscience_subject_name_set[k];
                                result_list.Add(new Subject(level, field, name));
                            }
                            break;
                        case "Khoa Học Xã Hội":
                            for (int k = 0; k < config.SubjectNameConfig.socialscience_subject_name_set.Length; k++)
                            {
                                string name = config.SubjectNameConfig.socialscience_subject_name_set[k];
                                result_list.Add(new Subject(level, field, name));
                            }
                            break;
                        case "Văn Học và Ngoại Ngữ":
                            for (int k = 0; k < config.SubjectNameConfig.language_subject_name_set.Length; k++)
                            {
                                string name = config.SubjectNameConfig.language_subject_name_set[k];
                                result_list.Add(new Subject(level, field, name));
                            }
                            break;
                        case "Toán":
                            for (int k = 0; k < config.SubjectNameConfig.math_subject_name_set.Length; k++)
                            {
                                string name = config.SubjectNameConfig.math_subject_name_set[k];
                                result_list.Add(new Subject(level, field, name));
                            }
                            break;
                        case "Khác":
                            for (int k = 0; k < config.SubjectNameConfig.miscellaneous_subject_name_set.Length; k++)
                            {
                                string name = config.SubjectNameConfig.miscellaneous_subject_name_set[k];
                                result_list.Add(new Subject(level, field, name));
                            }
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
