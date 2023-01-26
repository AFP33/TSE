using Tse.Entities;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Controller
{
    internal interface IStockController <T> : IController<T>
    {
        T Get(Stock stock);
    }
}
