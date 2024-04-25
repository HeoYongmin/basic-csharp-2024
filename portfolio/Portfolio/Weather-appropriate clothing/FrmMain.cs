namespace Weather_appropriate_clothing
{
    public partial class FrmMain : Form
    {
        string curSeason = "";

        public FrmMain()
        {
            InitializeComponent();

            InitializeForm();
            RdoSpring.Checked = RdoSummer.Checked = RdoFall.Checked = RdoWinter.Checked = false;
        }

        private void InitializeForm()
        {
            ResetAll();
            
        }

        private void ResetAll()
        {
            
            ResetSpringImgAndTxt();
            ResetSummerImgAndTxt();
            ResetFallImgAndTxt();
            ResetWinterImgAndTxt();
        }

        private void RdoSpring_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RdoSpring.Checked)
            {
                curSeason = "Spring";
                PicSpringOTT1.Image = Properties.Resources.cardigan;
                PicSpringOTT2.Image = Properties.Resources.denim_jacket;
                PicSpringOTT3.Image = Properties.Resources.hoodie;
                PicSpringOTT4.Image = Properties.Resources.blue_jeans;
                PicSpringOTT5.Image = Properties.Resources.sneakers;

                TxtDcpSpring.Text = "봄에 적합한 옷차림입니다.\n 가디건, 자켓, 후드, 바지를 입고, \n 신발은 스니커즈나 런닝화를 추천합니다.";

                ResetSummerImgAndTxt();
                ResetFallImgAndTxt();
                ResetWinterImgAndTxt();

                RdoSummer.Checked = false;
                RdoFall.Checked = false;
                RdoWinter.Checked = false;
            }
            else
            {
                ResetSpringImgAndTxt();
            }
            
        }

        private void RdoSummer_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RdoSummer.Checked)
            {
                curSeason = "Summer";
                PicSummerOTT1.Image = Properties.Resources.clothes;
                PicSummerOTT2.Image = Properties.Resources.tshirt;
                PicSummerOTT3.Image = Properties.Resources.hawaiian_shirt;
                PicSummerOTT4.Image = Properties.Resources.denim_shorts;
                PicSummerOTT5.Image = Properties.Resources.sandals;

                TxtDcpSummer.Text = "여름에 적합한 옷차림입니다.\n 얇은 긴팔, 반팔, 반팔셔츠와 반바지를 입고, \n 가볍고 시원한 샌들을 추천합니다.";

                ResetSpringImgAndTxt();
                ResetFallImgAndTxt();
                ResetWinterImgAndTxt();

                RdoSpring.Checked = false;
                RdoFall.Checked = false;
                RdoWinter.Checked = false;
            }
            else
            {
                ResetSummerImgAndTxt();
            }
            
        }

        private void RdoFall_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RdoFall.Checked)
            {
                curSeason = "Fall";
                PicFallOTT1.Image = Properties.Resources.coat1;
                PicFallOTT2.Image = Properties.Resources.jacket;
                PicFallOTT3.Image = Properties.Resources.sweater;
                PicFallOTT4.Image = Properties.Resources.trousers;
                PicFallOTT5.Image = Properties.Resources.mens_shoes;

                TxtDcpFall.Text = "가을에 적합한 옷차림입니다.\n 트렌치 코트, 패딩조끼, 니트, 바지를 입고, \n 구두나 신발을 더하는 것이 좋습니다.";

                ResetSpringImgAndTxt();
                ResetSummerImgAndTxt();
                ResetWinterImgAndTxt();

                RdoSummer.Checked = false;
                RdoWinter.Checked = false;
                RdoSpring.Checked = false;
            }
            else
            {
                ResetFallImgAndTxt();
            }

            
        }

        private void RdoWinter_CheckedChanged_1(object sender, EventArgs e)
        {
            if (RdoWinter.Checked)
            {
                curSeason = "Winter";
                PicWinterOTT1.Image = Properties.Resources.coat;
                PicWinterOTT2.Image = Properties.Resources.padding;
                PicWinterOTT3.Image = Properties.Resources.jumper;
                PicWinterOTT4.Image = Properties.Resources.pants;
                PicWinterOTT5.Image = Properties.Resources.winter_scarf;
                PicWinterOTT6.Image = Properties.Resources.gloves;

                TxtDcpWinter.Text = "겨울에 적합한 옷차림입니다.\n 두꺼운 코트, 패딩, 니트와 기모 바지를 입고, \n 추위를 더 타시면 목도리와 장갑을 추천합니다.";

                ResetSpringImgAndTxt();
                ResetSummerImgAndTxt();
                ResetFallImgAndTxt();

                RdoSummer.Checked = false;
                RdoFall.Checked = false;
                RdoSpring.Checked = false;
            }
            else
            {
                ResetWinterImgAndTxt();
            }

            
        }

        private void ResetSpringImgAndTxt()
        {
            PicSpringOTT1.Image = null;
            PicSpringOTT2.Image = null;
            PicSpringOTT3.Image = null;
            PicSpringOTT4.Image = null;
            PicSpringOTT5.Image = null;

            TxtDcpSpring.Text = "";
        }

        private void ResetSummerImgAndTxt()
        {
            PicSummerOTT1.Image = null;
            PicSummerOTT2.Image = null;
            PicSummerOTT3.Image = null;
            PicSummerOTT4.Image = null;
            PicSummerOTT5.Image = null;

            TxtDcpSummer.Text = "";
        }

        private void ResetFallImgAndTxt()
        {
            PicFallOTT1.Image = null;
            PicFallOTT2.Image = null;
            PicFallOTT3.Image = null;
            PicFallOTT4.Image = null;
            PicFallOTT5.Image = null;

            TxtDcpFall.Text = "";
        }

        private void ResetWinterImgAndTxt()
        {
            PicWinterOTT1.Image = null;
            PicWinterOTT2.Image = null;
            PicWinterOTT3.Image = null;
            PicWinterOTT4.Image = null;
            PicWinterOTT5.Image = null;
            PicWinterOTT6.Image = null;

            TxtDcpWinter.Text = "";
        }
    }
}
