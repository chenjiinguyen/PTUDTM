using BLL;
using DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PTUDTM.form
{
    public partial class EditUser : UserControl
    {
        string iduser;
        public EditUser()
        {
            InitializeComponent();
            this.SetTopLevel(false);
        }

        public EditUser(string iduser)
        {
            this.iduser = iduser;
            InitializeComponent();
            this.SetTopLevel(false);
        }

        private void EditUser_Load(object sender, EventArgs e)
        {
            user user = Businesses.user.GetUsername(iduser);
            List<usergroup> usergroups = Businesses.usergroup.GetAll();

            var bindingSource1 = new BindingSource();
            bindingSource1.DataSource = usergroups;

            cboUserGroup.DataSource = bindingSource1.DataSource;
            cboUserGroup.DisplayMember = "name";
            cboUserGroup.ValueMember = "idgroup";

            cboUserGroup.SelectedValue = user.usergroup;
            txtUsername.Text = user.username;
            txtEmail.Text = user.email;
            guna2DateTimePicker1.Value = user.birthday;
            txtAvt.Text = user.avatar;
            cboGender.Text = user.gender;
            txtName.Text = user.name;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            DateTime birthday = guna2DateTimePicker1.Value;
            string avatar = txtAvt.Text;
            string name = txtName.Text;
            string usergroup = cboUserGroup.SelectedValue.ToString();
            string gender = cboGender.Text;

            if (email.Trim().Length == 0 || avatar.Trim().Length == 0 || name.Trim().Length == 0)
            {
                MessageBox.Show("Vui lòng không để trống!", "Thông báo");

            }
            else
            {
                string regexLink = @"^(http(s?):)([/|.|\w|\s|-])*\.(?:jpg|jpeg|png)$";
                bool match = Regex.IsMatch(avatar, regexLink);
                if (match || avatar.Contains("https://ui-avatars.com"))
                {
                    user user = new user();
                    user.email = email;
                    user.avatar = avatar;
                    user.name = name;
                    user.birthday = birthday;
                    user.usergroup = usergroup;
                    user.gender = gender;

                    bool update = Businesses.user.UpdateUser(iduser, user);
                    if (!update)
                    {
                        MessageBox.Show("Thất bại", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Thành công", "Thông báo");
                        Program.LoadForm(new UsersList());
                        ((Form)this.TopLevelControl).Close();
                    }

                }
                else
                {
                    MessageBox.Show("Link ảnh không hợp lệ", "Thông báo");
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Close();
        }
    } }
