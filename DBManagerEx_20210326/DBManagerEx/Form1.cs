using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBManagerEx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection sqlConn = new SqlConnection();
        SqlCommand sqlcom = new SqlCommand();
       

        private void mnuFileNew_Click(object sender, EventArgs e)  // New 메뉴 생성
        {
            // grid 초기화
            //table 명칭 초기화
            //db 초기화 (sql connection 클로즈)
            dataGridView1.Rows.Clear(); // 그리드는 컬럼이 없는 로우는 존재하지 않음. 생성시 컬럼->로우 / 초기화시 로우 -> 컬럼
            dataGridView1.Columns.Clear();

            sbPanel1.Text = "DB File Name";  // 초기네임 부여. 기존 파일이름 삭제 -> db file name이 들어갈 자리
            sbPanel2.Text = "Table List"; // 초기네임 부여.
            sbPanel2.DropDownItems.Clear();  // 드롭다운아이템들 내용 전체 클리어
            sbPanel3.Text = "Initialized";

            sqlConn.Close();

        }

        private void mnuFileMigration_Click(object sender, EventArgs e)
        {
            //파일을 열어서 파일 셀렉트 -> 데이터그리드로 가져오기
            if(openFileDialog1.ShowDialog() != DialogResult.OK) return;
            // 파일 오픈 -> 파일 읽어오기 (streamreader)
            StreamReader sr = new StreamReader(openFileDialog1.FileName); // streamreader로 열을 파일의 경로 (오픈파일다이얼로그의 파일네임)
            string buf = sr.ReadLine(); // 한줄 읽기 / 첫번재 라인에는 각 컬럼의 HeaderText가 들어가 있음. -> buf에 저장
            string[] sARR = buf.Split(','); // 라인 하나씩 분리하여 그 컬럼의 갯수만큼 생성 -> 컬럼 베드 표시 / buf에 있는 라인을 스플릿 함수를 이용하여 아이템별로 ',' 구분자로 구분되어 있음 -> sArr 스트림 어레이에 저장


        }
    }
}
