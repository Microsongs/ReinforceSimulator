using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReinforceSimulator
{
    public partial class Form1 : Form
    {
        Sword sword;    //검 생성
        //ReinforcePercent mypercent; //강화 확률
        int mycycle = 0;
        public Form1()
        {
            InitializeComponent();

            InitializeForm();
        }
        private void InitializeForm()
        {
            //이미지 불러오기
            WeaponBox.Load(@"../../images/Sword.png");
            WeaponBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //무기 초기화
            sword = new Sword("낡은 한손검");
            TxtSetting();
        }
        private void TxtSetting()
        {
            weaponName.Text = sword.Name;   //무기 이름 변경
            weaponReinForce.Text = "+ " + sword.Reinforce.ToString(); //무기 강화수치 불러오기
            System.Diagnostics.Debug.WriteLine(sword.STR());
            weaponData.Text = "힘 : " + sword.STR() + "\n" + "공격력 : " + sword.ATK();
            weaponPercent.Text = sword.percentData();
            cycle.Text = "강화 횟수 : " + mycycle.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ReinforceBtn_Click(object sender, EventArgs e)
        {
            //System.Diagnostics.Debug.WriteLine(sword.Reinforce);
            //mypercent.SetPercent(sword.Reinforce);
            /*
            bool check = mypercent.ReinForce();
            //System.Diagnostics.Debug.WriteLine(check);
            if(check == true)
            {
                sword.Reinforce++;
            }
            else
            {
                sword.Reinforce--;
            }
            */
            sword.Action();
            mycycle++;
            TxtSetting();
        }
    }
}
