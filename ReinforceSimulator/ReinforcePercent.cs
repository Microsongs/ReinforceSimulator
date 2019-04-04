using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReinforceSimulator
{
    class ReinforcePercent
    {
        //강화 수치 클래스
        //string text;    //안내 텍스트
        int success;    //성공 확률
        int fail;       //실패 확률
        public ReinforcePercent()
        {
            success = 100;
            fail = 0;
        }
        public void SetPercent(int reinforce)
        {
            System.Diagnostics.Debug.WriteLine(reinforce);
            if(reinforce < 20)
            {
                success = 100 - (reinforce * 5);
                fail = 0 + (reinforce * 5);
            }
            else
            {
                success = 5;
                fail = 95;
            }
        }
        public string Text
        {
            get { return "성공 확률 : " + success + "%" + "\n 실패 확률 : " + fail + "%"; }
        }
        public int Success
        {
            get { return success; }
        }
        public int Fail
        {
            get { return fail; }
        }
        public bool ReinForce()
        {
            Random m = new Random();
            int temp = m.Next(1, 100);
            if (temp >= fail)
                return true;
            else
                return false;
        }
    }
}
