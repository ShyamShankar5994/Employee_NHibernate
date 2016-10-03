using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;


namespace NhibernateTutorial
{
    class NhibernateDataProvider
    {
        public Employee getEmployeeById(int employeeId)
        {
            ISessionFactory sessionFactory = new Configuration().Configure().BuildSessionFactory();

            ISession session = sessionFactory.OpenSession();

            return session.Get<Employee>(employeeId);
        }
    }
}
