using System.Collections.Generic;
using Tse.Controller.Stocks;
using Tse.Entities;
using System;

//
// Tehran Stock Exchange (TSE) Library Project
// Developed by AFP33, 2023
// https://github.com/AFP33
//

namespace Tse.Handlers
{
    public class StockHandler : IHandler
    {
        private Stock stock { get; set; }

        public StockHandler(Stock stock)
        {
            if (stock == null)
                throw new ArgumentNullException(nameof(stock));
            this.stock = stock;
        }

        /// <summary>
        /// دریافت سابقه معاملاتی
        /// </summary>
        public IList<TransactionHistory> GetTransactionHistory
            (TransactionHistoryType transactionHistoryType = TransactionHistoryType.TradedDay)
        {
            try
            {
                return new TransactionHistoryController(transactionHistoryType).Get(stock);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// دریافت اطلاعات اولیه
        /// </summary>
        public BriefInformation BriefInformations
        {
            get
            {
                try
                {
                    return new BriefInformationController().Get(stock);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// دریافت اطلاعیه ها
        /// </summary>
        /// <returns></returns>
        public IList<Announcement> Announcements
        {
            get
            {
                try
                {
                    return new AnnouncementController().Get(stock);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// دریافت اطلاعات شناسه نماد
        /// </summary>
        /// <returns></returns>
        public CompanyIdentity CompanyIdentities
        {
            get
            {
                try
                {
                    return new CompanyIdentityController().Get(stock);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// دریافت ترازنامه ها
        /// </summary>
        /// <returns></returns>
        public IList<BalanceSheet> BalanceSheets
        {
            get
            {
                try
                {
                    return new BalanceSheetController().Get(stock);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// دریافت آگهی های مجمع
        /// </summary>
        /// <returns></returns>
        public IList<CouncilAnnouncement> CouncilAnnouncements
        {
            get
            {
                try
                {
                    return new CouncilAnnouncementController().Get(stock);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// دریافت تغییرات وضعیت نماد
        /// </summary>
        /// <returns></returns>
        public IList<StatusChange> StatusChanges
        {
            get
            {
                try
                {
                    return new StatusChangeController().Get(stock);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// دریافت اطلاعات هیئت مدیره
        /// </summary>
        /// <returns></returns>
        public IList<BoardOfDirector> BoardOfDirectors
        {
            get
            {
                try
                {
                    return new BoardOfDirectorController().Get(stock);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// معاملات حقیقی و حقوقی
        /// </summary>
        /// <returns></returns>
        public IList<RealLegal> RealLegals
        {
            get
            {
                try
                {
                    return new RealLegalController().Get(stock);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// دریافت اطلاعات سهامداران
        /// </summary>
        /// <returns></returns>
        public IList<Stockholder> Stockholders
        {
            get
            {
                try
                {
                    var companyIdentity = this.CompanyIdentities;
                    return new StockholderController(companyIdentity.Company12DigitCode).Get(stock);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// دریافت اطلاعات مربوط به EPS
        /// </summary>
        /// <returns></returns>
        public IList<EPS> EPSs
        {
            get
            {
                try
                {
                    var companyIdentity = this.CompanyIdentities;
                    return new EPSController(companyIdentity.Company12DigitCode).Get(stock);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// دریافت اطلاعات مربوط به DPS
        /// </summary>
        /// <returns></returns>
        public IList<DPS> DPSs
        {
            get
            {
                try
                {
                    return new DPSController().Get(stock);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// اطلاعات مربوط به معرفی شرکت
        /// </summary>
        /// <returns></returns>
        public CompanyInfo CompanyInfos
        {
            get
            {
                try
                {
                    return new CompanyInfoController().Get(stock);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// اطلاعات سود و زیان
        /// </summary>
        /// <returns></returns>
        public IList<CostBenefit> CostBenefits
        {
            get
            {
                try
                {
                    return new CostBenefitController().Get(stock);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// دریافت پیام های ناظر
        /// </summary>
        /// <returns></returns>
        public IList<SupervisorMessage> SupervisorMessages
        {
            get
            {
                try
                {
                    return new SupervisorMessageController().Get(stock);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
