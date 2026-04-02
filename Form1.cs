namespace LoginScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 시작할 때 삭제/보기 버튼들은 숨겨두는 것이 깔끔합니다 (선택사항)
            btnDeleteID.Visible = false;
            btnDeletePW.Visible = false;
            btnShowPW.Visible = false;
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            if (txtID.Text == "아이디")
            {
                txtID.Text = "";
                txtID.ForeColor = Color.Black;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                txtID.Text = "아이디";
                txtID.ForeColor = Color.Silver;
                btnDeleteID.Visible = false; // 글자가 없으면 X버튼 숨김
            }
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            // Placeholder인 "아이디"가 아닐 때만 X버튼 표시
            btnDeleteID.Visible = (txtID.Text.Length > 0 && txtID.Text != "아이디");
        }

        private void btnDeleteID_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtID_Leave(null, null); // 삭제 후 Placeholder가 나타나도록 강제 호출
            txtID.Focus();
        }

        private void btnDeleteID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPW_Enter(object sender, EventArgs e)
        {
            if (txtPW.Text == "패스워드")
            {
                txtPW.Text = "";
                txtPW.ForeColor = Color.Black;
                txtPW.UseSystemPasswordChar = true;
            }
        }

        private void txtPW_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPW.Text))
            {
                txtPW.UseSystemPasswordChar = false;
                txtPW.Text = "패스워드";
                txtPW.ForeColor = Color.Silver;
                btnDeletePW.Visible = false;
                btnShowPW.Visible = false;
            }
        }

        private void txtPW_TextChanged(object sender, EventArgs e)
        {
            bool hasText = (txtPW.Text.Length > 0 && txtPW.Text != "패스워드");
            btnDeletePW.Visible = hasText;
            btnShowPW.Visible = hasText;
        }

        private void btnDeletePW_Click(object sender, EventArgs e)
        {
            txtPW.Clear();
            txtPW_Leave(null, null); // 삭제 후 Placeholder 및 ● 해제 로직 실행
            txtPW.Focus();
        }

        private void btnShowPW_Click(object sender, EventArgs e)
        {
            // Placeholder 상태일 때는 동작하지 않도록 방어 코드
            if (txtPW.Text == "패스워드") return;

            txtPW.UseSystemPasswordChar = !txtPW.UseSystemPasswordChar;

            // 텍스트박스 포커스가 풀리지 않게 유지 (UX 향상)
            txtPW.Focus();
            // 커서를 마지막 글자 뒤로 이동
            txtPW.SelectionStart = txtPW.Text.Length;
        }

        string myID = "admin";
        string myPW = "superman";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputID = txtID.Text;
            string inputPW = txtPW.Text;
            if (inputID == myID && inputPW == myPW)
            {
                MessageBox.Show("로그인성공!");
            }
            else
            {
                //MessageBox.Show("로그인실패~"); 
                //MessageBox.Show("아이디 또는 패스워드가 잘못 입력되었습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblErrorMsg.Visible = true;
            }
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 기본비프음방지
                txtPW.Focus(); // 패스워드입력창이포커스를갖게끔
            }
        }

        private void txtPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // 기본비프음방지
                btnLogin.PerformClick(); // 버튼이눌린것처럼만들기
            }
        }
    }
}
