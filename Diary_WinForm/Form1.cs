using Microsoft.VisualBasic;

namespace Diary_WinForm
{
    public partial class Form1 : Form
    {
        string[] i = new string[366];
        string stryear = DateTime.Now.Year.ToString();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var datTim1 = Convert.ToDateTime("#1/1/" + stryear + "#");
            DateTime datTim2 = this.dtpTime.Value;
            int wD = Convert.ToInt32(DateAndTime.DateDiff(DateInterval.Day, datTim1, datTim2, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
            i[wD] = this.txtMemo.Text;
            if(i[wD].Length > 0)
            {
                MessageBox.Show("일기가 정상적으로 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtMemo.Clear();
            }
        }

        private void dtpTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime datTim1 = Convert.ToDateTime("#1/1/" + stryear + "#");
            DateTime datTim2 = this.dtpTime.Value;
            int wD = Convert.ToInt32(DateAndTime.DateDiff(DateInterval.Day, datTim1, datTim2, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
            this.txtMemo.Text = i[wD];
        }
    }
}