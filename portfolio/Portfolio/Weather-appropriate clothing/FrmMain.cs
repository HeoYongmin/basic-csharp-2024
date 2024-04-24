namespace Weather_appropriate_clothing
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            RadioButton RdoSummer = new RadioButton();
            RdoSummer.Text = "여름";
            RdoSummer.CheckedChanged += RdoSummer_CheckedChanged;
            // RdoSummer.Location = new System.Drawing.Point(20, 20);
        }

        private void RdoSummer_CheckedChanged(object sender, EventArgs e)
        {
            // 여름 라디오 버튼이 선택될 때 실행되는 코드
            if (RdoSummer.Checked)
            {
                // 여름 옷차림 이미지와 설명을 표시
                PicSummerImg.Image = Properties.Resources.summer_outfit;
                TxtDcpSummer.Text = "여름에 적합한 옷차림입니다.\n반팔 티셔츠와 반바지를 입고,\n가볍고 시원한 슬리퍼를 신으세요.";
            }
        }
    }
}