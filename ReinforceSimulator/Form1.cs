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
            WeaponName.Text = sword.Name;   //무기 이름 변경
            WeaponReinForce.Text = sword.Reinforce.ToString(); //무기 강화수치 불러오기
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
