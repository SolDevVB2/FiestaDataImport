using System;
using System.Collections.Generic;
using System.Text;
using FiestaDataImport.Model;
using Microsoft.EntityFrameworkCore;

namespace FiestaDataImport
{
    public static class AddEntities
    {
        public static void Add_Fiesta_ARTable(List<FiestaArtable> entities)
        {
            using (var context = new FiestaZohoDBContext())
            {
                context.FiestaArtable.AddRange(entities);
                context.SaveChanges();
            }
        }

        public static void Add_Fiesta_ARTableDup(List<FiestaArtableDup> entities)
        {
            using (var context = new FiestaZohoDBContext())
            {
                context.FiestaArtableDup.AddRange(entities);
                context.SaveChanges();
            }
        }

        public static void Add_Fiesta_Commission_Table(List<FiestaCommissionTable> entities)
        {
            using (var context = new FiestaZohoDBContext())
            {
                context.FiestaCommissionTable.AddRange(entities);
                context.SaveChanges();
            }
        }

        public static void Add_Fiesta_Commission_TableDup(List<FiestaCommissionTableDup> entities)
        {
            using (var context = new FiestaZohoDBContext())
            {
                context.FiestaCommissionTableDup.AddRange(entities);
                context.SaveChanges();
            }
        }

        public static void Add_Fiesta_DDTable(List<FiestaDdtable> entities)
        {
            using (var context = new FiestaZohoDBContext())
            {
                context.FiestaDdtable.AddRange(entities);
                context.SaveChanges();
            }
        }

        public static void Add_Fiesta_DDTableDUP(List<FiestaDdtableDup> entities)
        {
            using (var context = new FiestaZohoDBContext())
            {
                context.FiestaDdtableDup.AddRange(entities);
                context.SaveChanges();
            }
        }

        public static void Add_Fiesta_EFTTable(List<FiestaEfttable> entities)
        {
            using (var context = new FiestaZohoDBContext())
            {                
                context.FiestaEfttable.AddRange(entities);
                context.SaveChanges();
            }
        }

        public static void Add_Fiesta_EFTTableDUP(List<FiestaEfttableDup> entities)
        {
            using (var context = new FiestaZohoDBContext())
            {
                context.FiestaEfttableDup.AddRange(entities);
                context.SaveChanges();
            }
        }

        public static void Add_Fiesta_EFTTableTEMP(List<FiestaEfttableTemp> entities)
        {
            using (var context = new FiestaZohoDBContext())
            {
                context.FiestaEfttableTemp.AddRange(entities);
                context.SaveChanges();
            }
        }

        public static void Add_Fiesta_Employee(List<FiestaEmployee> entities)
        {
            using (var context = new FiestaZohoDBContext())
            {
                context.FiestaEmployee.AddRange(entities);
                context.SaveChanges();
            }
        }

        public static void Add_Fiesta_EmpStates(List<FiestaEmpStates> entities)
        {
            using (var context = new FiestaZohoDBContext())
            {
                context.FiestaEmpStates.AddRange(entities);
                context.SaveChanges();
            }
        }

        public static void Add_Fiesta_EmpStore(List<FiestaEmpStore> entities)
        {
            using (var context = new FiestaZohoDBContext())
            {
                context.FiestaEmpStore.AddRange(entities);
                context.SaveChanges();
            }
        }

        public static void Add_Fiesta_EmpStoreReport(List<FiestaEmpStoreReport> entities)
        {
            using (var context = new FiestaZohoDBContext())
            {
                context.FiestaEmpStoreReport.AddRange(entities);
                context.SaveChanges();
            }
        }

        public static void Add_Fiesta_EOD_Table(List<FiestaEodtable> entities)
        {
            using (var context = new FiestaZohoDBContext())
            {
                context.FiestaEodtable.AddRange(entities);
                context.SaveChanges();
            }
        }

        public static void Add_Fiesta_EOD_TableDUP(List<FiestaEodtableDup> entities)
        {
            using (var context = new FiestaZohoDBContext())
            {
                context.FiestaEodtableDup.AddRange(entities);
                context.SaveChanges();
            }
        }

        public static void Add_Fiesta_ExcelCompare(List<FiestaExcelCompare> entities)
        {
            using (var context = new FiestaZohoDBContext())
            {
                context.FiestaExcelCompare.AddRange(entities);
                context.SaveChanges();
            }
        }

        public static void Add_Fiesta_ReconTable(List<FiestaReconTable> entities)
        {
            using (var context = new FiestaZohoDBContext())
            {
                context.FiestaReconTable.AddRange(entities);
                context.SaveChanges();
            }
        }

        public static void Add_Fiesta_ReconTableDup(List<FiestaReconTableDup> entities)
        {
            using (var context = new FiestaZohoDBContext())
            {
                context.FiestaReconTableDup.AddRange(entities);
                context.SaveChanges();
            }
        }

        public static void Add_Fiesta_Report(List<FiestaReport> entities)
        {
            using (var context = new FiestaZohoDBContext())
            {
                context.FiestaReport.AddRange(entities);
                context.SaveChanges();
            }
        }

        public static void Add_Fiesta_Role(List<FiestaRole> entities)
        {
            using (var context = new FiestaZohoDBContext())
            {
                context.FiestaRole.AddRange(entities);
                context.SaveChanges();
            }
        }

        public static void Add_Fiesta_RPTable(List<FiestaRptable> entities)
        {
            using (var context = new FiestaZohoDBContext())
            {
                context.FiestaRptable.AddRange(entities);
                context.SaveChanges();
            }
        }

        public static void Add_Fiesta_RPTableDUP(List<FiestaRptableDup> entities)
        {
            using (var context = new FiestaZohoDBContext())
            {
                context.FiestaRptableDup.AddRange(entities);
                context.SaveChanges();
            }
        }

        public static void Add_Fiesta_State(List<FiestaState> entities)
        {
            using (var context = new FiestaZohoDBContext())
            {
                context.FiestaState.AddRange(entities);
                context.SaveChanges();
            }
        }

        public static void Add_Fiesta_Store(List<FiestaStore> entities)
        {
            using (var context = new FiestaZohoDBContext())
            {
                context.FiestaStore.AddRange(entities);
                context.SaveChanges();
            }
        }

        public static void Add_ReportFileUploads(List<ReportFileUploads> entities)
        {
            using (var context = new FiestaZohoDBContext())
            {
                context.ReportFileUploads.AddRange(entities);
                context.SaveChanges();
            }
        }

    }
}
