using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core.UnitTests.TransformerUnitTests.FakeObjects;
using Framework.Core.UnitTests.TransformerUnitTests.FakeObjects.Rules;
using NUnit.Framework;

namespace Framework.Core.UnitTests.TransformerUnitTests
{
    [TestFixture]
    public class ObjectTransformationRuleTests
    {
        [Test]
        public void ExecuteRules_ShouldBeExecuteMaskingRule_WhenPropertyIsNotEmpty()
        {
            PanMaskingRule transactionTransformationRule = new PanMaskingRule();

            Transaction transaction = TransactionFactory.CreateTransaction();

            Transaction result = transactionTransformationRule.ExecuteRules(transaction) as Transaction;

            Assert.AreEqual(result.PanInfo.CardHolder.Pan, "4012********1112");
        }

        [Test]
        public void ExecuteRules_DoesNotExecuteMaskingRule_WhenPropertyValueLengthSmallerThanEarlyDigitsValue()
        {
            PanMaskingRule transactionTransformationRule = new PanMaskingRule();

            Transaction transaction = TransactionFactory.CreateTransaction();

            transaction.PanInfo.CardHolder.Pan = "401";

            Transaction result = transactionTransformationRule.ExecuteRules(transaction) as Transaction;

            Assert.AreEqual(result.PanInfo.CardHolder.Pan, "401");
        }

        [Test]
        public void ExecuteRules_ShouldBeExecuteRemovingRule_WhenPropertyValueIsNotEmpty()
        {
            PanRemovingRule transactionTransformationRule = new PanRemovingRule();

            Transaction transaction = TransactionFactory.CreateTransaction();

            Transaction result = transactionTransformationRule.ExecuteRules(transaction) as Transaction;

            Assert.AreEqual(result.PanInfo.CardHolder.Pan, null);
        }

        [Test]
        public void ExecuteRules_ResultShouldBeSaleTransaction_WhenTransactionIsSaleTransaction()
        {
            PanRemovingRule transactionTransformationRule = new PanRemovingRule();

            SaleTransaction transaction = TransactionFactory.CreateNewSaleTransaction();

            SaleTransaction result = transactionTransformationRule.ExecuteRules(transaction) as SaleTransaction;

            Assert.IsNotNull(result);

            Assert.AreEqual(result.PanInfo.CardHolder.Pan, null);
        }

        [Test]
        public void ExecuteRules_ShouldBeMaskAndRemove_WhenBothMaskingAndRemovingRulesDeclared()
        {
            PanMaskingAndMSISDNRemovingRule transactionTransformationRule = new PanMaskingAndMSISDNRemovingRule();

            SaleTransaction transaction = TransactionFactory.CreateNewSaleTransaction();

            SaleTransaction result = transactionTransformationRule.ExecuteRules(transaction) as SaleTransaction;

            Assert.AreEqual(result.MSISDN, null);

            Assert.AreEqual(result.PanInfo.CardHolder.Pan, "4012********1112");
        }

        [Test]
        public void ExecuteRules_DoesNotThrows_WhenExecutingMaskingRulesForNullClass()
        {
            PanMaskingRule transactionTransformationRule = new PanMaskingRule();

            SaleTransaction transaction = TransactionFactory.CreateNewSaleTransaction();

            transaction.PanInfo = null;

            Assert.DoesNotThrow(() => transactionTransformationRule.ExecuteRules(transaction));
        }

        [Test]
        public void ExecuteRules_DoesNotThrows_WhenExecutingMaskingRulesForNullProperty()
        {
            PanMaskingRule transactionTransformationRule = new PanMaskingRule();

            SaleTransaction transaction = TransactionFactory.CreateNewSaleTransaction();

            transaction.PanInfo.CardHolder = null;

            Assert.DoesNotThrow(() => transactionTransformationRule.ExecuteRules(transaction));
        }

        [Test]
        public void ExecuteRules_DoesNotThrows_WhenExecutingMaskingRulesForEmptyProperty()
        {
            PanMaskingRule transactionTransformationRule = new PanMaskingRule();

            SaleTransaction transaction = TransactionFactory.CreateNewSaleTransaction();

            transaction.PanInfo.CardHolder.Pan = "";

            Assert.DoesNotThrow(() => transactionTransformationRule.ExecuteRules(transaction));
        }

        [Test]
        public void ExecuteRules_DoesNotThrows_WhenExecutingRemovingRulesForNullProperty()
        {
            MSISDNRemovingRule transactionTransformationRule = new MSISDNRemovingRule();

            SaleTransaction transaction = TransactionFactory.CreateNewSaleTransaction();

            transaction.MSISDN = null;

            Assert.DoesNotThrow(() => transactionTransformationRule.ExecuteRules(transaction));
        }

        [Test]
        public void ExecuteRules_ShouldBeSetPropertyToDefaultValue_WhenIntFieldRemoving()
        {
            TerminalNumberRemovingRule transactionTransformationRule = new TerminalNumberRemovingRule();

            SaleTransaction transaction = TransactionFactory.CreateNewSaleTransaction();

            SaleTransaction result = transactionTransformationRule.ExecuteRules(transaction) as SaleTransaction;

            Assert.AreEqual(result.TerminalInfo.TerminalNumber, 0);
        }

        [Test]
        public void ExecuteRules_ShouldBeSetPropertyToDefaultValue_WhenNullableIntFieldRemoving()
        {
            NullableTerminalNumberRemovingRule transactionTransformationRule = new NullableTerminalNumberRemovingRule();

            SaleTransaction transaction = TransactionFactory.CreateNewSaleTransaction();

            SaleTransaction result = transactionTransformationRule.ExecuteRules(transaction) as SaleTransaction;

            Assert.AreEqual(result.TerminalNumberNullable, null);
        }

        [Test]
        public void ExecuteRules_ShouldBeSetPropertyToDefaultValue_WhenTryingToRemoveSomeGenericList()
        {
            CustomDataListRemovingRule transactionTransformationRule = new CustomDataListRemovingRule();

            SaleTransaction transaction = TransactionFactory.CreateNewSaleTransaction();

            SaleTransaction result = transactionTransformationRule.ExecuteRules(transaction) as SaleTransaction;

            Assert.AreEqual(result.CustomDataList, null);
        }

        [Test]
        public void ExecuteRules_ShouldBeCompletelyMask_WhenMaskingRulesEarlyAndLastDigitsEqualsToZero()
        {
            Cvv2MaskingRule transactionTransformationRule = new Cvv2MaskingRule();

            SaleTransaction transaction = TransactionFactory.CreateNewSaleTransaction();

            SaleTransaction result = transactionTransformationRule.ExecuteRules(transaction) as SaleTransaction;

            Assert.AreEqual(result.PanInfo.CardHolder.Cvv2, "***");
        }

        [Test]
        public void ExecuteRules_ShouldBeSucess_WhenTryingToExecuteMultipleRules()
        {
            MultiplePropertyRules transactionTransformationRule = new MultiplePropertyRules();

            SaleTransaction transaction = TransactionFactory.CreateNewSaleTransaction();

            SaleTransaction result = transactionTransformationRule.ExecuteRules(transaction) as SaleTransaction;

            Assert.AreEqual(result.CustomDataList, null);

            Assert.AreEqual(result.MSISDN, null);

            Assert.AreEqual(result.TerminalInfo.TerminalNumber, 0);

            Assert.AreEqual(result.TerminalNumberNullable, null);

            Assert.AreEqual(result.PanInfo.CardHolder.Pan, "4012********1112");

            Assert.AreEqual(result.PanInfo.CardHolder.Cvv2, "***");
        }

        [Test]
        public void ExecuteRules_ShouldBeCompletelyMaskAndRemove()
        {
            PanInfoCollection collection = TransactionFactory.CreatePanInfoCollection();

            PanInfoCollectionMaskingRule maskingRule = new PanInfoCollectionMaskingRule();

            PanInfoCollection transformedCollection = maskingRule.ExecuteRules(collection) as PanInfoCollection;
        }
    }
}
