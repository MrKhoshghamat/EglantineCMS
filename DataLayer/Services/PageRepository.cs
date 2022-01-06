using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class PageRepository : IPageRepository
    {
        private EglantineCMSContext db;

        public PageRepository(EglantineCMSContext context)
        {
            db = context;
        }
        public bool DeletePage(Page page)
        {
            try
            {
                db.Entry(page).State = EntityState.Deleted;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeletePage(int pageId)
        {
            var page = GetPageById(pageId);
            DeletePage(page);
            return true;
        }

        public void Dispose()
        {
            db.Dispose();
        }

        public IEnumerable<Page> GetAllPage()
        {
            return db.Pages;
        }

        public Page GetPageById(int pageId)
        {
            return db.Pages.Find(pageId);
        }

        public bool InsertPage(Page page)
        {
            try
            {
                db.Pages.Add(page);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Page> LatestNews(int take = 4)
        {
            return db.Pages.OrderByDescending(p=>p.CreationDateTime).Take(take);
        }

        public IEnumerable<Page> PagesInSlider()
        {
            return db.Pages.Where(p => p.ShownInSlider == true);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public IEnumerable<Page> SearchPage(string search)
        {
            return db.Pages.Where(
                p => 
                p.Title.Contains(search) || 
                p.ShortDescription.Contains(search) || 
                p.Tags.Contains(search) || 
                p.Text.Contains(search)).Distinct();
        }

        public IEnumerable<Page> ShowPageByGroupId(int groupId)
        {
            return db.Pages.Where(p => p.GroupID == groupId);
        }

        public IEnumerable<Page> TopNews(int take = 4)
        {
            return db.Pages.OrderByDescending(p => p.Visit).Take(take);
        }

        public bool UpdatePage(Page page)
        {
            try
            {
                db.Entry(page).State = EntityState.Modified;
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
