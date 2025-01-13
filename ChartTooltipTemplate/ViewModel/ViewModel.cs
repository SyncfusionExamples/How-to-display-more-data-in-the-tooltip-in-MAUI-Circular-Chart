using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartTooltipTemplate
{
    public class MonthlyExpensesViewModel
    {
        public List<ExpenseModel> Data { get; set; }

        public MonthlyExpensesViewModel()
        {
            double totalAmount = 0;
            Data = new List<ExpenseModel>()
            {
                new ExpenseModel() { Category = "Rent", Amount = 1200 },
                new ExpenseModel() { Category = "Utilities", Amount = 300 },
                new ExpenseModel() { Category = "Groceries", Amount = 450 },
                new ExpenseModel() { Category = "Transportation", Amount = 200 },
                new ExpenseModel() { Category = "Entertainment", Amount = 150 }
            };

            totalAmount = Data.Sum(item => item.Amount);
            foreach (var item in Data)
            {
                item.Percentage = (item.Amount / totalAmount) * 100;
            }
        }
    }

}
