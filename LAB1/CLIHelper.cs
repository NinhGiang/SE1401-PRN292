using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class CLIHelper
    {
        List<string> helper_list;

        public CLIHelper()
        {
            helper_list = new List<string>();
        }

        public CLIHelper(List<string> helper)
        {
            helper_list = helper;
        }

        //Thêm một instruction vào cuối list
        public void AddInstruction(string instruction)
        {
            helper_list.Add(instruction.Trim());
        }

        //xóa một instruction dựa theo vị trí instruction, tính từ vị trí 0
        public void DeleteInstruction(int index)
        {
            if ((index < helper_list.Count) && (index >= 0))
            {
                helper_list.RemoveAt(index);
            }
        }

        //in toàn bộ instruction ra màn hình console
        public void DisplayInstruction()
        {
            for (int i = 0; i < helper_list.Count; i++)
            {
                Console.WriteLine("     {0}. {1}", i + 1, helper_list[i]);
            }
        }
    }
}
