using LabASPNETWeb.Models.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LabASPNETWeb.DataRepository.Linq
{
    public class LinqBaseRep : IConnect
    {
        protected DBDataContext _context;        
        protected ConnectionState _status_cd;

        public LinqBaseRep()
        {

        }        

        private int doConnect(string conn_string)
        {
            try
            {
                this._context = new DBDataContext(AppStoreData.CONN_STR);
                this._status_cd = this._context.Connection.State;
                if (this._status_cd.Equals(ConnectionState.Open) || this._status_cd.Equals(ConnectionState.Closed))
                    return 1;

                //? Not handle if connect is still broken or be closed
                return 0;
            }
            catch (Exception ex)
            {
                AppStoreData.APP_LOGGER.Error("LingBaseRep Error");
                AppStoreData.APP_LOGGER.Error(ex);
                return -1;
            }
        }

        public int connectDataSource()
        {
            return doConnect(AppStoreData.CONN_STR);
        }

        public int connectDateSource(string connection_string)
        {
            return doConnect(connection_string);
        }

        public ConnectionState getStatus()
        {
            return this._status_cd;
        }
    }
}