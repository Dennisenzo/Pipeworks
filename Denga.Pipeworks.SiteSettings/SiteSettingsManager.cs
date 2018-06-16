using System;
using Denga.Pipeworks.SiteSettings.Data;

namespace Denga.Pipeworks.SiteSettings
{
    public class SiteSettingsManager
    {
        private readonly SiteSettingsContext _db;

        public SiteSettingsManager(SiteSettingsContext db)
        {
            _db = db;
        }

        public void Initialize()
        {

        }
    }
}
