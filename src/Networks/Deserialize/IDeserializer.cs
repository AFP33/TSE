//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Networks.Deserialize
{
    internal interface IDeserializer<T>
    {
        T Get(string serverResponse);
    }
}
