using System;

namespace Interface_2_dbmigrate
{
    public partial class DbMigrator
    {
        private readonly Ilogger _logger;

        public DbMigrator(Ilogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo("Migration started at " + DateTime.Now);
            _logger.LogInfo("Migration finished at "+ DateTime.Now);
        }


    }
}
