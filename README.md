# Bill-Generator
A micro-service that calculates the customer account value.

## Domain UML
![CustomerBill](https://user-images.githubusercontent.com/13722768/64496956-8b866b80-d280-11e9-82a4-ed2cf361d97b.jpg)

## Main Business Rule
CustomerBillBusiness.cs
```cs
/// <summary>
        /// The method BillCalculator will return a float value according to business rules.
        /// </summary>
        /// <param name="customerBill"></param>
        /// <returns></returns>
        public CustomerBill Insert(CustomerBill customerBill)
        {
            CustomerBill customerBillUpdated = customerBill;
            try
            {
                customerBillUpdated.billValue = BillCalculator(customerBill);
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception caught.", e);
            }

            return _customerBillRepository.Insert(customerBill);
        }

        private float BillCalculator(CustomerBill cb)
        {
            float totalBill = 0;

            foreach (Perform perform in cb.performList)
            {
                switch (perform.performType)
                {
                    case PerformType.Comedy:
                        totalBill += 30000;
                        if( perform.audience - 20 > 0 ) totalBill += (perform.audience - 20) * 500;
                        break;
                    case PerformType.Tragedy:
                        totalBill += 40000;
                        if (perform.audience - 30 > 0) totalBill += (perform.audience - 30) * 1000;
                        break;
                    default:
                        Console.WriteLine("Unregistered performance");
                        break;
                }
            }
            return totalBill;
        }
```