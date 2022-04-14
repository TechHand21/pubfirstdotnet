using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = string.Format( @" abc {0}", "STest");
            Console.WriteLine("Hello World!");
            object newWipStateID ;
            var wipStates = GetWIPSList();

            foreach (var wip in wipStates)
            {
                var saleOrders = GetSaleOrders(wip.NickName, wip.StopReasons);

                foreach (var saleOrder in saleOrders)
                {

                    newWipStateID = wip.UpdatedWipStateKey;

                    //Call Mulesoft endpoint to updadate SalesOrderWipState
                    //Parm: BrighTreeID, NewWipStateID

                }




            }
        }

        static List<ARPWIPAutomationModel> GetWIPSList()
        {
            List<ARPWIPAutomationModel> list = new List<ARPWIPAutomationModel>();

            DataTable tb = new DataTable();
            DataRow dr;
            tb.Columns.Add("ID", typeof(string));
            tb.Columns.Add("NickName", typeof(string));
            tb.Columns.Add("ExcludedWips", typeof(string));
            tb.Columns.Add("StopReasonKeys", typeof(string));
            tb.Columns.Add("StopReasons", typeof(string));
            tb.Columns.Add("UpdatedWipStateKey", typeof(string));
            dr = tb.NewRow();
            dr["ID"] = "1";
            dr["NickName"] = "AerocareHolding";
            dr["ExcludedWips"] = "190, 264";
            dr["StopReasonKeys"] = "4";
            dr["StopReasons"] = "ARP 1-ASSET RECOVER";
            dr["UpdatedWipStateKey"] = "666";
            tb.Rows.Add(dr);
            dr = tb.NewRow();
            dr["ID"] = "2";
            dr["NickName"] = "AerocareHolding";
            dr["ExcludedWips"] = "190, 264";
            dr["StopReasonKeys"] = "1";
            dr["StopReasons"] = "ARP-Branch Review";
            dr["UpdatedWipStateKey"] = "777";
            tb.Rows.Add(dr);

            dr = tb.NewRow();
            dr["ID"] = "3";
            dr["NickName"] = "OHH";
            dr["ExcludedWips"] = "10046, 511";
            dr["StopReasonKeys"] = "1, ";
            dr["StopReasons"] = "ARP 1-ASSET RECOVER, ARP-Branch Review, Branch Review - DOD";
            dr["UpdatedWipStateKey"] = "";
            tb.Rows.Add(dr);
            dr = tb.NewRow();
            dr["ID"] = "4";
            dr["NickName"] = "OHH";
            dr["ExcludedWips"] = "10046, 511";
            dr["StopReasonKeys"] = "1, ";
            dr["StopReasons"] = "ARP 1-ASSET RECOVER, ARP-Branch Review, Branch Review - DOD";
            dr["UpdatedWipStateKey"] = "";

            tb.Rows.Add(dr);
            dr = tb.NewRow();
            dr["ID"] = "3";
            dr["NickName"] = "StLukes";
            dr["ExcludedWips"] = "10026, 1205";
            dr["StopReasonKeys"] = "3,1, ";
            dr["StopReasons"] = "ARP 1-ASSET RECOVER, ARP-Branch Review, Branch Review - DOD";
            dr["UpdatedWipStateKey"] = "";
            tb.Rows.Add(dr);

            if (tb.Rows.Count != 0)
            {
                foreach (DataRow row in tb.Rows)
                {
                    list.Add(new ARPWIPAutomationModel
                    {
                        ID = Convert.ToInt32(row["ID"]),
                        NickName = Convert.ToString(row["NickName"]),
                        ExcludedWips = Convert.ToString(row["ExcludedWips"]),
                        StopReasonKeys = Convert.ToString(row["StopReasonKeys"]),
                        StopReasons = Convert.ToString(row["StopReasons"]),
                        UpdatedWipStateKey = Convert.ToString(row["UpdatedWipStateKey"])
                    });
                }
            }

            return list;
        }

        static List<ARPWIPAutomationModel> GetWIPSList2()
        {
            List<ARPWIPAutomationModel> list = new List<ARPWIPAutomationModel>();

            DataTable tb = new DataTable();
            DataRow dr;
            tb.Columns.Add("ID", typeof(string));
            tb.Columns.Add("NickName", typeof(string));
            tb.Columns.Add("ExcludedWips", typeof(string));
            tb.Columns.Add("StopReasonKeys", typeof(string));
            tb.Columns.Add("StopReasons", typeof(string));
            tb.Columns.Add("UpdatedWipStateKey", typeof(string));
            dr = tb.NewRow();
            dr["ID"] = "1";
            dr["NickName"] = "AerocareHolding";
            dr["ExcludedWips"] = "190, 264";
            dr["StopReasonKeys"] = "4, 1, ";
            dr["StopReasons"] = "ARP 1-ASSET RECOVER, ARP-Branch Review, Branch Review - DOD";
            dr["UpdatedWipStateKey"] = "saleOrder.StopReason ==\"ARP 1 - ASSET RECOVER\" ?\"123\":\"456\"";
            tb.Rows.Add(dr);
            dr = tb.NewRow();
            dr["ID"] = "2";
            dr["NickName"] = "OHH";
            dr["ExcludedWips"] = "10046, 511";
            dr["StopReasonKeys"] = "1, ";
            dr["StopReasons"] = "ARP 1-ASSET RECOVER, ARP-Branch Review, Branch Review - DOD";
            dr["UpdatedWipStateKey"] = "";
            tb.Rows.Add(dr);
            dr = tb.NewRow();
            dr["ID"] = "3";
            dr["NickName"] = "StLukes";
            dr["ExcludedWips"] = "10026, 1205";
            dr["StopReasonKeys"] = "3,1, ";
            dr["StopReasons"] = "ARP 1-ASSET RECOVER, ARP-Branch Review, Branch Review - DOD";
            dr["UpdatedWipStateKey"] = "";
            tb.Rows.Add(dr);

            if (tb.Rows.Count != 0)
            {
                foreach (DataRow row in tb.Rows)
                {
                    list.Add(new ARPWIPAutomationModel
                    {
                        ID = Convert.ToInt32(row["ID"]),
                        NickName = Convert.ToString(row["NickName"]),
                        ExcludedWips = Convert.ToString(row["ExcludedWips"]),
                        StopReasonKeys = Convert.ToString(row["StopReasonKeys"]),
                        StopReasons = Convert.ToString(row["StopReasons"]),
                        UpdatedWipStateKey = Convert.ToString(row["UpdatedWipStateKey"])
                    });
                }
            }

            return list;
        }

        static List<DummySaleOrderModel> GetSaleOrders(string nickName, string stopReason)
        {
            List<DummySaleOrderModel> list = new List<DummySaleOrderModel>();
            list.Add(new DummySaleOrderModel
            {
                SalesOrderKey = 11111,
                NickName = "AerocareHolding",
                StopReason = "ARP 1-ASSET RECOVER"
            });
            list.Add(new DummySaleOrderModel
            {
                SalesOrderKey = 11112,
                NickName = "AerocareHolding",
                StopReason = "ARP-Branch Review"
            });
            list.Add(new DummySaleOrderModel
            {
                SalesOrderKey = 11113,
                NickName = "AerocareHolding",
                StopReason = "Branch Review - DOD"
            });

            list.Add(new DummySaleOrderModel
            {
                SalesOrderKey = 11114,
                NickName = "ohh",
                StopReason = "ARP 1-ASSET RECOVER"
            });
            list.Add(new DummySaleOrderModel
            {
                SalesOrderKey = 11115,
                NickName = "ohh",
                StopReason = "ARP-Branch Review"
            });
            list.Add(new DummySaleOrderModel
            {
                SalesOrderKey = 11116,
                NickName = "ohh",
                StopReason = "Branch Review - DOD"
            });

            list.Add(new DummySaleOrderModel
            {
                SalesOrderKey = 11117,
                NickName = "StLukesh",
                StopReason = "ARP 1-ASSET RECOVER"
            });
            list.Add(new DummySaleOrderModel
            {
                SalesOrderKey = 11118,
                NickName = "StLukesh",
                StopReason = "ARP-Branch Review"
            });
            list.Add(new DummySaleOrderModel
            {
                SalesOrderKey = 11119,
                NickName = "StLukesh",
                StopReason = "Branch Review - DOD"
            });

            return list.Where(x =>  x.NickName == nickName && x.StopReason == stopReason).ToList<DummySaleOrderModel>();
        }
    }

    public class ARPWIPAutomationModel
    {
        public int ID { get; set; }
        public string NickName { get; set; }
        public string ExcludedWips { get; set; }
        public string StopReasonKeys { get; set; }
        public string StopReasons { get; set; }
        public string UpdatedWipStateKey { get; set; }
        public bool IsEnabled { get; set; }

    }
    public class DummySaleOrderModel
    {
        public int SalesOrderKey { get; set; }
        public string NickName { get; set; }
        public string StopReason { get; set; }
    }
}
