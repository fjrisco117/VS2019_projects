using System;
using Recurly;
using Recurly.Resources;

namespace showamount
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Recurly.Client("e9922993342845dbbc583c145b2ab811");

            var subscriptionUuid = "50b8aee7610eefeb55374a4996838338";
            var change = new SubscriptionChange
            {
                TimeFrame = SubscriptionChange.ChangeTimeframe.Now,
                // or TimeFrame = SubscriptionChange.ChangeTimeframe.Renewal
                // or TimeFrame = SubscriptionChange.ChangeTimeframe.BillDate
                PlanCode = "silver",
                Quantity = 2
            };

            // perform the update operation
            Subscription.ChangeSubscription(subscriptionUuid, change);

        }
    }
}

