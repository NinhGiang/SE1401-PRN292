using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProgramManagerStudent
{
    class Room
    {
        private string uuid;
        private uint no;
        private uint numbOfStudent;
        
        public string Uuid { get { return uuid; }}
        public uint No { get { return no; }}
        public uint NumbOfStudent { get { return numbOfStudent; }}

        public Room(string uuid, uint no, uint numbOfStudent)
        {
            this.uuid = uuid;
            this.no = no;
            this.numbOfStudent = numbOfStudent;
        }

        public static List<Room> CreateRoom(uint numbOfStudentInSchool)
        {
            Random rnd = new Random();
            List<Room> roomList = new List<Room>();
            uint count = 1;
            while (numbOfStudentInSchool > 0)
            {
                uint numbOfStudentInClass;
                if (numbOfStudentInSchool > 100 && numbOfStudentInSchool <= 120)
                {
                    numbOfStudentInClass = numbOfStudentInSchool / 3;
                }
                else if (numbOfStudentInSchool >= 60 && numbOfStudentInSchool <= 100)
                {
                    numbOfStudentInClass = numbOfStudentInSchool / 2;
                }
                else if (numbOfStudentInSchool >= 30 && numbOfStudentInSchool <= 50)
                {
                    numbOfStudentInClass = numbOfStudentInSchool;
                }
                else
                {
                    numbOfStudentInClass = (uint)rnd.Next(30, 51);
                }
                string uuid = Guid.NewGuid().ToString();
                roomList.Add(new Room(uuid, count, numbOfStudentInClass));
                numbOfStudentInSchool -= numbOfStudentInClass;
                count++;
            }
            return roomList;
        }
        public static void SaveRooms(List<Room> roomList)
        {
            String content = "UUID, No, Number Of Students";
            foreach (Room room in roomList)
            {
                content += "\n" + room.Uuid + ", " + room.No + ", " + room.NumbOfStudent;
            }
            File.WriteAllText(@"..\..\..\Rooms.csv", content);
        }
    }
}
