using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using FiestaDataImport.Model;

namespace FiestaDataImport
{    
    class Program
    {
        static string path = @"D:\Development\Experintia\Fiesta Project\Db\Exported Data\Failed\";
        static void Main(string[] args)
        {
            Itterate();
            Console.WriteLine("Completed");
            Console.Write("Press any key to end.");
            Console.ReadKey();
        }

        private static void Itterate()
        {
            /***********************************************************************************
             * 
             *  There has to be a better way to do this. Just a down and dirty solution
             *  
             ***********************************************************************************/
             
            //AddEntities.Add_Fiesta_ARTable(Parse<FiestaArtable>("Fiesta_ARTable"));
            //AddEntities.Add_Fiesta_ARTableDup(Parse<FiestaArtableDup>("Fiesta_ARTableDup"));
            //AddEntities.Add_Fiesta_Commission_Table(Parse<FiestaCommissionTable>("Fiesta_CommissionTable"));
            //AddEntities.Add_Fiesta_Commission_TableDup(Parse<FiestaCommissionTableDup>("Fiesta_CommissionTableDup"));
            //AddEntities.Add_Fiesta_DDTable(Parse<FiestaDdtable>("Fiesta_DDTable"));
            //AddEntities.Add_Fiesta_DDTableDUP(Parse<FiestaDdtableDup>("Fiesta_DDTableDUP"));
            //AddEntities.Add_Fiesta_EFTTable(Parse<FiestaEfttable>("Fiesta_EFTTable"));
            //AddEntities.Add_Fiesta_EFTTableDUP(Parse<FiestaEfttableDup>("Fiesta_EFTTableDUP"));
            //AddEntities.Add_Fiesta_EFTTableTEMP(Parse<FiestaEfttableTemp>("Fiesta_EFTTableTEMP"));
            //AddEntities.Add_Fiesta_Employee(Parse<FiestaEmployee>("Fiesta_Employee"));
            //AddEntities.Add_Fiesta_EmpStates(Parse<FiestaEmpStates>("Fiesta_EmpStates"));
            //AddEntities.Add_Fiesta_EmpStore(Parse<FiestaEmpStore>("Fiesta_EmpStore"));
            //AddEntities.Add_Fiesta_EmpStoreReport(Parse<FiestaEmpStoreReport>("Fiesta_EmpStoreReport"));
            //AddEntities.Add_Fiesta_EOD_Table(Parse<FiestaEodtable>("Fiesta_EOD_Table"));
            //AddEntities.Add_Fiesta_EOD_TableDUP(Parse<FiestaEodtableDup>("Fiesta_EOD_TableDUP"));
            //AddEntities.Add_Fiesta_ExcelCompare(Parse<FiestaExcelCompare>("Fiesta_ExcelCompare"));
            //AddEntities.Add_Fiesta_ReconTable(Parse<FiestaReconTable>("Fiesta_ReconTable"));
            //AddEntities.Add_Fiesta_ReconTableDup(Parse<FiestaReconTableDup>("Fiesta_ReconTableDup"));
            //AddEntities.Add_Fiesta_Report(Parse<FiestaReport>("Fiesta_Report"));
            //AddEntities.Add_Fiesta_Role(Parse<FiestaRole>("Fiesta_Role"));
            //AddEntities.Add_Fiesta_RPTable(Parse<FiestaRptable>("Fiesta_RPTable"));
            //AddEntities.Add_Fiesta_RPTableDUP(Parse<FiestaRptableDup>("Fiesta_RPTableDUP"));
            //AddEntities.Add_Fiesta_State(Parse<FiestaState>("Fiesta_State"));
            //AddEntities.Add_Fiesta_Store(Parse<FiestaStore>("Fiesta_Store"));
            //AddEntities.Add_ReportFileUploads(Parse<ReportFileUploads>("ReportFileUploads"));
        }

        private static List<T> Parse<T>(string file)
        {
            Console.WriteLine($"Parsing {file} ... ");

            using (TextReader reader = new StreamReader(path + file + ".txt"))
            {
                var csvReader = new CsvReader(reader);
                csvReader.Configuration.PrepareHeaderForMatch = header => header.ToLower();
                csvReader.Configuration.BadDataFound = null;

                return csvReader.GetRecords<T>().ToList();
            }
        }
    }

    
}
