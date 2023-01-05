using crudTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace crudTest.Services
{
    public class ContentService
    {
        private ContentDao contentDao;
        public ContentService(ContentDao contentDao)
        {
            this.contentDao = contentDao;
        }
        
        public List<Content> ContentList()
        {
            List<Content> contentList = contentDao.selectContentList();
            if(contentList.Count > 0)
            {
                contentList = contentList.OrderBy(x => x.name).ToList();
            }
            return contentList;
        }
    }
}
