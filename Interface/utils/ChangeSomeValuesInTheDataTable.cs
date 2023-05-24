using DataBase;
using System.Data;

namespace CourseManagement
{
    internal class ChangeSomeValuesInTheDataTable
    {
        static public DataTable DtListAttendance(DataTable dtListAttendance)
        {
            dtListAttendance.Columns.Add("presence", typeof(string));

            foreach (DataRow dr in dtListAttendance.Rows)
            {
                dr["presence"] = dr["presence2"].ToString() == "1" ? "Presente" : "Falta";
                dr["description"] = dr["presence2"].ToString() == "1" ? "---" : string.IsNullOrEmpty(dr["description"].ToString()) ? "Motivo da Falta: Nenhum" : $"Motivo da falta: {dr["description"].ToString()}";
            }

            //dtListAttendance.Columns.RemoveAt(dtListAttendance.Columns.Count - 1);
            return dtListAttendance;
        }
    }
}

