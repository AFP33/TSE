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
    public class BourseHandler : IHandler
    {

        /// <summary>
        /// بورس در یک نگاه
        /// </summary>
        public Bourse BourseAtGlance
        {
            get
            {
                try
                {
                    return new BourseController().Get();
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
                    return new EffectiveOnIndexController().Get();
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
                    return new TopTransactionSymbolController().Get();
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
        public IList<ChosenIndexes> ChosenIndexes
        {
            get
            {
                try
                {
                    return new ChosenIndexesController().Get();
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
    }
}
