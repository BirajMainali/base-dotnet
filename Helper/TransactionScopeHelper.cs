using System.Transactions;

namespace Base.Helper
{
    public static class TransactionScopeHelper
    {
        public static TransactionScope Scope()
        {
            return new TransactionScope(TransactionScopeAsyncFlowOption.Enabled);
        }
    }
}