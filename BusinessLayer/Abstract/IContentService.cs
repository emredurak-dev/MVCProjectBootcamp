using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetContent(string p);
        List<Content> GetContentByWriter(int id);
        List<Content> GetContentById(int id);
        void ContentAdd(Content content);
        Category GetById(int id);
        void ContentDelete(Content content);
        void ContentUpdate(Content content);
    }
}
