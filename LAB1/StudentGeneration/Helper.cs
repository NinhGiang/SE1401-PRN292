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

        public void addInstruction(string instruction)
        {
            helper_list.Add(instruction.Trim());
        }

        public void deleteInstruction(int index)
        {       
            if ((index < helper_list.Count) && (index >=0))
            {
                helper_list.RemoveAt(index);
            }
        }
    }
}
