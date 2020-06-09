using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1.StudentGeneration
{
    class Helper
    {
        List<string> helper_list;

        public Helper() 
        {
            helper_list = new List<string>();
        }

        public Helper(List<string> helper)
        {
            helper_list = helper;
        }
        
        //Thêm một instruction vào cuối list
        public void addInstruction(string instruction)
        {
            helper_list.Add(instruction.Trim());
        }

        //xóa một instruction dựa theo vị trí instruction, tính từ vị trí 0
        public void deleteInstruction(int index)
        {       
            if ((index < helper_list.Count) && (index >=0))
            {
                helper_list.RemoveAt(index);
            }
        }

        //in toàn bộ instruction ra màn hình console
        public void displayInstruction()
        {
            for (int i = 0; i < helper_list.Count; i++)
            {
                Console.WriteLine("     {0}. {1}", i + 1, helper_list[i]);
            }
        }
    }
}
