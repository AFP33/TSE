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
        /// دریافت ریز معاملات براساس معامله روز
        /// </summary>
        /// <param name="transactionHistory">روز مد نظر</param>
        /// <returns></returns>
        public IList<TransactionDetails> GetTransactionDetails(TransactionHistory transactionHistory)
        {
            try
            {
                return new TransactionDetailsController(transactionHistory).Get(stock);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// دریافت ریز معاملات براساس یک تاریخ میلادی
        /// </summary>
        /// <param name="specificDate">تاریخ باید به میلادی باشد</param>
        /// <returns></returns>
        public IList<TransactionDetails> GetTransactionDetails(DateTime specificDate)
        {
            try
            {
                return new TransactionDetailsController(specificDate).Get(stock);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// دریاتف ریز معاملات براساس یک تاریخ شمسی
        /// </summary>
        /// <param name="persianDate">تاریخ باید به شمسی باشد</param>
        /// <returns></returns>
        public IList<TransactionDetails> GetTransactionDetails(string persianDate)
        {
            try
            {
                return new TransactionDetailsController(persianDate).Get(stock);
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
        /// تابلو معاملات.
        /// سفارشهایی مانند "معتبر تا لغو" و یا "معتبر تا تاریخ" در سیستم ثبت میشود اما چون در برخی موارد در بازه مجاز قیمتی نیستند قابلیت انجام ندارند، با پارامتر ورودی میتواند این مسائل را مدیریت کنید.
        /// </summary>
        /// <param name="queueStatus">اگر مقدار Clean انتخاب شود، سفارشهایی که در محدوده مجاز روز نباشند در لیست قرار نخواهند گرفت، و انتخاب Full نمایش همه سفارشات فارغ از بازه معتبر را شامل میشود.</param>
        /// <returns></returns>
        public StockQueue StockQueue(QueueStatus queueStatus = QueueStatus.Full)
        {
            try
            {
                return new StockQueueController(queueStatus).Get(stock);
            }
            catch (Exception)
            {
                throw;
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

        /// <summary>
        /// آمارها
        /// </summary>
        public Statistics Statistics
        {
            get
            {
                try
                {
                    return new StatisticsController().Get(stock);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// تصمیمات مجمع
        /// </summary>
        public IList<CouncilDecision> CouncilDecisions
        {
            get
            {
                try
                {
                    return new CouncilDecisionController().Get(stock);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// پورتفوی شرکت
        /// </summary>
        public Portfo Portfo
        {
            get
            {
                try
                {
                    return new PortfoController().Get(stock);
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
