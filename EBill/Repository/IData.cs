﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EBill.Models;
using System.Data.SqlClient;


namespace EBill.Repository
{
    interface IData
    {
        void SaveBillDetails(BillDetail details);
        void SaveBillItems(List<Items> items, SqlConnection con, int id);
        List<BillDetail> GetAllDetail();
        BillDetail GetDetail(int Id);
    }
}
