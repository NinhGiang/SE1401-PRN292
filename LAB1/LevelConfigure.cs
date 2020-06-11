using System;
using System.Collections.Generic;
using System.Text;

namespace LAB1
{
    class LevelConfigure
    {
        private string id;
        public string UUID { get; set; }

        public void a()
        {
            id = Guid.NewGuid().ToString();
        }
        //
    }
}
