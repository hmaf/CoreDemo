using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class NewsletterManeger:INewsletterService
    {
        private INewsletterDal _newsletter;

        public NewsletterManeger(INewsletterDal newsletter)
        {
            _newsletter = newsletter;
        }

        public void AddNewsletter(Newsletter newsletter)
        {
            _newsletter.Insert(newsletter);
        }
    }
}
