using LabASPNETWeb.DataRepository.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabASPNETWeb.DataRepository
{
    public interface IUser
    {
        wpUser getUser(string username);

        bool authenticateUser(string username, string password);

        bool encrytSavePassword(string username, string password);

        bool savePassword(string username, string password);

        bool insertUser(wpUser user);

        bool updateUser(wpUser user);

        bool inactiveUser(string username);

        bool activeUser(string username);

        bool saveLastLogin(string username);
    }
}
