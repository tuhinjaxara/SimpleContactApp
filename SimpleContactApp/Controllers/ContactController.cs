

using System;

namespace SimpleContactApp.Controllers
{
    using DataAccessLayer;
    using Models;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web.Http;

    public class ContactController : ApiController
    {
        DataContext db = new DataContext();
        [Route("api/Contact/search")]
        [HttpGet]
        public IEnumerable<Contact> SearchContactss(string searchText)
        {
            searchText = searchText ?? "";
            return db.Contacts
                 .Where(x => x.Name.Contains(searchText) ||
                         x.City.Contains(searchText)
                 )
                 .Take(20);
        }

        // GET: api/Contact/pageSize/pageNumber/orderBy(optional) 
        [Route("api/Contact/searchwithpagination"), HttpGet]
        public IHttpActionResult Get(string searchText,int pageSize, int pageNumber, string orderBy = "")
        {
            searchText = searchText ?? "";
            var totalCount = db.Contacts.Count();
            var totalPages = Math.Ceiling((double)totalCount / pageSize);

            var contactQuery = db.Contacts;

            var contacts = contactQuery
                .Where(x => x.Name.Contains(searchText) ||
                                                   x.City.Contains(searchText)
                )
                .OrderBy(c => c.Name)
                .Skip((pageNumber - 1)*pageSize)
                .Take(pageSize)
                .ToList();

            var result = new
            {
                TotalCount = totalCount,
                totalPages = totalPages,
                Contacts = contacts
            };

            return Ok(result);
        }

        [Route("api/Contact/new")]
        [HttpGet]
        public Contact NewContact()
        {
            return new Contact();
        }

        [Route("api/Contact/detail/{id}")]
        [HttpGet]
        public Contact GetDetail(int Id)
        {
            return db.Contacts.FirstOrDefault(x => x.Id == Id);
        }

        [Route("api/Contact/Save")]
        [HttpPost]
        public Contact SaveContact(Contact contact)
        {

            if (contact.Id > 0)
            {
                var dbContact = db.Contacts.FirstOrDefault(x => x.Id == contact.Id);
                dbContact.Name = contact.Name;
                dbContact.Address = contact.Address;
                dbContact.City = contact.City;
                dbContact.ZipCode = contact.ZipCode;
                db.SaveChanges();
                return dbContact;
            }
            else
            {
                db.Contacts.Add(contact);
                db.SaveChanges();
                return contact;
            }
        }

        [Route("api/Contact/delete/{id}")]
        [HttpPost]
        public void DeleteContact(int Id)
        {
            var contact = db.Contacts.FirstOrDefault(x => x.Id == Id);
            db.Contacts.Remove(contact);
            db.SaveChanges();
        }
    }
}
