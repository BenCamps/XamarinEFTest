using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinEFTest.Model
{
    public class CuttingUnitContext : DbContext
    {
        public ICommand AddCruiseCommand =>
            new Command(() => AddCruise());

        public void AddCruise()
        {
            var id = Guid.NewGuid();
            var newCruise = new CuttingUnit
            {
                Code = "Unit " + new String(id.ToString().Take(5).ToArray()),
            };

            Units.Add(newCruise);
        }

        public DbSet<CuttingUnit> Units { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = new Microsoft.Data.Sqlite.SqliteConnectionStringBuilder()
            {
                DataSource = App.FolderService.GetDBPath()
            };

            optionsBuilder.UseSqlite(connectionString.ToString());
        }
    }
}