using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabASPNETWeb.DataRepository
{
    public interface IConnect
    {
        /* ! Return code:
         * 0: doing nothing
         * 1: done ! without error
         * 2: -1 with error and exception message come with log4net
         */
        int connectDataSource();

        int connectDateSource(string connection_string);

        ConnectionState getStatus();

    }
}
