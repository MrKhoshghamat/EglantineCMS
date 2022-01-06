using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PageCommentRepository : IPageCommentRepository
    {
        private EglantineCMSContext db;
        public PageCommentRepository(EglantineCMSContext context)
        {
            db = context;
        }
        public bool AddComment(PageComment comment)
        {
            try
            {
                db.PageComments.Add(comment);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<PageComment> GetCommentsByNewsId(int pageId)
        {
            return db.PageComments.Where(c => c.PageID == pageId);
        }
    }
}
