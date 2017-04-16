using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.IO;
namespace 笔记管理系统
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
     
        private void btnBack_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            btnShowReg.Visible = true;
            btnShowLogin.Visible = true;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            etPW.Visible = false;
            etPW_login.Visible = false;
            etPWcom.Visible = false;
            etUsername.Visible = false;
            etUsername_Login.Visible = false;
            btnLogin_Log.Visible = false;
            btnRegist.Visible = false;

            btnBack.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            btnBack_log.Visible = false;
        }

        private void Regist_Load(object sender, EventArgs e)
        {


            




            label4.Visible = true;
            btnShowReg.Visible = true;
            btnShowLogin.Visible = true;

            label1.Visible =false;
            label2.Visible = false;
            label3.Visible = false;
            etPW.Visible = false;
            etPW_login.Visible = false;
            etPWcom.Visible = false;
            etUsername.Visible = false;
            etUsername_Login.Visible = false;
            btnLogin_Log.Visible = false;
            btnRegist.Visible = false;

            btnBack.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            btnBack_log.Visible = false;
        }

        private void btnShowReg_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            etUsername.Visible = true;
            label2.Visible = true;
            etPW.Visible = true;
            label3.Visible = true;
            etPWcom.Visible = true;
            btnBack.Visible = true;
            btnRegist.Visible = true;

            label4.Visible = false;
            btnShowReg.Visible = false;
            btnShowLogin.Visible = false;
            etPW_login.Visible = false;
            etUsername_Login.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            
        }

        private void btnShowLogin_Click(object sender, EventArgs e)
        {
            etPW_login.Visible = true;
            etUsername_Login.Visible = true;
            btnLogin_Log.Visible = true;
            btnBack_log.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

            label4.Visible = false;
            btnShowReg.Visible = false;
            btnShowLogin.Visible = false;
            label1.Visible = false;
            etUsername.Visible = false;
            label2.Visible = false;
            etPW.Visible = false;
            label3.Visible = false;
            etPWcom.Visible = false;
            btnBack.Visible = false;
            btnRegist.Visible = false;
        }

        private void btnBack_log_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            btnShowReg.Visible = true;
            btnShowLogin.Visible = true;

            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            etPW.Visible = false;
            etPW_login.Visible = false;
            etPWcom.Visible = false;
            etUsername.Visible = false;
            etUsername_Login.Visible = false;
            btnLogin_Log.Visible = false;
            btnRegist.Visible = false;

            btnBack.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            btnBack_log.Visible = false;
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            String strConnection = @"Server=DESKTOP-V900MGO;";
            strConnection += "initial catalog=NoteDB;";
            strConnection += "user id=sa;";
            strConnection += "password=lj123456;";
            SqlConnection con = new SqlConnection(strConnection);

            String pw = etPW.Text.Trim();
            String pw_con = etPWcom.Text.Trim();
            String name = etUsername.Text.Trim();
            if (!name.Equals(""))
            {
                if (pw.Equals(pw_con) && pw!="")
                {
                    
                    String insert = "insert into Users (username,password) values('"+name+"','"+pw+"')";
                    SqlCommand command = new SqlCommand(insert, con);
                    try//异常处理
                    {
                        con.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("注册成功！");
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("{0} Exception caught.", ex);
                        MessageBox.Show(ex.Message);
                    }
                }
                else if(pw.Equals("")){
                   MessageBox.Show("密码不能为空");
                }
                else
                {
                    MessageBox.Show("密码不一致");
                }

            }
            else {
                MessageBox.Show("用户名不能为空！");
            }
            
            
        }
        //开启一个线程，当登录成功后就自动转到主界面
        public void startMain()
        {
            Application.Run(new Main());
        }
        private void btnLogin_Log_Click(object sender, EventArgs e)
        {
            String strConnection = @"Server=DESKTOP-V900MGO;";
            strConnection += "initial catalog=NoteDB;";
            strConnection += "user id=sa;";
            strConnection += "password=lj123456;";
            SqlConnection con = new SqlConnection(strConnection);
            con.Open();
            String insert = "select *from Users";
            SqlCommand command = new SqlCommand(insert, con);
            SqlDataReader reader = command.ExecuteReader();
          
            // 判断数据是否读到尾. 
            while (reader.Read())
            {
                
                String s = Convert.ToString(reader[0]);
                String pw = Convert.ToString(reader[1]);

                string username = etUsername_Login.Text.Trim();
                if (username.Equals(s.Trim()) && etPW_login.Text.Trim().Equals(pw.Trim()))
                {

                    File.WriteAllText(@"D:\1.txt", username);

                    Thread t = new Thread(startMain);
                    t.Start();                 
                    this.Close();
                    reader.Close();
                    con.Close();
                    return;
                }
               
            }
            MessageBox.Show("用户名或密码错误");
           
            // 一定要关闭 reader 对象.
            reader.Close();
            con.Close();
          
        }
    }
}
