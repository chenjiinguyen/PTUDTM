using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Model
{
    public class UserModel
    {
        string username, email, name, gender, usergroup, avatar;

        public string Avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }

        public string Usergroup
        {
            get { return usergroup; }
            set { usergroup = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        DateTime birthday, createdAt, updatedAt;

        public DateTime UpdatedAt
        {
            get { return updatedAt; }
            set { updatedAt = value; }
        }

        public DateTime CreatedAt
        {
            get { return createdAt; }
            set { createdAt = value; }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        int point;

        public int Point
        {
            get { return point; }
            set { point = value; }
        }

        public UserModel() { }

        public UserModel(string pUsername, string pEmail, string pName, string pGender, string pUsergroup, string pAvatar, DateTime pBirthday, DateTime pCreatedAt, DateTime pUpdatedAt, int pPoint) {
            username = pUsername;
            email = pEmail;
            name = pName;
            gender = pGender;
            usergroup = pUsergroup;
            avatar = pAvatar;
            birthday = pBirthday;
            createdAt = pCreatedAt;
            updatedAt = pUpdatedAt;
            point = pPoint;
        }
    }
}
