using LabASPNETWeb.DataRepository.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabASPNETWeb.DataRepository
{
    public interface INews
    {
        List<wpNew> getNews();

        List<wpNew> getNews(bool isHomepage);

        List<wpNew> getNews(string user_posted);

        wpNew getNewsDetail(int id);

    }
}
