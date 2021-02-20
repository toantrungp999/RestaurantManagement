using System;
using System.Collections.Generic;
using System.Linq;
using partI.DB_Layer;

namespace partI.DS_Layer
{
    class CReport
    {
        QlyNhaHangEntities qly = new QlyNhaHangEntities();
        public List<DayRevenueReport_Result> ReportDoanhThuNgay(DateTime? start, DateTime? end, string status)
        {
            return qly.DayRevenueReport(start, end, status).ToList<DayRevenueReport_Result>().OrderByDescending(n=>n.Time).ToList<DayRevenueReport_Result>();
        }

        public List<MonthRevenueReport_Result> ReportDoanhThuThang(DateTime? start, DateTime? end, string status)
        {
            return qly.MonthRevenueReport(start, end, status).ToList<MonthRevenueReport_Result>()
                .OrderByDescending(n=>n.YearOfDate).ThenByDescending(n=>n.MonthOfDate).ToList<MonthRevenueReport_Result>();
        }

        public List<TurnoverReport_Result> ReportDoanhSo(DateTime? start, DateTime? end, string status, string type)
        {
            return qly.TurnoverReport(start, end, status, type).ToList<TurnoverReport_Result>()
                .OrderByDescending(n => n.Amount).ToList<TurnoverReport_Result>();
        }

        public List<GetBillReport_Result> ReportHoaDon(DateTime? start, DateTime? end, string status)
        {
            return qly.GetBillReport(start, end, status).ToList<GetBillReport_Result>()
                .OrderByDescending(n => n.Time).ToList<GetBillReport_Result>();
        }

        public List<GetDetailBillReport_Result> ReportChiTietHoaDon(int? id)
        {
            return qly.GetDetailBillReport(id).ToList<GetDetailBillReport_Result>();
        }

        public List<GetCancelledReport_Result> ReportHoaDonHuy(DateTime? start, DateTime? end, string status)
        {
            return qly.GetCancelledReport(start, end, status).ToList<GetCancelledReport_Result>()
                .OrderByDescending(n => n.Time).ToList<GetCancelledReport_Result>();
        }
    }
}
