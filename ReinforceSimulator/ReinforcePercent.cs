using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        int maintain;   //유지 확률
        int down;       //하락 확률
        int fail;       //파괴 확률
        public ReinforcePercent()
        {
            success = 100;
            maintain = 0;
            down = 0;
            fail = 0;
        }
        public void SetPercent(int reinforce)
        {
            if(reinforce < 10)
            {
                success = 100 - (reinforce * 5);
                maintain = 0 + (reinforce * 5);
            }
            else
            {
                switch (reinforce)
                {
                    case 10:
                        success = 45;
                        maintain = 55;
                        down = 0;
                        fail = 0;
                        break;
                    case 11:
                        success = 40;
                        maintain = 30;
                        down = 30;
                        fail = 0;
                        break;
                    case 12:
                    case 13:
                    case 14:
                        success = 35;
                        maintain = 0;
                        down = 62;
                        fail = 3;
                        break;
                    case 15:
                        success = 35;
                        maintain = 60;
                        down = 0;
                        fail = 5;
                        break;
                    case 16:
                    case 17:
                    case 18:
                    case 19:
                        success = 35;
                        maintain = 0;
                        down = 60;
                        fail = 5;
                        break;
                    case 20:
                        success = 35;
                        maintain = 58;
                        down = 0;
                        fail = 7;
                        break;
                    case 21:
                        success = 35;
                        maintain = 0;
                        down = 55;
                        fail = 10;
                        break;
                    //기타 케이스(22이상)
                    default:
                        success = 3;
                        maintain = 0;
                        down = 77;
                        fail = 20;
                        break;
                }
            }
        }
        public string Text
        {
            get { return "성공 확률 : " + success + "% \n 유지 확률 : " + maintain + "%" +
                    "\n 하락 확률 : " + down +"% \n 파괴 확률 : " + fail + "%"; }
        }
        public int Success
        {
            get { return success; }
        }
        public int Fail
        {
            get { return fail; }
        }
        public int ReinForce()
        {
            Random m = new Random();
            int rand = m.Next(1, 100);
            Debug.WriteLine("rand : {0}, success : {1}, maintain : {2}, down : {3}, fail : {4}",rand, success, maintain, down, fail);
            if (success >= rand)        //성공
                return (int)Result.success;
            else if (success + maintain >= rand)    //유지
                return (int)Result.maintain;
            else if (success + maintain + down >= rand)  //하락
                return (int)Result.down;
            else    //파괴
                return (int)Result.fail;
        }
    }
    enum Result
    {
        success, maintain, down, fail
    }
}
