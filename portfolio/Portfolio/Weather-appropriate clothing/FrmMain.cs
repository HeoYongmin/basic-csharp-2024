namespace Weather_appropriate_clothing
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            RadioButton RdoSummer = new RadioButton();
            RdoSummer.Text = "����";
            RdoSummer.CheckedChanged += RdoSummer_CheckedChanged;
            // RdoSummer.Location = new System.Drawing.Point(20, 20);
        }

        private void RdoSummer_CheckedChanged(object sender, EventArgs e)
        {
            // ���� ���� ��ư�� ���õ� �� ����Ǵ� �ڵ�
            if (RdoSummer.Checked)
            {
                // ���� ������ �̹����� ������ ǥ��
                PicSummerImg.Image = Properties.Resources.summer_outfit;
                TxtDcpSummer.Text = "������ ������ �������Դϴ�.\n���� Ƽ������ �ݹ����� �԰�,\n������ �ÿ��� �����۸� ��������.";
            }
        }
    }
}