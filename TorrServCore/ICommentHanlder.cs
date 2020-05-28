using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TorrServData.Models;

namespace TorrServCore
{
    public interface ICommentHanlder
    {
       void  GetCommentIndex(TorrentMovie movie);
    }
}
