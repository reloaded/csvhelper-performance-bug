using System;
using CsvHelper.Configuration;

namespace ConsoleApp1.Services
{
    public sealed class CustomerImportCsvMap : ClassMap<CustomerImportCsvRowDto>
    {
        public CustomerImportCsvMap()
        {
            AutoMap();
            Map(m => m.CsvRowNumber).ConvertUsing(row => row.Context.RawRow);
            Map(m => m.AccountNumber).Index((int)ColumnIndexMap.AccountNumber);
            Map(m => m.MasterCustomerDetailsFlag).Index((int)ColumnIndexMap.MasterCustomerDetailsFlag).Default(false);
            Map(m => m.PrimaryAccountHolderFlag).Index((int)ColumnIndexMap.PrimaryAccountHolderFlag).Default(false);
            Map(m => m.Title).Index((int)ColumnIndexMap.Title);
            Map(m => m.FirstName).Index((int)ColumnIndexMap.FirstName);
            Map(m => m.MiddleInitial).Index((int)ColumnIndexMap.MiddleInitial);
            Map(m => m.LastName).Index((int)ColumnIndexMap.LastName);
            Map(m => m.NameSuffix).Index((int)ColumnIndexMap.NameSuffix);
            Map(m => m.BusinessName).Index((int)ColumnIndexMap.BusinessName);
            Map(m => m.StreetAddress1).Index((int)ColumnIndexMap.StreetAddress1);
            Map(m => m.StreetAddress2).Index((int)ColumnIndexMap.StreetAddress2);
            Map(m => m.StreetAddress3).Index((int)ColumnIndexMap.StreetAddress3);
            Map(m => m.City).Index((int)ColumnIndexMap.City);
            Map(m => m.State).Index((int)ColumnIndexMap.State);
            Map(m => m.ZipCodePre).Index((int)ColumnIndexMap.ZipCodePre);
            Map(m => m.ZipCodeSuffix).Index((int)ColumnIndexMap.ZipCodeSuffix);
            Map(m => m.DateOfBirth).Index((int)ColumnIndexMap.DateOfBirth).ConvertUsing(row =>
            {
                var stringDate = row.GetField<string>((int)ColumnIndexMap.DateOfBirth);

                if (string.IsNullOrWhiteSpace(stringDate))
                {
                    return null;
                }

                return DateTime.Parse(stringDate);
            });
            Map(m => m.DeathDate).Index((int)ColumnIndexMap.DeathDate).ConvertUsing(row =>
            {
                var stringDate = row.GetField<string>((int)ColumnIndexMap.DeathDate);

                if (string.IsNullOrWhiteSpace(stringDate))
                {
                    return null;
                }

                return DateTime.Parse(stringDate);
            });
            Map(m => m.PhoneNumber).Index((int)ColumnIndexMap.PhoneNumber);
            Map(m => m.EmailAddress).Index((int)ColumnIndexMap.EmailAddress);
            Map(m => m.SSN).Index((int)ColumnIndexMap.SSN);
            Map(m => m.CommunicationPreference).Index((int)ColumnIndexMap.CommunicationPreference);
            Map(m => m.Income).Index((int)ColumnIndexMap.Income).Default(0);
            Map(m => m.EmployerName).Index((int)ColumnIndexMap.EmployerName);
            Map(m => m.EmploymentDate).Index((int)ColumnIndexMap.EmploymentDate).ConvertUsing(row =>
            {
                var stringDate = row.GetField<string>((int)ColumnIndexMap.EmploymentDate);

                if (string.IsNullOrWhiteSpace(stringDate))
                {
                    return null;
                }

                try
                {
                    return DateTime.Parse(stringDate);
                }
                catch (Exception)
                {
                    return null;
                }
            });
            Map(m => m.MemberStartDate).Index((int)ColumnIndexMap.MemberStartDate).ConvertUsing(row =>
            {
                var stringDate = row.GetField<string>((int)ColumnIndexMap.MemberStartDate);

                if (string.IsNullOrWhiteSpace(stringDate))
                {
                    return null;
                }

                return DateTime.Parse(stringDate);
            });
            Map(m => m.RelationshipCode).Index((int)ColumnIndexMap.RelationshipCode);
            Map(m => m.RaddonSegment).Index((int)ColumnIndexMap.RaddonSegment);
            Map(m => m.County).Index((int)ColumnIndexMap.County);
            Map(m => m.Region).Index((int)ColumnIndexMap.Region);
            Map(m => m.Branch).Index((int)ColumnIndexMap.Branch);
            Map(m => m.CheckingFlag).Index((int)ColumnIndexMap.CheckingFlag).Default(false);
            Map(m => m.CDFlag).Index((int)ColumnIndexMap.CDFlag).Default(false);
            Map(m => m.MoneyMarketFlag).Index((int)ColumnIndexMap.MoneyMarketFlag).Default(false);
            Map(m => m.AutoLoanFlag).Index((int)ColumnIndexMap.AutoLoanFlag).Default(false);
            Map(m => m.CreditCardFlag).Index((int)ColumnIndexMap.CreditCardFlag).Default(false);
            Map(m => m.PLFlag).Index((int)ColumnIndexMap.PLFlag).Default(false);
            Map(m => m.HELOCFlag).Index((int)ColumnIndexMap.HELOCFlag).Default(false);
            Map(m => m.HomeEquityLoanFlag).Index((int)ColumnIndexMap.HomeEquityLoanFlag).Default(false);
            Map(m => m.FirstMortgageFlag).Index((int)ColumnIndexMap.FirstMortgageFlag).Default(false);
            Map(m => m.StudentLoanFlag).Index((int)ColumnIndexMap.StudentLoanFlag).Default(false);
            Map(m => m.OnlineBankingFlag).Index((int)ColumnIndexMap.OnlineBankingFlag).Default(false);
            Map(m => m.BillPayFlag).Index((int)ColumnIndexMap.BillPayFlag).Default(false);
            Map(m => m.DebitCardFlag).Index((int)ColumnIndexMap.DebitCardFlag).Default(false);
            Map(m => m.NegShareWarning).Index((int)ColumnIndexMap.NegShareWarning).Default(false);
            Map(m => m.BankruptcyWarning).Index((int)ColumnIndexMap.BankruptcyWarning).Default(false);
            Map(m => m.DQWarning).Index((int)ColumnIndexMap.DQWarning).Default(false);
            Map(m => m.BadAddressWarning).Index((int)ColumnIndexMap.BadAddressWarning).Default(false);
            Map(m => m.BadEmailWarning).Index((int)ColumnIndexMap.BadEmailWarning).Default(false);
            Map(m => m.ExcessiveFeesWarning).Index((int)ColumnIndexMap.ExcessiveFeesWarning).Default(false);
            Map(m => m.CreditScore1).Index((int)ColumnIndexMap.CreditScore1).Default(0);
            Map(m => m.CreditScoreDate1).Index((int)ColumnIndexMap.CreditScoreDate1).ConvertUsing(row =>
            {
                var stringDate = row.GetField<string>((int)ColumnIndexMap.CreditScoreDate1);

                if (string.IsNullOrWhiteSpace(stringDate))
                {
                    return null;
                }

                return DateTime.Parse(stringDate);
            });
            Map(m => m.CreditScore2).Index((int)ColumnIndexMap.CreditScore2).Default(0);
            Map(m => m.CreditScoreDate2).Index((int)ColumnIndexMap.CreditScoreDate2).ConvertUsing(row =>
            {
                var stringDate = row.GetField<string>((int)ColumnIndexMap.CreditScoreDate2);

                if (string.IsNullOrWhiteSpace(stringDate))
                {
                    return null;
                }

                return DateTime.Parse(stringDate);
            });
            Map(m => m.CreditScore3).Index((int)ColumnIndexMap.CreditScore3).Default(0);
            Map(m => m.CreditScoreDate3).Index((int)ColumnIndexMap.CreditScoreDate3).ConvertUsing(row =>
            {
                var stringDate = row.GetField<string>((int)ColumnIndexMap.CreditScoreDate3);

                if (string.IsNullOrWhiteSpace(stringDate))
                {
                    return null;
                }

                return DateTime.Parse(stringDate);
            });
            Map(m => m.CreditScore4).Index((int)ColumnIndexMap.CreditScore4).Default(0);
            Map(m => m.CreditScoreDate4).Index((int)ColumnIndexMap.CreditScoreDate4).ConvertUsing(row =>
            {
                var stringDate = row.GetField<string>((int)ColumnIndexMap.CreditScoreDate4);

                if (string.IsNullOrWhiteSpace(stringDate))
                {
                    return null;
                }

                return DateTime.Parse(stringDate);
            });
            Map(m => m.ProductAccountNumber).Index((int)ColumnIndexMap.ProductAccountNumber);
            Map(m => m.ProductType).Index((int)ColumnIndexMap.ProductType).ConvertUsing(row =>
            {
                return row.GetField((int)ColumnIndexMap.ProductType).Replace('-', ' ');
            });
            Map(m => m.Description).Index((int)ColumnIndexMap.Description);
            Map(m => m.MonthlyPayment).Index((int)ColumnIndexMap.MonthlyPayment).Default(0);
            Map(m => m.DateOpened).Index((int)ColumnIndexMap.DateOpened).ConvertUsing(row =>
            {
                var stringDate = row.GetField<string>((int)ColumnIndexMap.DateOpened);

                if (string.IsNullOrWhiteSpace(stringDate))
                {
                    return null;
                }

                return DateTime.Parse(stringDate);
            });
            Map(m => m.Rate).Index((int)ColumnIndexMap.Rate).Default(0);
            Map(m => m.TermType).Index((int)ColumnIndexMap.TermType);
            Map(m => m.TermInMonths).Index((int)ColumnIndexMap.TermInMonths).Default(0);
            Map(m => m.OriginalBalance).Index((int)ColumnIndexMap.OriginalBalance).Default(0);
            Map(m => m.CurrentBalance).Index((int)ColumnIndexMap.CurrentBalance).Default(0);
            Map(m => m.CCLimit).Index((int)ColumnIndexMap.CCLimit).Default(0);
            Map(m => m.FlexFlag1).Index((int)ColumnIndexMap.FlexFlag1).Default(false);
            Map(m => m.FlexFlag2).Index((int)ColumnIndexMap.FlexFlag2).Default(false);
            Map(m => m.FlexFlag3).Index((int)ColumnIndexMap.FlexFlag3).Default(false);
            Map(m => m.FlexFlag4).Index((int)ColumnIndexMap.FlexFlag4).Default(false);
            Map(m => m.FlexFlag5).Index((int)ColumnIndexMap.FlexFlag5).Default(false);
            Map(m => m.FlexFlag6).Index((int)ColumnIndexMap.FlexFlag6).Default(false);
            Map(m => m.FlexFlag7).Index((int)ColumnIndexMap.FlexFlag7).Default(false);
            Map(m => m.FlexFlag8).Index((int)ColumnIndexMap.FlexFlag8).Default(false);
            Map(m => m.FlexFlag9).Index((int)ColumnIndexMap.FlexFlag9).Default(false);
            Map(m => m.FlexFlag10).Index((int)ColumnIndexMap.FlexFlag10).Default(false);
            Map(m => m.FlexChar1).Index((int)ColumnIndexMap.FlexChar1);
            Map(m => m.FlexChar2).Index((int)ColumnIndexMap.FlexChar2);
            Map(m => m.FlexChar3).Index((int)ColumnIndexMap.FlexChar3);
            Map(m => m.FlexChar4).Index((int)ColumnIndexMap.FlexChar4);
            Map(m => m.FlexNum1).Index((int)ColumnIndexMap.FlexNum1);
            Map(m => m.FlexNum2).Index((int)ColumnIndexMap.FlexNum2);
            Map(m => m.FlexNum3).Index((int)ColumnIndexMap.FlexNum3);
            Map(m => m.FlexNum4).Index((int)ColumnIndexMap.FlexNum4);
            Map(m => m.FlexDate1).Index((int)ColumnIndexMap.FlexDate1).ConvertUsing(row =>
            {
                var stringDate = row.GetField<string>((int)ColumnIndexMap.FlexDate1);

                if (string.IsNullOrWhiteSpace(stringDate))
                {
                    return null;
                }

                return DateTime.Parse(stringDate);
            });
            Map(m => m.FlexDate2).Index((int)ColumnIndexMap.FlexDate2).ConvertUsing(row =>
            {
                var stringDate = row.GetField<string>((int)ColumnIndexMap.FlexDate2);

                if (string.IsNullOrWhiteSpace(stringDate))
                {
                    return null;
                }

                return DateTime.Parse(stringDate);
            });
            Map(m => m.FlexDate3).Index((int)ColumnIndexMap.FlexDate3).ConvertUsing(row =>
            {
                var stringDate = row.GetField<string>((int)ColumnIndexMap.FlexDate3);

                if (string.IsNullOrWhiteSpace(stringDate))
                {
                    return null;
                }

                return DateTime.Parse(stringDate);
            });
            Map(m => m.FlexDate4).Index((int)ColumnIndexMap.FlexDate4).ConvertUsing(row =>
            {
                var stringDate = row.GetField<string>((int)ColumnIndexMap.FlexDate4);

                if (string.IsNullOrWhiteSpace(stringDate))
                {
                    return null;
                }

                return DateTime.Parse(stringDate);
            });
            Map(m => m.FlexMoney1).Index((int)ColumnIndexMap.FlexMoney1);
            Map(m => m.FlexMoney2).Index((int)ColumnIndexMap.FlexMoney2);
            Map(m => m.FlexMoney3).Index((int)ColumnIndexMap.FlexMoney3);
            Map(m => m.FlexMoney4).Index((int)ColumnIndexMap.FlexMoney4);
            Map(m => m.FlexRate1).Index((int)ColumnIndexMap.FlexRate1);
            Map(m => m.FlexRate2).Index((int)ColumnIndexMap.FlexRate2);
            Map(m => m.FlexRate3).Index((int)ColumnIndexMap.FlexRate3);
            Map(m => m.FlexRate4).Index((int)ColumnIndexMap.FlexRate4);
        }
    }
}