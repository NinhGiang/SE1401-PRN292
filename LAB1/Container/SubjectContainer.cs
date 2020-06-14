using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LAB1.Container
{
    class SubjectContainer
    {
        private List<Subject> _subject_list;

        public SubjectContainer(Subject[] subject)
        {
            _subject_list = new List<Subject>(subject);
        }

        public void SubjectSave(String filename)
        {
            String content = "ID, Subject Name, Level ID, Field ID\n";
            foreach (Subject subject in _subject_list)
            {
                content += subject.UUID + ", " + subject.SubName + ", " + subject.Level_info + ", " + subject.Field_info + "\n";
            }
            File.WriteAllText(filename, content);
        }
    }
}
