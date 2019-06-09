using LabASPNETWeb.Models.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabASPNETWeb.DataRepository.Linq
{
    public class LinqUserRep : LinqBaseRep, IUser
    {
        public LinqUserRep() : base()
        {
            this.connectDataSource();
        }

        public LinqUserRep(string connection_string) : base()
        {
            this.connectDateSource(connection_string);
        }

        public bool activeUser(string username)
        {
            try
            {
                this._context.wpUsers.Where(x => x.username.Equals(username)).SingleOrDefault().activeyn = true;
                this._context.SubmitChanges();

                return true;
            }
            catch(Exception ex)
            {
                AppStoreData.APP_LOGGER.Error(ex);
                return false;
            }
        }

        public bool authenticateUser(string username, string password)
        {
            try
            {
                wpUser u = this._context.wpUsers.Where(x => x.username.Equals(username)).SingleOrDefault();
                return (u.pwd.Equals(EncrytionFactory.Encrypt(password, AppStoreData.ENCRYTION_KEY)));                
            }
            catch (Exception ex)
            {
                AppStoreData.APP_LOGGER.Error(ex);
                return false;
            }
        }

        public bool encrytSavePassword(string username, string password)
        {
            try
            {
                wpUser u = this._context.wpUsers.Where(x => x.username.Equals(username)).SingleOrDefault();
                u.pwd = EncrytionFactory.Encrypt(password, AppStoreData.ENCRYTION_KEY);

                this._context.SubmitChanges();
                return true;
            }
            catch (Exception ex)
            {
                AppStoreData.APP_LOGGER.Error(ex);
                return false;
            }
        }

        public wpUser getUser(string username)
        {
            try
            {
                return this._context.wpUsers.Where(x => x.username.Equals(username)).SingleOrDefault();                
            }
            catch (Exception ex)
            {
                AppStoreData.APP_LOGGER.Error(ex);
                return AppStoreData.NULL_USER;
            }
        }

        public bool inactiveUser(string username)
        {
            try
            {
                this._context.wpUsers.Where(x => x.username.Equals(username)).SingleOrDefault().activeyn = false;
                this._context.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                AppStoreData.APP_LOGGER.Error(ex);
                return false;
            }
        }

        public bool insertUser(wpUser user)
        {
            try
            {
                this._context.wpUsers.InsertOnSubmit(user);
                this._context.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                AppStoreData.APP_LOGGER.Error(ex);
                return false;
            }
        }

        public bool saveLastLogin(string username)
        {
            try
            {
                this._context.wpUsers.Where(x => x.username.Equals(username)).SingleOrDefault().lastlogindt = DateTime.Now;
                this._context.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                AppStoreData.APP_LOGGER.Error(ex);
                return false;
            }
        }

        public bool savePassword(string username, string password)
        {
            throw new NotImplementedException();
        }

        public bool updateUser(wpUser user)
        {
            try
            {
                wpUser u = this._context.wpUsers.Where(x => x.username.Equals(user.username)).SingleOrDefault();
                u.name = user.name;
                u.email = user.email;
                u.lastupddt = DateTime.Now;

                this._context.SubmitChanges();

                return true;
            }
            catch (Exception ex)
            {
                AppStoreData.APP_LOGGER.Error(ex);
                return false;
            }
        }
    }
}