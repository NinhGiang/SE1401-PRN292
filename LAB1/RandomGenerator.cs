using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class RandomGenerator
    {
        public static DateTime randBirthday()
        {
            Random rnd = new Random();
            //ganerate random birthday
            DateTime from = new DateTime(2002, 1, 1);
            DateTime to = new DateTime(2004, 12, 31);
            var range = new TimeSpan(to.Ticks - from.Ticks);
            TimeSpan randTimeSpan = TimeSpan.FromSeconds((long)(range.TotalSeconds - rnd.Next(0, (int)range.TotalSeconds)));
            DateTime birthday = from + randTimeSpan;
            return birthday;
        }

        public static string randUUID()
        {
            string id = Guid.NewGuid().ToString();
            return id;
        }

        public static string randMaleStudentName(StudentConfigure config)
        {
            Random rnd = new Random();
            NameConfig _ = config.NameConfig;
            int last_name_index = rnd.Next(_.last_name_set.Length);
            int first_name_index = rnd.Next(_.first_male_name_set.Length);
            int middle_name_index = rnd.Next(_.middle_male_name_set.Length);
            string full_name = _.last_name_set[last_name_index] + " ";
            full_name += _.middle_male_name_set[middle_name_index] + " ";
            full_name += _.first_male_name_set[first_name_index];
            return full_name;
        }

        public static string randFemaleStudentName(StudentConfigure config)
        {
            Random rnd = new Random();
            NameConfig _ = config.NameConfig;
            int last_name_index = rnd.Next(_.last_name_set.Length);
            int first_name_index = rnd.Next(_.first_female_name_set.Length);
            int middle_name_index = rnd.Next(_.middle_female_name_set.Length);
            string full_name = _.last_name_set[last_name_index] + " ";
            full_name += _.middle_female_name_set[middle_name_index] + " ";
            full_name += _.first_female_name_set[first_name_index];
            return full_name;
        }

        public static string randLevelName(LevelConfigure config)
        {
            Random rnd = new Random();
            LevelNameConfig _ = config.LevelNameConfig;
            int level_index = rnd.Next(_.level_name_set.Length);
            string level = _.level_name_set[level_index];
            return level;
        }
        public static bool randGender()
        {
            //female is 0, male is 1
            Random rnd = new Random();
            int gender_num = rnd.Next(0, 2);
            if (gender_num == 0)
            {
                return false;
            }
            else
                return true;
        }
    }
}
