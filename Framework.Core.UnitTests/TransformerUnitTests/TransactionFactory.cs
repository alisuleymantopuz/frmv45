using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core.UnitTests.TransformerUnitTests.FakeObjects;

namespace Framework.Core.UnitTests.TransformerUnitTests
{
    public class TransactionFactory
    {
        public static Transaction CreateTransaction()
        {
            Transaction transaction = new Transaction
            {
                PanInfo = new PanInfo
                {
                    CardHolder = new CardHolder
                    {
                        Pan = "4012001037141112",
                        Cvv2 = "544"
                    }
                },
                MSISDN = "deneme",
                PaymentTransactionType = PaymentTransactionType.Sale,
                RequestId = "5",
                RequestPassword = "asd"
            };

            transaction.CustomDataList = new List<CustomData>();
            transaction.CustomDataList.Add(new CustomData
            {
                CustomItem = "deneme",
                CustomItemValue = "value"
            });
            return transaction;
        }
        public static SaleTransaction CreateNewSaleTransaction()
        {
            SaleTransaction transaction = new SaleTransaction
            {
                PanInfo = new PanInfo
                {
                    CardHolder = new CardHolder
                    {
                        Pan = "4012001037141112",
                        Cvv2 = "544"
                    }
                },
                MSISDN = "deneme",
                PaymentTransactionType = PaymentTransactionType.Sale,
                RequestId = "5",
                RequestPassword = "asd",
                SaleId = 5,
                TerminalInfo = new TerminalInfo
                {
                    TerminalNumber = 5
                },
                TerminalNumberNullable = 10
            };

            transaction.CustomDataList = new List<CustomData>();
            transaction.CustomDataList.Add(new CustomData
            {
                CustomItem = "deneme",
                CustomItemValue = "value"
            });
            return transaction;
        }

        public static PanInfoCollection CreatePanInfoCollection()
        {
            PanInfoCollection panInfoCollection = new PanInfoCollection();
            panInfoCollection.PanInfos = new List<PanInfo>();
            panInfoCollection.PanInfos.Add(new PanInfo()
            {
                CardHolder = new CardHolder()
                    {
                        Cvv2 = "000",
                        Pan = "4012001037141112"
                    }
            });

            panInfoCollection.PanInfos.Add(new PanInfo()
            {
                CardHolder = new CardHolder()
                {
                    Cvv2 = "123",
                    Pan = "4654852111226598"
                }
            });


            panInfoCollection.PanInfos.Add(new PanInfo()
            {
                CardHolder = new CardHolder()
                {
                    Cvv2 = "333",
                    Pan = "5571124585457485"
                }
            });

             

            return panInfoCollection;
        }
    }
}
