using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PesalinkLiveTester.TranscationClasses
{
    public class Credit_CreditTransfer
    {
        public string OriginalmessageId { get; set; }
        public string DebtorPhonNb { get; set; }
        public string CdtrBankCode { get; set; }
        public string DbtrName { get; set; }
        public string DbtrAcct { get; set; }
        public string DbtrAcctName { get; set; }
        public string amount { get; set; }
        public string EndtoEndId { get; set; }
    }
    public class AccountVerification
    {
        public string BackCode { get; set; }
        public string AccountNo { get; set; }
    }
    public class PaymentStatus
    {
        public string OriginalmessageId { get; set; }
        public string DebtorPhonNb { get; set; }
        public string CdtrBankCode { get; set; }
        public string DbtrName { get; set; }
        public string DbtrAcct { get; set; }
        public string DbtrAcctName { get; set; }
        public string amount { get; set; }
        public string EndtoEndId { get; set; }
    }
}
