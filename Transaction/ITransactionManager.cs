interface ITransactionManager
{
    TransactionBase[] todayTransactions();

    TransactionBase[] getLastFiveTransaction();
    TransactionBase[] getAllTransactions();
}