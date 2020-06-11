using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace LAB1
{
    class Teacher
    {
        protected String _tcuuid;
        protected String _tcfullname;
        protected String _tcgender;
        protected String _field;

        public String TcUUID { get { return _tcuuid; } }
        public String TcFullName { get { return _tcfullname; } }
        public String TcGender { get { return _tcgender; } }
        public String Field_info { get { return _field; } }

        public Teacher(String TcUUID, String TcFullName, String TcGender, String Field_info)
        {
            _tcuuid = TcUUID;
            _tcfullname = TcFullName;
            _tcgender = TcGender;
            _field = Field_info;
        }

        public static Teacher[] Create (uint num_teacher, Field[] flist)
        {
            Teacher[] result = new Teacher[num_teacher];
            string content = File.ReadAllText(@"..\..\..\Configure.json");
            Configure config = JsonSerializer.Deserialize<Configure>(content);

            Random rnd = new Random();
            for(int i = 0; i < num_teacher; i++)
            {
                String uuid = Guid.NewGuid().ToString();

                int gender = rnd.Next(0, 2);
                String genderStr = "Female";
                if (gender == 1)
                {
                    genderStr = "Male";
                }

                NameConfig _ = config.NameConfig;
                int last_name_set = rnd.Next(_.last_name_set.Length);
                int middle_name_set = rnd.Next(_.middle_name_set.Length);
                int first_name_set = rnd.Next(_.first_name_set.Length);
                string full_name = _.last_name_set[last_name_set] + " ";
                full_name += _.middle_name_set[middle_name_set] + " ";
                full_name += _.first_name_set[first_name_set];

                String field_info = flist[rnd.Next(flist.Length)].Name;

                result[i] = new Teacher(uuid, full_name, genderStr, field_info);
            }
            return result;
        }

        public void print()
        {
            Console.WriteLine(_tcuuid + " " + _tcfullname);
        }
    }
}
