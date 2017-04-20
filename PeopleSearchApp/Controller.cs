using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PeopleSearchApp
{
    class Controller
    {
        private MainWindow view;
        PeopleDb db = new PeopleDb();

        public Controller(MainWindow mainWindow)
        {
            view = mainWindow;
        }

        public void runSearch(string query)
        {
            using (var db = new PeopleDb())
            {
                var query = from p in db.People
                            orderby p.FirstName
                            select p;

                foreach (var item in query)
                {
                    string firstName = item.FirstName;
                    string lastName = item.LastName;

                    if (firstName.Equals(query) || lastName.Equals(query))
                    {

                    }
                }
            }

            view.viewDatabase();
        }

        public void anotherSearch()
        {
            view.viewSearchForm();
        }
    }
}
