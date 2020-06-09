using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace LAB1.StudentGeneration
{
    class SupportTools
    {
        public static string getSchoolName(string input)
        {
            int index_of_s = input.IndexOf(" -s ");
            string school_name;
            if (index_of_s > 0)
            {
                school_name = input.Substring(0, index_of_s).Trim();
                return school_name;
            }
            return null;
        }

        public static int getStudentAmount(string input)
        {
            int index_of_s = input.LastIndexOf(" -s ");
            int index_of_r = input.IndexOf(" -r ");
            int number_of_students;
            if (index_of_s > 0)
            {
                int index_of_student_amount = index_of_s + 4;
                if (index_of_r > 0)
                {
                    int number_of_char = index_of_r - index_of_student_amount;
                    number_of_students = IntegerType.FromString(
                        input.Substring(index_of_student_amount, number_of_char));
                } 
                else
                {
                    int number_of_char = input.Length - index_of_student_amount;
                    number_of_students = IntegerType.FromString(
                        input.Substring(index_of_student_amount, number_of_char));
                }
                return number_of_students;
            }
            return -1;
        }  

        public static int getRoomAmount(string input)
        {
            int index_of_r = input.IndexOf(" -r ");
            int number_of_rooms;

            if (index_of_r > 0)
            {
                int index_of_room_amount = index_of_r + 4;
                int number_of_chars = input.Length - index_of_room_amount;
                if (number_of_chars > 0)
                {
                    number_of_rooms = IntegerType.FromString(
                                        input.Substring(index_of_room_amount, number_of_chars));
                    return number_of_rooms;
                }
            }
            return -1;
        }
    }
}
