using LabASPNETWeb.Models.Global;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace LabASPNETWeb.DataRepository.Linq
{
    public class LinqNewsRep : LinqBaseRep, INews
    {
        public LinqNewsRep() : base()
        {
            //! Do connect to server
            this.connectDataSource();
        }

        public LinqNewsRep(string connection_string) : base()
        {
            this.connectDateSource(connection_string);
        }

        public List<wpNew> getNews()
        {
            try
            {
                if (this._status_cd.Equals(ConnectionState.Open))
                {
                    return this._context.wpNews.Where(x => x.activeyn.Equals(true)).ToList();
                }
                else
                {
                    AppStoreData.APP_LOGGER.Error(typeof(LinqNewsRep));
                    AppStoreData.APP_LOGGER.Error("CONN N/A");
                    return new List<wpNew>();
                }
            }
            catch(Exception ex)
            {
                AppStoreData.APP_LOGGER.Error(typeof(LinqNewsRep));
                AppStoreData.APP_LOGGER.Error(ex);
                return new List<wpNew>();
            }
        }

        public List<wpNew> getNews(string user_posted)
        {
            try
            {
                if (this._status_cd.Equals(ConnectionState.Open))
                {
                    return this._context.wpNews.Where(x => x.activeyn.Equals(true) && x.usr_create.Equals(user_posted)).ToList();
                }
                else
                {
                    AppStoreData.APP_LOGGER.Error(typeof(LinqNewsRep));
                    AppStoreData.APP_LOGGER.Error("CONN N/A");
                    return new List<wpNew>();
                }
            }
            catch (Exception ex)
            {
                AppStoreData.APP_LOGGER.Error(typeof(LinqNewsRep));
                AppStoreData.APP_LOGGER.Error(ex);
                return new List<wpNew>();
            }
        }

        public List<wpNew> getNews(bool isHomepage)
        {
            try
            {                
               return this._context.wpNews.Where(x => x.activeyn.Equals(true) && x.homepageyn.Equals(true)).ToList();
               
            }
            catch (Exception ex)
            {
                AppStoreData.APP_LOGGER.Error(typeof(LinqNewsRep));
                AppStoreData.APP_LOGGER.Error(ex);
                return new List<wpNew>();
            }
        }

        public wpNew getNewsDetail(int id)
        {
            try
            {
                if (this._status_cd.Equals(ConnectionState.Open))
                {
                    return this._context.wpNews.Where(x => x.activeyn.Equals(true) && x.id.Equals(id)).SingleOrDefault();
                }
                else
                {
                    AppStoreData.APP_LOGGER.Error(typeof(LinqNewsRep));
                    AppStoreData.APP_LOGGER.Error("CONN N/A");
                    //? Expect to return non-null object to application, to count on NULLPOINTEREXCEPTION
                    return new wpNew { id = -1 };
                }
            }
            catch (Exception ex)
            {
                AppStoreData.APP_LOGGER.Error(typeof(LinqNewsRep));
                AppStoreData.APP_LOGGER.Error(ex);
                //! define default null value to object
                return AppStoreData.NULL_NEWS;
            }
        }
    }
}