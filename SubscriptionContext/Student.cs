using Conceitos_POO.ShareContext;
using System.Collections.Generic;
using System.Linq;
using Conceitos_POO.NotificationContext;

namespace Conceitos_POO.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subcriptions = new List<Subscription>();
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public User User{ get; set; }

        public IList<Subscription> Subcriptions { get; set; } 

        public void CreateSubscription(Subscription subscription)
        {
            if(IsPremium)
            {
                AddNotification(new Notification("Premium","O aluno é premium"));
                return;
            }

            Subcriptions.Add(subscription);
        }
        public bool IsPremium => Subcriptions.Any(x => !x.IsInactive);
    }
}