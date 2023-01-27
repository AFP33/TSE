using System.Collections.Generic;
using Tse.Controller.Markets;
using Tse.Entities;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Handlers
{
    public class FarabourseHandler : IHandler
    {

        /// <summary>
        /// فرابورس در یک نگاه
        /// </summary>
        public FaraBourse FaraBourseAtGlance
        {
            get
            {
                try
                {
                    return new FaraBourseController().Get();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// دریافت نماد های موثر شاخص بورس
        /// </summary>
        public IList<EffectiveOnIndex> EffectiveOnIndex
        {
            get
            {
                try
                {
                    return new EffectiveOnIndexController("Farabourse").Get();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }

        /// <summary>
        /// دریافت نمادهای پر تراکنش مارکت بورس
        /// </summary>
        public IList<TopTransactionSymbol> TopTransactionSymbol
        {
            get
            {
                try
                {
                    return new TopTransactionSymbolController("Farabourse").Get();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
