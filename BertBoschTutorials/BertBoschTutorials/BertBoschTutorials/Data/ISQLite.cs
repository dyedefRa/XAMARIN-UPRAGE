using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace BertBoschTutorials.Data
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
