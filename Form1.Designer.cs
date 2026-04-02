namespace LoginScreen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAppName = new Label();
            btnLogin = new Button();
            txtPW = new TextBox();
            txtID = new TextBox();
            lblErrorMsg = new Label();
            btnDeleteID = new Button();
            btnShowPW = new Button();
            btnDeletePW = new Button();
            SuspendLayout();
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("한컴 말랑말랑 Bold", 48F, FontStyle.Bold, GraphicsUnit.Point, 129);
            lblAppName.Location = new Point(251, 41);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(306, 124);
            lblAppName.TabIndex = 0;
            lblAppName.Text = "Login";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ActiveBorder;
            btnLogin.Font = new Font("한컴 말랑말랑 Regular", 28F, FontStyle.Regular, GraphicsUnit.Point, 129);
            btnLogin.Location = new Point(241, 503);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(330, 139);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "로그인";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPW
            // 
            txtPW.BackColor = SystemColors.Window;
            txtPW.Font = new Font("한컴 말랑말랑 Regular", 28F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtPW.ForeColor = Color.Silver;
            txtPW.Location = new Point(118, 329);
            txtPW.Name = "txtPW";
            txtPW.Size = new Size(620, 80);
            txtPW.TabIndex = 3;
            txtPW.Text = "패스워드";
            txtPW.TextChanged += txtPW_TextChanged;
            txtPW.Enter += txtPW_Enter;
            txtPW.KeyDown += txtPW_KeyDown;
            txtPW.Leave += txtPW_Leave;
            // 
            // txtID
            // 
            txtID.BackColor = SystemColors.Window;
            txtID.Font = new Font("한컴 말랑말랑 Regular", 28F, FontStyle.Regular, GraphicsUnit.Point, 129);
            txtID.ForeColor = Color.Silver;
            txtID.Location = new Point(118, 208);
            txtID.Name = "txtID";
            txtID.Size = new Size(620, 80);
            txtID.TabIndex = 2;
            txtID.Text = "아이디";
            txtID.TextChanged += txtID_TextChanged;
            txtID.Enter += txtID_Enter;
            txtID.KeyDown += txtID_KeyDown;
            txtID.Leave += txtID_Leave;
            // 
            // lblErrorMsg
            // 
            lblErrorMsg.AutoSize = true;
            lblErrorMsg.Font = new Font("한컴 말랑말랑 Regular", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            lblErrorMsg.ForeColor = Color.Red;
            lblErrorMsg.Location = new Point(118, 415);
            lblErrorMsg.Name = "lblErrorMsg";
            lblErrorMsg.Size = new Size(393, 31);
            lblErrorMsg.TabIndex = 4;
            lblErrorMsg.Text = "아이디 또는 비밀번호가 잘못되었습니다.";
            lblErrorMsg.Visible = false;
            // 
            // btnDeleteID
            // 
            btnDeleteID.Location = new Point(687, 229);
            btnDeleteID.Name = "btnDeleteID";
            btnDeleteID.Size = new Size(41, 34);
            btnDeleteID.TabIndex = 5;
            btnDeleteID.Text = "×";
            btnDeleteID.UseVisualStyleBackColor = true;
            btnDeleteID.TextChanged += btnDeleteID_TextChanged;
            btnDeleteID.Click += btnDeleteID_Click;
            // 
            // btnShowPW
            // 
            btnShowPW.Location = new Point(639, 350);
            btnShowPW.Name = "btnShowPW";
            btnShowPW.Size = new Size(42, 34);
            btnShowPW.TabIndex = 6;
            btnShowPW.Text = "👁";
            btnShowPW.UseVisualStyleBackColor = true;
            btnShowPW.Click += btnShowPW_Click;
            // 
            // btnDeletePW
            // 
            btnDeletePW.Location = new Point(687, 350);
            btnDeletePW.Name = "btnDeletePW";
            btnDeletePW.Size = new Size(41, 34);
            btnDeletePW.TabIndex = 7;
            btnDeletePW.Text = "×";
            btnDeletePW.UseVisualStyleBackColor = true;
            btnDeletePW.Click += btnDeletePW_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 684);
            Controls.Add(btnDeletePW);
            Controls.Add(btnShowPW);
            Controls.Add(btnDeleteID);
            Controls.Add(lblErrorMsg);
            Controls.Add(txtID);
            Controls.Add(txtPW);
            Controls.Add(btnLogin);
            Controls.Add(lblAppName);
            Name = "Form1";
            Text = "Login Screen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAppName;
        private Button btnLogin;
        private TextBox txtPW;
        private TextBox txtID;
        private Label lblErrorMsg;
        private Button btnDeleteID;
        private Button btnShowPW;
        private Button btnDeletePW;
    }
}
