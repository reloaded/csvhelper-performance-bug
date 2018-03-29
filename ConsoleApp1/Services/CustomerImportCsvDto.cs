using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1.Services
{
    /// <summary>
    /// Represents a row in the Customer Import CSV file.
    /// </summary>
    /// <remarks>Please keep the order of the class properties in the same order as the CSV
    /// columns for easier on-going maintenance.</remarks>
    /// <remarks> Do not change any property names below unless the column names are also changed 
    /// in the CSV.</remarks>
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class CustomerImportCsvRowDto
    {
        public int CsvRowNumber { get; set; }
        public string AccountNumber { get; set; }
        public bool MasterCustomerDetailsFlag { get; set; }
        public bool PrimaryAccountHolderFlag { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleInitial { get; set; }
        public string LastName { get; set; }
        public string NameSuffix { get; set; }
        public string BusinessName { get; set; }
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }
        public string StreetAddress3 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCodePre { get; set; }
        public string ZipCodeSuffix { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DeathDate { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string SSN { get; set; }
        public string CommunicationPreference { get; set; }
        public decimal Income { get; set; }
        public string EmployerName { get; set; }
        public DateTime? EmploymentDate { get; set; }
        public DateTime? MemberStartDate { get; set; }
        public string RelationshipCode { get; set; }
        public string RaddonSegment { get; set; }
        public string County { get; set; }
        public string Region { get; set; }
        public string Branch { get; set; }
        public bool CheckingFlag { get; set; }
        public bool CDFlag { get; set; }
        public bool MoneyMarketFlag { get; set; }
        public bool AutoLoanFlag { get; set; }
        public bool CreditCardFlag { get; set; }
        public bool PLFlag { get; set; }
        public bool HELOCFlag { get; set; }
        public bool HomeEquityLoanFlag { get; set; }
        public bool FirstMortgageFlag { get; set; }
        public bool StudentLoanFlag { get; set; }
        public bool OnlineBankingFlag { get; set; }
        public bool BillPayFlag { get; set; }
        public bool DebitCardFlag { get; set; }
        public bool NegShareWarning { get; set; }
        public bool BankruptcyWarning { get; set; }
        public bool DQWarning { get; set; }
        public bool BadAddressWarning { get; set; }
        public bool BadEmailWarning { get; set; }
        public bool ExcessiveFeesWarning { get; set; }
        public int CreditScore1 { get; set; }
        public DateTime? CreditScoreDate1 { get; set; }
        public int CreditScore2 { get; set; }
        public DateTime? CreditScoreDate2 { get; set; }
        public int CreditScore3 { get; set; }
        public DateTime? CreditScoreDate3 { get; set; }
        public int CreditScore4 { get; set; }
        public DateTime? CreditScoreDate4 { get; set; }
        public string ProductAccountNumber { get; set; }
        public string ProductType { get; set; }
        public string Description { get; set; }
        public decimal MonthlyPayment { get; set; }
        public DateTime? DateOpened { get; set; }
        public decimal Rate { get; set; }
        public string TermType { get; set; }
        public int TermInMonths { get; set; }
        public decimal OriginalBalance { get; set; }
        public decimal CurrentBalance { get; set; }
        public decimal CCLimit { get; set; }
        public bool FlexFlag1 { get; set; }
        public bool FlexFlag2 { get; set; }
        public bool FlexFlag3 { get; set; }
        public bool FlexFlag4 { get; set; }
        public bool FlexFlag5 { get; set; }
        public bool FlexFlag6 { get; set; }
        public bool FlexFlag7 { get; set; }
        public bool FlexFlag8 { get; set; }
        public bool FlexFlag9 { get; set; }
        public bool FlexFlag10 { get; set; }
        public string FlexChar1 { get; set; }
        public string FlexChar2 { get; set; }
        public string FlexChar3 { get; set; }
        public string FlexChar4 { get; set; }
        public int? FlexNum1 { get; set; }
        public int? FlexNum2 { get; set; }
        public int? FlexNum3 { get; set; }
        public int? FlexNum4 { get; set; }
        public DateTime? FlexDate1 { get; set; }
        public DateTime? FlexDate2 { get; set; }
        public DateTime? FlexDate3 { get; set; }
        public DateTime? FlexDate4 { get; set; }
        public decimal? FlexMoney1 { get; set; }
        public decimal? FlexMoney2 { get; set; }
        public decimal? FlexMoney3 { get; set; }
        public decimal? FlexMoney4 { get; set; }
        public decimal? FlexRate1 { get; set; }
        public decimal? FlexRate2 { get; set; }
        public decimal? FlexRate3 { get; set; }
        public decimal? FlexRate4 { get; set; }
    }
}