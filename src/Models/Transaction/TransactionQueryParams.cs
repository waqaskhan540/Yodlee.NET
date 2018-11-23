using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yodlee.Models.Transaction
{
    public class TransactionQueryParams
    {
        public string container { get; set; }
        public string baseType { get; set; }
        public string keyword { get; set; }
        public string accountId { get; set; }
        public DateTime? fromDate { get; set; }
        public DateTime? toDate { get; set; }
        public List<long> categoryId { get; set; }
        public List<long> highLevelCategoryId { get; set; }

        public string type { get; set; }
        public string categoryType { get; set; }
        public string accountReconType { get; set; }
        public int? skip { get; set; }
        public int? top { get; set; }
        public string ToQueryString()
        {           
            var queryString = string.Empty;
            foreach(var property in GetType().GetProperties())
            {
                var value = property.GetValue(this, null);
                if(value != null)
                {
                    if(property.Name == "fromDate" || property.Name == "toDate")
                    {
                        value = DateTime.Parse(value.ToString()).ToString("yyyy-MM-dd");
                    }
                    if (property.Name == "categoryId" || property.Name == "highLevelCategoryId")
                    {
                        var values=(List<long>) value; 
                        if (values.Count > 0)
                        {
                            value = string.Join(",", values);
                            queryString += property.Name + "=" + value.ToString() + "&";
                        }
                    }
                    else
                    {
                        queryString += property.Name + "=" + value.ToString() + "&";
                    }
                }
            }

            return queryString.TrimEnd('&');
        }

    }

    public enum Type
    {
        SEE,
        SWEEP
    }
    public enum CategoryType
    {
        UNCATEGORIZE,
        INCOME,
        TRANSFER,
        EXPENSE,
        DEFERRED_COMPENSATION
    }

    public enum AccountReconType
    {
        UNRECONCILED,
        RECONCILED
    }
    public enum BaseType
    {
        DEBIT,
        CREDIT
    }
    public enum Container
    {
        bank,
        creditCard,
        investment,
        insurance,
        loan
    }
}
