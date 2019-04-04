using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinforceSimulator
{
    class Sword
    {
        private string name;    //무기 이름
        int reinforce;  //강화
        public Sword(string name)
        {
            this.name = name;
            reinforce = 0;
        }
        //이름 수정
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Reinforce
        {
            get { return reinforce; }
            set { reinforce += value; }
        }
    }
}
