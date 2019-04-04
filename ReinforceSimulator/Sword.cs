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
        WeaponData weapondata;
        ReinforcePercent reinforcePercent;

        public Sword(string name)
        {
            this.name = name;
            reinforce = 0;
            weapondata = new WeaponData();
            reinforcePercent = new ReinforcePercent();
        }
        //이름 수정
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //강화 실행
        public void Action()
        {
            if (reinforcePercent.ReinForce() == true)
                Reinforce++;
            else
                Reinforce--;
            reinforcePercent.SetPercent(reinforce);
        }
        //강화
        public int Reinforce
        {
            get { return reinforce; }
            set {
                if (value > reinforce)
                    reinforce++;
                else
                    reinforce--;
                weapondata.setData(reinforce);
            }
        }
        //공격력
        public string ATK()
        {
            return weapondata.Attack.ToString();
        }
        //힘
        public string STR()
        {
            return weapondata.Strength.ToString();
        }
        public string percentData()
        {
            return reinforcePercent.Text;
        }

        //inner class
        class WeaponData
        {
            int strength;    //힘
            int attack;     //공격력
            int frontReinforce = 0;
            public WeaponData()
            {
                strength = 0;
                attack = 5;
            }
            public int Strength
            {
                get { return strength; }
            }
            public int Attack
            {
                get { return attack; }
            }

            public void setData(int reinforce)
            {
                int temp = reinforce - frontReinforce;
                //성공
                if (temp >= 1)
                {
                    if (reinforce >= 10)
                    {
                        strength += 4;
                        attack += 7;
                    }
                    else if (reinforce >= 5)
                    {
                        strength += 2;
                        attack += 4;
                    }
                    else
                    {
                        strength += 1;
                        attack += 2;
                    }
                }
                //유지
                else if (temp == 0)
                {
                    return;
                }
                //실패
                else
                {
                    if (frontReinforce >= 10)
                    {
                        strength -= 4;
                        attack -= 7;
                    }
                    else if (frontReinforce >= 5)
                    {
                        strength -= 2;
                        attack -= 4;
                    }
                    else
                    {
                        strength -= 1;
                        attack -= 2;
                    }
                }
                frontReinforce = reinforce;
            }
        }
    }
}
