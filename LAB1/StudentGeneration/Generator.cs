using StudentGeneration;
using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.StudentGeneration
{
    class Generator
    {
        private static Random rd;
        public static int getRandomInteger(int range)
        {
            rd = new Random();
            return rd.Next(range);
        }

        public static int getRandomInteger(int lowerBound, int upperBound)
        {
            rd = new Random();
            return rd.Next(lowerBound, upperBound);
        }

        public static DateTime getRandomDate(int year)
        {
            rd = new Random();
            DateTime startDate = new DateTime(year, 1, 1);
            DateTime endDate = new DateTime(year, 12, 31);
            int randomDay = rd.Next((endDate - startDate).Days);
            return startDate.AddDays(randomDay);
        }

        public static string createFullnameRandomly(Configure config)
        {
            NameDataSet name_config = config.NameDataSet;
            int lastname_length_inDB = name_config.LastNameSet.Length;
            int middelname_length_inDB = name_config.MiddleNameSet.Length;
            int firstname_length_inDB = name_config.FirstNameSet.Length;

            int last_name_index = getRandomInteger(lastname_length_inDB);
            int middle_name_index = getRandomInteger(middelname_length_inDB);
            int first_name_index = getRandomInteger(firstname_length_inDB);

            string fullname = name_config.LastNameSet[last_name_index] + " ";
            fullname += name_config.MiddleNameSet[middle_name_index] + " ";
            fullname += name_config.FirstNameSet[first_name_index];

            return fullname;
        }

        public static string createGenderRandomly(Configure config)
        {
            GenderDataSet gender_config = config.GenderDataSet;
            int gender_length_inDB = gender_config.GenderSet.Length;
            int gender_index = getRandomInteger(gender_length_inDB);
            string gender = gender_config.GenderSet[gender_index];
            return gender;
        }

        public static string createLevelRandomly(Configure config)
        {
            LevelDataSet level_config = config.LevelDataSet;
            int level_length_inDB = level_config.LevelSet.Length;
            int level_index = getRandomInteger(level_length_inDB);
            string level = level_config.LevelSet[level_index];
            return level;
        }

        public static string createClassRandomly(Configure config)
        {
            CLassDataSet class_config = config.CLassDataSet;
            int class_length_inDB = class_config.ClassSet.Length;
            int class_index = getRandomInteger(class_length_inDB);
            string level = createLevelRandomly(config);
            string class_name = level + class_config.ClassSet[class_index];
            return class_name;
        }
    }
}
